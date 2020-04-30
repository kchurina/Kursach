using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovaya
{
    public partial class MainForm : Form
    {
        private OrdersManager ord_mngr;
        private List<Order_data> orders;
        private OrderMngrContr mngr_contr;

        public MainForm()
        {
            ord_mngr = new OrdersManager();
            mngr_contr = new OrderMngrContr(ord_mngr);
            mngr_contr.Set_orders_list();

            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Display();

            foreach (Order_data ord in orders)
            {
                Console.WriteLine("@");
                Console.WriteLine(ord.get_ord_name().get_value() + " " + ord.get_customer().get_cust_name().get_value());

                Console.WriteLine("     !" + ord.get_rest().get_rest_name());
                foreach (Dish dish in ord.get_dishes_list())
                {
                    Console.WriteLine("         " + dish.get_ord_id_field().get_value() + " " + dish.get_name_field().get_value());
                }
                if (Convert.ToInt32(ord.get_dish_col().get_value()) == 0)
                {
                    OrdersInfoContr ord_contr = new OrdersInfoContr(ord);
                    ord_contr.Delete_order();
                }
            }
        }

        public void Display()
        {
            orders = ord_mngr.get_orders_list();
            int count_itms = orders.Count();
            Console.WriteLine(count_itms);
            listView1.FullRowSelect = true;
            this.listView1.GridLines = true;

            for (int i = 0; i < count_itms; i++)
            {
                ListViewItem item = new ListViewItem(new string[] { orders[i].get_ord_name().get_value(),
                   orders[i].get_event_date().get_value(),
                   orders[i].get_customer().get_cust_name().get_value(),
                   orders[i].get_customer().get_cust_tel().get_value(),
                   orders[i].get_fin_cost().get_value(),
                   orders[i].get_status().get_value(),
                   orders[i].get_dish_col().get_value()
               });
                listView1.Items.Add(item);
            }

        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            string text = listView1.FocusedItem.Text;
            OrdersInfoContr ord_contr = new OrdersInfoContr(mngr_contr.FindOrder(text));
            RestAndDishesForm rest_form = new RestAndDishesForm(ord_contr);
            rest_form.Show();
        }
        
        private void RestListTSMItem_Click(object sender, EventArgs e)
        {
            ShowDBListForm show_form = new ShowDBListForm(new List<Restaurant>());
            show_form.Show();
        }

        private void DishListTSMItem_Click(object sender, EventArgs e)
        {
            ShowDBListForm show_form = new ShowDBListForm(new List<Dish>());
            show_form.Show();
        }

        private void CustListTSMItem_Click(object sender, EventArgs e)
        {
            ShowDBListForm show_form = new ShowDBListForm(new List<Customer>());
            show_form.Show();
        }

        private void UpdateTSMenuItem_Click(object sender, EventArgs e)
        {
            int n = listView1.Items.Count;
            for (int i = n - 1; i >= 0; --i)
            {
                listView1.Items.Clear();
            }

            mngr_contr = new OrderMngrContr();
            mngr_contr.Set_orders_list();
            ord_mngr = mngr_contr.Get_mngr();

            foreach (Order_data ord in ord_mngr.get_orders_list())
            {
                if (Convert.ToInt32(ord.get_dish_col().get_value()) == 0)
                {
                    OrdersInfoContr ord_contr = new OrdersInfoContr(ord);
                    ord_contr.Delete_order();
                }
                if (String.Equals(ord.get_status().get_value(), "В процессе уточнения"))
                    ord.RecountFPrice();
                ord.CountDishCol();
            }
            mngr_contr.Set_orders_list();
            Display();
        }

        private void AddOrderTSMItem_Click(object sender, EventArgs e)
        {
            OrderForm order_form = new OrderForm(mngr_contr, "add");
            order_form.Show();
        }

        private void AddDishTSMItem_Click(object sender, EventArgs e)
        {
            DishForm add_dish_f = new DishForm("add");
            add_dish_f.Show();
        }

        private void AddRestTSMItem_Click(object sender, EventArgs e)
        {
            RestForm add_rest_f = new RestForm("add");
            add_rest_f.Show();
        }

        private void AddCustTSMItem_Click(object sender, EventArgs e)
        {
            CustForm add_cust_f = new CustForm("add");
            add_cust_f.Show();
        }

        private void EditOrdetTSMI_Click(object sender, EventArgs e)
        {
            OrderForm edit_ord_f = new OrderForm(mngr_contr, "edit");
            edit_ord_f.Show();
        }

        private void EditCustTSIM_Click(object sender, EventArgs e)
        {
            CustForm cust_f = new CustForm("edit");
            cust_f.Show();
        }

        private void DelCustTCMI_Click(object sender, EventArgs e)
        {
            CustForm cust_f = new CustForm("delete");
            cust_f.Show();
        }

        private void DelRestTSMI_Click(object sender, EventArgs e)
        {
            RestForm rest_f = new RestForm("delete");
            rest_f.Show();
        }

        private void EditRestTSMI_Click(object sender, EventArgs e)
        {
            RestForm rest_f = new RestForm("edit");
            rest_f.Show();
        }

        private void EditDishTSMI_Click(object sender, EventArgs e)
        {
            DishForm dish_f = new DishForm("edit");
            dish_f.Show();
        }

        private void DelDishTSMI_Click(object sender, EventArgs e)
        {
            DishForm dish_f = new DishForm("delete");
            dish_f.Show();
        }

        private void DelOrdTSMI_Click(object sender, EventArgs e)
        {
            OrderForm ord_f = new OrderForm(mngr_contr, "delete");
            ord_f.Show();
        }
    
    }
}

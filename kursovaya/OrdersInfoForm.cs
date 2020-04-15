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
        private OrdersManager ord_mngr = new OrdersManager();
        private List<Order_data> orders;
        private OrderMngrContr mngr_contr;
        private DBContr slcontr;

        public MainForm()
        {
            slcontr = new DBContr();
            orders = slcontr.Load_from_db();
            foreach (Order_data ord in orders)
            {
                Console.WriteLine("@");
                Console.WriteLine(ord.get_customer().get_cust_name().get_value());

                Console.WriteLine("     " + ord.get_rest().get_rest_name());
                foreach (Dish dish in ord.get_rest().get_dishes_list())
                {
                    Console.WriteLine("         " + dish.get_name_field().get_value());
                }

            }

            ord_mngr.set_orders_list(orders);
            mngr_contr = new OrderMngrContr(ord_mngr);
            
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Display();
        }

        public void Display()
        {
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
            foreach (Order_data ord in orders)
            {
                Console.WriteLine("@");
                Console.WriteLine(ord.get_customer().get_cust_name().get_value());

                Console.WriteLine("     " + ord.get_rest().get_rest_name());
                foreach (Dish dish in ord.get_rest().get_dishes_list())
                {
                    Console.WriteLine("         " + dish.get_name_field().get_value());
                }

            }

        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            string text = listView1.FocusedItem.Text;
            OrdersInfoContr ord_contr = new OrdersInfoContr(mngr_contr.FindOrder(text));
            RestAndDishesForm rest_form = new RestAndDishesForm(ord_contr);
            rest_form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddOrderInfoForm add_form = new AddOrderInfoForm(mngr_contr);
            add_form.Show();
        }

        /*private void button4_Click(object sender, EventArgs e)
        {
            DeleteOrderForm del_form = new DeleteOrderForm(mngr_contr);
            del_form.Show();
        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            int n = listView1.Items.Count;
            for (int i = n - 1; i >= 0; --i)
            {
                listView1.Items.Clear();
            }
            ord_mngr.set_orders_list(slcontr.Load_from_db());
            foreach (Order_data ord in ord_mngr.get_orders_list())
            {
                if(String.Equals(ord.get_status().get_value(), "В процессе уточнения"))
                    ord.RecountFPrice();
                ord.CountDishCol();
            }
            Display();
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
        }
/*
        private void button3_Click(object sender, EventArgs e)
        {
            slcontr.SaveMngrToFile(ord_mngr);
            FiltersContr filter_controler = new FiltersContr();
            FilterForm frm_filter = new FilterForm(filter_controler);
            frm_filter.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GetOrdNameForm get_form = new GetOrdNameForm(mngr_contr);
            get_form.Show();
        }*/
    }
}

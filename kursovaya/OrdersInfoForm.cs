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
        OrderMngrContr mngr_contr;
        SaverLoaderContr slcontr;

        public MainForm()
        {
            slcontr = new SaverLoaderContr();
            orders = slcontr.Load_orders_from_file();

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
            listView1.FullRowSelect = true;
            this.listView1.GridLines = true;

            for (int i = 0; i < count_itms; i++)
            {
                ListViewItem item = new ListViewItem(new string[] { orders[i].get_ord_name().get_value(),
                   orders[i].get_event_date().get_value(),
                   orders[i].get_cust_name().get_value(),
                   orders[i].get_cust_tel().get_value(),
                   orders[i].get_fin_cost().get_value(),
                   orders[i].get_status().get_value(),
                   orders[i].get_rest_col().get_value(),
                   orders[i].get_dish_col().get_value()
               });
                listView1.Items.Add(item);
            }
        }

       /* private void listView1_ItemActivate(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            DeleteOrderForm del_form = new DeleteOrderForm(mngr_contr);
            del_form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = listView1.Items.Count;
            for (int i = n - 1; i >= 0; --i)
            {
                listView1.Items.Clear();
            }
            foreach (Order_data ord in ord_mngr.get_orders_list())
            {
                ord.RecountFPrice();
                ord.CountRestCol();
                ord.CountDishCol();
            }
            Display();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            slcontr.SaveMngrToFile(ord_mngr);
        }

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

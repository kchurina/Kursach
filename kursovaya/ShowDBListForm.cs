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
    public partial class ShowDBListForm : Form
    {
        private DBContr db_contr= new DBContr();

        public ShowDBListForm(List<Restaurant> rests_list)
        {            
            InitializeComponent();
            rests_list = db_contr.Get_rests_from_db();
            Show_rests(rests_list);
        }

        public ShowDBListForm(List<Dish> dishes_list)
        {
            InitializeComponent();
            dishes_list = db_contr.Get_dishes_from_db();
            Show_dishes(dishes_list);
        }

        public ShowDBListForm(List<Customer> custs_list)
        {
            InitializeComponent();
            custs_list = db_contr.Get_custs_from_db();
            Show_custs(custs_list);
        }

        private void Show_custs(List<Customer> custs)
        {
            ColumnHeader columnHeader1 = new ColumnHeader();
            columnHeader1.Text = "ID";
            ColumnHeader columnHeader2 = new ColumnHeader();
            columnHeader2.Text = "Имя заказчика";
            ColumnHeader columnHeader3 = new ColumnHeader();
            columnHeader3.Text = "Телефон";
            columnHeader1.Width = 50;
            columnHeader2.Width = 155;
            columnHeader3.Width = 150;
            listView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });

            listView.FullRowSelect = true;
            listView.GridLines = true;

            foreach (Customer cust in custs)
            {
                ListViewItem item = new ListViewItem(new string[] { cust.get_cust_id_p().get_value(), cust.get_cust_name().get_value(), cust.get_cust_tel().get_value()});
                listView.Items.Add(item);
            }
        }

        private void Show_dishes(List<Dish> dishes)
        {
            ColumnHeader columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader1.Text = "ID";
            ColumnHeader columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader2.Text = "Название блюда";
            ColumnHeader columnHeader3 = new System.Windows.Forms.ColumnHeader();
            columnHeader3.Text = "Стоимость";
            columnHeader1.Width = 50;
            columnHeader2.Width = 215;
            columnHeader3.Width = 90;
            listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {columnHeader1,columnHeader2, columnHeader3});

            listView.FullRowSelect = true;
            listView.GridLines = true;

            foreach(Dish dish in dishes)
            {
                ListViewItem item = new ListViewItem(new string[] {dish.get_dish_id_field().get_value(), dish.get_name_field().get_value(), dish.get_cost_field().get_value()});
                listView.Items.Add(item);
            }
        }

        private void Show_rests(List<Restaurant> rests)
        {
            ColumnHeader columnHeader1 = new ColumnHeader();
            columnHeader1.Text = "ID";
            ColumnHeader columnHeader2 = new ColumnHeader();
            columnHeader2.Text = "Название ресторана";
            columnHeader1.Width = 100;
            columnHeader2.Width = 255;
            listView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });

            listView.FullRowSelect = true;
            listView.GridLines = true;

            foreach (Restaurant rest in rests)
            {
                ListViewItem item = new ListViewItem(new string[] { rest.get_rest_id(),rest.get_rest_name() });
                listView.Items.Add(item);
            }
        }
    }
}

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
    public partial class RestAndDishesForm : Form
    {
        private Restaurant rest;
        OrdersInfoContr ord_contr;
        private Order_data order;

        public RestAndDishesForm(OrdersInfoContr new_contr)
        {
            ord_contr = new_contr;
            rest = ord_contr.Get_order().get_rest();
            order = ord_contr.Get_order();
            InitializeComponent();
        }

        public void Display()
        {
            Label rest_label = new Label();
            ListView list_view = new ListView();

            ColumnHeader columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader1.Text = "Название блюда";
            ColumnHeader columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader2.Text = "Стоимость блюда";
            ColumnHeader columnHeader3 = new System.Windows.Forms.ColumnHeader();
            columnHeader3.Text = "Кол-во порций блюда";
            columnHeader1.Width = 200;
            columnHeader2.Width = 200;
            columnHeader3.Width = 200;
            list_view.Size = new Size(600, 150);
            int n=20;
            list_view.Location = new System.Drawing.Point(250, n);
            list_view.View = System.Windows.Forms.View.Details;
            list_view.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            list_view.FullRowSelect = true;
            list_view.GridLines = true;

            rest_label.Location = new Point(10, n);
            rest_label.Size = new Size(500, 100);
            rest_label.Text = "Название заказа: \n" + order.get_ord_name().get_value() + "\nНазвание ресторана: \n" + rest.get_rest_name();

            this.Controls.Add(list_view);//ЭТО ВАЖНО КАК ВОЗДУХ И ПИЩА!!!!!!!!!
            this.Controls.Add(rest_label);

            List<Dish> dishes = order.get_dishes_list();
            foreach (Dish dish in dishes)
            {
                ListViewItem item = new ListViewItem(new string[] { dish.get_name_field().get_value(), dish.get_cost_field().get_value(), dish.get_nmb_field().get_value() });
                list_view.Items.Add(item);
            }

            Label price_l = new Label();
            price_l.Location = new Point(250, n*2+150);
            price_l.Size = new Size(300, 50);
            price_l.Text = "ОБЩАЯ СТОИМОСТЬ: " + order.get_fin_cost().get_value();
            price_l.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            price_l.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Controls.Add(price_l);

        }

        private void RestAndDishesForm_Load(object sender, EventArgs e)
        {
            Display();
        }

       /* private void AddRestB_Click(object sender, EventArgs e)
        {
            AddRestForm add_rest_f = new AddRestForm(ord_contr);
            add_rest_f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddDishToRestForm get_name = new AddDishToRestForm(ord_contr);
            get_name.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteRestForm get_name = new DeleteRestForm(ord_contr);
            get_name.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DelDishFromRestForm get_name = new DelDishFromRestForm(ord_contr);
            get_name.Show();
        }
        */
        private void button1_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            order.RecountFPrice();
            order.CountDishCol();
            Display();
        }
    }
}

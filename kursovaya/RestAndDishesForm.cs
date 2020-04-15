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

            Button AddRestB = new Button();
            Button button2 = new Button();
            Button button3 = new Button();
            Button button4 = new Button();
            Button button1 = new Button();

            if (order.get_dish_col().get_value() == "0") button4.Visible = false;

            if (order.get_status().get_value() == "Done" || order.get_status().get_value() == "Выполнен")
            {
                AddRestB.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button1.Visible = false;

            }

            AddRestB.Location = new System.Drawing.Point(51, 29);
            AddRestB.Name = "AddRestB";
            AddRestB.Size = new System.Drawing.Size(157, 23);
            AddRestB.TabIndex = 0;
            AddRestB.Text = "Добавить ресторан";
            AddRestB.UseVisualStyleBackColor = true;
            //AddRestB.Click += new System.EventHandler(this.AddRestB_Click);

            button2.Location = new System.Drawing.Point(236, 29);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(149, 23);
            button2.TabIndex = 1;
            button2.Text = "Удалить ресторан";
            button2.UseVisualStyleBackColor = true;
            //button2.Click += new System.EventHandler(this.button2_Click);

            button3.Location = new System.Drawing.Point(50, 70);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(158, 23);
            button3.TabIndex = 2;
            button3.Text = "Добавить блюдо";
            button3.UseVisualStyleBackColor = true;
            //button3.Click += new System.EventHandler(this.button3_Click);

            button4.Location = new System.Drawing.Point(236, 70);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(149, 23);
            button4.TabIndex = 3;
            button4.Text = "Удалить блюдо";
            button4.UseVisualStyleBackColor = true;
            //button4.Click += new System.EventHandler(this.button4_Click);

            button1.Location = new System.Drawing.Point(413, 41);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(92, 42);
            button1.TabIndex = 4;
            button1.Text = "Обновить \r\nформу";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(this.button1_Click);

            this.Controls.Add(AddRestB);
            this.Controls.Add(button2);
            this.Controls.Add(button3);
            this.Controls.Add(button4);
            this.Controls.Add(button1);
                            
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
                list_view.Location = new System.Drawing.Point(250, 120);
                list_view.View = System.Windows.Forms.View.Details;
                list_view.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
                list_view.FullRowSelect = true;
                list_view.GridLines = true;

            rest_label.Location = new Point(10, 120);
            rest_label.Size = new Size(500, 100);
            rest_label.Text = "Название заказа: \n" + order.get_ord_name().get_value() + "\nНазвание ресторана: \n" + rest.get_rest_name();

                this.Controls.Add(list_view);//ЭТО ВАЖНО КАК ВОЗДУХ И ПИЩА!!!!!!!!!
                this.Controls.Add(rest_label);

                List<Dish> dishes = rest.get_dishes_list();
                foreach (Dish dish in dishes)
                {
                    ListViewItem item = new ListViewItem(new string[] { dish.get_name_field().get_value(), dish.get_cost_field().get_value(), dish.get_nmb_field().get_value() });
                    list_view.Items.Add(item);
                }

                Label price_l = new Label();
                price_l.Location = new Point(550, 40);
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

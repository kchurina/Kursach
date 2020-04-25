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
    public partial class OrderForm : Form
    {
        private DBContr db_contr = new DBContr();
        private List<Customer> custs;
        private List<Restaurant> rests;
        private List<Dish> dishes;
        private Order_data order = new Order_data();
        private OrderMngrContr mngr_contr;

        private List<ComboBox> DishCB_list = new List<ComboBox>();
        private List<TextBox> DishTB_list = new List<TextBox>();
        private List<Label> dish_name_list = new List<Label>();
        private List<Label> dish_col_list = new List<Label>();
        private List<Label> num_list = new List<Label>();

        public OrderForm(OrderMngrContr new_mngr_contr)
        {            
            InitializeComponent();
            custs = db_contr.Get_custs_from_db();
            rests = db_contr.Get_rests_from_db();
            dishes = db_contr.Get_dishes_from_db();
            mngr_contr = new_mngr_contr;

            Display(custs, rests);
        }

        private void Display(List<Customer> custs, List<Restaurant> rests)
        {
            foreach(Customer cust in custs)
            { 
                CustomerCB.Items.Add(cust.get_cust_id_p().get_value() + "  " +cust.get_cust_name().get_value());
            }

            foreach(Restaurant rest in rests)
            {
                RestCB.Items.Add(rest.get_rest_id() + "  " + rest.get_rest_name());
            }
        }

        private void CustomerCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Customer cust in custs)
            {
                if(String.Equals(cust.get_cust_id_p().get_value()+"  "+ cust.get_cust_name().get_value(), CustomerCB.Text))
                {
                    TelTB.Text = cust.get_cust_tel().get_value();
                }
            }
        }

        private void addDishButton_Click(object sender, EventArgs e)
        {

            field(DishCB_list.Count);
        }

        private void field(int index)
        {
            Label dish_namel = new Label();
            dish_namel.Text = "Название блюда:";
            dish_namel.Size = new Size(140, 17);
            dish_namel.Location = new System.Drawing.Point(163, label8.Location.Y + 70 * index);
            dish_name_list.Add(dish_namel);

            Label dish_coll = new Label();
            dish_coll.Text = "Кол-во:";
            dish_coll.Size = new Size(70, 24);
            dish_coll.Location = new System.Drawing.Point(330, label8.Location.Y + 70 * index);
            dish_col_list.Add(dish_coll);

            ComboBox DishCB = new ComboBox();
            DishCB.Size = new Size(155, 24);
            DishCB.Location = new System.Drawing.Point(163, label8.Location.Y + 30 + 70 * index);

            foreach (Dish dish in dishes)
            {
                DishCB.Items.Add(dish.get_dish_id_field().get_value() + "  " + dish.get_name_field().get_value());
            }
            DishCB_list.Add(DishCB);

            TextBox DishTB = new TextBox();
            DishTB.Size = new Size(70, 24);
            DishTB.Location = new System.Drawing.Point(330, label8.Location.Y + 30 + 70 * index);
            DishTB_list.Add(DishTB);

            Label num = new Label();
            num.Text = index.ToString();
            num.Size = new Size(24, 24);
            num.Location = new System.Drawing.Point(145, label8.Location.Y + 33 + 70 * index);
            num_list.Add(num);

            this.Controls.Add(dish_namel);
            this.Controls.Add(dish_coll);
            this.Controls.Add(DishCB);
            this.Controls.Add(DishTB);
            this.Controls.Add(num);


        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            if(DelTextBox.Text=="")
            {
                return;
            }
            string index = DelTextBox.Text;
            int i = Convert.ToInt32(index);

            this.Controls.Remove(DishCB_list[i]);
            this.Controls.Remove(DishTB_list[i]);
            this.Controls.Remove(dish_name_list[i]);
            this.Controls.Remove(dish_col_list[i]);
            this.Controls.Remove(num_list[i]);

            DishCB_list.RemoveAt(i);
            dish_name_list.RemoveAt(i);
            DishTB_list.RemoveAt(i);
            dish_col_list.RemoveAt(i);
            num_list.RemoveAt(i);

            for(int j = 0; j<DishCB_list.Count; j++)
            {
                dish_name_list[j].Location = new System.Drawing.Point(163, label8.Location.Y + 70 * j);
                dish_col_list[j].Location = new System.Drawing.Point(330, label8.Location.Y + 70 * j);
                DishCB_list[j].Location = new System.Drawing.Point(163, label8.Location.Y + 30 + 70 * j);
                DishTB_list[j].Location = new System.Drawing.Point(330, label8.Location.Y + 30 + 70 * j);
                num_list[j].Location = new System.Drawing.Point(145, label8.Location.Y + 33 + 70 * j);
                num_list[j].Text = j.ToString();
            }
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            Restaurant rest = new Restaurant();
            Customer cust = new Customer();
            List<Dish> new_dish_list = new List<Dish>();

            foreach (Restaurant r in rests)
            {
                if (String.Equals((r.get_rest_id() + "  " + r.get_rest_name()), RestCB.Text))
                {
                    rest = r;
                }
            }
            foreach (Customer c in custs)
            {
                if (String.Equals(c.get_cust_id_p().get_value() + "  " + c.get_cust_name().get_value(), CustomerCB.Text))
                {
                    cust = c;
                }
            }

            for (int i = 0; i < DishCB_list.Count; i++)
            {
                foreach (Dish d in dishes)
                {
                    if (String.Equals((d.get_dish_id_field().get_value() + "  " + d.get_name_field().get_value()),DishCB_list[i].Text))
                    {
                        Dish new_d = new Dish();
                        new_d.get_nmb_field().set_value(DishTB_list[i].Text);
                        new_d.get_name_field().set_value(d.get_name_field().get_value());
                        new_d.get_cost_field().set_value(d.get_cost_field().get_value());
                        new_d.get_dish_id_field().set_value(d.get_dish_id_field().get_value());

                        new_dish_list.Add(new_d);
                    }
                }
            }
            mngr_contr.Add_new_order("0", "0", dateTimePicker.Text, costTB.Text, statusLB.Text, rest, cust, new_dish_list);
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            int final_price = 0;

            for (int i = 0; i < DishCB_list.Count; i++)
            {
                foreach (Dish d in dishes)
                {
                    if (String.Equals((d.get_dish_id_field().get_value() + "  " + d.get_name_field().get_value()), DishCB_list[i].Text))
                    {
                        final_price += Convert.ToInt32(d.get_cost_field().get_value())* Convert.ToInt32(DishTB_list[i].Text);

                    }
                }

                costTB.Text = final_price.ToString();
            }
        }
    }
}

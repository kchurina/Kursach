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
    public partial class DishForm : Form
    {
        DishInfoContr dish_contr;
        DishInfoContr dish_contr2;
        OrderMngrContr mngr_contr;
        string mode;


        public DishForm(string new_mode, OrderMngrContr new_mngr_contr)
        {
            dish_contr = new DishInfoContr();
            mode = new_mode;
            mngr_contr = new_mngr_contr;

            InitializeComponent();
            if (String.Equals(mode, "add"))
            {
                IdCB.Enabled = false;
            }
            else
                Display();
        }

        public void Display()
        {
            if (String.Equals(mode, "edit"))
                AddB.Text = "Сохранить";
            if (String.Equals(mode, "delete"))
                AddB.Text = "Удалить";

            foreach (Dish dish in dish_contr.GetDishesList())
                IdCB.Items.Add(dish.get_dish_id_field().get_value() + "  " + dish.get_name_field().get_value());


            if (String.Equals(mode, "delete"))
            {
                cost_box.Enabled = false;
                name_box.Enabled = false;
            }
        }

        private void AddB_Click(object sender, EventArgs e)
        {
            if (cost_box.Text != "" && name_box.Text != "")
            {
                if (String.Equals(mode, "add"))
                {
                    if (!dish_contr.CheckExistDish(name_box.Text))
                    {
                        dish_contr.Add_dish(name_box.Text, "0", cost_box.Text);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Блюдо с таким названием уже существует!");
                    }
                }

                if (String.Equals(mode, "edit"))
                {
                    if (!String.Equals(name_box.Text, dish_contr2.Get_dish().get_name_field().get_value()))
                    {
                        dish_contr2.Get_dish().get_name_field().set_value(name_box.Text);
                        dish_contr2.Edit_dish(dish_contr2.Get_dish().get_name_field());
                        Console.WriteLine("Edited dish name to " + dish_contr2.Get_dish().get_name_field().get_value());
                    }
                    if (!String.Equals(cost_box.Text, dish_contr2.Get_dish().get_cost_field().get_value()))
                    {
                        dish_contr2.Get_dish().get_cost_field().set_value(cost_box.Text);
                        dish_contr2.Edit_dish(dish_contr2.Get_dish().get_cost_field());
                        Console.WriteLine("Edited dish cost to " + dish_contr2.Get_dish().get_cost_field().get_value());
                    }

                }
            }
            if (String.Equals(mode, "delete"))
            {
                dish_contr2.Delete_dish();
            }

        }

        private void IdCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Dish dish in dish_contr.GetDishesList())
            {
                if (String.Equals(IdCB.Text, dish.get_dish_id_field().get_value() + "  " + dish.get_name_field().get_value()))
                {
                    name_box.Text = dish.get_name_field().get_value();
                    cost_box.Text = dish.get_cost_field().get_value();
                    dish_contr2 = new DishInfoContr(dish);
                }
            }
        }
    }
}

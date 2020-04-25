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
    public partial class AddDishForm : Form
    {
        TextBox name_box = new TextBox();
        TextBox cost_box = new TextBox();
        DishInfoContr dish_contr = new DishInfoContr();

        public AddDishForm()
        {
            Display();
            InitializeComponent();
        }

        public void Display()
        {
            Label dish_name = new Label();
            Label dish_cost = new Label();

            dish_name.Location = new Point(20, 20);
            dish_name.Size = new System.Drawing.Size(200, 30);
            dish_name.Text = "Введите название блюда: ";
            dish_cost.Location = new Point(20, 50);
            dish_cost.Size = new System.Drawing.Size(150, 30);
            dish_cost.Text = "Введите цену блюда: ";

            name_box.Location = new Point(250, 20);
            name_box.Size = new Size(200, 40);
            cost_box.Location = new Point(250, 50);
            cost_box.Size = new Size(200, 40);

            this.Controls.Add(dish_name);
            this.Controls.Add(dish_cost);

            this.Controls.Add(name_box);
            this.Controls.Add(cost_box);

            Button add_b = new Button();
            add_b.Size = new Size(100, 30);
            add_b.Location = new Point(20, 80);
            add_b.Text = "Добавить";
            add_b.Click += new System.EventHandler(add_b_Click);

            this.Controls.Add(add_b);
        }
        private void AddDishForm_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void add_b_Click(object sender, EventArgs e)
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


    }
}

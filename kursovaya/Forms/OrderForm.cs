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
        private string mode;

        private List<Customer> custs;
        private List<Restaurant> rests;
        private List<Dish> dishes;
        private OrderMngrContr mngr_contr;
        private DishInfoContr dish_contr;
        private RestInfoContr rest_contr;
        private CustInfoContr cust_contr;
        private OrdersInfoContr ord_contr;

        private List<ComboBox> DishCB_list;
        private List<TextBox> DishTB_list;
        private List<Label> dish_name_list;
        private List<Label> dish_col_list;
        private List<Label> num_list;

        public OrderForm(OrderMngrContr new_mngr_contr, string new_mode)
        {            
            InitializeComponent();
            dish_contr = new DishInfoContr();
            rest_contr = new RestInfoContr();
            cust_contr = new CustInfoContr();

            DishCB_list = new List<ComboBox>();
            DishTB_list = new List<TextBox>();
            dish_name_list = new List<Label>();
            dish_col_list = new List<Label>();
            num_list = new List<Label>();

            dishes = dish_contr.GetDishesList();
            rests = rest_contr.GetRestsList();
            custs = cust_contr.GetCustsList();
            mngr_contr = new_mngr_contr;
            mode = new_mode;

            Display(custs, rests);
        }

        private void Display(List<Customer> custs, List<Restaurant> rests)
        {
            if (String.Equals(mode, "add"))
            {
                foreach (Customer cust in custs)
                {
                    CustomerCB.Items.Add(cust.get_cust_id_p().get_value() + "  " + cust.get_cust_name().get_value());
                }

                foreach (Restaurant rest in rests)
                {
                    RestCB.Items.Add(rest.get_rest_id() + "  " + rest.get_rest_name());
                }

                IdCB.Enabled = false;
            }

            if (String.Equals(mode, "edit"))
            {
                AddOrderButton.Text = "Сохранить изменения";
                IdCB.Enabled = true;
                foreach (Customer cust in custs)
                {
                    CustomerCB.Items.Add(cust.get_cust_id_p().get_value() + "  " + cust.get_cust_name().get_value());
                }

                foreach (Restaurant rest in rests)
                {
                    RestCB.Items.Add(rest.get_rest_id() + "  " + rest.get_rest_name());
                }

                foreach(Order_data ord in mngr_contr.Get_mngr().get_orders_list())
                {
                    IdCB.Items.Add(ord.get_ord_name().get_value());
                }
            }

            if(String.Equals(mode, "delete"))
            {
                AddOrderButton.Text = "Удалить";
                IdCB.Enabled = true;
                foreach (Customer cust in custs)
                {
                    CustomerCB.Items.Add(cust.get_cust_id_p().get_value() + "  " + cust.get_cust_name().get_value());
                }

                foreach (Restaurant rest in rests)
                {
                    RestCB.Items.Add(rest.get_rest_id() + "  " + rest.get_rest_name());
                }

                foreach (Order_data ord in mngr_contr.Get_mngr().get_orders_list())
                {
                    IdCB.Items.Add(ord.get_ord_name().get_value());
                }

                dateTimePicker.Enabled = false;
                CustomerCB.Enabled = false;
                RestCB.Enabled = false;
                statusLB.Enabled = false;
                addDishButton.Visible = false;
                DelButton.Visible = false;
                DelTextBox.Visible = false;
                countButton.Visible = false;
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

        private void clean_field()
        {
            for (int i=0; i< DishCB_list.Count; i++)
            {
                this.Controls.Remove(DishCB_list[i]);
                this.Controls.Remove(DishTB_list[i]);
                this.Controls.Remove(dish_name_list[i]);
                this.Controls.Remove(dish_col_list[i]);
                this.Controls.Remove(num_list[i]);
            }

            DishCB_list.Clear();
            DishTB_list.Clear();
            dish_name_list.Clear();
            dish_col_list.Clear();
            num_list.Clear();
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            if(DelTextBox.Text=="")
            {
                return;
            }
            string index = DelTextBox.Text;
            int i;
            try
            {
                i = Convert.ToInt32(index);
            }
            catch (FormatException)
            {
                MessageBox.Show("В числовом поле должно быть число!");
                return;
            }

            try
            {
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

            }

            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("Позиции с номером "+ i + " нет в списке!");
                return;
            }
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
            bool empty = false;
            if (dateTimePicker.Text == "" || CustomerCB.Text == "" || RestCB.Text == "" || statusLB.Text == "")
            {
                empty = true;
            }
            for (int i = 0; i < DishCB_list.Count; i++)
            {
                if (DishCB_list[i].Text == "" || DishTB_list[i].Text == "")
                {
                    empty = true;
                    break;
                }
            }
            if (!empty)
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

                RestInfoContr rest_contr = new RestInfoContr();
                if (!rest_contr.CheckExistRest(rest.get_rest_name()))
                {
                    MessageBox.Show("Выберите ресторан!");
                    return;
                }

                foreach (Customer c in custs)
                {
                    if (String.Equals(c.get_cust_id_p().get_value() + "  " + c.get_cust_name().get_value(), CustomerCB.Text))
                    {
                        cust = c;
                    }
                }
                CustInfoContr cust_contr = new CustInfoContr();
                if (!cust_contr.CheckExistCust(cust.get_cust_id_p().get_value()))
                {
                    MessageBox.Show("Выберите заказчика!");
                    return;
                }

                for (int i = 0; i < DishCB_list.Count; i++)
                {
                    foreach (Dish d in dishes)
                    {
                        if (String.Equals((d.get_dish_id_field().get_value() + "  " + d.get_name_field().get_value()), DishCB_list[i].Text)&& DishTB_list[i].Text!="0")
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
                if (String.Equals(mode, "add"))
                {
                    try
                    {

                        foreach (Dish d in new_dish_list)
                        {
                            int num = 0;
                            foreach (Dish d2 in new_dish_list)
                            {
                                if (String.Equals(d.get_dish_id_field().get_value(), d2.get_dish_id_field().get_value()))
                                {
                                    num++;
                                }
                            }
                            //если повторяется больше одного раза (первый раз мы находим ровно то же блюдо, 
                            //которое проверяем), то это другое такое же блюдо
                            if (num > 1)
                            {
                                MessageBox.Show("Блюда не должны дублироваться!");
                                return;
                            }
                        }
                        mngr_contr.Add_new_order("0", "0", dateTimePicker.Value.ToLongDateString(), costTB.Text, statusLB.Text, rest, cust, new_dish_list);
                        MessageBox.Show("Заказ был добавлен в базу данных!");
                        this.Close();
                    }
                    catch(Npgsql.PostgresException)
                    {
                        MessageBox.Show("В числовом поле должно быть число!");
                        return;
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("В числовом поле должно быть число!");
                        return;
                    }

                }

                if (String.Equals(mode, "edit"))
                {
                    try
                    {
                        ord_contr = new OrdersInfoContr(mngr_contr.FindOrder(IdCB.Text));
                        OrdersInfoContr ord_contr2 = new OrdersInfoContr(mngr_contr.Create_new_order("0", "0", dateTimePicker.Value.ToLongDateString(), costTB.Text, statusLB.Text, rest, cust, new_dish_list));
                        if (!ord_contr.Check_status_date_equal(ord_contr2.Get_order()))
                        {
                            if (!String.Equals(ord_contr.Get_order().get_status().get_value(), ord_contr2.Get_order().get_status().get_value()))
                            {
                                Console.WriteLine("Change order status to " + ord_contr2.Get_order().get_status().get_value());
                                ord_contr.Edit_ord_field(ord_contr2.Get_order().get_status());
                            }
                            if (!String.Equals(ord_contr.Get_order().get_event_date().get_value(), ord_contr2.Get_order().get_event_date().get_value()))
                            {
                                Console.WriteLine("Change order date to " + ord_contr2.Get_order().get_event_date().get_value());
                                ord_contr.Edit_ord_field(ord_contr2.Get_order().get_event_date());
                            }
                        }
                        foreach (Dish d in ord_contr2.Get_order().get_dishes_list())
                        {
                            if (ord_contr2.Check_exist_dish(d.get_dish_id_field().get_value()))
                            {
                                MessageBox.Show("Блюда не должны дублироваться!");
                                return;
                            }
                        }
                        foreach (Dish d in ord_contr.Get_order().get_dishes_list())
                        {
                            if (!ord_contr2.Check_exist_dish(d.get_dish_id_field().get_value()))
                            {
                                Console.WriteLine("Delete dish " + d.get_dish_id_field().get_value());
                                ord_contr.DelDish_from_order(d);
                            }
                        }

                        foreach (Dish d in ord_contr2.Get_order().get_dishes_list())
                        {
                            if (!ord_contr.Check_exist_dish(d.get_dish_id_field().get_value()))
                            {
                                Console.WriteLine("Add dish " + d.get_dish_id_field().get_value());
                                ord_contr.Add_dish_to_order(d);
                            }
                        }

                        foreach (Dish d2 in ord_contr2.Get_order().get_dishes_list())
                        {
                            foreach (Dish d in ord_contr.Get_order().get_dishes_list())
                            {
                                if (String.Equals(d.get_dish_id_field().get_value(), d2.get_dish_id_field().get_value()) && !String.Equals(d.get_nmb_field().get_value(), d2.get_nmb_field().get_value()))
                                {
                                    Console.WriteLine("Chande col of dish " + d.get_dish_id_field().get_value() + " from " + d.get_nmb_field().get_value() + " to " + d2.get_nmb_field().get_value());
                                    DishInfoContr dc2 = new DishInfoContr(d2);
                                    dc2.Update_ordered(ord_contr.Get_order().get_ord_name().get_value());
                                }
                            }
                        }

                        if (!ord_contr.Check_exist_rest(ord_contr2.Get_rest().get_rest_id()))
                        {
                            Console.WriteLine("Change rest to " + ord_contr2.Get_rest().get_rest_id());
                            ord_contr2.Get_order().get_rest_id_f().set_value(ord_contr2.Get_rest().get_rest_id());
                            ord_contr.Edit_ord_field(ord_contr2.Get_order().get_rest_id_f());
                        }

                        if (!ord_contr.Check_exist_cust(ord_contr2.Get_cust().get_cust_id_p().get_value()))
                        {
                            Console.WriteLine("Change cust to " + ord_contr2.Get_cust().get_cust_id_p().get_value());
                            ord_contr2.Get_order().get_cust_id_f().set_value(ord_contr2.Get_cust().get_cust_id_p().get_value());
                            ord_contr.Edit_ord_field(ord_contr2.Get_order().get_cust_id_f());
                        }

                        MessageBox.Show("Заказ успешно отредактирован!");
                        this.Close();
                    }
                    catch (NullReferenceException)
                    {
                        MessageBox.Show("Заполните поля выбора правильно!");
                        return;
                    }
                    catch(FormatException)
                    {
                        MessageBox.Show("В числовом поле должно быть число!");
                        return;

                    }
                }

            }

            if (String.Equals(mode, "delete"))
            {
                try
                {
                    ord_contr = new OrdersInfoContr(mngr_contr.FindOrder(IdCB.Text));
                    ord_contr.Delete_order();
                    MessageBox.Show("Заказ успешно удален!");
                    this.Close();
                }
                catch(NullReferenceException)
                {
                    MessageBox.Show("Выберите заказ!");
                    return;
                }
            }

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

        private void IdCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ord_contr = new OrdersInfoContr(mngr_contr.FindOrder(IdCB.Text));

            CustomerCB.Text = ord_contr.Get_order().get_customer().get_cust_id_p().get_value() + "  " + ord_contr.Get_order().get_customer().get_cust_name().get_value();
            RestCB.Text = ord_contr.Get_order().get_rest().get_rest_id() + "  " + ord_contr.Get_order().get_rest().get_rest_name();
            dateTimePicker.Text = ord_contr.Get_order().get_event_date().get_value();
            clean_field();
            costTB.Text = ord_contr.Get_order().get_fin_cost().get_value();
            
            for(int i=0; i<Convert.ToInt32(ord_contr.Get_order().get_dishes_list().Count); i++ )
            {
                field(i);
                DishCB_list[i].Text = ord_contr.Get_dish_of_order(i).get_dish_id_field().get_value() + "  " + ord_contr.Get_dish_of_order(i).get_name_field().get_value();
                DishTB_list[i].Text = ord_contr.Get_dish_of_order(i).get_nmb_field().get_value();
            }

            if(String.Equals(ord_contr.Get_order().get_status().get_value(),"Выполнено "))
            {
                Block_all_fields();
            }
            if(String.Equals(ord_contr.Get_order().get_status().get_value(), "В процессе "))
                Enable_all_fields();
            if (String.Equals(mode, "delete"))
            {
                Block_all_fields();
            }
        }

        private void Block_all_fields()
        {

            dateTimePicker.Enabled = false;
            CustomerCB.Enabled = false;
            RestCB.Enabled = false;
            addDishButton.Visible = false;
            DelButton.Visible = false;
            DelTextBox.Visible = false;
            countButton.Visible = false;

            for (int i = 0; i < DishCB_list.Count; i++)
            {
                DishCB_list[i].Enabled = false;
                DishTB_list[i].Enabled = false;
            }
        }

        private void Enable_all_fields()
        {
            dateTimePicker.Enabled = true;
            CustomerCB.Enabled = true;
            RestCB.Enabled = true;
            addDishButton.Visible = true;
            DelButton.Visible = true;
            DelTextBox.Visible = true;
            countButton.Visible = true;

            for (int i = 0; i < DishCB_list.Count; i++)
            {
                DishCB_list[i].Enabled = true;
                DishTB_list[i].Enabled = true;
            }
        }

        private void statusLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (String.Equals(statusLB.Text, "Выполнено "))
            {
                Block_all_fields();
            }
            if(String.Equals(statusLB.Text, "В процессе"))
            {
                Enable_all_fields();
            }
        }
    }
}

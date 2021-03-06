﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml;

using Npgsql;
using System.Data.Common;

namespace kursovaya
{
    public class DBContr
    {                
        private String connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=rbcrf325;Database=usrdb;";

        public int AddOrder(Order_data order)
        {
            int ord_id;

            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();

            NpgsqlCommand ord_commadn = new NpgsqlCommand("INSERT INTO oorder(status, rest_id_f, cust_id_f, order_date) VALUES ('"+order.get_status().get_value()+"', "+ Convert.ToInt32(order.get_rest().get_rest_id())+", "+ Convert.ToInt32(order.get_customer().get_cust_id_p().get_value())+",'"+order.get_event_date().get_value()+"') RETURNING order_id_p", npgSqlConnection);
            ord_id = Convert.ToInt32(ord_commadn.ExecuteScalar().ToString());
            Console.WriteLine(ord_id);

            foreach(Dish dish in order.get_dishes_list())
            {
                /*try
                {*/
                    int price = Convert.ToInt32(dish.get_nmb_field().get_value()) * Convert.ToInt32(dish.get_cost_field().get_value());
                    NpgsqlCommand ordr_commadn = new NpgsqlCommand("INSERT INTO ordered(order_id_p, dish_id_p, oredered_dish_price, num)" + "VALUES (" + ord_id + ", " + Convert.ToInt32(dish.get_dish_id_field().get_value()) + ", " + price + "::money, " + Convert.ToInt32(dish.get_nmb_field().get_value()) + ")", npgSqlConnection);
                    ordr_commadn.ExecuteScalar();
               /*}
                catch (System.FormatException)
                {
                    System.Windows.Forms.MessageBox.Show("В числовом поле должно быть число!");
                }*/
;
            }
            npgSqlConnection.Close();
            return ord_id;
        }

        public string AddRest(Restaurant rest)
        {
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();

            NpgsqlCommand add_commadn = new NpgsqlCommand("INSERT INTO restaurant(rest_name) VALUES ('" + rest.get_rest_name() + "') RETURNING rest_id_p", npgSqlConnection);
            string id = add_commadn.ExecuteScalar().ToString();
            npgSqlConnection.Close();
            return id;
        }

        public string AddCustomer(Customer cust)
        {
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();

            NpgsqlCommand add_commadn = new NpgsqlCommand("INSERT INTO customer(fname, tel) VALUES ('" +cust.get_cust_name().get_value() +"', '"+cust.get_cust_tel().get_value()+"') RETURNING cust_id_p", npgSqlConnection);
            string id = add_commadn.ExecuteScalar().ToString();

            npgSqlConnection.Close();
            return id;
        }

        public void AddDish_to_order(string ord_id, string dish_id, string dish_col, string ordered_price)
        {
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();

            Console.WriteLine(ord_id + "  " + dish_col + " " + ordered_price);
            NpgsqlCommand add_commadn = new NpgsqlCommand("INSERT INTO ordered VALUES (" + ord_id + ", " + dish_id + ", "+ordered_price+", "+dish_col+")", npgSqlConnection);
            add_commadn.ExecuteScalar();

            npgSqlConnection.Close();
        }

        public void DelDish_from_order(string ord_id, string dish_id)
        {
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();

            Console.WriteLine(ord_id + "  " + dish_id);
            NpgsqlCommand add_commadn = new NpgsqlCommand("DELETE FROM ordered WHERE order_id_p="+ord_id+" AND dish_id_p="+dish_id+"", npgSqlConnection);
            add_commadn.ExecuteScalar();

            npgSqlConnection.Close();
        }

        public bool AddDish(Dish dish)
        {
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();

            try
            {
                NpgsqlCommand add_commadn = new NpgsqlCommand("INSERT INTO dish(dish_name, price) VALUES ('" + dish.get_name_field().get_value() + "', " + Convert.ToInt32(dish.get_cost_field().get_value()) + ") RETURNING dish_id_p", npgSqlConnection);
                string id = add_commadn.ExecuteScalar().ToString();
                npgSqlConnection.Close();
                return false;
            }
            catch (FormatException)
            {
                System.Windows.Forms.MessageBox.Show("В числовом поле должно быть число!");
                npgSqlConnection.Close();
                return true;
            }            
            
            
        }

        public List<Order_data> Load_from_db()
        {
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();
            NpgsqlCommand Order_data_Command = new NpgsqlCommand("SELECT customer.fname, customer.tel, customer.cust_id_p, oorder.order_date, oorder.order_id_p, oorder.rest_id_f, oorder.status FROM customer, oorder WHERE oorder.cust_id_f=customer.cust_id_p", npgSqlConnection);
            NpgsqlCommand Dish_command = new NpgsqlCommand("SELECT dish.dish_name, dish.dish_id_p, dish.price, ordered.num, ordered.oredered_dish_price, ordered.order_id_p, oorder.rest_id_f FROM dish, ordered, oorder WHERE dish.dish_id_p=ordered.dish_id_p AND ordered.order_id_p=oorder.order_id_p", npgSqlConnection);
            NpgsqlCommand Rest_command = new NpgsqlCommand("SELECT restaurant.rest_name, restaurant.rest_id_p FROM restaurant", npgSqlConnection);

            OrdersManager ord_mngr = new OrdersManager();
            NpgsqlDataReader Order_data_reader = Order_data_Command.ExecuteReader();

            foreach (DbDataRecord Odr in Order_data_reader)
            {
                Order_data order_data = new Order_data();
                Customer cust = new Customer();

                order_data.get_ord_name().set_value(Odr["order_id_p"].ToString());
                order_data.get_status().set_value(Odr["status"].ToString());
                cust.get_cust_id_p().set_value(Odr["cust_id_p"].ToString());
                order_data.get_event_date().set_value(Odr["order_date"].ToString());
                order_data.get_rest_id_f().set_value(Odr["rest_id_f"].ToString());
                cust.get_cust_name().set_value(Odr["fname"].ToString());
                cust.get_cust_tel().set_value(Odr["tel"].ToString());

                order_data.set_customer(cust);

                ord_mngr.add_order(order_data);
            }
            Order_data_reader.Close();

            NpgsqlDataReader Rest_data_reader = Rest_command.ExecuteReader();
            if (Order_data_reader.HasRows)
            {
                foreach (DbDataRecord Rr in Rest_data_reader)
                {
                    Restaurant rest = new Restaurant();

                    rest.set_rest_name(Rr["rest_name"].ToString());
                    rest.set_rest_id(Rr["rest_id_p"].ToString());

                    foreach (Order_data ord in ord_mngr.get_orders_list())
                    {
                        if (String.Equals(ord.get_rest_id_f().get_value(), rest.get_rest_id()))
                        {
                            ord.set_rest(rest);
                        }
                    }
                }
            }
            else
                Console.WriteLine("Error");

            Rest_data_reader.Close();

            NpgsqlDataReader Dish_data_reader = Dish_command.ExecuteReader();
            foreach (DbDataRecord Dr in Dish_data_reader)
            {
                Dish d = new Dish();

                d.get_name_field().set_value(Dr["dish_name"].ToString());
                d.get_nmb_field().set_value(Dr["num"].ToString());
                d.get_cost_field().set_value(Dr["price"].ToString());
                d.get_ord_id_field().set_value(Dr["order_id_p"].ToString());
                d.get_dish_id_field().set_value(Dr["dish_id_p"].ToString());

                foreach (Order_data ord in ord_mngr.get_orders_list())
                {
                    if (ord.get_ord_name().get_value() == d.get_ord_id_field().get_value())
                    {
                        Console.WriteLine(ord.get_ord_name().get_value() + "==" + d.get_ord_id_field().get_value());
                        ord.add_dish_to_order(d);
                    }
                }
            }

            Dish_data_reader.Close();

            foreach (Order_data ord in ord_mngr.get_orders_list())
            {

                if (!String.Equals(ord.get_status().get_value(), "Выполнено "))
                {
                    ord.CountDishCol();
                    ord.RecountFPrice();
                }
                else
                {
                    ord.CountDishCol();
                    int price = 0;
                    NpgsqlCommand Price_command = new NpgsqlCommand("SELECT ordered.oredered_dish_price, ordered.order_id_p FROM ordered WHERE ordered.order_id_p=" + ord.get_ord_name().get_value(), npgSqlConnection);

                    NpgsqlDataReader Price_data_reader = Price_command.ExecuteReader();
                    foreach (DbDataRecord Pr in Price_data_reader)
                    {
                        price += Convert.ToInt32(Pr["oredered_dish_price"]);
                        Console.WriteLine(price);
                    }
                    Price_data_reader.Close();
                    ord.get_fin_cost().set_value(price.ToString());
                }
            }
            npgSqlConnection.Close();

            return ord_mngr.get_orders_list();
        }

        public List<Restaurant> Get_db_rests()
        {
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();
            NpgsqlCommand Rests_data_Command = new NpgsqlCommand("SELECT * FROM restaurant", npgSqlConnection);

            List<Restaurant> rests_list = new List<Restaurant>();
            NpgsqlDataReader Rests_data_reader = Rests_data_Command.ExecuteReader();
            foreach (DbDataRecord R in Rests_data_reader)
            {
                Restaurant rest = new Restaurant();
                rest.set_rest_name(R["rest_name"].ToString());
                rest.set_rest_id(R["rest_id_p"].ToString());

                rests_list.Add(rest);
            }
            Rests_data_reader.Close();
            npgSqlConnection.Close();

            return rests_list;
        }

        public List<Dish> Get_db_dishes()
        {
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();
            NpgsqlCommand Dishes_data_Command = new NpgsqlCommand("SELECT * FROM dish", npgSqlConnection);

            List<Dish> dishes_list = new List<Dish>();
            NpgsqlDataReader Dishes_data_reader = Dishes_data_Command.ExecuteReader();

            foreach (DbDataRecord D in Dishes_data_reader)
            {
                Dish dish = new Dish();
                dish.get_dish_id_field().set_value(D["dish_id_p"].ToString());
                dish.get_name_field().set_value(D["dish_name"].ToString());
                dish.get_cost_field().set_value(D["price"].ToString());
                dish.get_nmb_field().set_value("0");

                dishes_list.Add(dish);
            }
            Dishes_data_reader.Close();
            npgSqlConnection.Close();

            return dishes_list;
        }

        public List<Customer> Get_db_custs()
        {
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();
            NpgsqlCommand Orders_data_Command = new NpgsqlCommand("SELECT * FROM customer", npgSqlConnection);

            List<Customer> custs_list = new List<Customer>();
            NpgsqlDataReader Custs_data_reader = Orders_data_Command.ExecuteReader();

            foreach(DbDataRecord C in Custs_data_reader)
            {
                Customer cust = new Customer();
                cust.get_cust_id_p().set_value(C["cust_id_p"].ToString());
                cust.get_cust_name().set_value(C["fname"].ToString());
                cust.get_cust_tel().set_value(C["tel"].ToString());

                custs_list.Add(cust);
            }
            Custs_data_reader.Close();
            npgSqlConnection.Close();

            return custs_list;
        }

        public void Edit_order_field(Order_fields field, string id)
        {
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();

            Console.WriteLine("@@" + id + " " + field.get_value());

            if (field.get_type() == "string")
            {
                NpgsqlCommand ord_commadn = new NpgsqlCommand("UPDATE oorder SET " + field.get_db_name() + "='" + field.get_value() + "' WHERE order_id_p=" + Convert.ToInt32(id), npgSqlConnection);
                ord_commadn.ExecuteScalar();
            }
            if (field.get_type() == "int")
            {
                NpgsqlCommand ord_commadn = new NpgsqlCommand("UPDATE oorder SET " + field.get_db_name() + "=" + Convert.ToUInt32(field.get_value()) + " WHERE order_id_p=" + Convert.ToInt32(id), npgSqlConnection);
                ord_commadn.ExecuteScalar();
            }
            npgSqlConnection.Close();
        }

        public void Edit_cust_field(Order_fields field, string id)
        {
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();

            NpgsqlCommand commadn = new NpgsqlCommand("UPDATE customer SET " + field.get_db_name() + "='" + field.get_value() + "' WHERE cust_id_p=" + Convert.ToInt32(id), npgSqlConnection);
            commadn.ExecuteScalar();

            npgSqlConnection.Close();
        }

        public void Edit_rest(string rest_name, string id)
        {
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();

            NpgsqlCommand commadn = new NpgsqlCommand("UPDATE restaurant SET rest_name='" + rest_name + "' WHERE rest_id_p=" + Convert.ToInt32(id), npgSqlConnection);
            commadn.ExecuteScalar();

            npgSqlConnection.Close();
        }

        public bool Edit_dish_field(Dish_fields field, string id)
        {
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();

            try
            {
                NpgsqlCommand commadn = new NpgsqlCommand("UPDATE dish SET " + field.get_db_name() + "='" + field.get_value() + "' WHERE dish_id_p=" + Convert.ToInt32(id), npgSqlConnection);
                commadn.ExecuteScalar();
                npgSqlConnection.Close();
                return false;
            }
            catch (Npgsql.PostgresException)
            {
                System.Windows.Forms.MessageBox.Show("В числовом поле должно быть число!");
                npgSqlConnection.Close();
                return true;
            }
        }

        public void Delete_cust(string id)
        {
            List<string> ordrs_id = new List<string>();
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();

            NpgsqlCommand commadn0 = new NpgsqlCommand("SELECT order_id_p FROM oorder WHERE cust_id_f=" + Convert.ToInt32(id), npgSqlConnection);
            NpgsqlDataReader Order_data_reader = commadn0.ExecuteReader();

            foreach (DbDataRecord Ord in Order_data_reader)
            {
                ordrs_id.Add(Ord["order_id_p"].ToString());
            }
            Order_data_reader.Close();

            foreach (string ord_id in ordrs_id)
            {
                NpgsqlCommand commadn1 = new NpgsqlCommand("DELETE FROM ordered WHERE order_id_p = " + Convert.ToInt32(ord_id)+"; DELETE FROM oorder WHERE order_id_p=" + Convert.ToInt32(ord_id), npgSqlConnection);
                commadn1.ExecuteScalar();
            }
            NpgsqlCommand commadn2 = new NpgsqlCommand("DELETE FROM customer WHERE cust_id_p=" + Convert.ToInt32(id), npgSqlConnection);
            commadn2.ExecuteScalar();

            npgSqlConnection.Close();
        }

        public void Delete_rest(string id)
        {
            List<string> ordrs_id = new List<string>();
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();

            NpgsqlCommand commadn0 = new NpgsqlCommand("SELECT order_id_p FROM oorder WHERE rest_id_f=" + Convert.ToInt32(id), npgSqlConnection);
            NpgsqlDataReader Order_data_reader = commadn0.ExecuteReader();

            foreach (DbDataRecord Ord in Order_data_reader)
            {
                ordrs_id.Add(Ord["order_id_p"].ToString());
            }
            Order_data_reader.Close();

            foreach (string ord_id in ordrs_id)
            {
                NpgsqlCommand commadn1 = new NpgsqlCommand("DELETE FROM ordered WHERE order_id_p = " + Convert.ToInt32(ord_id) + "; DELETE FROM oorder WHERE order_id_p=" + Convert.ToInt32(ord_id), npgSqlConnection);
                commadn1.ExecuteScalar();
            }
            NpgsqlCommand commadn2 = new NpgsqlCommand("DELETE FROM restaurant WHERE rest_id_p=" + Convert.ToInt32(id), npgSqlConnection);
            commadn2.ExecuteScalar();

            npgSqlConnection.Close();
        }

        public void Delete_dish(string id)
        {
            List<string> ordrs_id = new List<string>();
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();

            NpgsqlCommand commadn0 = new NpgsqlCommand("DELETE FROM ordered WHERE dish_id_p=" + Convert.ToInt32(id), npgSqlConnection);
            commadn0.ExecuteScalar();
            NpgsqlCommand commadn1 = new NpgsqlCommand("DELETE FROM dish WHERE dish_id_p=" + Convert.ToInt32(id), npgSqlConnection);
            commadn1.ExecuteScalar();

            npgSqlConnection.Close();
        }

        public void Delete_order(string id)
        {
            List<string> ordrs_id = new List<string>();
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();

            NpgsqlCommand commadn0 = new NpgsqlCommand("DELETE FROM ordered WHERE order_id_p=" + Convert.ToInt32(id), npgSqlConnection);
            commadn0.ExecuteScalar();
            NpgsqlCommand commadn1 = new NpgsqlCommand("DELETE FROM oorder WHERE order_id_p=" + Convert.ToInt32(id), npgSqlConnection);
            commadn1.ExecuteScalar();

            npgSqlConnection.Close();
        }

        public void Update_ordered(string order_id, Dish dish)
        {
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();

            int price = Convert.ToInt32(dish.get_nmb_field().get_value()) * Convert.ToInt32(dish.get_cost_field().get_value());
            NpgsqlCommand commadn0 = new NpgsqlCommand("UPDATE ordered SET oredered_dish_price="+price+" WHERE order_id_p=" + Convert.ToInt32(order_id)+" AND dish_id_p="+dish.get_dish_id_field().get_value(), npgSqlConnection);
            Console.WriteLine(order_id + "!!  " + price.ToString() + "col" + dish.get_nmb_field().get_value());
            commadn0.ExecuteScalar();

            NpgsqlCommand commadn1 = new NpgsqlCommand("UPDATE ordered SET num=" + dish.get_nmb_field().get_value() + " WHERE order_id_p=" + Convert.ToInt32(order_id) + " AND dish_id_p=" + dish.get_dish_id_field().get_value(), npgSqlConnection);
            commadn1.ExecuteScalar();

            npgSqlConnection.Close();
        }
    }
}

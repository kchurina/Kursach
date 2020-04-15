using System;
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

        public List<Order_data> Load_from_db()
        {
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();
            NpgsqlCommand Order_data_Command = new NpgsqlCommand("SELECT customer.fname, customer.tel, customer.cust_id_p, oorder.order_date, oorder.order_id_p, oorder.rest_id_f FROM customer, oorder WHERE oorder.cust_id_f=customer.cust_id_p", npgSqlConnection);
            NpgsqlCommand Dish_command = new NpgsqlCommand("SELECT dish.dish_name, dish.dish_id_p, dish.price, ordered.num, ordered.oredered_dish_price, ordered.order_id_p, oorder.rest_id_f FROM dish, ordered, oorder WHERE dish.dish_id_p=ordered.dish_id_p AND ordered.order_id_p=oorder.order_id_p", npgSqlConnection);
            NpgsqlCommand Rest_command = new NpgsqlCommand("SELECT restaurant.rest_name, restaurant.rest_id_p FROM restaurant", npgSqlConnection);

            OrdersManager ord_mngr = new OrdersManager();
            NpgsqlDataReader Order_data_reader = Order_data_Command.ExecuteReader();
            
                foreach (DbDataRecord Odr in Order_data_reader)
                {
                    Order_data order_data = new Order_data();
                Customer cust = new Customer();

                    order_data.get_ord_name().set_value(Odr["order_id_p"].ToString());
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
                Dish dish = new Dish();

                dish.get_name_field().set_value(Dr["dish_name"].ToString());
                dish.get_nmb_field().set_value(Dr["num"].ToString());
                dish.get_cost_field().set_value(Dr["price"].ToString());
                dish.get_ord_id_field().set_value(Dr["order_id_p"].ToString());
                dish.get_rest_id_field().set_value(Dr["rest_id_f"].ToString());
                dish.get_dish_id_field().set_value(Dr["dish_id_p"].ToString());

                foreach (Order_data ord in ord_mngr.get_orders_list())
                {
                    Restaurant rest = ord.get_rest();
                    
                        if (String.Equals(ord.get_ord_name().get_value(), dish.get_ord_id_field().get_value()) &
                            String.Equals(rest.get_rest_id(), dish.get_rest_id_field().get_value()))
                        {
                            rest.add_dish_to_rest(dish);
                        }
                    
                }
            }

            Dish_data_reader.Close();

            foreach (Order_data ord in ord_mngr.get_orders_list())
            {
                ord.CountDishCol();
                ord.RecountFPrice();
            }

            npgSqlConnection.Close();
                     
            return ord_mngr.get_orders_list();
        }

        public List<Restaurant> Get_rests_from_db()
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

        public List<Dish> Get_dishes_from_db()
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

                dishes_list.Add(dish);
            }
            Dishes_data_reader.Close();
            npgSqlConnection.Close();

            return dishes_list;
        }

        public List<Customer> Get_custs_from_db()
        {
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();
            NpgsqlCommand Orders_data_Command = new NpgsqlCommand("SELECT * FROM customers", npgSqlConnection);

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
    }
}

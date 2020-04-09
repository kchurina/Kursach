using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data.Common;

namespace kursovaya
{
    class Program
    {
        static void Main(string[] args)
        {
            String connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=rbcrf325;Database=usrdb;";
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();
            NpgsqlCommand Order_data_Command = new NpgsqlCommand("SELECT customer.fname, customer.tel, oorder.order_date, oorder.order_id_p, oorder.rest_id_f FROM customer, oorder WHERE oorder.cust_id_f=customer.cust_id_p", npgSqlConnection);
            NpgsqlCommand Dish_command = new NpgsqlCommand("SELECT dish.dish_name, dish.price, ordered.num, ordered.oredered_dish_price, ordered.order_id_p, oorder.rest_id_f FROM dish, ordered, oorder WHERE dish.dish_id_p=ordered.dish_id_p AND ordered.order_id_p=oorder.order_id_p", npgSqlConnection);
            NpgsqlCommand Rest_command = new NpgsqlCommand("SELECT restaurant.rest_name, restaurant.rest_id_p FROM restaurant", npgSqlConnection);

            OrdersManager ord_mngr = new OrdersManager();
            NpgsqlDataReader Order_data_reader = Order_data_Command.ExecuteReader();
            if (Order_data_reader.HasRows)
            {
                
                Console.WriteLine("Table: customer");
                foreach (DbDataRecord Odr in Order_data_reader)
                {
                    Order_data order_data = new Order_data();

                    order_data.get_ord_name().set_value(Odr["order_id_p"].ToString());
                    order_data.get_event_date().set_value(Odr["order_date"].ToString());
                    order_data.get_restid_field().set_value(Odr["rest_id_f"].ToString());
                    order_data.get_cust_name().set_value(Odr["fname"].ToString());
                    order_data.get_cust_tel().set_value(Odr["tel"].ToString());

                    ord_mngr.add_order(order_data);
                }
            }
            else
                Console.WriteLine("Error");

            Order_data_reader.Close();

            

            NpgsqlDataReader Rest_data_reader = Rest_command.ExecuteReader();
            if (Order_data_reader.HasRows)
            {
                foreach (DbDataRecord Rr in Rest_data_reader)
                {
                    Restaurant rest = new Restaurant();

                    rest.set_rest_name(Rr["rest_name"].ToString());
                    rest.set_rest_id(Rr["rest_id_p"].ToString());

                    foreach(Order_data ord in ord_mngr.get_orders_list())
                    {
                        if(String.Equals(ord.get_restid_field().get_value(),rest.get_rest_id()))
                        {
                            ord.add_rest(rest);
                        }
                    }
                }
            }
            else
                Console.WriteLine("Error");

            Rest_data_reader.Close();

            NpgsqlDataReader Dish_data_reader = Dish_command.ExecuteReader();
            foreach(DbDataRecord Dr in Dish_data_reader)
            {                   
                Dish dish = new Dish();

                dish.get_name_field().set_value(Dr["dish_name"].ToString());
                dish.get_nmb_field().set_value(Dr["num"].ToString());
                dish.get_cost_field().set_value(Dr["price"].ToString());
                dish.get_id_field().set_value(Dr["order_id_p"].ToString());
                dish.get_restid_field().set_value(Dr["rest_id_f"].ToString());

                foreach (Order_data ord in ord_mngr.get_orders_list())
                {
                    foreach(Restaurant rest in ord.get_rests_list())
                    {
                        if(String.Equals(ord.get_ord_name().get_value(),dish.get_id_field().get_value()) &
                            String.Equals(rest.get_rest_id(),dish.get_restid_field().get_value()))
                        {
                            rest.add_dish_to_rest(dish);
                        }
                    }
                }
            }            
            
            Dish_data_reader.Close();

            foreach(Order_data ord in ord_mngr.get_orders_list())
            {
                Console.WriteLine("@");
                Console.WriteLine(ord.get_cust_name().get_value());
                foreach (Restaurant rest in ord.get_rests_list())
                {
                    Console.WriteLine("     " + rest.get_rest_name());
                    foreach (Dish dish in rest.get_dishes_list())
                    {
                        Console.WriteLine("         " + dish.get_name_field().get_value());
                    }
                }
            }
        }
    }
}


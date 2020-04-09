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
    public class SaverLoaderContr
    {                
        /*public void SaveMngrToFile(OrdersManager ord_mgr)
        {
            XDocument xdoc = new XDocument();

            XElement Xorders = new XElement("orders");

            foreach (Order_data order in ord_mgr.get_orders_list())
            {
                XElement Xrests = new XElement("restorans");

                foreach (Restaurant rest in order.get_rests_list())
                {
                    XElement dishes = new XElement("dishes");

                    foreach (Dish dish in rest.get_dishes_list())
                    {
                        XElement Xdish = new XElement("dish");

                        XElement dish_name = new XElement("dish_name", dish.get_name_field().get_value());
                        XElement cost = new XElement("cost", dish.get_cost_field().get_value());
                        XElement nmb = new XElement("nmb", dish.get_nmb_field().get_value());

                        Xdish.Add(dish_name);
                        Xdish.Add(cost);
                        Xdish.Add(nmb);

                        dishes.Add(Xdish);
                    }
                    XElement Xrest = new XElement("restoran");

                    XElement rest_name = new XElement("restoran_name", rest.get_rest_name());

                    Xrest.Add(rest_name);
                    Xrest.Add(dishes);

                    Xrests.Add(Xrest);
                }
                XElement Xorder = new XElement("order", new XAttribute("name", order.get_ord_name().get_value()));

                XElement even_date = new XElement("even_date", order.get_event_date().get_value());
                XElement status = new XElement("status", order.get_status().get_value());
                XElement cust_name = new XElement("cust_name", order.get_cust_name().get_value());
                XElement cust_tel = new XElement("cust_tel", order.get_cust_tel().get_value());
                XElement rest_col = new XElement("rest_col", order.get_rest_col().get_value());
                XElement dish_col = new XElement("dish_col", order.get_dish_col().get_value());

                Xorder.Add(even_date);
                Xorder.Add(status);
                Xorder.Add(cust_name);
                Xorder.Add(cust_tel);
                Xorder.Add(rest_col);
                Xorder.Add(dish_col);
                Xorder.Add(Xrests);

                Xorders.Add(Xorder);

            }
            xdoc.Add(Xorders);
            xdoc.Save("D:/VUZ/ООП/Kursach/Kursovic/Kursovic/try_save.xml");
        }*/

        public List<Order_data> Load_orders_from_file()
        {
            String connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=rbcrf325;Database=usrdb;";
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();
            NpgsqlCommand Order_data_Command = new NpgsqlCommand("SELECT customer.fname, customer.tel, customer.cust_id_p, oorder.order_date, oorder.order_id_p, oorder.rest_id_f FROM customer, oorder WHERE oorder.cust_id_f=customer.cust_id_p", npgSqlConnection);
            NpgsqlCommand Dish_command = new NpgsqlCommand("SELECT dish.dish_name, dish.dish_id_p, dish.price, ordered.num, ordered.oredered_dish_price, ordered.order_id_p, oorder.rest_id_f FROM dish, ordered, oorder WHERE dish.dish_id_p=ordered.dish_id_p AND ordered.order_id_p=oorder.order_id_p", npgSqlConnection);
            NpgsqlCommand Rest_command = new NpgsqlCommand("SELECT restaurant.rest_name, restaurant.rest_id_p FROM restaurant", npgSqlConnection);

            OrdersManager ord_mngr = new OrdersManager();
            NpgsqlDataReader Order_data_reader = Order_data_Command.ExecuteReader();
            if (Order_data_reader.HasRows)
            {
                foreach (DbDataRecord Odr in Order_data_reader)
                {
                    Order_data order_data = new Order_data();

                    order_data.get_ord_name().set_value(Odr["order_id_p"].ToString());
                    order_data.get_cust_id_p().set_value(Odr["cust_id_p"].ToString());
                    order_data.get_event_date().set_value(Odr["order_date"].ToString());
                    order_data.get_rest_id_f().set_value(Odr["rest_id_f"].ToString());
                    order_data.get_cust_name().set_value(Odr["fname"].ToString());
                    order_data.get_cust_tel().set_value(Odr["tel"].ToString());

                    ord_mngr.add_order(order_data);
                }
            }
            else
                Console.WriteLine("!Order_data_reader.HasRows");

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
                            ord.add_rest(rest);
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
                    foreach (Restaurant rest in ord.get_rests_list())
                    {
                        if (String.Equals(ord.get_ord_name().get_value(), dish.get_ord_id_field().get_value()) &
                            String.Equals(rest.get_rest_id(), dish.get_rest_id_field().get_value()))
                        {
                            rest.add_dish_to_rest(dish);
                        }
                    }
                }
            }

            Dish_data_reader.Close();

            return ord_mngr.get_orders_list();
        }
    }
}

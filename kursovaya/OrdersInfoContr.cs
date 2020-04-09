using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kursovaya
{
    public class OrdersInfoContr
    {
        private Order_data order;

        public OrdersInfoContr(Order_data new_ord)
        {
            order = new_ord;
        }

        public void Set_order(Order_data new_ord)
        {
            order = new_ord;
        }

        public Order_data Get_order()
        {
            return order;
        }

        public void Add_rest(string rest_name)
        {
            Restaurant new_rest = new Restaurant();

            new_rest.set_rest_name(rest_name);
            order.add_rest(new_rest);
        }

        public bool CheckExist(string name)
        {
            foreach (Restaurant rest in order.get_rests_list())
            {
                if (String.Equals(name, rest.get_rest_name()))
                {
                    return true;
                }
            }
            return false;
        }

        public Restaurant FindRest(string name)
        {
            foreach (Restaurant rest in order.get_rests_list())
            {
                if (String.Equals(name, rest.get_rest_name()))
                {
                    return rest;
                }
            }
            return null;
        }

        public void Change_order(string name, string date, string c_name, string tel, string cost, string status)
        {
            order.get_ord_name().set_value(name);
            order.get_event_date().set_value(date);
            order.get_cust_name().set_value(c_name);
            order.get_cust_tel().set_value(tel);
            order.get_fin_cost().set_value(cost);
            order.get_status().set_value(status);

        }

        public void DelRest(string rest_name)
        {
            List<Restaurant> rest_list = order.get_rests_list();
            for (int i = 0; i < rest_list.Count; i++)
            {
                if (String.Equals(rest_list[i].get_rest_name(), rest_name))
                {
                    rest_list.RemoveAt(i);
                    break;
                }
            }
        }

    }
}

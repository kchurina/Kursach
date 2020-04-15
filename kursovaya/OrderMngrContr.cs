using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kursovaya
{
    public class OrderMngrContr
    {
        private OrdersManager ord_mngr;

        public OrderMngrContr(OrdersManager new_mngr)
        {
            ord_mngr = new_mngr;
        }
        public OrderMngrContr()
        {
            ord_mngr = new OrdersManager();
        }

        public void Add_new_order(string order_id_p, string cust_id_p, string name, string date, string c_name, string tel, string cost, string status)
        {
            Order_data new_ord = new Order_data();
            Customer new_cust = new Customer();
            new_ord.get_ord_name().set_value(order_id_p);
            new_ord.get_ord_name().set_value(name);
            new_ord.get_event_date().set_value(date);
            new_cust.get_cust_name().set_value(c_name);
            new_cust.get_cust_tel().set_value(tel);
            new_cust.get_cust_id_p().set_value(cust_id_p);
            new_ord.get_fin_cost().set_value(cost);
            new_ord.get_status().set_value(status);

            new_ord.set_customer(new_cust);

            ord_mngr.add_order(new_ord);
        }

        public bool CheckExist(string name)
        {
            foreach (Order_data ord in ord_mngr.get_orders_list())
            {
                if (String.Equals(name, ord.get_ord_name().get_value()))
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckExistForChange(string name)
        {
            foreach (Order_data ord in ord_mngr.get_orders_list())
            {
                if (String.Equals(name, ord.get_ord_name().get_value()) )
                {
                    return true;
                }
            }
            return false;
        }

        public Order_data FindOrder(string ord_name)
        {
            foreach (Order_data ord in ord_mngr.get_orders_list())
            {
                if (String.Equals(ord.get_ord_name().get_value(), ord_name))
                {
                    return ord;
                }
            }
            return null;
        }

        public OrdersManager Get_mngr()
        {
            return ord_mngr;
        }

        public void DeleteOrder(string ord_name)
        {
            List<Order_data> ord_list = ord_mngr.get_orders_list();
            for (int i = 0; i < ord_list.Count; i++)
            {
                if (String.Equals(ord_list[i].get_ord_name().get_value(), ord_name))
                {
                    ord_list.RemoveAt(i);
                    break;
                }
            }
        }
    }
}

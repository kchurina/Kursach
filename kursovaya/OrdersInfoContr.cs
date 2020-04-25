using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kursovaya
{
    public class OrdersInfoContr
    {
        private Order_data order;
        private DBContr db_contr;

        public OrdersInfoContr(Order_data new_ord)
        {
            order = new_ord;
            db_contr = new DBContr();
        }

        public OrdersInfoContr()
        {
            db_contr = new DBContr();
        }

        public void Set_order(Order_data new_ord)
        {
            order = new_ord;
        }

        public Order_data Get_order()
        {
            return order;
        }
        
        public void Set_rest(Restaurant new_rest)
        {
            order.set_rest(new_rest);
        }

        public Restaurant Get_rest()
        {
            return order.get_rest();
        }

        public void Change_order(string name, string date, string c_name, string tel, string cost, string status)
        {
            order.get_ord_name().set_value(name);
            order.get_event_date().set_value(date);
            order.get_customer().get_cust_name().set_value(c_name);
            order.get_customer().get_cust_tel().set_value(tel);
            order.get_fin_cost().set_value(cost);
            order.get_status().set_value(status);
            ///
        }
    }
}

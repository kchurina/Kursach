using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml;

namespace kursovaya
{
    public class OrdersManager
    {
        private List<Order_data> orders;

        public OrdersManager()
        {
            orders = new List<Order_data>();
        }

        public List<Order_data> get_orders_list()
        {
            return orders;
        }

        public void set_orders_list(List<Order_data> new_list)
        {
            orders = new_list;
        }

        public void add_order(Order_data new_ord)
        {
            orders.Add(new_ord);
        }
    }
}

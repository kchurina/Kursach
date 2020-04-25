using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kursovaya
{
    public class OrderMngrContr
    {
        private OrdersManager ord_mngr;
        private DBContr db_contr = new DBContr();

        public OrderMngrContr(OrdersManager new_mngr)
        {
            ord_mngr = new_mngr;
        }
        public OrderMngrContr()
        {
            ord_mngr = new OrdersManager();
        }

        public Order_data Add_new_order(string order_id_p, string cust_id_p, string date, string cost, string status, Restaurant rest, Customer cust, List<Dish> dishes_list)
        {
            Order_data new_ord = new Order_data();
            new_ord.get_ord_name().set_value(order_id_p);
            new_ord.get_event_date().set_value(date);
            new_ord.get_fin_cost().set_value(cost);
            new_ord.get_status().set_value(status);


            new_ord.set_customer(cust);
            new_ord.set_rest(rest);
            new_ord.set_dishes_list(dishes_list);

            db_contr.AddOrder(new_ord);

            return new_ord;
        }

        public void Add_dish_to_order(Order_data order, Dish new_dish)
        {
            order.get_dishes_list().Add(new_dish);
            ord_mngr.add_order(order);
        }

        public void Add_dish_to_order(Order_data order, string dish_id, string name, string price, string col)
        {
            Dish new_dish = new Dish();

            new_dish.get_name_field().set_value(name);
            new_dish.get_dish_id_field().set_value(dish_id);
            new_dish.get_cost_field().set_value(price);
            new_dish.get_nmb_field().set_value(col);

            order.get_dishes_list().Add(new_dish);
            ord_mngr.add_order(order);
        }

        public void Add_rest_to_order(Order_data order, Restaurant new_rest)
        {
            order.set_rest(new_rest);
        }

        public void Add_rest_to_order(Order_data order, string rest_id, string rest_name)
        {
            Restaurant rest = new Restaurant();

            rest.set_rest_id(rest_id);
            rest.set_rest_name(rest_name);

            order.set_rest(rest);
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

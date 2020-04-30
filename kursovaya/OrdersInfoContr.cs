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

        public Customer Get_cust()
        {
            return order.get_customer();
        }

        public void Edit_ord_field(Order_fields field)
        {
            db_contr.Edit_order_field(field, order.get_ord_name().get_value());
        }

        public bool Check_status_date_equal(Order_data some_ord)
        {
            if (!String.Equals(order.get_event_date().get_value(), some_ord.get_event_date().get_value()))
                return false;
            if(!String.Equals(order.get_status().get_value(), some_ord.get_status().get_value()))
                return false;
            return true;
        }

        public bool Check_exist_dish(string id)
        {
            foreach (Dish d in order.get_dishes_list())
            {
                if (String.Equals(d.get_dish_id_field().get_value(), id))
                    return true;
            }
            return false;
        }

        public bool Check_exist_cust(string id)
        {
            if (String.Equals(order.get_customer().get_cust_id_p().get_value(), id))
                return true;
            else 
                return false;
        }

        public bool Check_exist_rest(string id)
        {
            if (String.Equals(order.get_rest().get_rest_id(), id))
                return true;
            else
                return false;
        }
        
        public Dish Get_dish_of_order(int i)
        {
            return order.get_dishes_list()[i];
        }

        public void Add_dish_to_order(Dish dish)
        {
            int price = Convert.ToInt32(dish.get_nmb_field().get_value()) * Convert.ToInt32(dish.get_cost_field().get_value());
            db_contr.AddDish_to_order(order.get_ord_name().get_value(), dish.get_dish_id_field().get_value(), dish.get_nmb_field().get_value(), price.ToString());
        }

        public void DelDish_from_order(Dish d)
        {
            db_contr.DelDish_from_order(order.get_ord_name().get_value(), d.get_dish_id_field().get_value());
        }

        public void Delete_order()
        {
            db_contr.Delete_order(order.get_ord_name().get_value());
        }
    }
}

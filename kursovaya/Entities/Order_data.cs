using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace kursovaya
{
    public class Order_data
    {
        private List<Order_fields> ord_fields;
        private List<Dish> dishes;
        private Restaurant rest;
        private Customer cust;

        public Order_data()
        {
            rest = new Restaurant();
            cust = new Customer();
            dishes = new List<Dish>();

            ord_fields = new List<Order_fields>();
            ord_fields.Add(new OrdName_field());
            ord_fields.Add(new Date_field());
            ord_fields.Add(new Status_field());
            ord_fields.Add(new FinCost_field());
            ord_fields.Add(new DishCol_field());
            ord_fields.Add(new Rest_id_f());
        }


        public void RecountFPrice()
        {
            int price = 0;

            foreach (Dish dish in dishes)
            {
                price += Convert.ToInt32(dish.get_nmb_field().get_value()) * Convert.ToInt32(dish.get_cost_field().get_value());

            }

            ord_fields[3].set_value(price.ToString());
        }

        public void CountDishCol()
        {
            ord_fields[4].set_value("0");
            int col = 0;


            foreach (Dish dish in dishes)
            {
                col += Convert.ToInt32(dish.get_nmb_field().get_value());
            }

            ord_fields[4].set_value(col.ToString());
        }

        public Customer get_customer()
        {
            return cust;
        }

        public void set_customer(Customer new_cust)
        {
            cust = new_cust;
        }

        public void set_rest(Restaurant new_rest)
        {
            rest = new_rest;
        }

        public Restaurant get_rest()
        {
            return rest;
        }

        public Order_fields get_ord_name()
        {
            return ord_fields[0];
        }

        public Order_fields get_event_date()
        {
            return ord_fields[1];
        }

        public Order_fields get_status()
        {
            return ord_fields[2];
        }

        public Order_fields get_fin_cost()
        {
            return ord_fields[3];
        }

        public Order_fields get_dish_col()
        {
            return ord_fields[4];
        }

        public Order_fields get_rest_id_f()
        {
            return ord_fields[5];
        }

        public List<Order_fields> get_fields_list()
        {
            return ord_fields;
        }

        public void set_dishes_list(List<Dish> new_list)
        {
            dishes = new_list;
        }

        public List<Dish> get_dishes_list()
        {
            return dishes;
        }

        public void add_dish_to_order(Dish new_dish)
        {
            dishes.Add(new_dish);
        }

    }
}

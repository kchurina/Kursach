using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kursovaya
{
    public class Order_data
    {
        private List<Order_fields> ord_fields;
        private List<Restaurant> rests;

        public Order_data()
        {
            rests = new List<Restaurant>();

            ord_fields = new List<Order_fields>();
            ord_fields.Add(new OrdName_field());
            ord_fields.Add(new Date_field());
            ord_fields.Add(new Status_field());
            ord_fields.Add(new CustName_field());
            ord_fields.Add(new CustTel_field());
            ord_fields.Add(new FinCost_field());
            ord_fields.Add(new RestCol_field());
            ord_fields.Add(new DishCol_field());
            ord_fields.Add(new Rest_id_f());
            ord_fields.Add(new Cust_id_p());
        }

        public void RecountFPrice()
        {
            int price = 0;

            foreach (Restaurant rest in rests)
            {
                foreach (Dish dish in rest.get_dishes_list())
                {
                    price += Convert.ToInt32(dish.get_nmb_field().get_value()) * Convert.ToInt32(dish.get_cost_field().get_value());
                }
            }
            ord_fields[5].set_value(price.ToString());
        }

        public void CountRestCol()
        {
            ord_fields[6].set_value(rests.Count.ToString());
        }

        public void CountDishCol()
        {
            ord_fields[7].set_value("0");
            int col = 0;

            foreach (Restaurant rest in rests)
            {
                foreach (Dish dish in rest.get_dishes_list())
                {
                    col += Convert.ToInt32(dish.get_nmb_field().get_value());
                }
            }

            ord_fields[7].set_value(col.ToString());
        }

        public void set_rests_list(List<Restaurant> new_rest_list)
        {
            rests = new_rest_list;
        }

        public List<Restaurant> get_rests_list()
        {
            return rests;
        }

        public void add_rest(Restaurant new_rest)
        {
            rests.Add(new_rest);
        }

        public Restaurant get_rest(int i)
        {
            return rests[i];
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

        public Order_fields get_cust_name()
        {
            return ord_fields[3];
        }

        public Order_fields get_cust_tel()
        {
            return ord_fields[4];
        }

        public Order_fields get_fin_cost()
        {
            return ord_fields[5];
        }

        public Order_fields get_rest_col()
        {
            return ord_fields[6];
        }

        public Order_fields get_dish_col()
        {
            return ord_fields[7];
        }

        public Order_fields get_rest_id_f()
        {
            return ord_fields[8];
        }

        public Order_fields get_cust_id_p()
        {
            return ord_fields[9];
        }

        public List<Order_fields> get_fields_list()
        {
            return ord_fields;
        }
    }        
}

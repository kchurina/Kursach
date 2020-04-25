using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kursovaya
{
    public class Dish
    {
        private List<Dish_fields> fields;

        public Dish()
        {
            fields = new List<Dish_fields>();
            fields.Add(new Name_field());
            fields.Add(new Cost_field());
            fields.Add(new Nmb_field());
            fields.Add(new Order_id_p());
            fields.Add(new Rest_Id_f());
            fields.Add(new Dish_id_p());
        }
        
        public List<Dish_fields> get_all_dish_fields()
        {
            return fields;
        }

        public void set_all_dish_fields(List<Dish_fields> new_field_list)
        {
            fields = new_field_list;
        }

        public int get_size()
        {
            return fields.Count;
        }

        public Dish_fields get_name_field()
        {
            return fields[0];
        }
        
        public Dish_fields get_cost_field()
        {
            return fields[1];
        }

        public Dish_fields get_nmb_field()
        {
            return fields[2];
        }

        public Dish_fields get_ord_id_field()
        {
            return fields[3];
        }

        public Dish_fields get_rest_id_field()
        {
            return fields[4];
        }

        public Dish_fields get_dish_id_field()
        {
            return fields[5];
        }

    }
}

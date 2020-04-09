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
            fields.Add(new DishOrdId_field());
            fields.Add(new DishRestId_field());
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

        public Dish_fields get_id_field()
        {
            return fields[3];
        }

        public void set_id_field(DishOrdId_field new_field)
        {
            fields[3] = new_field;
        }

        public Dish_fields get_name_field()
        {
            return fields[0];
        }

        public void set_name_field(Name_field new_field)
        {
            fields[0] = new_field;
        }

        public Dish_fields get_cost_field()
        {
            return fields[1];
        }

        public void set_cost_field(Cost_field new_field)
        {
            fields[1] = new_field;
        }

        public Dish_fields get_nmb_field()
        {
            return fields[2];
        }

        public void set_nmb_field(Nmb_field new_field)
        {
            fields[2] = new_field;
        }

        public Dish_fields get_restid_field()
        {
            return fields[4];
        }

        public void set_rest_field(DishRestId_field new_field)
        {
            fields[4] = new_field;
        }
    }
}

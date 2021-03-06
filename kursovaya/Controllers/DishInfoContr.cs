﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovaya
{
    class DishInfoContr
    {
        private DBContr db_contr = new DBContr();
        private List<Dish> dishes;
        private Dish dish;

        public DishInfoContr(Dish new_dish)
        {
            dish = new_dish;
            dishes = db_contr.Get_db_dishes();
        }

        public DishInfoContr()
        {
            dishes = db_contr.Get_db_dishes();
        }

        public bool CheckExistDish(string id)
        {
            foreach (Dish d in dishes)
            {
                if (String.Equals(id, d.get_dish_id_field().get_value()))
                {
                    return true;
                }
            }
            return false;
        }

        public List<Dish> GetDishesList()
        {
            return db_contr.Get_db_dishes();
        }

        public Dish Get_dish()
        {
            return dish;
        }

        public bool Add_dish(string name, string nmb, string cost)
        {
            Dish dish = new Dish();

            dish.get_name_field().set_value(name);
            dish.get_nmb_field().set_value(nmb);
            dish.get_cost_field().set_value(cost);

            return db_contr.AddDish(dish);
        }

        public bool Edit_dish(Dish_fields field)
        {
            return db_contr.Edit_dish_field(field, dish.get_dish_id_field().get_value());
        }

        public void Delete_dish()
        {
            db_contr.Delete_dish(dish.get_dish_id_field().get_value());
        }

        public void Update_ordered(string order_id)
        {
            db_contr.Update_ordered(order_id, dish);
        }

    }
}

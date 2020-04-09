using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kursovaya
{
    public class Restaurant
    {
        private string rest_name;
        private List<Dish> dishes;
        private string rest_id;

        public Restaurant()
        {
            dishes = new List<Dish>();
        }

        public void set_rest_id(string new_id)
        {
            rest_id = new_id;
        }

        public string get_rest_id()
        {
            return rest_id;
        }

        public void set_rest_name(string new_name)
        {
            rest_name = new_name;
        }

        public string get_rest_name()
        {
            return rest_name;
        }

        public void set_dishes_list(List<Dish> new_list)
        {
            dishes = new_list;
        }

        public List<Dish> get_dishes_list()
        {
            return dishes;
        }

        public void add_dish_to_rest(Dish new_dish)
        {
            dishes.Add(new_dish);
        }

        public Dish get_dish_of_rest(int i)
        {
            return dishes[i];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kursovaya
{
    public class Dish_fields
    {
        protected string value;
        protected string field_type;
        protected string name_field;

        virtual public string get_name() { return name_field; }
        virtual public string get_value() { return value; }
        virtual public void set_value(string new_value) { value = new_value; }
        virtual public string get_type() { return field_type; }
    }

    public class Name_field : Dish_fields
    {
        public Name_field() { name_field = "Название блюда"; field_type = "string"; }
    }

    public class Cost_field : Dish_fields
    {
        public Cost_field() { name_field = "Цена блюда"; field_type = "int"; }
    }

    public class Nmb_field : Dish_fields
    {
        public Nmb_field() { name_field = "Количество единиц блюда"; field_type = "int"; }
    }

    public class DishOrdId_field : Dish_fields
    {
        public DishOrdId_field() { name_field = "ID блюда"; field_type = "int"; }
    }

    public class DishRestId_field : Dish_fields
    {
        public DishRestId_field() { name_field = "ID ресторана"; field_type = "int"; }
    }
}

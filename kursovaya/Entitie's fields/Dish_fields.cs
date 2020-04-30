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
        protected string db_name;

        virtual public string get_name() { return name_field; }
        virtual public string get_value() { return value; }
        virtual public void set_value(string new_value) { value = new_value; }
        virtual public string get_type() { return field_type; }
        virtual public string get_db_name() { return db_name; }
    }

    public class Name_field : Dish_fields
    {
        public Name_field() { name_field = "Название блюда"; field_type = "string"; db_name = "dish_name"; }
    }

    public class Cost_field : Dish_fields
    {
        public Cost_field() { name_field = "Цена блюда"; field_type = "int"; db_name = "price"; }
    }

    public class Nmb_field : Dish_fields
    {
        public Nmb_field() { name_field = "Количество единиц блюда"; field_type = "int"; db_name = "ordered.num"; }
    }

    public class Order_id_p : Dish_fields
    {
        public Order_id_p() { name_field = "DishOrdId"; field_type = "string"; db_name = "ordered.order_id_p"; }
    }


    public class Dish_id_p : Dish_fields
    {
        public Dish_id_p () { name_field = "dish_id_p"; field_type = "int"; db_name = "dish_id_p"; }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kursovaya
{
    public class Order_fields
    {
        protected string value;
        protected string field_type;
        protected string name_field;

        virtual public string get_name() { return name_field; }
        virtual public string get_value() { return value; }
        virtual public void set_value(string new_value) { value = new_value; }
        virtual public string get_type() { return field_type; }
    }

    public class RestId_field : Order_fields
    {
        public RestId_field () { name_field = "ID ресторана: "; field_type = "int"; }

    }

    public class OrdName_field : Order_fields
    {
        public OrdName_field() { name_field = "Название заказа: "; field_type = "string"; }
    }

    public class Date_field : Order_fields
    {
        public Date_field() { name_field = "Дата заваза: "; field_type = "date"; }
    }

    public class Status_field : Order_fields
    {
        public Status_field() { name_field = "Статус заказаз: "; field_type = "string"; }
    }

    public class CustName_field : Order_fields
    {
        public CustName_field() { name_field = "Имя заказчика: "; field_type = "string"; }
    }

    public class CustTel_field : Order_fields
    {
        public CustTel_field() { name_field = "Телефон заказчика: "; field_type = "string"; }
    }

    public class FinCost_field : Order_fields
    {
        public FinCost_field() { name_field = "Итоговая стоимость заказа: "; field_type = "int"; }
    }

    public class RestCol_field : Order_fields
    {
        public RestCol_field() { name_field = "Количество ресторанов: "; field_type = "int"; }
    }

    public class DishCol_field : Order_fields
    {
        public DishCol_field() { name_field = "Количество блюд: "; field_type = "int"; }
    }
}

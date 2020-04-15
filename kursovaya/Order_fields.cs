﻿using System;
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

    public class Rest_id_f : Order_fields
    {
        public Rest_id_f () { name_field = "rest_id_f: "; field_type = "int"; }

    }

    public class Cust_id_p: Order_fields
    {
        public Cust_id_p () { name_field = "cust_id_p: "; field_type = "int"; }
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
    
    public class DishCol_field : Order_fields
    {
        public DishCol_field() { name_field = "Количество блюд: "; field_type = "int"; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kursovaya
{
    public class Restaurant
    {
        private string rest_name;
        private string rest_id_p;

        public void set_rest_id(string new_id)
        {
            rest_id_p = new_id;
        }

        public string get_rest_id()
        {
            return rest_id_p;
        }

        public void set_rest_name(string new_name)
        {
            rest_name = new_name;
        }

        public string get_rest_name()
        {
            return rest_name;
        }
    }
}

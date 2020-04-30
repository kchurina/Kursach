using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovaya
{
    class RestInfoContr
    {
        private DBContr db_contr;
        private List<Restaurant> rests;
        private Restaurant rest;

        public RestInfoContr()
        {
            db_contr = new DBContr();
            rests = db_contr.Get_db_rests();
        }

        public RestInfoContr(Restaurant new_rest)
        {
            db_contr = new DBContr();
            rests = db_contr.Get_db_rests();
            rest = new_rest;
        }

        public Restaurant Get_rest()
        {
            return rest;
        }

        public void Add_rest(string rest_name)
        {
            Restaurant new_rest = new Restaurant();

            new_rest.set_rest_name(rest_name);
            db_contr.AddRest(new_rest);
        }

        public bool CheckExistRest(string name)
        {
            foreach (Restaurant rest in rests)
            {

                if (String.Equals(name, rest.get_rest_name()))
                {
                    return true;
                }
            }
            return false;
        }

        public Restaurant FindRest(string name)
        {
            foreach (Restaurant rest in rests)
            {

                if (String.Equals(name, rest.get_rest_name()))
                {
                    return rest;
                }
            }
            return null;
        }

        public List<Restaurant> GetRestsList()
        {
            return db_contr.Get_db_rests();
        }

        public void Delete_rest()
        {
            db_contr.Delete_rest(rest.get_rest_id());
        }

        public void Edit_rest(string new_name)
        {
            db_contr.Edit_rest(new_name, rest.get_rest_id());
        }
    }
}

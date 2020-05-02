using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovaya
{
    class CustInfoContr
    {
        DBContr db_contr;
        List<Customer> cust_list;
        Customer customer;

        public CustInfoContr()
        {
            db_contr = new DBContr();
            cust_list = db_contr.Get_db_custs();
        }

        public CustInfoContr(Customer new_customer)
        {
            db_contr = new DBContr();
            cust_list = db_contr.Get_db_custs();
            customer = new_customer;
        }

        public Customer Get_cust()
        {
            return customer;
        }

        public List<Customer> GetCustsList()
        {
            cust_list = db_contr.Get_db_custs();
            return cust_list;
        }

        public void Add_cust(Customer new_cust)
        {
            db_contr.AddCustomer(new_cust);
        }

        public void Edit_cust(Order_fields field)
        {
            db_contr.Edit_cust_field(field, customer.get_cust_id_p().get_value());
        }

        public void Delete_cust()
        {
            db_contr.Delete_cust(customer.get_cust_id_p().get_value());
        }

        public bool CheckExistCust(string id)
        {
            foreach(Customer c in cust_list)
            {
                if (String.Equals(id, c.get_cust_id_p().get_value()))
                    return true;
            }
            return false;
        }
    }
}

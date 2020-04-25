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

        public CustInfoContr()
        {
            db_contr = new DBContr();
            cust_list = db_contr.Get_db_custs();
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
    }
}

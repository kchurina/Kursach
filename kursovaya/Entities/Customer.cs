using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovaya
{
    public class Customer
    {
        private List<Order_fields> cust_fields;

        public Customer()
        {
            cust_fields = new List<Order_fields>();

            cust_fields.Add(new CustName_field());
            cust_fields.Add(new CustTel_field());
            cust_fields.Add(new Cust_id_f());
        }

        public Order_fields get_cust_name()
        {
            return cust_fields[0];
        }

        public Order_fields get_cust_tel()
        {
            return cust_fields[1];
        }

        public Order_fields get_cust_id_p()
        {
            return cust_fields[2];
        }
    }
}

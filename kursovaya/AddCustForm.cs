using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovaya
{
    public partial class AddCustForm : Form
    {
        private CustInfoContr cust_contr;

        public AddCustForm()
        {
            cust_contr = new CustInfoContr();
            InitializeComponent();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            if(CustTB.Text!=""&&TelTB.Text!="")
            {
                Customer cust = new Customer();
                cust.get_cust_name().set_value(CustTB.Text);
                cust.get_cust_tel().set_value(TelTB.Text);

                cust_contr.Add_cust(cust);
            }
        }
    }
}

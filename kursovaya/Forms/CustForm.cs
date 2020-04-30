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
    public partial class CustForm : Form
    {
        private CustInfoContr cust_contr;
        private CustInfoContr cust_contr2;
        private string mode;

        public CustForm(string new_mode)
        {
            cust_contr = new CustInfoContr();
            mode = new_mode;
            
            InitializeComponent();
            if (String.Equals(mode, "add"))
            {
                IdCB.Enabled = false;
            }
            else
                Display();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            if (CustTB.Text != "" && TelTB.Text != "")
            {
                if (String.Equals(mode, "add"))
                {
                    Customer cust = new Customer();
                    cust.get_cust_name().set_value(CustTB.Text);
                    cust.get_cust_tel().set_value(TelTB.Text);

                    cust_contr.Add_cust(cust);
                }

                if (String.Equals(mode, "edit"))
                {
                    if (!String.Equals(CustTB.Text, cust_contr2.Get_cust().get_cust_name().get_value()))
                    {
                        cust_contr2.Get_cust().get_cust_name().set_value(CustTB.Text);
                        cust_contr2.Edit_cust(cust_contr2.Get_cust().get_cust_name());
                        Console.WriteLine("Edited cust name to " + cust_contr2.Get_cust().get_cust_name().get_value());
                    }
                    if (!String.Equals(TelTB.Text, cust_contr2.Get_cust().get_cust_tel().get_value()))
                    {
                        cust_contr2.Get_cust().get_cust_tel().set_value(TelTB.Text);
                        cust_contr2.Edit_cust(cust_contr2.Get_cust().get_cust_tel());
                        Console.WriteLine("Edited cust tel to " + cust_contr2.Get_cust().get_cust_tel().get_value());
                    }

                }
            }
            if (String.Equals(mode, "delete"))
            {
                cust_contr2.Delete_cust();
            }
        }

        private void Display()
        {
            if(String.Equals(mode, "edit"))
                Add_button.Text = "Сохранить";
            if (String.Equals(mode, "delete"))
                Add_button.Text = "Удалить";

            foreach(Customer cust in cust_contr.GetCustsList())
                IdCB.Items.Add(cust.get_cust_id_p().get_value()+"  "+cust.get_cust_name().get_value());


            if (String.Equals(mode, "delete"))
            {
                CustTB.Enabled = false;
                TelTB.Enabled = false;
            }
        }

        private void IdCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Customer cust in cust_contr.GetCustsList())
            {
                if(String.Equals(IdCB.Text, cust.get_cust_id_p().get_value() + "  " + cust.get_cust_name().get_value()))
                {
                    CustTB.Text = cust.get_cust_name().get_value();
                    TelTB.Text = cust.get_cust_tel().get_value();
                    cust_contr2 = new CustInfoContr(cust);
                }
            }
        }
    }
}

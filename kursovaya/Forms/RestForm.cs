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
    public partial class RestForm : Form
    {
        RestInfoContr rest_contr;
        RestInfoContr rest_contr2;
        string mode;

        public RestForm(string new_mode)
        {
            rest_contr = new RestInfoContr();
            InitializeComponent();
            mode = new_mode;
            if (String.Equals(mode, "add"))
            {
                IdCB.Enabled = false;
            }
            else
                Display();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (String.Equals(mode, "add"))
                {
                    if (!rest_contr.CheckExistRest(textBox1.Text))
                    {
                        rest_contr.Add_rest(textBox1.Text);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Ресторан с таким названием уже существует!");

                    this.Close();
                }

                if (String.Equals(mode, "edit"))
                {
                    try
                    {
                        if (!String.Equals(textBox1.Text, rest_contr2.Get_rest().get_rest_name()))
                        {
                            rest_contr2.Edit_rest(textBox1.Text);
                            this.Close();
                        }
                    }
                    catch(NullReferenceException)
                    {
                        MessageBox.Show("Выберите ресторан!");
                        return;
                    }

                }

                if (String.Equals(mode, "delete"))
                {
                    rest_contr2.Delete_rest();
                    this.Close();
                }

            }
        }

        private void Display()
        {
            if (String.Equals(mode, "edit"))
                button1.Text = "Сохранить";
            if (String.Equals(mode, "delete"))
                button1.Text = "Удалить";

            foreach (Restaurant rest in rest_contr.GetRestsList())
                IdCB.Items.Add(rest.get_rest_id() + "  " + rest.get_rest_name());

            if (String.Equals(mode, "delete"))
            {
                textBox1.Enabled = false;
            }
        }

        private void IdCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Restaurant rest in rest_contr.GetRestsList())
            {
                if (String.Equals(IdCB.Text, rest.get_rest_id() + "  " + rest.get_rest_name()))
                {
                    textBox1.Text = rest.get_rest_name();
                    rest_contr2 = new RestInfoContr(rest);
                }
            }
        }
    }
}

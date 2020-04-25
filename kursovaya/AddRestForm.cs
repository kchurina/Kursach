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
    public partial class AddRestForm : Form
    {
        RestInfoContr rest_cont;

        public AddRestForm()
        {
            rest_cont = new RestInfoContr();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (!rest_cont.CheckExistRest(textBox1.Text))
                {
                    rest_cont.Add_rest(textBox1.Text);
                    this.Close();
                }
                else
                    MessageBox.Show("Ресторан с таким названием уже существует!");
            }
        }
    }
}

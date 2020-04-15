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
    public partial class AddOrderInfoForm : Form
    {
        OrderMngrContr mngr_contr;

        public AddOrderInfoForm(OrderMngrContr new_contr)
        {
            mngr_contr = new_contr;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && listBox1.Text != "")
            {
                if (!mngr_contr.CheckExist(textBox1.Text))
                {
                    //mngr_contr.Add_new_order(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, listBox1.Text);//переделаю форму, ошибка исчезнет магичски
                    MessageBox.Show("После повторной загрузки из базы данных имя заказа может измениться.");
                    this.Close();
                }
                else
                    MessageBox.Show("Заказ с таким названием уже есть в базе данных!\nНазвания заказов долны быть уникальны.\nПосле повторной загрузки из базы данных имя заказа может измениться.");
            }
            else
                MessageBox.Show("Заполните форму.");
        }
    }
}

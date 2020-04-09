using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data.Common;
using System.Windows.Forms;

namespace kursovaya
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            OrdersManager ord_mngr = new OrdersManager();
            SaverLoaderContr sl_cntr = new SaverLoaderContr();
            ord_mngr.set_orders_list(sl_cntr.Load_orders_from_file());

            foreach (Order_data ord in ord_mngr.get_orders_list())
            {
                Console.WriteLine("@");
                Console.WriteLine(ord.get_cust_name().get_value());
                foreach (Restaurant rest in ord.get_rests_list())
                {
                    Console.WriteLine("     " + rest.get_rest_name());
                    foreach (Dish dish in rest.get_dishes_list())
                    {
                        Console.WriteLine("         " + dish.get_name_field().get_value());
                    }
                }
            }
        }
    }
}


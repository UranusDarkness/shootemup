using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Threading.Tasks;

namespace ShootEmUp
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            App.connection.Open();
            Application newapp = new Application();
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);
            newapp.Run(new MenuWindow());
        }
        static void OnProcessExit(object sender, EventArgs e)
        {
            App.connection.Close();
        }
    }
}

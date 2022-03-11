using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ShootEmUp
{
    /// <summary>
    /// Logica di interazione per App.xaml
    /// </summary>
    public partial class App : Application
    {
        static string connectionString = "Server=discontinued; Database=spaceshoot_leaderboard; Uid=spaceshootuser; Pwd=discontinued;";
        public static MySqlConnection connection = new MySqlConnection(connectionString);
    }
}

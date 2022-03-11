using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using WindowsInput;
using WindowsInput.Native;

namespace ShootEmUp
{
    /// <summary>
    /// Logica di interazione per Leaderboard.xaml
    /// </summary>
    public partial class Leaderboard : UserControl
    {
        public Leaderboard()
        {
            InitializeComponent();
        }

        private void leaderboardWindow_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter && menuLabel.IsSelected)
            {
                this.Visibility = Visibility.Collapsed;
                MenuWindow session = (MenuWindow)App.Current.MainWindow;
                session.menuControl.Visibility = Visibility.Visible;
                TabSimulator();
            }
        }

        private void leaderboardControls_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            List<Player> playerList = new List<Player>();
            string sqlquery = "SELECT * FROM top_player";
            MySqlCommand command = new MySqlCommand(sqlquery, App.connection);
            MySqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Player tempPlayer = new Player(dataReader.GetString(1), dataReader.GetInt32(2));
                playerList.Add(tempPlayer);
            }

            List<Player> topTenPlayers = playerList.OrderByDescending(x => x.score).ToList();
            if (topTenPlayers.Count > 10)
                topTenPlayers.RemoveRange(10, topTenPlayers.Count - 10);

            dataGridLeaderboard.ItemsSource = topTenPlayers;
            dataReader.Close();

            if (this.Visibility == Visibility.Visible)
            {
                for (int i = 0; i < dataGridLeaderboard.Items.Count*2; i++)
                {
                    TabSimulator();
                }
            }
            
        }
        public void TabSimulator()
        {
            InputSimulator simu = new InputSimulator();
            simu.Keyboard.KeyPress(VirtualKeyCode.TAB);
        }
    }
}

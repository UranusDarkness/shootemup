using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WindowsInput;
using WindowsInput.Native;

namespace ShootEmUp
{
    /// <summary>
    /// Logica di interazione per GameOverWindow.xaml
    /// </summary>
    public partial class GameOverWindow : Window
    {
        MenuWindow session;
        int savedscore;
        public GameOverWindow(int score, MenuWindow old)
        {
            savedscore = score;
            session = old;
            InitializeComponent();
        }

        private void nicknameTextbox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9A-Za-z]+").IsMatch(e.Text);
        }

        private void gameOver_Loaded(object sender, RoutedEventArgs e)
        {
            scoreTextblock.Text = "Score: " + savedscore.ToString() + Environment.NewLine + "Game Over!"+Environment.NewLine+ "Inserisci il tuo nickname"+Environment.NewLine +"per salvare il tuo record";
            gameoverbgmPlayer.Source = new Uri(Environment.CurrentDirectory + "/Resources/BGM/gameover_bgm.mp3");
            gameoverbgmPlayer.Play();
            TabSimulator();
        }

        public void TabSimulator()
        {
            InputSimulator simu = new InputSimulator();
            simu.Keyboard.KeyPress(VirtualKeyCode.TAB);
        }

        private void nicknameTextbox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down)
            {
                Keyboard.Focus(saveLabel);
                saveLabel.IsSelected = true;
            }
        }

        private void saveLabel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Up)
            {
                saveLabel.IsSelected = false;
                this.nicknameTextbox.Focus();
            }
        }


        private void saveLabel_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter && saveLabel.IsSelected)
            {
                string registerQuery = "INSERT INTO top_player(nickname, score) VALUES (@nickname, @score)";
                MySqlCommand command = new MySqlCommand(registerQuery, App.connection);
                command.Parameters.AddWithValue("@nickname", nicknameTextbox.Text);
                command.Parameters.AddWithValue("@score", savedscore);
                command.Prepare();
                command.ExecuteNonQuery();

                session.Show();
                session.bgmPlayer.Play();
                session.menuControl.Visibility = Visibility.Visible;
                TabSimulator();
                this.Hide();
                gameoverbgmPlayer.Stop();
            }
        }

        private void mainMenuLabel_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                session.Show();
                session.bgmPlayer.Play();
                session.menuControl.Visibility = Visibility.Visible;
                TabSimulator();
                this.Hide();
                gameoverbgmPlayer.Stop();
            }
        }

        private void gameOverWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.Escape))
                App.Current.Shutdown();
        }

        private void bgmPlayer_MediaFailed(object sender, ExceptionRoutedEventArgs e)
        {
            MessageBox.Show(e.ErrorException.ToString());
        }

        private void bgmPlayer_MediaEnded(object sender, RoutedEventArgs e)
        {
            gameoverbgmPlayer.Stop();
            gameoverbgmPlayer.Play();
        }

        private void gameOverWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            App.connection.Close();
            App.Current.Shutdown();
        }
    }
}

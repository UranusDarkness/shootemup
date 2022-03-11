using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WindowsInput;
using WindowsInput.Native;

namespace ShootEmUp
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {

        public int tokens;
        //DoubleAnimation da = new DoubleAnimation();
        public MenuWindow()
        {
            InitializeComponent();
        }

        private void menuWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.MinHeight = this.Height;
            this.MinWidth = this.Width;

            bgmPlayer.Source = new Uri(Environment.CurrentDirectory + "/Resources/BGM/bgm_music.mp3");
            bgmPlayer.Play();
            tokensLabel.Content = "TOKENS: "+tokens.ToString();
            InputSimulator simu = new InputSimulator();
            simu.Keyboard.KeyPress(VirtualKeyCode.TAB);
        }

        private void menuWindow_KeyDown(object sender, KeyEventArgs e)
        {
                if (Keyboard.IsKeyDown(Key.Escape))
                    App.Current.Shutdown();
                if (e.Key == Key.OemPlus||e.Key == Key.Add)
                {
                    this.tokens++;
                    tokensLabel.Content = "TOKENS: " + tokens.ToString();
                }
                else if(e.Key == Key.OemMinus||e.Key == Key.Subtract)
                {
                    if (tokens > 0)
                        {
                            this.tokens--;
                            tokensLabel.Content = "TOKENS: " + tokens.ToString();
                        } 
                }
        }

        private void bgmPlayer_MediaFailed(object sender, ExceptionRoutedEventArgs e)
        {
            MessageBox.Show(e.ErrorException.ToString());
        }

        private void bgmPlayer_MediaEnded(object sender, RoutedEventArgs e)
        {
            bgmPlayer.Stop();
            bgmPlayer.Play();
        }

        private void mainMenuWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            App.connection.Close();
            App.Current.Shutdown();
        }
    }
}

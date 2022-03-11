using ShootEmUp.Properties;
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
using WindowsInput;
using WindowsInput.Native;

namespace ShootEmUp
{
    /// <summary>
    /// Logica di interazione per MainMenu.xaml
    /// </summary>
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Entry_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if(playEntry.IsSelected)
                {
                    menuControls.Visibility = Visibility.Collapsed;
                    MenuWindow session = (MenuWindow)App.Current.MainWindow;
                    string tokenscheck = session.tokensLabel.Content.ToString();
                    string b = string.Empty;
                    int val = 0;

                    for (int i = 0; i < tokenscheck.Length; i++)
                    {
                        if (Char.IsDigit(tokenscheck[i]))
                            b += tokenscheck[i];
                    }
                    if (b.Length > 0)
                        val = int.Parse(b);

                    if (val > 0)
                    {
                        session.bgmPlayer.Stop();
                        session.tokens --;
                        session.tokensLabel.Content = "TOKENS: " + session.tokens.ToString();
                        Game gm = new Game(session);
                        session.Hide();
                        gm.Show();
                    }
                    else
                    {
                        menuControls.Visibility = Visibility.Collapsed;
                        session.notEnoughTokens.Visibility = Visibility.Visible;
                    }
                    
                }
                else if(leaderboardEntry.IsSelected)
                {
                    MenuWindow session = (MenuWindow)App.Current.MainWindow;
                    menuControls.Visibility = Visibility.Collapsed;
                    session.leaderboardControl.Visibility = Visibility.Visible;              
                }
                else if(rulesEntry.IsSelected)
                {
                    menuControls.Visibility = Visibility.Collapsed;
                    MenuWindow session = (MenuWindow)App.Current.MainWindow;
                    session.rulesControl.Visibility = Visibility.Visible;
                }
                else if(creditsEntry.IsSelected)
                {
                    menuControls.Visibility = Visibility.Collapsed;
                    MenuWindow session = (MenuWindow)App.Current.MainWindow;
                    session.creditsControl.Visibility = Visibility.Visible;
                }
                else if(exitEntry.IsSelected)
                    App.Current.Shutdown();
            }
                
        }

        private void menuControls_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if(this.Visibility == Visibility.Collapsed)
            {
                InputSimulator simu = new InputSimulator();
                simu.Keyboard.KeyPress(VirtualKeyCode.TAB);
            }
            
        }
    }
}

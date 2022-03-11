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
    /// Logica di interazione per Rules.xaml
    /// </summary>
    public partial class Rules : UserControl
    {
        public Rules()
        {
            InitializeComponent();
        }

        private void backEntry_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                this.Visibility = Visibility.Collapsed;
                MenuWindow session = (MenuWindow)App.Current.MainWindow;
                session.menuControl.Visibility = Visibility.Visible;
            }
        }

        private void rulesControls_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            InputSimulator simu = new InputSimulator();
            simu.Keyboard.KeyPress(VirtualKeyCode.TAB);
        }
    }
}

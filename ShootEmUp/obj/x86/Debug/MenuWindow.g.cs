#pragma checksum "..\..\..\MenuWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BF726F1EBBF630473CF433ED157A499D9A5D8424EE1E774DA4406E7AC8C4CB71"
//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

using ShootEmUp;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using XamlAnimatedGif;


namespace ShootEmUp {
    
    
    /// <summary>
    /// MenuWindow
    /// </summary>
    public partial class MenuWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ShootEmUp.MenuWindow mainMenuWindow;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid totalWindow;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ShootEmUp.MainMenu menuControl;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ShootEmUp.Rules rulesControl;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ShootEmUp.Credits creditsControl;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ShootEmUp.NotEnoughTokens notEnoughTokens;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement bgmPlayer;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label tokensLabel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ShootEmUp;component/menuwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MenuWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.mainMenuWindow = ((ShootEmUp.MenuWindow)(target));
            
            #line 9 "..\..\..\MenuWindow.xaml"
            this.mainMenuWindow.Loaded += new System.Windows.RoutedEventHandler(this.menuWindow_Loaded);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\MenuWindow.xaml"
            this.mainMenuWindow.KeyDown += new System.Windows.Input.KeyEventHandler(this.menuWindow_KeyDown);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\MenuWindow.xaml"
            this.mainMenuWindow.Closing += new System.ComponentModel.CancelEventHandler(this.mainMenuWindow_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.totalWindow = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.menuControl = ((ShootEmUp.MainMenu)(target));
            return;
            case 4:
            this.rulesControl = ((ShootEmUp.Rules)(target));
            return;
            case 5:
            this.creditsControl = ((ShootEmUp.Credits)(target));
            return;
            case 6:
            this.notEnoughTokens = ((ShootEmUp.NotEnoughTokens)(target));
            return;
            case 7:
            this.bgmPlayer = ((System.Windows.Controls.MediaElement)(target));
            
            #line 25 "..\..\..\MenuWindow.xaml"
            this.bgmPlayer.MediaFailed += new System.EventHandler<System.Windows.ExceptionRoutedEventArgs>(this.bgmPlayer_MediaFailed);
            
            #line default
            #line hidden
            
            #line 25 "..\..\..\MenuWindow.xaml"
            this.bgmPlayer.MediaEnded += new System.Windows.RoutedEventHandler(this.bgmPlayer_MediaEnded);
            
            #line default
            #line hidden
            return;
            case 8:
            this.tokensLabel = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


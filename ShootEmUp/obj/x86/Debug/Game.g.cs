﻿#pragma checksum "..\..\..\Game.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "57D3FEBD725912ACAD8A07DA79D46F8C720E53ADB6555921E1C2B234C1948AA1"
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
    /// Game
    /// </summary>
    public partial class Game : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\Game.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ShootEmUp.Game gameWindow;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Game.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridWindow;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Game.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement gamebgmPlayer;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Game.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border superBorder;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Game.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas gameArea;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Game.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle bg1;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Game.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle bg2;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Game.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle playerShipRect;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Game.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse explosionAni;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Game.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock @void;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Game.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel panelControls;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Game.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock scoreTextblock;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Game.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid stackpanelGrid;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Game.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock damageTextblock;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Game.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image shipIndicator1;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Game.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image shipIndicator2;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Game.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image shipIndicator3;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Game.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock startingLabel;
        
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
            System.Uri resourceLocater = new System.Uri("/ShootEmUp;component/game.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Game.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
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
            this.gameWindow = ((ShootEmUp.Game)(target));
            
            #line 9 "..\..\..\Game.xaml"
            this.gameWindow.KeyDown += new System.Windows.Input.KeyEventHandler(this.gameWindow_KeyDown);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\Game.xaml"
            this.gameWindow.Loaded += new System.Windows.RoutedEventHandler(this.gameWindow_Loaded);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\Game.xaml"
            this.gameWindow.Closing += new System.ComponentModel.CancelEventHandler(this.gameWindow_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.gridWindow = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.gamebgmPlayer = ((System.Windows.Controls.MediaElement)(target));
            
            #line 22 "..\..\..\Game.xaml"
            this.gamebgmPlayer.MediaFailed += new System.EventHandler<System.Windows.ExceptionRoutedEventArgs>(this.bgmPlayer_MediaFailed);
            
            #line default
            #line hidden
            
            #line 22 "..\..\..\Game.xaml"
            this.gamebgmPlayer.MediaEnded += new System.Windows.RoutedEventHandler(this.bgmPlayer_MediaEnded);
            
            #line default
            #line hidden
            return;
            case 4:
            this.superBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 5:
            this.gameArea = ((System.Windows.Controls.Canvas)(target));
            
            #line 24 "..\..\..\Game.xaml"
            this.gameArea.KeyDown += new System.Windows.Input.KeyEventHandler(this.playerKeyDown);
            
            #line default
            #line hidden
            
            #line 24 "..\..\..\Game.xaml"
            this.gameArea.KeyUp += new System.Windows.Input.KeyEventHandler(this.releasePlayerKeyUp);
            
            #line default
            #line hidden
            return;
            case 6:
            this.bg1 = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 7:
            this.bg2 = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 8:
            this.playerShipRect = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 9:
            this.explosionAni = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 10:
            this.@void = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.panelControls = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 12:
            this.scoreTextblock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 13:
            this.stackpanelGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 14:
            this.damageTextblock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 15:
            this.shipIndicator1 = ((System.Windows.Controls.Image)(target));
            return;
            case 16:
            this.shipIndicator2 = ((System.Windows.Controls.Image)(target));
            return;
            case 17:
            this.shipIndicator3 = ((System.Windows.Controls.Image)(target));
            return;
            case 18:
            this.startingLabel = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


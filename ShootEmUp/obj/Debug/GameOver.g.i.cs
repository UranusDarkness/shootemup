﻿#pragma checksum "..\..\GameOver.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A9AF2D370ACA8735D900011DE113467292765D29F29CA26838745897B59A3DB6"
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


namespace ShootEmUp {
    
    
    /// <summary>
    /// GameOver
    /// </summary>
    public partial class GameOver : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\GameOver.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ShootEmUp.GameOver gameOver;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\GameOver.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock scoreTextblock;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\GameOver.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nicknameTextbox;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\GameOver.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBoxItem saveLabel;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\GameOver.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBoxItem mainMenuLabel;
        
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
            System.Uri resourceLocater = new System.Uri("/ShootEmUp;component/gameover.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\GameOver.xaml"
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
            this.gameOver = ((ShootEmUp.GameOver)(target));
            
            #line 8 "..\..\GameOver.xaml"
            this.gameOver.Loaded += new System.Windows.RoutedEventHandler(this.gameOver_Loaded);
            
            #line default
            #line hidden
            
            #line 8 "..\..\GameOver.xaml"
            this.gameOver.IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.gameOver_IsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.scoreTextblock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.nicknameTextbox = ((System.Windows.Controls.TextBox)(target));
            
            #line 60 "..\..\GameOver.xaml"
            this.nicknameTextbox.KeyDown += new System.Windows.Input.KeyEventHandler(this.nicknameTextbox_KeyDown);
            
            #line default
            #line hidden
            
            #line 60 "..\..\GameOver.xaml"
            this.nicknameTextbox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.nicknameTextbox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 4:
            this.saveLabel = ((System.Windows.Controls.ListBoxItem)(target));
            
            #line 65 "..\..\GameOver.xaml"
            this.saveLabel.KeyDown += new System.Windows.Input.KeyEventHandler(this.saveLabel_KeyDown);
            
            #line default
            #line hidden
            
            #line 65 "..\..\GameOver.xaml"
            this.saveLabel.KeyUp += new System.Windows.Input.KeyEventHandler(this.saveLabel_KeyUp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.mainMenuLabel = ((System.Windows.Controls.ListBoxItem)(target));
            
            #line 66 "..\..\GameOver.xaml"
            this.mainMenuLabel.KeyUp += new System.Windows.Input.KeyEventHandler(this.mainMenuLabel_KeyUp);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

﻿#pragma checksum "..\..\..\MainMenu.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C8CC48B0007620CD21BED4682FE97905074AE33DCF723DD7DD17B6E90A5F181A"
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
    /// MainMenu
    /// </summary>
    public partial class MainMenu : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ShootEmUp.MainMenu menuControls;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBoxItem playEntry;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBoxItem leaderboardEntry;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBoxItem rulesEntry;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBoxItem creditsEntry;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBoxItem exitEntry;
        
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
            System.Uri resourceLocater = new System.Uri("/ShootEmUp;component/mainmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainMenu.xaml"
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
            this.menuControls = ((ShootEmUp.MainMenu)(target));
            
            #line 8 "..\..\..\MainMenu.xaml"
            this.menuControls.IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.menuControls_IsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.playEntry = ((System.Windows.Controls.ListBoxItem)(target));
            
            #line 34 "..\..\..\MainMenu.xaml"
            this.playEntry.KeyUp += new System.Windows.Input.KeyEventHandler(this.Entry_KeyUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.leaderboardEntry = ((System.Windows.Controls.ListBoxItem)(target));
            
            #line 35 "..\..\..\MainMenu.xaml"
            this.leaderboardEntry.KeyUp += new System.Windows.Input.KeyEventHandler(this.Entry_KeyUp);
            
            #line default
            #line hidden
            return;
            case 4:
            this.rulesEntry = ((System.Windows.Controls.ListBoxItem)(target));
            
            #line 36 "..\..\..\MainMenu.xaml"
            this.rulesEntry.KeyUp += new System.Windows.Input.KeyEventHandler(this.Entry_KeyUp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.creditsEntry = ((System.Windows.Controls.ListBoxItem)(target));
            
            #line 37 "..\..\..\MainMenu.xaml"
            this.creditsEntry.KeyUp += new System.Windows.Input.KeyEventHandler(this.Entry_KeyUp);
            
            #line default
            #line hidden
            return;
            case 6:
            this.exitEntry = ((System.Windows.Controls.ListBoxItem)(target));
            
            #line 38 "..\..\..\MainMenu.xaml"
            this.exitEntry.KeyUp += new System.Windows.Input.KeyEventHandler(this.Entry_KeyUp);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\menu.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8C2AA8AC03E5B616EEAC21A2D6A0182ACF4C068E"
//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

using GranteGen;
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


namespace GranteGen {
    
    
    /// <summary>
    /// menu
    /// </summary>
    public partial class menu : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button refb;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button createWizardb;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock refl;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button refokb;
        
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
            System.Uri resourceLocater = new System.Uri("/GranteGen;component/menu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\menu.xaml"
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
            this.refb = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\menu.xaml"
            this.refb.Click += new System.Windows.RoutedEventHandler(this.refb_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.createWizardb = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\menu.xaml"
            this.createWizardb.Click += new System.Windows.RoutedEventHandler(this.createWizardb_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.refl = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.refokb = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\menu.xaml"
            this.refokb.Click += new System.Windows.RoutedEventHandler(this.refokb_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


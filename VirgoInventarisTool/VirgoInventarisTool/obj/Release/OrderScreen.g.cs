﻿#pragma checksum "..\..\OrderScreen.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C6D1B8CB3F9B66408C4D799EADBA1703BB0B8DD9870EA2A0D3D8BC474AE7D8B4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using VirgoInventarisTool;


namespace VirgoInventarisTool {
    
    
    /// <summary>
    /// orderScreen
    /// </summary>
    public partial class orderScreen : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\OrderScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button orderScreen_Home;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\OrderScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OrderScreen_Quotems;
        
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
            System.Uri resourceLocater = new System.Uri("/VirgoInventarisTool;component/orderscreen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\OrderScreen.xaml"
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
            this.orderScreen_Home = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\OrderScreen.xaml"
            this.orderScreen_Home.Click += new System.Windows.RoutedEventHandler(this.OrderScreen_Home_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.OrderScreen_Quotems = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\OrderScreen.xaml"
            this.OrderScreen_Quotems.Click += new System.Windows.RoutedEventHandler(this.OrderScreen_Quotems_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

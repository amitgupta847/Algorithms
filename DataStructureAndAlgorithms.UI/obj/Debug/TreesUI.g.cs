﻿#pragma checksum "..\..\TreesUI.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D077AFD1B3873A500660206A88D116B5"
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


namespace DataStructureAndAlgorithms.UI {
    
    
    /// <summary>
    /// TreesUI
    /// </summary>
    public partial class TreesUI : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\TreesUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstInput;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\TreesUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstOutput;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\TreesUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNumberOfElements;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\TreesUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnQuickFind;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\TreesUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnQuickUnion;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\TreesUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtGCDNumberA;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\TreesUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtGCDNumberB;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\TreesUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtAnalysisGCD;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\TreesUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtTotalTimeGCD;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\TreesUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtResultGCD;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\TreesUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGCD;
        
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
            System.Uri resourceLocater = new System.Uri("/DataStructureAndAlgorithms.UI;component/treesui.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TreesUI.xaml"
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
            this.lstInput = ((System.Windows.Controls.ListBox)(target));
            return;
            case 2:
            this.lstOutput = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            this.txtNumberOfElements = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.btnQuickFind = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\TreesUI.xaml"
            this.btnQuickFind.Click += new System.Windows.RoutedEventHandler(this.SortClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnQuickUnion = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\TreesUI.xaml"
            this.btnQuickUnion.Click += new System.Windows.RoutedEventHandler(this.SortClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtGCDNumberA = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtGCDNumberB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txtAnalysisGCD = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.txtTotalTimeGCD = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.txtResultGCD = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.btnGCD = ((System.Windows.Controls.Button)(target));
            
            #line 97 "..\..\TreesUI.xaml"
            this.btnGCD.Click += new System.Windows.RoutedEventHandler(this.SortClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

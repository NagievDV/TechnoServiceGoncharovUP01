﻿#pragma checksum "..\..\..\Pages\Requests.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BDE204F3C5E65D8E2748C83DAF60C9BE4291C1DD6D9E95A83C7F33E8BCE9A4BD"
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
using TechnoServiceGoncharovUP01.Pages;


namespace TechnoServiceGoncharovUP01.Pages {
    
    
    /// <summary>
    /// Requests
    /// </summary>
    public partial class Requests : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 17 "..\..\..\Pages\Requests.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Add;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Pages\Requests.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FindForNumber;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Pages\Requests.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FindForStatus;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Pages\Requests.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FindForPriority;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Pages\Requests.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ClearFilters;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Pages\Requests.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridRequests;
        
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
            System.Uri resourceLocater = new System.Uri("/TechnoServiceGoncharovUP01;component/pages/requests.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Requests.xaml"
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
            this.Add = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\Pages\Requests.xaml"
            this.Add.Click += new System.Windows.RoutedEventHandler(this.Add_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.FindForNumber = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\..\Pages\Requests.xaml"
            this.FindForNumber.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.FindForNumber_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.FindForStatus = ((System.Windows.Controls.ComboBox)(target));
            
            #line 21 "..\..\..\Pages\Requests.xaml"
            this.FindForStatus.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FindForStatus_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.FindForPriority = ((System.Windows.Controls.ComboBox)(target));
            
            #line 23 "..\..\..\Pages\Requests.xaml"
            this.FindForPriority.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FindForPriority_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ClearFilters = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\Pages\Requests.xaml"
            this.ClearFilters.Click += new System.Windows.RoutedEventHandler(this.ClearFilters_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.DataGridRequests = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 7:
            
            #line 41 "..\..\..\Pages\Requests.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Edit_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}


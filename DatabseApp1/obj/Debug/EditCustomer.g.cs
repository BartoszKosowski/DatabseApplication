﻿#pragma checksum "..\..\EditCustomer.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A3937D3B9D59D56CC19D7029DB10C1140102BE5C7AB72A15CD15DF766AB01BE7"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using DatabaseApplication;
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


namespace DatabaseApplication {
    
    
    /// <summary>
    /// EditCustomer
    /// </summary>
    public partial class EditCustomer : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 103 "..\..\EditCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox firstNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\EditCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox lastNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\EditCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox phoneNumberTextBox;
        
        #line default
        #line hidden
        
        
        #line 133 "..\..\EditCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox streetTextBox;
        
        #line default
        #line hidden
        
        
        #line 143 "..\..\EditCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox houseNumberTextBox;
        
        #line default
        #line hidden
        
        
        #line 153 "..\..\EditCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox zipCodeTextBox;
        
        #line default
        #line hidden
        
        
        #line 163 "..\..\EditCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox cityTextBox;
        
        #line default
        #line hidden
        
        
        #line 172 "..\..\EditCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock updateInfo;
        
        #line default
        #line hidden
        
        
        #line 173 "..\..\EditCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border updateButton;
        
        #line default
        #line hidden
        
        
        #line 176 "..\..\EditCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border closeButton;
        
        #line default
        #line hidden
        
        
        #line 179 "..\..\EditCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border deleteButton;
        
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
            System.Uri resourceLocater = new System.Uri("/DatabseApp1;component/editcustomer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\EditCustomer.xaml"
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
            
            #line 10 "..\..\EditCustomer.xaml"
            ((DatabaseApplication.EditCustomer)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.firstNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.lastNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.phoneNumberTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.streetTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.houseNumberTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.zipCodeTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.cityTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.updateInfo = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.updateButton = ((System.Windows.Controls.Border)(target));
            
            #line 173 "..\..\EditCustomer.xaml"
            this.updateButton.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.updateButton_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 11:
            this.closeButton = ((System.Windows.Controls.Border)(target));
            
            #line 176 "..\..\EditCustomer.xaml"
            this.closeButton.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.closeButton_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 12:
            this.deleteButton = ((System.Windows.Controls.Border)(target));
            
            #line 179 "..\..\EditCustomer.xaml"
            this.deleteButton.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.deleteButton_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


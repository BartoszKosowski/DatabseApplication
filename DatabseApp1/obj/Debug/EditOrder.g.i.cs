﻿#pragma checksum "..\..\EditOrder.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "808A0CDFE165A85EDD2F7F94E8F1A01205E6AA30522C90448C3B9B9405000B67"
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
using DatabaseApplication.Database;
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
    /// EditOrder
    /// </summary>
    public partial class EditOrder : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 85 "..\..\EditOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nameTextBox;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\EditOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox serviceComboBox;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\EditOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker orderDate;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\EditOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker expireDate;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\EditOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox statusComboBox;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\EditOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox descRichBox;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\EditOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock updateInfo;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\EditOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border updateButton;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\EditOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border closeButton;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\EditOrder.xaml"
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
            System.Uri resourceLocater = new System.Uri("/DatabseApp1;component/editorder.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\EditOrder.xaml"
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
            this.nameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.serviceComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.orderDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.expireDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.statusComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.descRichBox = ((System.Windows.Controls.RichTextBox)(target));
            return;
            case 7:
            this.updateInfo = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.updateButton = ((System.Windows.Controls.Border)(target));
            
            #line 113 "..\..\EditOrder.xaml"
            this.updateButton.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.updateButton_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 9:
            this.closeButton = ((System.Windows.Controls.Border)(target));
            
            #line 116 "..\..\EditOrder.xaml"
            this.closeButton.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.closeButton_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 10:
            this.deleteButton = ((System.Windows.Controls.Border)(target));
            
            #line 119 "..\..\EditOrder.xaml"
            this.deleteButton.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.deleteButton_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\..\Windows\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1F189207A7CDC26732CF82EA5EA3DD7B653CFB71"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FridgeWPF;
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


namespace FridgeWPF {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblFridgeName;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRefreshFridgeContent;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lstFridgeContent;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtInputAmount;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbIngredientList;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker cldExpiryDate;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddNewIngredient;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDeleteIngredient;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOpenRecipeBook;
        
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
            System.Uri resourceLocater = new System.Uri("/FridgeWPF;component/windows/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\MainWindow.xaml"
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
            this.lblFridgeName = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.btnRefreshFridgeContent = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\Windows\MainWindow.xaml"
            this.btnRefreshFridgeContent.Click += new System.Windows.RoutedEventHandler(this.BtnRefreshFridgeContent_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lstFridgeContent = ((System.Windows.Controls.ListView)(target));
            return;
            case 4:
            this.txtInputAmount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.cmbIngredientList = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.cldExpiryDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.btnAddNewIngredient = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\Windows\MainWindow.xaml"
            this.btnAddNewIngredient.Click += new System.Windows.RoutedEventHandler(this.BtnAddNewIngredient_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnDeleteIngredient = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\Windows\MainWindow.xaml"
            this.btnDeleteIngredient.Click += new System.Windows.RoutedEventHandler(this.BtnDeleteIngredient_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnOpenRecipeBook = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\Windows\MainWindow.xaml"
            this.btnOpenRecipeBook.Click += new System.Windows.RoutedEventHandler(this.BtnOpenRecipeBook_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


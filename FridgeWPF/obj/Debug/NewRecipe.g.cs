﻿#pragma checksum "..\..\NewRecipe.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "AA2FB19974B642E0F87B999700729C910ECDCCAD"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
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
    /// NewRecipe
    /// </summary>
    public partial class NewRecipe : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\NewRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtName;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\NewRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbIngredientList;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\NewRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAmount;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\NewRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lstIngredients;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\NewRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDescription;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\NewRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblUnit;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\NewRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddIngredientToRecipe;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\NewRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSave;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\NewRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRemove;
        
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
            System.Uri resourceLocater = new System.Uri("/FridgeWPF;component/newrecipe.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\NewRecipe.xaml"
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
            this.txtName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.cmbIngredientList = ((System.Windows.Controls.ComboBox)(target));
            
            #line 11 "..\..\NewRecipe.xaml"
            this.cmbIngredientList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbIngredientList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtAmount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.lstIngredients = ((System.Windows.Controls.ListView)(target));
            return;
            case 5:
            this.txtDescription = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.lblUnit = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.btnAddIngredientToRecipe = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\NewRecipe.xaml"
            this.btnAddIngredientToRecipe.Click += new System.Windows.RoutedEventHandler(this.btnAddIngredientToRecipe_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\NewRecipe.xaml"
            this.btnSave.Click += new System.Windows.RoutedEventHandler(this.btnSave_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnRemove = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\NewRecipe.xaml"
            this.btnRemove.Click += new System.Windows.RoutedEventHandler(this.btnRemove_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


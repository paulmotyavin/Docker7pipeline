﻿#pragma checksum "..\..\SeatClassPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7EED8BF0BE17C95B07D45610F317C5ACC7630B2D1D110F7006C73BCBC2596C17"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace AviaPlace {
    
    
    /// <summary>
    /// SeatClassPage
    /// </summary>
    public partial class SeatClassPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 49 "..\..\SeatClassPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddBtn;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\SeatClassPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditBtn;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\SeatClassPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteBtn;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\SeatClassPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ItemsList;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\SeatClassPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RowsTbx;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\SeatClassPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PlacesTbx;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\SeatClassPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PriceTbx;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\SeatClassPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ClassCbx;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\SeatClassPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FlightCbx;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\SeatClassPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock RowsLeftTbk;
        
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
            System.Uri resourceLocater = new System.Uri("/AviaPlace;component/seatclasspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SeatClassPage.xaml"
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
            this.AddBtn = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\SeatClassPage.xaml"
            this.AddBtn.Click += new System.Windows.RoutedEventHandler(this.AddBtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.EditBtn = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\SeatClassPage.xaml"
            this.EditBtn.Click += new System.Windows.RoutedEventHandler(this.EditBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DeleteBtn = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\SeatClassPage.xaml"
            this.DeleteBtn.Click += new System.Windows.RoutedEventHandler(this.DeleteBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ItemsList = ((System.Windows.Controls.ListBox)(target));
            
            #line 53 "..\..\SeatClassPage.xaml"
            this.ItemsList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ItemsList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.RowsTbx = ((System.Windows.Controls.TextBox)(target));
            
            #line 55 "..\..\SeatClassPage.xaml"
            this.RowsTbx.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.RowsPlacesTbx_TextChanged);
            
            #line default
            #line hidden
            
            #line 55 "..\..\SeatClassPage.xaml"
            this.RowsTbx.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.RowsTbx_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 6:
            this.PlacesTbx = ((System.Windows.Controls.TextBox)(target));
            
            #line 56 "..\..\SeatClassPage.xaml"
            this.PlacesTbx.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.RowsPlacesTbx_TextChanged);
            
            #line default
            #line hidden
            
            #line 56 "..\..\SeatClassPage.xaml"
            this.PlacesTbx.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.RowsTbx_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 7:
            this.PriceTbx = ((System.Windows.Controls.TextBox)(target));
            
            #line 57 "..\..\SeatClassPage.xaml"
            this.PriceTbx.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.RowsTbx_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ClassCbx = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.FlightCbx = ((System.Windows.Controls.ComboBox)(target));
            
            #line 59 "..\..\SeatClassPage.xaml"
            this.FlightCbx.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FlightCbx_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.RowsLeftTbk = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


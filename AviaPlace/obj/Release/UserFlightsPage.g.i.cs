﻿#pragma checksum "..\..\UserFlightsPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E9AE0D84259D5CA6A3A9E394FCBF2C3517AE2C78581C28AF1BE2C3DCCFD5F921"
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
    /// UserFlightsPage
    /// </summary>
    public partial class UserFlightsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 53 "..\..\UserFlightsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FindFlight;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\UserFlightsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FindDeparture;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\UserFlightsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FindArrival;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\UserFlightsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PriceAfter;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\UserFlightsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PriceBefore;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\UserFlightsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DepartureDatePicker;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\UserFlightsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SortComboBox;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\UserFlightsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox FlightsList;
        
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
            System.Uri resourceLocater = new System.Uri("/AviaPlace;component/userflightspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UserFlightsPage.xaml"
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
            this.FindFlight = ((System.Windows.Controls.TextBox)(target));
            
            #line 53 "..\..\UserFlightsPage.xaml"
            this.FindFlight.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.FindFlight_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.FindDeparture = ((System.Windows.Controls.ComboBox)(target));
            
            #line 54 "..\..\UserFlightsPage.xaml"
            this.FindDeparture.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FindDeparture_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.FindArrival = ((System.Windows.Controls.ComboBox)(target));
            
            #line 55 "..\..\UserFlightsPage.xaml"
            this.FindArrival.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FindArrival_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.PriceAfter = ((System.Windows.Controls.TextBox)(target));
            
            #line 56 "..\..\UserFlightsPage.xaml"
            this.PriceAfter.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.PriceAfter_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.PriceBefore = ((System.Windows.Controls.TextBox)(target));
            
            #line 57 "..\..\UserFlightsPage.xaml"
            this.PriceBefore.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.PriceBefore_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.DepartureDatePicker = ((System.Windows.Controls.DatePicker)(target));
            
            #line 59 "..\..\UserFlightsPage.xaml"
            this.DepartureDatePicker.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.DepartureDatePicker_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.SortComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 61 "..\..\UserFlightsPage.xaml"
            this.SortComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SortComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.FlightsList = ((System.Windows.Controls.ListBox)(target));
            
            #line 70 "..\..\UserFlightsPage.xaml"
            this.FlightsList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FlightsList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

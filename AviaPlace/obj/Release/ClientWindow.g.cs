﻿#pragma checksum "..\..\ClientWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2F32FF38EBDBFF79F0E2B311FBABFB89097653D4D71DED63B88CF2A4923E78EE"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using AviaPlace;
using LottieSharp.WPF;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using SharpVectors.Converters;
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
    /// ClientWindow
    /// </summary>
    public partial class ClientWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 49 "..\..\ClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button minimizeBtn;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\ClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button closeBtn;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\ClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox NavigationList;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\ClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBoxItem FlightsItem;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\ClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBoxItem TicketsItem;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\ClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBoxItem ReviewsItem;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\ClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ProfileList;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\ClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBoxItem ProfileItem;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\ClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame PageFrame;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\ClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LottieSharp.WPF.LottieAnimationView LottieAnim;
        
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
            System.Uri resourceLocater = new System.Uri("/AviaPlace;component/clientwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ClientWindow.xaml"
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
            this.minimizeBtn = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\ClientWindow.xaml"
            this.minimizeBtn.Click += new System.Windows.RoutedEventHandler(this.minimizeBtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.closeBtn = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\ClientWindow.xaml"
            this.closeBtn.Click += new System.Windows.RoutedEventHandler(this.closeBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.NavigationList = ((System.Windows.Controls.ListBox)(target));
            return;
            case 4:
            this.FlightsItem = ((System.Windows.Controls.ListBoxItem)(target));
            
            #line 60 "..\..\ClientWindow.xaml"
            this.FlightsItem.Selected += new System.Windows.RoutedEventHandler(this.OnSelected);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TicketsItem = ((System.Windows.Controls.ListBoxItem)(target));
            
            #line 66 "..\..\ClientWindow.xaml"
            this.TicketsItem.Selected += new System.Windows.RoutedEventHandler(this.OnSelected);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ReviewsItem = ((System.Windows.Controls.ListBoxItem)(target));
            
            #line 72 "..\..\ClientWindow.xaml"
            this.ReviewsItem.Selected += new System.Windows.RoutedEventHandler(this.OnSelected);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ProfileList = ((System.Windows.Controls.ListBox)(target));
            return;
            case 8:
            this.ProfileItem = ((System.Windows.Controls.ListBoxItem)(target));
            
            #line 92 "..\..\ClientWindow.xaml"
            this.ProfileItem.Selected += new System.Windows.RoutedEventHandler(this.OnSelected);
            
            #line default
            #line hidden
            return;
            case 9:
            this.PageFrame = ((System.Windows.Controls.Frame)(target));
            return;
            case 10:
            this.LottieAnim = ((LottieSharp.WPF.LottieAnimationView)(target));
            
            #line 102 "..\..\ClientWindow.xaml"
            this.LottieAnim.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.LottieAnim_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


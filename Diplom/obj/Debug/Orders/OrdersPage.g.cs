﻿#pragma checksum "..\..\..\Orders\OrdersPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "736E52F0D5BF148F7339DD86FE15CEC2A60810F6A1D7C5FD227C1FA6CC414515"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Diplom.Orders;
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


namespace Diplom.Orders {
    
    
    /// <summary>
    /// OrdersPage
    /// </summary>
    public partial class OrdersPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 23 "..\..\..\Orders\OrdersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox OrderSearchBox;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Orders\OrdersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NewOrder;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Orders\OrdersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteOrder;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Orders\OrdersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Complete;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Orders\OrdersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox UnComplete;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Orders\OrdersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboTypeOrder;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\Orders\OrdersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboClientOrder;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Orders\OrdersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView OrdersList;
        
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
            System.Uri resourceLocater = new System.Uri("/Diplom;component/orders/orderspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Orders\OrdersPage.xaml"
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
            
            #line 9 "..\..\..\Orders\OrdersPage.xaml"
            ((Diplom.Orders.OrdersPage)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.OrdersListMouseEnter);
            
            #line default
            #line hidden
            return;
            case 2:
            this.OrderSearchBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 23 "..\..\..\Orders\OrdersPage.xaml"
            this.OrderSearchBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OrderSearch);
            
            #line default
            #line hidden
            return;
            case 3:
            this.NewOrder = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\Orders\OrdersPage.xaml"
            this.NewOrder.Click += new System.Windows.RoutedEventHandler(this.NewOrderClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DeleteOrder = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\Orders\OrdersPage.xaml"
            this.DeleteOrder.Click += new System.Windows.RoutedEventHandler(this.DeleteOrderClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Complete = ((System.Windows.Controls.CheckBox)(target));
            
            #line 50 "..\..\..\Orders\OrdersPage.xaml"
            this.Complete.Click += new System.Windows.RoutedEventHandler(this.CompleteCheck);
            
            #line default
            #line hidden
            return;
            case 6:
            this.UnComplete = ((System.Windows.Controls.CheckBox)(target));
            
            #line 54 "..\..\..\Orders\OrdersPage.xaml"
            this.UnComplete.Click += new System.Windows.RoutedEventHandler(this.UnCompleteCheck);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ComboTypeOrder = ((System.Windows.Controls.ComboBox)(target));
            
            #line 59 "..\..\..\Orders\OrdersPage.xaml"
            this.ComboTypeOrder.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboTypeOrderSelect);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ComboClientOrder = ((System.Windows.Controls.ComboBox)(target));
            
            #line 63 "..\..\..\Orders\OrdersPage.xaml"
            this.ComboClientOrder.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboClientSelect);
            
            #line default
            #line hidden
            return;
            case 9:
            this.OrdersList = ((System.Windows.Controls.ListView)(target));
            
            #line 67 "..\..\..\Orders\OrdersPage.xaml"
            this.OrdersList.MouseEnter += new System.Windows.Input.MouseEventHandler(this.OrdersListMouseEnter);
            
            #line default
            #line hidden
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
            System.Windows.EventSetter eventSetter;
            switch (connectionId)
            {
            case 10:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.Controls.Control.MouseDoubleClickEvent;
            
            #line 112 "..\..\..\Orders\OrdersPage.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.OrdersListItemMouseDoubleClick);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            }
        }
    }
}


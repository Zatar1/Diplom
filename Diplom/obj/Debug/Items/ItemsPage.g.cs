﻿#pragma checksum "..\..\..\Items\ItemsPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "966F7B4F8B7752D4525A7E52CBB7F9775BD17723436B0EBE858B6BF6B89EBBC0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Diplom.Items;
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


namespace Diplom.Items {
    
    
    /// <summary>
    /// ItemsPage
    /// </summary>
    public partial class ItemsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 24 "..\..\..\Items\ItemsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ItemSearchBox;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Items\ItemsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox UpCost;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Items\ItemsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox DownCost;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Items\ItemsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NewItem;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\Items\ItemsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteItem;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\Items\ItemsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NewMark;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\Items\ItemsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NewTypeItem;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\Items\ItemsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboType;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\Items\ItemsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboMark;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\Items\ItemsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ItemsList;
        
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
            System.Uri resourceLocater = new System.Uri("/Diplom;component/items/itemspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Items\ItemsPage.xaml"
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
            
            #line 9 "..\..\..\Items\ItemsPage.xaml"
            ((Diplom.Items.ItemsPage)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.ItemsListMouseEnter);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ItemSearchBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 24 "..\..\..\Items\ItemsPage.xaml"
            this.ItemSearchBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.ItemSearch);
            
            #line default
            #line hidden
            return;
            case 3:
            this.UpCost = ((System.Windows.Controls.CheckBox)(target));
            
            #line 47 "..\..\..\Items\ItemsPage.xaml"
            this.UpCost.Checked += new System.Windows.RoutedEventHandler(this.UpCostCheck);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DownCost = ((System.Windows.Controls.CheckBox)(target));
            
            #line 52 "..\..\..\Items\ItemsPage.xaml"
            this.DownCost.Checked += new System.Windows.RoutedEventHandler(this.DownCostCheck);
            
            #line default
            #line hidden
            return;
            case 5:
            this.NewItem = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\Items\ItemsPage.xaml"
            this.NewItem.Click += new System.Windows.RoutedEventHandler(this.NewItemClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.DeleteItem = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\Items\ItemsPage.xaml"
            this.DeleteItem.Click += new System.Windows.RoutedEventHandler(this.DeleteItemClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.NewMark = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\..\Items\ItemsPage.xaml"
            this.NewMark.Click += new System.Windows.RoutedEventHandler(this.NewMarkClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.NewTypeItem = ((System.Windows.Controls.Button)(target));
            
            #line 71 "..\..\..\Items\ItemsPage.xaml"
            this.NewTypeItem.Click += new System.Windows.RoutedEventHandler(this.NewTypeItemClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ComboType = ((System.Windows.Controls.ComboBox)(target));
            
            #line 78 "..\..\..\Items\ItemsPage.xaml"
            this.ComboType.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboTypeSelect);
            
            #line default
            #line hidden
            return;
            case 10:
            this.ComboMark = ((System.Windows.Controls.ComboBox)(target));
            
            #line 83 "..\..\..\Items\ItemsPage.xaml"
            this.ComboMark.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboMarkSelect);
            
            #line default
            #line hidden
            return;
            case 11:
            this.ItemsList = ((System.Windows.Controls.ListView)(target));
            
            #line 88 "..\..\..\Items\ItemsPage.xaml"
            this.ItemsList.MouseEnter += new System.Windows.Input.MouseEventHandler(this.ItemsListMouseEnter);
            
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
            case 12:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.Controls.Control.MouseDoubleClickEvent;
            
            #line 116 "..\..\..\Items\ItemsPage.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.ItemsListItemMouseDoubleClick);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            }
        }
    }
}

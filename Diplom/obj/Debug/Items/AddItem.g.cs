﻿#pragma checksum "..\..\..\Items\AddItem.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8A687871EE33C96BB36B9BF65432925E48895EC4D5F54A03EC5E8B1138D952A5"
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
    /// AddItem
    /// </summary>
    public partial class AddItem : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\..\Items\AddItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboTypeItem;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Items\AddItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboMarkItem;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Items\AddItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtItemName;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Items\AddItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtCost;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Items\AddItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtCount;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Items\AddItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NewMark;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Items\AddItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NewTypeItem;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Items\AddItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSaveItem;
        
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
            System.Uri resourceLocater = new System.Uri("/Diplom;component/items/additem.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Items\AddItem.xaml"
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
            
            #line 9 "..\..\..\Items\AddItem.xaml"
            ((Diplom.Items.AddItem)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.VisibleChg);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ComboTypeItem = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.ComboMarkItem = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.TxtItemName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TxtCost = ((System.Windows.Controls.TextBox)(target));
            
            #line 38 "..\..\..\Items\AddItem.xaml"
            this.TxtCost.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TxtCostChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TxtCount = ((System.Windows.Controls.TextBox)(target));
            
            #line 39 "..\..\..\Items\AddItem.xaml"
            this.TxtCount.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TxtCountChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.NewMark = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\Items\AddItem.xaml"
            this.NewMark.Click += new System.Windows.RoutedEventHandler(this.NewMarkClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.NewTypeItem = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\Items\AddItem.xaml"
            this.NewTypeItem.Click += new System.Windows.RoutedEventHandler(this.NewTypeItemClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.BtnSaveItem = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\Items\AddItem.xaml"
            this.BtnSaveItem.Click += new System.Windows.RoutedEventHandler(this.BtnSaveItemClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

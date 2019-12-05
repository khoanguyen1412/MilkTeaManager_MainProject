﻿#pragma checksum "..\..\..\..\Views\Pages\ImportMaterial.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5A23FCBA5A0B335C0C435EA4C0593E3DB4B7733344F08282041A0DE86776A885"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using MilkTeaManager.Views.CustomControls;
using MilkTeaManager.Views.Pages;
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


namespace MilkTeaManager.Views.Pages {
    
    
    /// <summary>
    /// ImportMaterial
    /// </summary>
    public partial class ImportMaterial : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 83 "..\..\..\..\Views\Pages\ImportMaterial.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddMaterial;
        
        #line default
        #line hidden
        
        
        #line 213 "..\..\..\..\Views\Pages\ImportMaterial.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker FutureDatePicker;
        
        #line default
        #line hidden
        
        
        #line 234 "..\..\..\..\Views\Pages\ImportMaterial.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEditProductInfo;
        
        #line default
        #line hidden
        
        
        #line 244 "..\..\..\..\Views\Pages\ImportMaterial.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDeleteProduct;
        
        #line default
        #line hidden
        
        
        #line 329 "..\..\..\..\Views\Pages\ImportMaterial.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnThemPhieuMua;
        
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
            System.Uri resourceLocater = new System.Uri("/MilkTeaManager;component/views/pages/importmaterial.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Pages\ImportMaterial.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.btnAddMaterial = ((System.Windows.Controls.Button)(target));
            
            #line 89 "..\..\..\..\Views\Pages\ImportMaterial.xaml"
            this.btnAddMaterial.Click += new System.Windows.RoutedEventHandler(this.addMaterial_click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.FutureDatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            this.btnEditProductInfo = ((System.Windows.Controls.Button)(target));
            
            #line 232 "..\..\..\..\Views\Pages\ImportMaterial.xaml"
            this.btnEditProductInfo.Click += new System.Windows.RoutedEventHandler(this.editImportBill_click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnDeleteProduct = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.btnThemPhieuMua = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


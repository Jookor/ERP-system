﻿#pragma checksum "..\..\..\Views\UpdateDealerView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EC5F8832AFFD2EF51AE0A1AD4AC86BCAA796AB5298C76B2A72318A84648A82D2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BetterWay.Views;
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


namespace BetterWay.Views {
    
    
    /// <summary>
    /// UpdateDealerView
    /// </summary>
    public partial class UpdateDealerView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Views\UpdateDealerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDealerName;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Views\UpdateDealerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDealerAddress;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Views\UpdateDealerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDealerCity;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Views\UpdateDealerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDealerPostcode;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Views\UpdateDealerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDealerPhone;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Views\UpdateDealerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDealerEmail;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Views\UpdateDealerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpdateDealer;
        
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
            System.Uri resourceLocater = new System.Uri("/BetterWay;component/views/updatedealerview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\UpdateDealerView.xaml"
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
            
            #line 10 "..\..\..\Views\UpdateDealerView.xaml"
            ((System.Windows.Controls.StackPanel)(target)).Loaded += new System.Windows.RoutedEventHandler(this.StackPanel_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtDealerName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtDealerAddress = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtDealerCity = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtDealerPostcode = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtDealerPhone = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtDealerEmail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.btnUpdateDealer = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\Views\UpdateDealerView.xaml"
            this.btnUpdateDealer.Click += new System.Windows.RoutedEventHandler(this.BtnUpdateDealer_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


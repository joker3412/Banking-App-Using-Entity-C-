﻿#pragma checksum "..\..\ExistingAccountOperations.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A01115D01316D0B3BE10C18906DDE113AB5985D63E198F4CA9ECFA9E646B5C82"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BankManagementSystem;
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


namespace BankManagementSystem {
    
    
    /// <summary>
    /// ExistingAccountOperations
    /// </summary>
    public partial class ExistingAccountOperations : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\ExistingAccountOperations.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal BankManagementSystem.ExistingAccountOperations EXT;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\ExistingAccountOperations.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Delete;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\ExistingAccountOperations.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem AccountDetail;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\ExistingAccountOperations.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Deposit;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\ExistingAccountOperations.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Withdraw;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\ExistingAccountOperations.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Transfer;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\ExistingAccountOperations.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Transaction;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\ExistingAccountOperations.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame pageContainer;
        
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
            System.Uri resourceLocater = new System.Uri("/BankManagementSystem;component/existingaccountoperations.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ExistingAccountOperations.xaml"
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
            this.EXT = ((BankManagementSystem.ExistingAccountOperations)(target));
            return;
            case 2:
            
            #line 19 "..\..\ExistingAccountOperations.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Delete = ((System.Windows.Controls.MenuItem)(target));
            
            #line 20 "..\..\ExistingAccountOperations.xaml"
            this.Delete.Click += new System.Windows.RoutedEventHandler(this.Delete_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AccountDetail = ((System.Windows.Controls.MenuItem)(target));
            
            #line 23 "..\..\ExistingAccountOperations.xaml"
            this.AccountDetail.Click += new System.Windows.RoutedEventHandler(this.AccountDetail_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Deposit = ((System.Windows.Controls.MenuItem)(target));
            
            #line 25 "..\..\ExistingAccountOperations.xaml"
            this.Deposit.Click += new System.Windows.RoutedEventHandler(this.Deposit_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Withdraw = ((System.Windows.Controls.MenuItem)(target));
            
            #line 26 "..\..\ExistingAccountOperations.xaml"
            this.Withdraw.Click += new System.Windows.RoutedEventHandler(this.Withdraw_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Transfer = ((System.Windows.Controls.MenuItem)(target));
            
            #line 27 "..\..\ExistingAccountOperations.xaml"
            this.Transfer.Click += new System.Windows.RoutedEventHandler(this.Transfer_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Transaction = ((System.Windows.Controls.MenuItem)(target));
            
            #line 29 "..\..\ExistingAccountOperations.xaml"
            this.Transaction.Click += new System.Windows.RoutedEventHandler(this.Transaction_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.pageContainer = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


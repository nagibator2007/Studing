﻿#pragma checksum "..\..\..\..\View\Pages\RadioButtonPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F28F6E5CC44AA2A762D8EFB33E802C9EA14CDDEDBAB44052093698FEB049F69F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using PanelProject.View.Pages;
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


namespace PanelProject.View.Pages {
    
    
    /// <summary>
    /// RadioButtonPage
    /// </summary>
    public partial class RadioButtonPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\..\View\Pages\RadioButtonPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel XamlStackPanel;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\View\Pages\RadioButtonPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel ProgrammStackPanel;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\View\Pages\RadioButtonPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteButton;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\View\Pages\RadioButtonPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox AdditingCheckBox;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\View\Pages\RadioButtonPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox AdditingGroupBox;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\View\Pages\RadioButtonPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AdditingTextBox;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\View\Pages\RadioButtonPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddButton;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\View\Pages\RadioButtonPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel DataBaseXamlStackPanel;
        
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
            System.Uri resourceLocater = new System.Uri("/PanelProject;component/view/pages/radiobuttonpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Pages\RadioButtonPage.xaml"
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
            this.XamlStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.ProgrammStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.DeleteButton = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\..\View\Pages\RadioButtonPage.xaml"
            this.DeleteButton.Click += new System.Windows.RoutedEventHandler(this.DeleteButtonClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AdditingCheckBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 31 "..\..\..\..\View\Pages\RadioButtonPage.xaml"
            this.AdditingCheckBox.Click += new System.Windows.RoutedEventHandler(this.AdditingCheckBoxClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.AdditingGroupBox = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 6:
            this.AdditingTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.AddButton = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\..\View\Pages\RadioButtonPage.xaml"
            this.AddButton.Click += new System.Windows.RoutedEventHandler(this.AddButtonClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.DataBaseXamlStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


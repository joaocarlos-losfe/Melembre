﻿#pragma checksum "..\..\..\Views\Add.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7A70126AEDB34822B7EE233706DA687048A52A7337F1534761AD1199ECAF2186"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using Melembre_v2;
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


namespace Melembre_v2 {
    
    
    /// <summary>
    /// AddEdit
    /// </summary>
    public partial class AddEdit : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\Views\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox input_txt;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Views\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button high_btn;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Views\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button average_button;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\Views\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button low_button;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\Views\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid selected_priority;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\Views\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock selected_text_priority;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\Views\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox category_selected;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\Views\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox frequency_select;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\Views\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SelectDaysBtn;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\..\Views\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox hour_select;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\..\Views\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox minut_select;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\..\Views\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button save_buttom;
        
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
            System.Uri resourceLocater = new System.Uri("/Melembre;component/views/add.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\Add.xaml"
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
            this.input_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.high_btn = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\Views\Add.xaml"
            this.high_btn.Click += new System.Windows.RoutedEventHandler(this.high_btn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.average_button = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\Views\Add.xaml"
            this.average_button.Click += new System.Windows.RoutedEventHandler(this.average_button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.low_button = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\Views\Add.xaml"
            this.low_button.Click += new System.Windows.RoutedEventHandler(this.low_button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.selected_priority = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.selected_text_priority = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.category_selected = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            
            #line 98 "..\..\..\Views\Add.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.frequency_select = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.SelectDaysBtn = ((System.Windows.Controls.Button)(target));
            
            #line 107 "..\..\..\Views\Add.xaml"
            this.SelectDaysBtn.Click += new System.Windows.RoutedEventHandler(this.SelectDaysBtn_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.hour_select = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 12:
            this.minut_select = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 13:
            this.save_buttom = ((System.Windows.Controls.Button)(target));
            
            #line 135 "..\..\..\Views\Add.xaml"
            this.save_buttom.Click += new System.Windows.RoutedEventHandler(this.save_buttom_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


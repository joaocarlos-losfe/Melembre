﻿#pragma checksum "..\..\..\Views\LembreteShowWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C7BF60654D47FA8167C46256FDA0A20FCC8A298434D22CEEB54A74A6CC26643F"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using Melembre.Source.Views;
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


namespace Melembre.Source.Views {
    
    
    /// <summary>
    /// LembreteShowWindow
    /// </summary>
    public partial class LembreteShowWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Views\LembreteShowWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock display_date_time;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Views\LembreteShowWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Display_lembrete;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Views\LembreteShowWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle display_color_priority;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Views\LembreteShowWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock display_priority;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Views\LembreteShowWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_mute;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Views\LembreteShowWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_parar;
        
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
            System.Uri resourceLocater = new System.Uri("/Melembre v2;component/views/lembreteshowwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\LembreteShowWindow.xaml"
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
            
            #line 8 "..\..\..\Views\LembreteShowWindow.xaml"
            ((Melembre.Source.Views.LembreteShowWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.display_date_time = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.Display_lembrete = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.display_color_priority = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 5:
            this.display_priority = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.btn_mute = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Views\LembreteShowWindow.xaml"
            this.btn_mute.Click += new System.Windows.RoutedEventHandler(this.btn_mute_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btn_parar = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\Views\LembreteShowWindow.xaml"
            this.btn_parar.Click += new System.Windows.RoutedEventHandler(this.btn_parar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

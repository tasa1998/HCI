#pragma checksum "..\..\EditEvent.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7DE6DEF0F474C9942A66DF21C2703F00EAF418038DA8B04A523923451B4BB4B5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HCI_projekat;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace HCI_projekat {
    
    
    /// <summary>
    /// EditEvent
    /// </summary>
    public partial class EditEvent : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 46 "..\..\EditEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox mark;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\EditEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox name;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\EditEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox description;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\EditEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox typeCB;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\EditEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox attendanceCB;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\EditEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker date;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\EditEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button izaberiIkonicu;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\EditEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ikonica;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\EditEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox humanitarian;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\EditEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox price;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\EditEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox country;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\EditEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox city;
        
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
            System.Uri resourceLocater = new System.Uri("/HCI projekat;component/editevent.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\EditEvent.xaml"
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
            this.mark = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.description = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.typeCB = ((System.Windows.Controls.ComboBox)(target));
            
            #line 55 "..\..\EditEvent.xaml"
            this.typeCB.AddHandler(System.Windows.Input.Keyboard.KeyDownEvent, new System.Windows.Input.KeyEventHandler(this.typeCB_KeyDown));
            
            #line default
            #line hidden
            return;
            case 5:
            this.attendanceCB = ((System.Windows.Controls.ComboBox)(target));
            
            #line 58 "..\..\EditEvent.xaml"
            this.attendanceCB.AddHandler(System.Windows.Input.Keyboard.KeyDownEvent, new System.Windows.Input.KeyEventHandler(this.attendanceCB_KeyDown));
            
            #line default
            #line hidden
            return;
            case 6:
            this.date = ((System.Windows.Controls.DatePicker)(target));
            
            #line 87 "..\..\EditEvent.xaml"
            this.date.AddHandler(System.Windows.Input.Keyboard.KeyDownEvent, new System.Windows.Input.KeyEventHandler(this.date_KeyDown));
            
            #line default
            #line hidden
            return;
            case 7:
            this.izaberiIkonicu = ((System.Windows.Controls.Button)(target));
            
            #line 90 "..\..\EditEvent.xaml"
            this.izaberiIkonicu.Click += new System.Windows.RoutedEventHandler(this.izaberiIkonicu_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ikonica = ((System.Windows.Controls.Image)(target));
            return;
            case 9:
            this.humanitarian = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 10:
            this.price = ((System.Windows.Controls.TextBox)(target));
            
            #line 96 "..\..\EditEvent.xaml"
            this.price.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.price_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 11:
            this.country = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.city = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            
            #line 107 "..\..\EditEvent.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 112 "..\..\EditEvent.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


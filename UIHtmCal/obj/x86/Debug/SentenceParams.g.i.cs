﻿#pragma checksum "..\..\..\SentenceParams.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "68E7AA52822FFCC7AA4286A487BEA138"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.261
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using HTM.HTMBitmapProcessor;
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


namespace HTM.UIHtmCal {
    
    
    /// <summary>
    /// SentenceParams
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class SentenceParams : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\SentenceParams.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox Sentences;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\SentenceParams.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider sliderNoise;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\SentenceParams.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider sliderLetters;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\SentenceParams.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas AlphaBeta;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\SentenceParams.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ok_Button;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/UIHtmCal;component/sentenceparams.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\SentenceParams.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Sentences = ((System.Windows.Controls.ListBox)(target));
            
            #line 27 "..\..\..\SentenceParams.xaml"
            this.Sentences.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Sentences_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.sliderNoise = ((System.Windows.Controls.Slider)(target));
            
            #line 49 "..\..\..\SentenceParams.xaml"
            this.sliderNoise.AddHandler(System.Windows.Controls.Primitives.Thumb.DragCompletedEvent, new System.Windows.Controls.Primitives.DragCompletedEventHandler(this.sliderDistort_DragCompleted));
            
            #line default
            #line hidden
            return;
            case 3:
            this.sliderLetters = ((System.Windows.Controls.Slider)(target));
            
            #line 64 "..\..\..\SentenceParams.xaml"
            this.sliderLetters.AddHandler(System.Windows.Controls.Primitives.Thumb.DragCompletedEvent, new System.Windows.Controls.Primitives.DragCompletedEventHandler(this.sliderDistort_DragCompleted));
            
            #line default
            #line hidden
            return;
            case 4:
            this.AlphaBeta = ((System.Windows.Controls.Canvas)(target));
            return;
            case 5:
            
            #line 84 "..\..\..\SentenceParams.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Cancel);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ok_Button = ((System.Windows.Controls.Button)(target));
            
            #line 92 "..\..\..\SentenceParams.xaml"
            this.ok_Button.Click += new System.Windows.RoutedEventHandler(this.Button_Click_ok);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


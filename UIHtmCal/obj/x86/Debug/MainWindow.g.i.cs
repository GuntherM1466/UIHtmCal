﻿#pragma checksum "..\..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1104BB5AA435131D80268883B37214F8"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.261
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

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
    /// MainWindow
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 45 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ToolBar UIAutomation;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Sentence_Connect;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button InitHTM;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button HTMButtonStep;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button HTMButtonFastStep;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button HTMButtonStop;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button HTMButtonShow;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid RegionMasterView;
        
        #line default
        #line hidden
        
        
        #line 149 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ColumnMasterView;
        
        #line default
        #line hidden
        
        
        #line 235 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid CellDetailView;
        
        #line default
        #line hidden
        
        
        #line 304 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander HTMLogView;
        
        #line default
        #line hidden
        
        
        #line 314 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid SentencesLog;
        
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
            System.Uri resourceLocater = new System.Uri("/UIHtmCal;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
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
            
            #line 29 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_Exit);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 33 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuShowTempLearning);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 36 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuRegion1Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 37 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuRegion2Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 38 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuRegion3Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 40 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuSynapseClick);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 42 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.UIAutomation = ((System.Windows.Controls.ToolBar)(target));
            return;
            case 9:
            this.Button_Sentence_Connect = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\MainWindow.xaml"
            this.Button_Sentence_Connect.Click += new System.Windows.RoutedEventHandler(this.InitalizeAlphaBeta);
            
            #line default
            #line hidden
            return;
            case 10:
            this.InitHTM = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\MainWindow.xaml"
            this.InitHTM.Click += new System.Windows.RoutedEventHandler(this.InitializeHTM);
            
            #line default
            #line hidden
            return;
            case 11:
            this.HTMButtonStep = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\..\MainWindow.xaml"
            this.HTMButtonStep.Click += new System.Windows.RoutedEventHandler(this.StepHTMEvents);
            
            #line default
            #line hidden
            return;
            case 12:
            this.HTMButtonFastStep = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\..\MainWindow.xaml"
            this.HTMButtonFastStep.Click += new System.Windows.RoutedEventHandler(this.FastThroughHTMEvents);
            
            #line default
            #line hidden
            return;
            case 13:
            this.HTMButtonStop = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\..\MainWindow.xaml"
            this.HTMButtonStop.Click += new System.Windows.RoutedEventHandler(this.StopUIAutomationListen);
            
            #line default
            #line hidden
            return;
            case 14:
            this.HTMButtonShow = ((System.Windows.Controls.Button)(target));
            
            #line 90 "..\..\..\MainWindow.xaml"
            this.HTMButtonShow.Click += new System.Windows.RoutedEventHandler(this.MenuShowTempLearning);
            
            #line default
            #line hidden
            return;
            case 15:
            this.RegionMasterView = ((System.Windows.Controls.DataGrid)(target));
            
            #line 121 "..\..\..\MainWindow.xaml"
            this.RegionMasterView.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.RegionMasterView_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 16:
            this.ColumnMasterView = ((System.Windows.Controls.DataGrid)(target));
            
            #line 153 "..\..\..\MainWindow.xaml"
            this.ColumnMasterView.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ColumnMasterView_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 17:
            this.CellDetailView = ((System.Windows.Controls.DataGrid)(target));
            
            #line 239 "..\..\..\MainWindow.xaml"
            this.CellDetailView.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CellDetailView_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 18:
            this.HTMLogView = ((System.Windows.Controls.Expander)(target));
            return;
            case 19:
            this.SentencesLog = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\XnaViewer.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C5568729FE0B0D1A66D64E6BC2124470"
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
using Transmute.Wpf;


namespace Transmute.Wpf {
    
    
    /// <summary>
    /// XnaViewer
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class XnaViewer : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\XnaViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel dockPanel;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\XnaViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ToolBar mainToolbar;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\XnaViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ScrollBar vScrollBar;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\XnaViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ScrollBar hScrollBar;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\XnaViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Transmute.Wpf.GraphicsDeviceControl graphicsDeviceControl;
        
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
            System.Uri resourceLocater = new System.Uri("/Transmute.Wpf;component/xnaviewer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\XnaViewer.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.dockPanel = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 2:
            this.mainToolbar = ((System.Windows.Controls.ToolBar)(target));
            return;
            case 3:
            this.vScrollBar = ((System.Windows.Controls.Primitives.ScrollBar)(target));
            
            #line 11 "..\..\XnaViewer.xaml"
            this.vScrollBar.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.vScrollBar_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.hScrollBar = ((System.Windows.Controls.Primitives.ScrollBar)(target));
            
            #line 12 "..\..\XnaViewer.xaml"
            this.hScrollBar.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.hScrollBar_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.graphicsDeviceControl = ((Transmute.Wpf.GraphicsDeviceControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


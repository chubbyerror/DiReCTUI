﻿#pragma checksum "..\..\..\..\ViewModels\Observations\ObservationsView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F99350E665A0EDACCC1C7DE63B7CC3BF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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


namespace DiReCTUI.ViewModels {
    
    
    /// <summary>
    /// ObservationsView
    /// </summary>
    public partial class ObservationsView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\ViewModels\Observations\ObservationsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl ObservationsTab;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\ViewModels\Observations\ObservationsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem MapTab;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\ViewModels\Observations\ObservationsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MapGrid;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\ViewModels\Observations\ObservationsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem RecordListTab;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\ViewModels\Observations\ObservationsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid RecordListGrid;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\ViewModels\Observations\ObservationsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem BackgroundTab;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\ViewModels\Observations\ObservationsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid BackgroundGrid;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\ViewModels\Observations\ObservationsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem TaskViewTab;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\ViewModels\Observations\ObservationsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid TaskViewGrid;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\ViewModels\Observations\ObservationsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ReturnButton;
        
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
            System.Uri resourceLocater = new System.Uri("/DiReCTUI;component/viewmodels/observations/observationsview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\ViewModels\Observations\ObservationsView.xaml"
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
            this.ObservationsTab = ((System.Windows.Controls.TabControl)(target));
            
            #line 10 "..\..\..\..\ViewModels\Observations\ObservationsView.xaml"
            this.ObservationsTab.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ObservationsTab_Change);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MapTab = ((System.Windows.Controls.TabItem)(target));
            return;
            case 3:
            this.MapGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.RecordListTab = ((System.Windows.Controls.TabItem)(target));
            return;
            case 5:
            this.RecordListGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.BackgroundTab = ((System.Windows.Controls.TabItem)(target));
            return;
            case 7:
            this.BackgroundGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 8:
            this.TaskViewTab = ((System.Windows.Controls.TabItem)(target));
            return;
            case 9:
            this.TaskViewGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 10:
            this.ReturnButton = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\..\ViewModels\Observations\ObservationsView.xaml"
            this.ReturnButton.Click += new System.Windows.RoutedEventHandler(this.ReturnButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


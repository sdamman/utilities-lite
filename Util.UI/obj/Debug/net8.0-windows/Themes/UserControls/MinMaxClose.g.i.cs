﻿#pragma checksum "..\..\..\..\..\Themes\UserControls\MinMaxClose.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F382DFDB9E1AF431D2361DD88E2A6C3522387AAA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ALMACO.UI.UserControls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace ALMACO.UI.UserControls {
    
    
    /// <summary>
    /// MinMaxClose
    /// </summary>
    public partial class MinMaxClose : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\..\Themes\UserControls\MinMaxClose.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Lingo;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\..\Themes\UserControls\MinMaxClose.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Sun;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\..\Themes\UserControls\MinMaxClose.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Moon;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\..\Themes\UserControls\MinMaxClose.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Min;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\..\Themes\UserControls\MinMaxClose.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Max;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\..\Themes\UserControls\MinMaxClose.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Restore;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\..\Themes\UserControls\MinMaxClose.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Close;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Util.UI;V1.1.0.0;component/themes/usercontrols/minmaxclose.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Themes\UserControls\MinMaxClose.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\..\..\Themes\UserControls\MinMaxClose.xaml"
            ((ALMACO.UI.UserControls.MinMaxClose)(target)).Loaded += new System.Windows.RoutedEventHandler(this.OnUserControlLoaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.button_Lingo = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.button_Sun = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\..\..\Themes\UserControls\MinMaxClose.xaml"
            this.button_Sun.Click += new System.Windows.RoutedEventHandler(this.OnThemeSwitch);
            
            #line default
            #line hidden
            return;
            case 4:
            this.button_Moon = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\..\..\Themes\UserControls\MinMaxClose.xaml"
            this.button_Moon.Click += new System.Windows.RoutedEventHandler(this.OnThemeSwitch);
            
            #line default
            #line hidden
            return;
            case 5:
            this.button_Min = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\..\..\Themes\UserControls\MinMaxClose.xaml"
            this.button_Min.Click += new System.Windows.RoutedEventHandler(this.Minimize);
            
            #line default
            #line hidden
            return;
            case 6:
            this.button_Max = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\..\..\Themes\UserControls\MinMaxClose.xaml"
            this.button_Max.Click += new System.Windows.RoutedEventHandler(this.MaxOrRestore);
            
            #line default
            #line hidden
            return;
            case 7:
            this.button_Restore = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\..\..\Themes\UserControls\MinMaxClose.xaml"
            this.button_Restore.Click += new System.Windows.RoutedEventHandler(this.MaxOrRestore);
            
            #line default
            #line hidden
            return;
            case 8:
            this.button_Close = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\..\..\Themes\UserControls\MinMaxClose.xaml"
            this.button_Close.Click += new System.Windows.RoutedEventHandler(this.CloseWindow);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


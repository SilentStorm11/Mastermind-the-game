﻿#pragma checksum "..\..\StartPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F9EEC1EE302A5E3257CFE6E8969BA067"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Projekat2;
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


namespace Projekat2 {
    
    
    /// <summary>
    /// StartPage
    /// </summary>
    public partial class StartPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\StartPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame mainFrame;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\StartPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement klik_sound;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\StartPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label naslov;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\StartPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button igra;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\StartPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lab;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\StartPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel tezine;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\StartPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label easy;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\StartPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label normal;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\StartPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label hard;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\StartPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button rezultati;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\StartPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exit;
        
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
            System.Uri resourceLocater = new System.Uri("/Projekat2;component/startpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\StartPage.xaml"
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
            this.mainFrame = ((System.Windows.Controls.Frame)(target));
            return;
            case 2:
            this.klik_sound = ((System.Windows.Controls.MediaElement)(target));
            
            #line 14 "..\..\StartPage.xaml"
            this.klik_sound.MediaEnded += new System.Windows.RoutedEventHandler(this.klik_sound_MediaEnded);
            
            #line default
            #line hidden
            return;
            case 3:
            this.naslov = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.igra = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\StartPage.xaml"
            this.igra.Click += new System.Windows.RoutedEventHandler(this.igra_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lab = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.tezine = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 7:
            this.easy = ((System.Windows.Controls.Label)(target));
            
            #line 22 "..\..\StartPage.xaml"
            this.easy.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.biranjeTezine);
            
            #line default
            #line hidden
            return;
            case 8:
            this.normal = ((System.Windows.Controls.Label)(target));
            
            #line 23 "..\..\StartPage.xaml"
            this.normal.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.biranjeTezine);
            
            #line default
            #line hidden
            return;
            case 9:
            this.hard = ((System.Windows.Controls.Label)(target));
            
            #line 24 "..\..\StartPage.xaml"
            this.hard.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.biranjeTezine);
            
            #line default
            #line hidden
            return;
            case 10:
            this.rezultati = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\StartPage.xaml"
            this.rezultati.Click += new System.Windows.RoutedEventHandler(this.rezultati_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.exit = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\StartPage.xaml"
            this.exit.Click += new System.Windows.RoutedEventHandler(this.exit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


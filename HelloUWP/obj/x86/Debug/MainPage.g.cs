﻿#pragma checksum "C:\Users\Robert\Documents\Visual Studio 2015\Projects\HelloUWP\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "020EAF1AC3898E044D9CC2237E76D423"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelloUWP
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.rect1 = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 2:
                {
                    this.rect1_2 = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 3:
                {
                    this.textBlock1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 62 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button).Click += this.button_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.MySlider = (global::Windows.UI.Xaml.Controls.Slider)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}


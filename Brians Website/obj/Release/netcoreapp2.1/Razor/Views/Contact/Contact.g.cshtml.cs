#pragma checksum "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Contact\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cc42beefcd8fec0554560b46e60c88f39457f21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Contact), @"mvc.1.0.view", @"/Views/Contact/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Contact/Contact.cshtml", typeof(AspNetCore.Views_Contact_Contact))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\_ViewImports.cshtml"
using Brians_Website;

#line default
#line hidden
#line 2 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\_ViewImports.cshtml"
using Brians_Website.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cc42beefcd8fec0554560b46e60c88f39457f21", @"/Views/Contact/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31fa6dc54be645cc22010954bb62d9325f200b69", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Contact\Contact.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
            BeginContext(357, 7331, true);
            WriteLiteral(@"

<div id=""homemenucircle"">
    <nav class='menu'>
        <input checked='checked' class='menu-toggler' id='menu-toggler' type='checkbox'>
        <label for='menu-toggler'></label>
        <ul>
            <li class='menu-item'>
                <a class='fa fa-envelope' href='mailto:mitchellbrian1985@gmail.com' target='_blank'></a>
            </li>
            <li class='menu-item'>
                <a class='fab fa-google' href='https://www.google.com/' target='_blank'></a>
            </li>
            <li class='menu-item'>
                <a class='fas fa-phone' href='tel:+353871223563' target='_blank'></a>
            </li>
            <li class='menu-item'>
                <a class='fab fa-codepen' href='https://codepen.io/' target='_blank'></a>
            </li>
            <li class='menu-item'>
                <a class='fab fa-linkedin-in' href='https://www.linkedin.com/in/brian-mitchell-0213a690/' target='_blank'></a>
            </li>
            <li class='menu-item'>
    ");
            WriteLiteral(@"            <a class='fab fa-github' href='https://github.com/brianm85' target='_blank'></a>
            </li>
        </ul>
    </nav>
</div>
<br />


<style>
    .menu-toggler {
        position: absolute;
        display: block;
        top: 0;
        bottom: 0;
        right: 0;
        left: 0;
        margin: auto;
        width: 40px;
        height: 40px;
        z-index: 2;
        opacity: 0;
        cursor: pointer;
    }

        .menu-toggler:hover + label, .menu-toggler:hover + label:before, .menu-toggler:hover + label:after {
            background: black;
        }

        .menu-toggler:checked + label {
            background: transparent;
        }

            .menu-toggler:checked + label:before, .menu-toggler:checked + label:after {
                top: 0;
                width: 40px;
                -webkit-transform-origin: 50% 50%;
                transform-origin: 50% 50%;
            }

            .menu-toggler:checked + label:before {
     ");
            WriteLiteral(@"           -webkit-transform: rotate(45deg);
                transform: rotate(45deg);
            }

            .menu-toggler:checked + label:after {
                -webkit-transform: rotate(-45deg);
                transform: rotate(-45deg);
            }

        .menu-toggler:checked ~ ul .menu-item {
            opacity: 1;
        }

            .menu-toggler:checked ~ ul .menu-item:nth-child(1) {
                -webkit-transform: rotate(0deg) translateX(-110px);
                transform: rotate(0deg) translateX(-110px);
            }

            .menu-toggler:checked ~ ul .menu-item:nth-child(2) {
                -webkit-transform: rotate(60deg) translateX(-110px);
                transform: rotate(60deg) translateX(-110px);
            }

            .menu-toggler:checked ~ ul .menu-item:nth-child(3) {
                -webkit-transform: rotate(120deg) translateX(-110px);
                transform: rotate(120deg) translateX(-110px);
            }

            .menu-togg");
            WriteLiteral(@"ler:checked ~ ul .menu-item:nth-child(4) {
                -webkit-transform: rotate(180deg) translateX(-110px);
                transform: rotate(180deg) translateX(-110px);
            }

            .menu-toggler:checked ~ ul .menu-item:nth-child(5) {
                -webkit-transform: rotate(240deg) translateX(-110px);
                transform: rotate(240deg) translateX(-110px);
            }

            .menu-toggler:checked ~ ul .menu-item:nth-child(6) {
                -webkit-transform: rotate(300deg) translateX(-110px);
                transform: rotate(300deg) translateX(-110px);
            }

            .menu-toggler:checked ~ ul .menu-item a {
                pointer-events: auto;
            }

        .menu-toggler + label {
            width: 40px;
            height: 5px;
            display: block;
            z-index: 1;
            border-radius: 2.5px;
            /*background: rgba(255, 255, 255, 0.7);*/
            background: black;
            -webkit-tra");
            WriteLiteral(@"nsition: top 0.5s, -webkit-transform 0.5s;
            transition: top 0.5s, -webkit-transform 0.5s;
            transition: transform 0.5s, top 0.5s;
            transition: transform 0.5s, top 0.5s, -webkit-transform 0.5s;
            position: absolute;
            display: block;
            top: 0;
            bottom: 0;
            right: 0;
            left: 0;
            margin: auto;
        }

            .menu-toggler + label:before, .menu-toggler + label:after {
                width: 40px;
                height: 5px;
                display: block;
                z-index: 1;
                border-radius: 2.5px;
                /*background: rgba(255, 255, 255, 0.7);*/
                background: black;
                -webkit-transition: top 0.5s, -webkit-transform 0.5s;
                transition: top 0.5s, -webkit-transform 0.5s;
                transition: transform 0.5s, top 0.5s;
                transition: transform 0.5s, top 0.5s, -webkit-transform 0.5s;
      ");
            WriteLiteral(@"          content: """";
                position: absolute;
                left: 0;
            }

            .menu-toggler + label:before {
                top: 10px;
            }

            .menu-toggler + label:after {
                top: -10px;
            }

    .menu-item:nth-child(1) a {
        -webkit-transform: rotate(0deg);
        transform: rotate(0deg);
    }

    .menu-item:nth-child(2) a {
        -webkit-transform: rotate(-60deg);
        transform: rotate(-60deg);
    }

    .menu-item:nth-child(3) a {
        -webkit-transform: rotate(-120deg);
        transform: rotate(-120deg);
    }

    .menu-item:nth-child(4) a {
        -webkit-transform: rotate(-180deg);
        transform: rotate(-180deg);
    }

    .menu-item:nth-child(5) a {
        -webkit-transform: rotate(-240deg);
        transform: rotate(-240deg);
    }

    .menu-item:nth-child(6) a {
        -webkit-transform: rotate(-300deg);
        transform: rotate(-300deg);
    }

    .m");
            WriteLiteral(@"enu-item {
        position: absolute;
        display: block;
        top: 0;
        bottom: 0;
        right: 0;
        left: 0;
        margin: auto;
        width: 80px;
        height: 80px;
        display: block;
        opacity: 0;
        -webkit-transition: 0.5s;
        transition: 0.5s;
    }

        .menu-item a {
            display: block;
            width: inherit;
            height: inherit;
            line-height: 80px;
            color: rgba(255, 255, 255, 0.7);
            background: black;
            opacity: .6;
            border-radius: 50%;
            text-align: center;
            text-decoration: none;
            font-size: 40px;
            pointer-events: none;
            -webkit-transition: .2s;
            transition: .2s;
        }

            .menu-item a:hover {
                box-shadow: 0 0 0 2px rgba(255, 255, 255, 0.3);
                color: black;
                background: rgba(255, 255, 255, 0.9);
                op");
            WriteLiteral("acity: 0.9;\r\n                font-size: 44.4444444444px;\r\n            }\r\n</style>\r\n\r\n<script>\r\n    //$(\'#navbar\').hide();\r\n    $(\'#footerbar\').hide();\r\n</script>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

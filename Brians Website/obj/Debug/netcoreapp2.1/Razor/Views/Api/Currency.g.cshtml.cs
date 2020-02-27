#pragma checksum "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Currency.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9387acfcd7bdff277c1ab9a43fc5d049c913edf6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Api_Currency), @"mvc.1.0.view", @"/Views/Api/Currency.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Api/Currency.cshtml", typeof(AspNetCore.Views_Api_Currency))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9387acfcd7bdff277c1ab9a43fc5d049c913edf6", @"/Views/Api/Currency.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31fa6dc54be645cc22010954bb62d9325f200b69", @"/Views/_ViewImports.cshtml")]
    public class Views_Api_Currency : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CheckAPIModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Currency.cshtml"
  
    ViewData["Title"] = "Currency";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var modeldata = Model;
    var selectList = new SelectList(
    new List<SelectListItem>
    {
                new SelectListItem {Text = "US Dollor", Value = "USD"},
                new SelectListItem {Text = "Euro", Value = "Euro"},
                new SelectListItem {Text = "British Pound", Value = "BPD"},
                new SelectListItem {Text = "Aus Dollor", Value = "AUD"},
            }, "Value", "Text");

#line default
#line hidden
            BeginContext(543, 103, true);
            WriteLiteral("<h2>Api</h2>\r\n<div class=\"sidenav\">\r\n    <ul class=\"sidemenu\">\r\n        <li><button class=\"buttonblock\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 646, "\"", 714, 3);
            WriteAttributeValue("", 656, "location.href=\'", 656, 15, true);
#line 18 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Currency.cshtml"
WriteAttributeValue("", 671, Url.Action("Dictionary", "ApiController"), 671, 42, false);

#line default
#line hidden
            WriteAttributeValue("", 713, "\'", 713, 1, true);
            EndWriteAttribute();
            BeginContext(715, 66, true);
            WriteLiteral(">Dictionary</button></li>\r\n        <li><button class=\"buttonblock\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 781, "\"", 847, 3);
            WriteAttributeValue("", 791, "location.href=\'", 791, 15, true);
#line 19 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Currency.cshtml"
WriteAttributeValue("", 806, Url.Action("Currency", "ApiController"), 806, 40, false);

#line default
#line hidden
            WriteAttributeValue("", 846, "\'", 846, 1, true);
            EndWriteAttribute();
            BeginContext(848, 78, true);
            WriteLiteral(">Currency</button></li>\r\n        <li><button class=\"buttonblock\" type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 926, "\"", 990, 3);
            WriteAttributeValue("", 936, "location.href=\'", 936, 15, true);
#line 20 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Currency.cshtml"
WriteAttributeValue("", 951, Url.Action("Travel", "ApiController"), 951, 38, false);

#line default
#line hidden
            WriteAttributeValue("", 989, "\'", 989, 1, true);
            EndWriteAttribute();
            BeginContext(991, 76, true);
            WriteLiteral(">Travel</button></li>\r\n        <li><button class=\"buttonblock\" type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1067, "\"", 1132, 3);
            WriteAttributeValue("", 1077, "location.href=\'", 1077, 15, true);
#line 21 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Currency.cshtml"
WriteAttributeValue("", 1092, Url.Action("NewsApi", "ApiController"), 1092, 39, false);

#line default
#line hidden
            WriteAttributeValue("", 1131, "\'", 1131, 1, true);
            EndWriteAttribute();
            BeginContext(1133, 290, true);
            WriteLiteral(@">News</button></li>
        <li><button class=""buttonblock"" onclick=""showPremResults()"">Results</button></li>
    </ul>
</div>
<div class=""textbox"" id=""CurrencyTextBox"">
    <h3 class=""centreheader"" id=""CurrencyApi""><u>Currency</u></h3>
    <br />
    <div id=""divdisplayCurrency"">
");
            EndContext();
#line 29 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Currency.cshtml"
         using (Html.BeginForm("CurrencyApi", "Api", FormMethod.Post))
        {

#line default
#line hidden
            BeginContext(1506, 63, true);
            WriteLiteral("            <div>\r\n                <span>\r\n                    ");
            EndContext();
            BeginContext(1570, 124, false);
#line 33 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Currency.cshtml"
               Write(Html.DropDownListFor(m => m.CurrencyToConvert,
                        selectList,
                        "Convert From"));

#line default
#line hidden
            EndContext();
            BeginContext(1694, 24, true);
            WriteLiteral("\r\n\r\n                    ");
            EndContext();
            BeginContext(1719, 122, false);
#line 37 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Currency.cshtml"
               Write(Html.DropDownListFor(m => m.CurrencyConverted,
                        selectList,
                        "Convert To"));

#line default
#line hidden
            EndContext();
            BeginContext(1841, 24, true);
            WriteLiteral("\r\n\r\n                    ");
            EndContext();
            BeginContext(1866, 38, false);
#line 41 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Currency.cshtml"
               Write(Html.LabelFor(m => m.AmmountToConvert));

#line default
#line hidden
            EndContext();
            BeginContext(1904, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1927, 40, false);
#line 42 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Currency.cshtml"
               Write(Html.TextBoxFor(m => m.AmmountToConvert));

#line default
#line hidden
            EndContext();
            BeginContext(1967, 111, true);
            WriteLiteral("\r\n\r\n                    <input type=\"submit\" value=\"Currency\" />\r\n                </span>\r\n            </div>\r\n");
            EndContext();
#line 47 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Currency.cshtml"
        }

#line default
#line hidden
            BeginContext(2089, 389, true);
            WriteLiteral(@"    </div>
</div>
<script>
    $(document).ready(function () {
        document.getElementById(""CurrencyTextBox"").style.display = ""block"";
        document.getElementById(""DictionaryTextBox"").style.display = ""none"";
        document.getElementById(""TravelTextBox"").style.display = ""none"";
        document.getElementById(""NewsTextBox"").style.display = ""none"";
    })
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CheckAPIModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
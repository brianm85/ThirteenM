#pragma checksum "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Currency.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a63475a9d34327a16a9a268bd1b1e6074a1e15c"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a63475a9d34327a16a9a268bd1b1e6074a1e15c", @"/Views/Api/Currency.cshtml")]
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
        new SelectListItem {Text = "Euro", Value = "EUR"},
        new SelectListItem {Text = "British Pound", Value = "GBP"},
        new SelectListItem {Text = "Aus Dollor", Value = "AUD"},
        new SelectListItem {Text = "Irish Punt", Value = "IEP"},
    }, "Value", "Text");

#line default
#line hidden
            BeginContext(568, 103, true);
            WriteLiteral("<h2>Api</h2>\r\n<div class=\"sidenav\">\r\n    <ul class=\"sidemenu\">\r\n        <li><button class=\"buttonblock\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 671, "\"", 739, 3);
            WriteAttributeValue("", 681, "location.href=\'", 681, 15, true);
#line 19 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Currency.cshtml"
WriteAttributeValue("", 696, Url.Action("Dictionary", "ApiController"), 696, 42, false);

#line default
#line hidden
            WriteAttributeValue("", 738, "\'", 738, 1, true);
            EndWriteAttribute();
            BeginContext(740, 66, true);
            WriteLiteral(">Dictionary</button></li>\r\n        <li><button class=\"buttonblock\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 806, "\"", 872, 3);
            WriteAttributeValue("", 816, "location.href=\'", 816, 15, true);
#line 20 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Currency.cshtml"
WriteAttributeValue("", 831, Url.Action("Currency", "ApiController"), 831, 40, false);

#line default
#line hidden
            WriteAttributeValue("", 871, "\'", 871, 1, true);
            EndWriteAttribute();
            BeginContext(873, 78, true);
            WriteLiteral(">Currency</button></li>\r\n        <li><button class=\"buttonblock\" type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 951, "\"", 1020, 3);
            WriteAttributeValue("", 961, "location.href=\'", 961, 15, true);
#line 21 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Currency.cshtml"
WriteAttributeValue("", 976, Url.Action("BusStopInfo", "ApiController"), 976, 43, false);

#line default
#line hidden
            WriteAttributeValue("", 1019, "\'", 1019, 1, true);
            EndWriteAttribute();
            BeginContext(1021, 83, true);
            WriteLiteral(">Bus Stop Info</button></li>\r\n        <li><button class=\"buttonblock\" type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1104, "\"", 1172, 3);
            WriteAttributeValue("", 1114, "location.href=\'", 1114, 15, true);
#line 22 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Currency.cshtml"
WriteAttributeValue("", 1129, Url.Action("TrainTimes", "ApiController"), 1129, 42, false);

#line default
#line hidden
            WriteAttributeValue("", 1171, "\'", 1171, 1, true);
            EndWriteAttribute();
            BeginContext(1173, 81, true);
            WriteLiteral(">Train Times</button></li>\r\n        <li><button class=\"buttonblock\" type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1254, "\"", 1319, 3);
            WriteAttributeValue("", 1264, "location.href=\'", 1264, 15, true);
#line 23 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Currency.cshtml"
WriteAttributeValue("", 1279, Url.Action("NewsApi", "ApiController"), 1279, 39, false);

#line default
#line hidden
            WriteAttributeValue("", 1318, "\'", 1318, 1, true);
            EndWriteAttribute();
            BeginContext(1320, 290, true);
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
#line 31 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Currency.cshtml"
         using (Html.BeginForm("CurrencyApi", "Api", FormMethod.Post))
        {

#line default
#line hidden
            BeginContext(1693, 63, true);
            WriteLiteral("            <div>\r\n                <span>\r\n                    ");
            EndContext();
            BeginContext(1757, 119, false);
#line 35 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Currency.cshtml"
               Write(Html.DropDownListFor(m => m.CurrencyFrom,
                        selectList,
                        "Convert From"));

#line default
#line hidden
            EndContext();
            BeginContext(1876, 24, true);
            WriteLiteral("\r\n\r\n                    ");
            EndContext();
            BeginContext(1901, 115, false);
#line 39 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Currency.cshtml"
               Write(Html.DropDownListFor(m => m.CurrencyTo,
                        selectList,
                        "Convert To"));

#line default
#line hidden
            EndContext();
            BeginContext(2016, 24, true);
            WriteLiteral("\r\n\r\n                    ");
            EndContext();
            BeginContext(2041, 38, false);
#line 43 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Currency.cshtml"
               Write(Html.LabelFor(m => m.AmmountToConvert));

#line default
#line hidden
            EndContext();
            BeginContext(2079, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(2102, 40, false);
#line 44 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Currency.cshtml"
               Write(Html.TextBoxFor(m => m.AmmountToConvert));

#line default
#line hidden
            EndContext();
            BeginContext(2142, 111, true);
            WriteLiteral("\r\n\r\n                    <input type=\"submit\" value=\"Currency\" />\r\n                </span>\r\n            </div>\r\n");
            EndContext();
#line 49 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Currency.cshtml"
        }

#line default
#line hidden
            BeginContext(2264, 389, true);
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

#pragma checksum "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Api.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac391b706578c3870ab7ebcffaecf28b9eeec141"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Api_Api), @"mvc.1.0.view", @"/Views/Api/Api.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Api/Api.cshtml", typeof(AspNetCore.Views_Api_Api))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac391b706578c3870ab7ebcffaecf28b9eeec141", @"/Views/Api/Api.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31fa6dc54be645cc22010954bb62d9325f200b69", @"/Views/_ViewImports.cshtml")]
    public class Views_Api_Api : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CheckAPIModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Api.cshtml"
  
    ViewData["Title"] = "Api";
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
            BeginContext(483, 103, true);
            WriteLiteral("<h2>Api</h2>\r\n<div class=\"sidenav\">\r\n    <ul class=\"sidemenu\">\r\n        <li><button class=\"buttonblock\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 586, "\"", 654, 3);
            WriteAttributeValue("", 596, "location.href=\'", 596, 15, true);
#line 17 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Api.cshtml"
WriteAttributeValue("", 611, Url.Action("Dictionary", "ApiController"), 611, 42, false);

#line default
#line hidden
            WriteAttributeValue("", 653, "\'", 653, 1, true);
            EndWriteAttribute();
            BeginContext(655, 66, true);
            WriteLiteral(">Dictionary</button></li>\r\n        <li><button class=\"buttonblock\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 721, "\"", 787, 3);
            WriteAttributeValue("", 731, "location.href=\'", 731, 15, true);
#line 18 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Api.cshtml"
WriteAttributeValue("", 746, Url.Action("Currency", "ApiController"), 746, 40, false);

#line default
#line hidden
            WriteAttributeValue("", 786, "\'", 786, 1, true);
            EndWriteAttribute();
            BeginContext(788, 78, true);
            WriteLiteral(">Currency</button></li>\r\n        <li><button class=\"buttonblock\" type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 866, "\"", 930, 3);
            WriteAttributeValue("", 876, "location.href=\'", 876, 15, true);
#line 19 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Api.cshtml"
WriteAttributeValue("", 891, Url.Action("Travel", "ApiController"), 891, 38, false);

#line default
#line hidden
            WriteAttributeValue("", 929, "\'", 929, 1, true);
            EndWriteAttribute();
            BeginContext(931, 76, true);
            WriteLiteral(">Travel</button></li>\r\n        <li><button class=\"buttonblock\" type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1007, "\"", 1072, 3);
            WriteAttributeValue("", 1017, "location.href=\'", 1017, 15, true);
#line 20 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Api.cshtml"
WriteAttributeValue("", 1032, Url.Action("NewsApi", "ApiController"), 1032, 39, false);

#line default
#line hidden
            WriteAttributeValue("", 1071, "\'", 1071, 1, true);
            EndWriteAttribute();
            BeginContext(1073, 313, true);
            WriteLiteral(@">News</button></li>
        <li><button class=""buttonblock"" onclick=""showPremResults()"">Results</button></li>
    </ul>
</div>
<div class=""textbox"" id=""DictionaryTextBox"" display=""none"">
    <h3 class=""centreheader"" id=""DictionaryApi""><u>Dictionary</u></h3>
    <br />
    <div id=""divdisplayDictionary"">
");
            EndContext();
#line 28 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Api.cshtml"
         using (Html.BeginForm("DictionaryApi", "Api", FormMethod.Post))
        {

#line default
#line hidden
            BeginContext(1471, 41, true);
            WriteLiteral("            <table>\r\n                <tr>");
            EndContext();
            BeginContext(1513, 34, false);
#line 31 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Api.cshtml"
               Write(Html.LabelFor(m => m.WordToSearch));

#line default
#line hidden
            EndContext();
            BeginContext(1547, 27, true);
            WriteLiteral("</tr>\r\n                <tr>");
            EndContext();
            BeginContext(1575, 36, false);
#line 32 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Api.cshtml"
               Write(Html.TextBoxFor(m => m.WordToSearch));

#line default
#line hidden
            EndContext();
            BeginContext(1611, 29, true);
            WriteLiteral("</tr>\r\n            </table>\r\n");
            EndContext();
            BeginContext(1642, 52, true);
            WriteLiteral("            <input type=\"submit\" value=\"Search\" />\r\n");
            EndContext();
#line 36 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Api.cshtml"
        }

#line default
#line hidden
            BeginContext(1705, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 37 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Api.cshtml"
         if (modeldata?.DictionaryData != null)
        {
            //call the same load as side menu from JS

#line default
#line hidden
            BeginContext(1820, 16, true);
            WriteLiteral("            <h3>");
            EndContext();
            BeginContext(1837, 28, false);
#line 40 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Api.cshtml"
           Write(Model.DictionaryData.Lexical);

#line default
#line hidden
            EndContext();
            BeginContext(1865, 7, true);
            WriteLiteral("</h3>\r\n");
            EndContext();
            BeginContext(1874, 50, true);
            WriteLiteral("            <ul style=\"list-style-type:circle;\">\r\n");
            EndContext();
#line 43 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Api.cshtml"
                 foreach (var item in modeldata.DictionaryData.Definitions)
                {

#line default
#line hidden
            BeginContext(2020, 24, true);
            WriteLiteral("                    <li>");
            EndContext();
            BeginContext(2045, 4, false);
#line 45 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Api.cshtml"
                   Write(item);

#line default
#line hidden
            EndContext();
            BeginContext(2049, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 46 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Api.cshtml"
                }

#line default
#line hidden
            BeginContext(2075, 67, true);
            WriteLiteral("            </ul>\r\n            <script>showDictionary();</script>\r\n");
            EndContext();
#line 49 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Api.cshtml"
        }

#line default
#line hidden
            BeginContext(2153, 389, true);
            WriteLiteral(@"    </div>
</div>


<script>
    $(document).ready(function () {
        document.getElementById(""CurrencyTextBox"").style.display = ""none"";
        document.getElementById(""DictionaryTextBox"").style.display = ""block"";
        document.getElementById(""TravelTextBox"").style.display = ""none"";
        document.getElementById(""NewsTextBox"").style.display = ""none"";
    })
</script>");
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

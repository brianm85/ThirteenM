#pragma checksum "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Dictionary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ad84416611aa2962779a2162391ce5a8633545a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Api_Dictionary), @"mvc.1.0.view", @"/Views/Api/Dictionary.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Api/Dictionary.cshtml", typeof(AspNetCore.Views_Api_Dictionary))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ad84416611aa2962779a2162391ce5a8633545a", @"/Views/Api/Dictionary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31fa6dc54be645cc22010954bb62d9325f200b69", @"/Views/_ViewImports.cshtml")]
    public class Views_Api_Dictionary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CheckAPIModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Dictionary.cshtml"
  
    ViewData["Title"] = "Dictionary";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var modeldata = Model;

#line default
#line hidden
            BeginContext(143, 103, true);
            WriteLiteral("<h2>Api</h2>\r\n<div class=\"sidenav\">\r\n    <ul class=\"sidemenu\">\r\n        <li><button class=\"buttonblock\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 246, "\"", 314, 3);
            WriteAttributeValue("", 256, "location.href=\'", 256, 15, true);
#line 10 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Dictionary.cshtml"
WriteAttributeValue("", 271, Url.Action("Dictionary", "ApiController"), 271, 42, false);

#line default
#line hidden
            WriteAttributeValue("", 313, "\'", 313, 1, true);
            EndWriteAttribute();
            BeginContext(315, 66, true);
            WriteLiteral(">Dictionary</button></li>\r\n        <li><button class=\"buttonblock\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 381, "\"", 447, 3);
            WriteAttributeValue("", 391, "location.href=\'", 391, 15, true);
#line 11 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Dictionary.cshtml"
WriteAttributeValue("", 406, Url.Action("Currency", "ApiController"), 406, 40, false);

#line default
#line hidden
            WriteAttributeValue("", 446, "\'", 446, 1, true);
            EndWriteAttribute();
            BeginContext(448, 78, true);
            WriteLiteral(">Currency</button></li>\r\n        <li><button class=\"buttonblock\" type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 526, "\"", 595, 3);
            WriteAttributeValue("", 536, "location.href=\'", 536, 15, true);
#line 12 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Dictionary.cshtml"
WriteAttributeValue("", 551, Url.Action("BusStopInfo", "ApiController"), 551, 43, false);

#line default
#line hidden
            WriteAttributeValue("", 594, "\'", 594, 1, true);
            EndWriteAttribute();
            BeginContext(596, 83, true);
            WriteLiteral(">Bus Stop Info</button></li>\r\n        <li><button class=\"buttonblock\" type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 679, "\"", 747, 3);
            WriteAttributeValue("", 689, "location.href=\'", 689, 15, true);
#line 13 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Dictionary.cshtml"
WriteAttributeValue("", 704, Url.Action("TrainTimes", "ApiController"), 704, 42, false);

#line default
#line hidden
            WriteAttributeValue("", 746, "\'", 746, 1, true);
            EndWriteAttribute();
            BeginContext(748, 81, true);
            WriteLiteral(">Train Times</button></li>\r\n        <li><button class=\"buttonblock\" type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 829, "\"", 894, 3);
            WriteAttributeValue("", 839, "location.href=\'", 839, 15, true);
#line 14 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Dictionary.cshtml"
WriteAttributeValue("", 854, Url.Action("NewsApi", "ApiController"), 854, 39, false);

#line default
#line hidden
            WriteAttributeValue("", 893, "\'", 893, 1, true);
            EndWriteAttribute();
            BeginContext(895, 313, true);
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
#line 22 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Dictionary.cshtml"
         using (Html.BeginForm("DictionaryApi", "Api", FormMethod.Post))
        {

#line default
#line hidden
            BeginContext(1293, 81, true);
            WriteLiteral("            <div class=\"labeltext\">\r\n                <span>\r\n                    ");
            EndContext();
            BeginContext(1375, 34, false);
#line 26 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Dictionary.cshtml"
               Write(Html.LabelFor(m => m.WordToSearch));

#line default
#line hidden
            EndContext();
            BeginContext(1409, 71, true);
            WriteLiteral("\r\n                </span>\r\n                <span>\r\n                    ");
            EndContext();
            BeginContext(1481, 74, false);
#line 29 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Dictionary.cshtml"
               Write(Html.TextBoxFor(m => m.WordToSearch, new { @style = "text-align:center" }));

#line default
#line hidden
            EndContext();
            BeginContext(1555, 157, true);
            WriteLiteral("\r\n            </span>\r\n            <span>\r\n                <input class=\"selectbutton\" type=\"submit\" value=\"Search\" />\r\n            </span>\r\n        </div>\r\n");
            EndContext();
#line 35 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Dictionary.cshtml"
        }

#line default
#line hidden
            BeginContext(1723, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 36 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Dictionary.cshtml"
         if (modeldata?.DictionaryData != null)
        {

#line default
#line hidden
            BeginContext(1783, 20, true);
            WriteLiteral("            <h3><em>");
            EndContext();
            BeginContext(1804, 28, false);
#line 38 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Dictionary.cshtml"
               Write(Model.DictionaryData.Lexical);

#line default
#line hidden
            EndContext();
            BeginContext(1832, 62, true);
            WriteLiteral("</em></h3>\r\n            <ul style=\"list-style-type:circle;\">\r\n");
            EndContext();
#line 40 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Dictionary.cshtml"
                 foreach (var item in modeldata.DictionaryData.Definitions)
                {

#line default
#line hidden
            BeginContext(1990, 27, true);
            WriteLiteral("                    <li><b>");
            EndContext();
            BeginContext(2018, 4, false);
#line 42 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Dictionary.cshtml"
                      Write(item);

#line default
#line hidden
            EndContext();
            BeginContext(2022, 11, true);
            WriteLiteral("</b></li>\r\n");
            EndContext();
#line 43 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Dictionary.cshtml"
                }

#line default
#line hidden
            BeginContext(2052, 19, true);
            WriteLiteral("            </ul>\r\n");
            EndContext();
#line 45 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\Dictionary.cshtml"
        }

#line default
#line hidden
            BeginContext(2082, 389, true);
            WriteLiteral(@"    </div>
</div>
<script>
    $(document).ready(function () {
        document.getElementById(""CurrencyTextBox"").style.display = ""none"";
        document.getElementById(""DictionaryTextBox"").style.display = ""block"";
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

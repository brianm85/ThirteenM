#pragma checksum "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\BusStopInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aad37a0edd23c85961a6e033b1bb45242798a4e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Api_BusStopInfo), @"mvc.1.0.view", @"/Views/Api/BusStopInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Api/BusStopInfo.cshtml", typeof(AspNetCore.Views_Api_BusStopInfo))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aad37a0edd23c85961a6e033b1bb45242798a4e0", @"/Views/Api/BusStopInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31fa6dc54be645cc22010954bb62d9325f200b69", @"/Views/_ViewImports.cshtml")]
    public class Views_Api_BusStopInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CheckAPIModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\BusStopInfo.cshtml"
  
    ViewData["Title"] = "Travel";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var modeldata = Model;

#line default
#line hidden
            BeginContext(139, 103, true);
            WriteLiteral("<h2>Api</h2>\r\n<div class=\"sidenav\">\r\n    <ul class=\"sidemenu\">\r\n        <li><button class=\"buttonblock\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 242, "\"", 310, 3);
            WriteAttributeValue("", 252, "location.href=\'", 252, 15, true);
#line 10 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\BusStopInfo.cshtml"
WriteAttributeValue("", 267, Url.Action("Dictionary", "ApiController"), 267, 42, false);

#line default
#line hidden
            WriteAttributeValue("", 309, "\'", 309, 1, true);
            EndWriteAttribute();
            BeginContext(311, 66, true);
            WriteLiteral(">Dictionary</button></li>\r\n        <li><button class=\"buttonblock\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 377, "\"", 443, 3);
            WriteAttributeValue("", 387, "location.href=\'", 387, 15, true);
#line 11 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\BusStopInfo.cshtml"
WriteAttributeValue("", 402, Url.Action("Currency", "ApiController"), 402, 40, false);

#line default
#line hidden
            WriteAttributeValue("", 442, "\'", 442, 1, true);
            EndWriteAttribute();
            BeginContext(444, 78, true);
            WriteLiteral(">Currency</button></li>\r\n        <li><button class=\"buttonblock\" type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 522, "\"", 591, 3);
            WriteAttributeValue("", 532, "location.href=\'", 532, 15, true);
#line 12 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\BusStopInfo.cshtml"
WriteAttributeValue("", 547, Url.Action("BusStopInfo", "ApiController"), 547, 43, false);

#line default
#line hidden
            WriteAttributeValue("", 590, "\'", 590, 1, true);
            EndWriteAttribute();
            BeginContext(592, 83, true);
            WriteLiteral(">Bus Stop Info</button></li>\r\n        <li><button class=\"buttonblock\" type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 675, "\"", 743, 3);
            WriteAttributeValue("", 685, "location.href=\'", 685, 15, true);
#line 13 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\BusStopInfo.cshtml"
WriteAttributeValue("", 700, Url.Action("TrainTimes", "ApiController"), 700, 42, false);

#line default
#line hidden
            WriteAttributeValue("", 742, "\'", 742, 1, true);
            EndWriteAttribute();
            BeginContext(744, 81, true);
            WriteLiteral(">Train Times</button></li>\r\n        <li><button class=\"buttonblock\" type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 825, "\"", 890, 3);
            WriteAttributeValue("", 835, "location.href=\'", 835, 15, true);
#line 14 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\BusStopInfo.cshtml"
WriteAttributeValue("", 850, Url.Action("NewsApi", "ApiController"), 850, 39, false);

#line default
#line hidden
            WriteAttributeValue("", 889, "\'", 889, 1, true);
            EndWriteAttribute();
            BeginContext(891, 285, true);
            WriteLiteral(@">News</button></li>
        <li><button class=""buttonblock"" onclick=""showPremResults()"">Results</button></li>
    </ul>
</div>
<div class=""textbox"" id=""BusTravelTextBox"">
    <h3 class=""centreheader"" id=""TravelApi""><u>Travel</u></h3>
    <br />
    <div id=""divdisplayTravel"">
");
            EndContext();
#line 22 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\BusStopInfo.cshtml"
         using (Html.BeginForm("BusStopInfoApi", "Api", FormMethod.Post))
        {
            

#line default
#line hidden
            BeginContext(1275, 32, false);
#line 24 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\BusStopInfo.cshtml"
       Write(Html.LabelFor(m => m.BusStation));

#line default
#line hidden
            EndContext();
            BeginContext(1322, 34, false);
#line 25 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\BusStopInfo.cshtml"
       Write(Html.TextBoxFor(m => m.BusStation));

#line default
#line hidden
            EndContext();
            BeginContext(1360, 52, true);
            WriteLiteral("            <input type=\"submit\" value=\"Travel\" />\r\n");
            EndContext();
#line 28 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\BusStopInfo.cshtml"
        }

#line default
#line hidden
            BeginContext(1423, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 29 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\BusStopInfo.cshtml"
         if (modeldata?.BusData != null)
        {

#line default
#line hidden
            BeginContext(1476, 396, true);
            WriteLiteral(@"            <br />
            <table style=""width:100%"">
                <thead>
                    <tr class=""w3-light-grey"">
                        <th>Full Name</th>
                        <th>Longitude</th>
                        <th>Latitude</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>");
            EndContext();
            BeginContext(1873, 22, false);
#line 42 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\BusStopInfo.cshtml"
                       Write(Model.BusData.Fullname);

#line default
#line hidden
            EndContext();
            BeginContext(1895, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1931, 23, false);
#line 43 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\BusStopInfo.cshtml"
                       Write(Model.BusData.Longitude);

#line default
#line hidden
            EndContext();
            BeginContext(1954, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1990, 22, false);
#line 44 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\BusStopInfo.cshtml"
                       Write(Model.BusData.Latitude);

#line default
#line hidden
            EndContext();
            BeginContext(2012, 431, true);
            WriteLiteral(@"</td>
                    </tr>
                </tbody>
            </table>
            <br />
            <table style=""width:100%"">
                <thead>
                    <tr class=""w3-light-grey"">
                        <th>Couriour</th>
                        <th>Routes</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>");
            EndContext();
            BeginContext(2444, 18, false);
#line 58 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\BusStopInfo.cshtml"
                       Write(Model.BusData.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2462, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 59 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\BusStopInfo.cshtml"
                         foreach (var item in Model.BusData.RouteNumbers)
                        {

#line default
#line hidden
            BeginContext(2571, 32, true);
            WriteLiteral("                            <td>");
            EndContext();
            BeginContext(2604, 4, false);
#line 61 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\BusStopInfo.cshtml"
                           Write(item);

#line default
#line hidden
            EndContext();
            BeginContext(2608, 8, true);
            WriteLiteral(",</td>\r\n");
            EndContext();
#line 62 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\BusStopInfo.cshtml"
                        }

#line default
#line hidden
            BeginContext(2643, 75, true);
            WriteLiteral("                    </tr>\r\n                </tbody>\r\n            </table>\r\n");
            EndContext();
#line 66 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Api\BusStopInfo.cshtml"
        }

#line default
#line hidden
            BeginContext(2729, 511, true);
            WriteLiteral(@"        <script>showTravel();</script>
    </div>
</div>
<script>
    $(document).ready(function () {
        document.getElementById(""BusTravelTextBox"").style.display = ""block"";
        document.getElementById(""TrainTravelTextBox"").style.display = ""none"";
        document.getElementById(""CurrencyTextBox"").style.display = ""none"";
        document.getElementById(""DictionaryTextBox"").style.display = ""none"";
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
#pragma checksum "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Shared\_DictionaryApi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f247cf6fbab7ef59861439053e7298226f9be59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__DictionaryApi), @"mvc.1.0.view", @"/Views/Shared/_DictionaryApi.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_DictionaryApi.cshtml", typeof(AspNetCore.Views_Shared__DictionaryApi))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f247cf6fbab7ef59861439053e7298226f9be59", @"/Views/Shared/_DictionaryApi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31fa6dc54be645cc22010954bb62d9325f200b69", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__DictionaryApi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CheckAPIModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 144, true);
            WriteLiteral("<div class=\"textbox\" id=\"DictionaryApi\">\r\n    <h3 class=\"centreheader\"><u>Dictionary</u></h3>\r\n    <br />\r\n    <div id=\"divdisplayDictionary\">\r\n");
            EndContext();
#line 6 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Shared\_DictionaryApi.cshtml"
         using (Html.BeginForm("DictionaryApi", "Api", FormMethod.Post))
        {
            

#line default
#line hidden
            BeginContext(264, 34, false);
#line 8 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Shared\_DictionaryApi.cshtml"
       Write(Html.LabelFor(m => m.WordToSearch));

#line default
#line hidden
            EndContext();
            BeginContext(313, 36, false);
#line 9 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Shared\_DictionaryApi.cshtml"
       Write(Html.TextBoxFor(m => m.WordToSearch));

#line default
#line hidden
            EndContext();
            BeginContext(353, 56, true);
            WriteLiteral("            <input type=\"submit\" value=\"Dictionary\" />\r\n");
            EndContext();
#line 12 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Shared\_DictionaryApi.cshtml"
        }

#line default
#line hidden
            BeginContext(420, 20, true);
            WriteLiteral("    </div>\r\n</div>\r\n");
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

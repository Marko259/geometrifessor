#pragma checksum "C:\Users\Markus\Documents\GitHub\geometrifessor\Pages\Beregnere.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63060c6f859dece2b4b89b07d4c961c323fae4c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(geometrifessor.Pages.Pages_Beregnere), @"mvc.1.0.razor-page", @"/Pages/Beregnere.cshtml")]
namespace geometrifessor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Markus\Documents\GitHub\geometrifessor\Pages\_ViewImports.cshtml"
using geometrifessor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Markus\Documents\GitHub\geometrifessor\Pages\Beregnere.cshtml"
using geometrifessor.Components;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63060c6f859dece2b4b89b07d4c961c323fae4c6", @"/Pages/Beregnere.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa452e34bcd8c0824963f3f5634e41162e200dda", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Beregnere : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Markus\Documents\GitHub\geometrifessor\Pages\Beregnere.cshtml"
  
    ViewData["Title"] = "Beregnere";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 7 "C:\Users\Markus\Documents\GitHub\geometrifessor\Pages\Beregnere.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p>Vælg den beregner du gerne vil bruge.</p>\r\n<br />\r\n\r\n");
#nullable restore
#line 12 "C:\Users\Markus\Documents\GitHub\geometrifessor\Pages\Beregnere.cshtml"
Write(await Html.RenderComponentAsync<Beregnerliste>(RenderMode.ServerPrerendered));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<script src=\"_framework/blazor.server.js\"></script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BeregnModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BeregnModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BeregnModel>)PageContext?.ViewData;
        public BeregnModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
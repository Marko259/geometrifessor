#pragma checksum "C:\Users\Markus\Documents\GitHub\geometrifessor\Pages\Emne.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1be29a3c5d44b31c7cfb8bb43f175be017fa028"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(geometrifessor.Pages.Pages_Emne), @"mvc.1.0.razor-page", @"/Pages/Emne.cshtml")]
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
#line 2 "C:\Users\Markus\Documents\GitHub\geometrifessor\Pages\Emne.cshtml"
using geometrifessor.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Markus\Documents\GitHub\geometrifessor\Pages\Emne.cshtml"
using geometrifessor.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Markus\Documents\GitHub\geometrifessor\Pages\Emne.cshtml"
using geometrifessor.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{Id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1be29a3c5d44b31c7cfb8bb43f175be017fa028", @"/Pages/Emne.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa452e34bcd8c0824963f3f5634e41162e200dda", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Emne : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Beregnere", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 7 "C:\Users\Markus\Documents\GitHub\geometrifessor\Pages\Emne.cshtml"
  
    ViewData["Title"] = "Emne";
    var value = RouteData.Values["Id"].ToString();

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Markus\Documents\GitHub\geometrifessor\Pages\Emne.cshtml"
 foreach (var emne in EmneService.GetEmner())
{
    if (emne.Id == value) 
    {  

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>");
#nullable restore
#line 15 "C:\Users\Markus\Documents\GitHub\geometrifessor\Pages\Emne.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 15 "C:\Users\Markus\Documents\GitHub\geometrifessor\Pages\Emne.cshtml"
                            Write(emne.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1><br/>\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 523, "\"", 540, 1);
#nullable restore
#line 19 "C:\Users\Markus\Documents\GitHub\geometrifessor\Pages\Emne.cshtml"
WriteAttributeValue("", 529, emne.Image, 529, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 559, "\"", 565, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <div>");
#nullable restore
#line 20 "C:\Users\Markus\Documents\GitHub\geometrifessor\Pages\Emne.cshtml"
                     Write(emne.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div><br>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1be29a3c5d44b31c7cfb8bb43f175be017fa0285657", async() => {
                WriteLiteral("Prøv vores ");
#nullable restore
#line 21 "C:\Users\Markus\Documents\GitHub\geometrifessor\Pages\Emne.cshtml"
                                                   Write(emne.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(" beregner her");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 25 "C:\Users\Markus\Documents\GitHub\geometrifessor\Pages\Emne.cshtml"
    }
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public JsonEmneService EmneService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmneModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EmneModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EmneModel>)PageContext?.ViewData;
        public EmneModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

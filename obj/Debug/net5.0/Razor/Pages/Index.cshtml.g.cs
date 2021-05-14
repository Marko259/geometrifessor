#pragma checksum "C:\Users\Markus\Documents\GitHub\geometrifessor\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74ec73e4500f1f4b1d772ae083d003e443ac8f2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(geometrifessor.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74ec73e4500f1f4b1d772ae083d003e443ac8f2d", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa452e34bcd8c0824963f3f5634e41162e200dda", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Markus\Documents\GitHub\geometrifessor\Pages\Index.cshtml"
  
    ViewData["Title"] = "Forside";   // Her der defineres side titlen hvilket bruges i _Layout.cshtml

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Her bruges bootstrap bibliotekets container system -->
<div class=""container""> 
    <!-- Dette bruges til formattering af forside teksten -->
    <div class=""text-center"">
        <h1 class=""display-4"">Velkommen til Geometrifessor</h1> 
        <p>Lær Geometri med Geometrifessor.</p>
    </div>
</div>
<!-- Der slutter bootstrap container klassen -->

<!-- Her laves slideshow vha. bootstrap -->
<div id=""carouselIndicators"" class=""carousel slide"" data-ride=""carousel"">
    <ol class=""carousel-indicators text-dark""> <!-- slideshow indikatorer defineres og de får en mørk tekst vha. text-dark som også er bootstrap derudover står indikatorne i en 'ordered list' -->
        <!-- De forskellige list tags får deres id som de er forbundet med og hvilket slide de henholdsvis skal vise. Klassen active er det slide som vises først -->
        <li data-target=""#carouselIndicators"" data-slide-to=""0"" class=""active""></li>
        <li data-target=""#carouselIndicators"" data-slide-to=""1""></li>
        <li d");
            WriteLiteral(@"ata-target=""#carouselIndicators"" data-slide-to=""2""></li>
    </ol>
    <div class=""carousel-inner"">
        <div class=""carousel-item img-fluid active""> <!-- Der defineres at dette er et slide og det har klassen 'active' hvilket gør det er det første slide der vises -->
            <img src=""img/retvinklet trekant.png"" class=""img-fluid"" alt=""Responsive image"" style=""height: 50rem"" width=""1280px""> <!-- billedet vælges og højde, bredde defineres -->
            <div class=""carousel-caption d-none d-md-block text-dark""> <!-- tekst til billedet vælges og gives en mærk farve til teksten -->
                <h3>Dette er en retvinklet trekant</h3>
            </div>
        </div>
        <div class=""carousel-item img-fluid""> <!-- her sker det samme som oven for -->
            <img src=""img/ligesidet-trekant.png"" class=""img-fluid"" alt=""Responsive image"" style=""height: 50rem"" width=""1280px"">
            <div class=""carousel-caption d-none d-md-block text-dark"">
                <h3>Dette er en ligesidet t");
            WriteLiteral(@"rekant</h3>
            </div>
        </div>
        <div class=""carousel-item img-fluid""> <!-- her sker det samme som oven for -->
            <img src=""img/ligebenet-trekant.png"" class=""img-fluid"" alt=""Responsive image"" style=""height: 50rem;"" width=""1280px"">
            <div class=""carousel-caption d-none d-md-block text-dark"">
                <h3>Dette er en ligebenet trekant</h3>
            </div>
        </div>
        <a class=""carousel-control-prev"" href=""#carouselIndicators"" role=""button"" data-slide=""prev""> <!-- Her laves den knap som vælger det tidligere slide -->
            <span aria-hidden=""true""><i class=""fas fa-arrow-left text-dark"" aria-hidden=""true""></i></span> <!-- Der bruges font-awesome til at få logoet til en pil som går mod venstre -->
            <span class=""sr-only"">Tidligere</span>
        </a>
        <a class=""carousel-control-next"" href=""#carouselIndicators"" role=""button"" data-slide=""next""> <!-- Her laves den knap som vælger det næste slide -->
            <span ar");
            WriteLiteral("ia-hidden=\"true\"><i class=\"fas fa-arrow-right text-dark\" aria-hidden=\"true\"></i></span> <!-- Der bruges font-awesome til at få logoet til en pil som går mod højre -->\r\n            <span class=\"sr-only\">Næste</span>\r\n        </a>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Markus\Documents\GitHub\geometrifessor\Components\Beregnerliste.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4aa5c9e91d90c3a7da0cac2692f7d6db0478106b"
// <auto-generated/>
#pragma warning disable 1591
namespace geometrifessor.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Markus\Documents\GitHub\geometrifessor\Components\Beregnerliste.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Markus\Documents\GitHub\geometrifessor\Components\Beregnerliste.razor"
using geometrifessor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Markus\Documents\GitHub\geometrifessor\Components\Beregnerliste.razor"
using geometrifessor.Services;

#line default
#line hidden
#nullable disable
    public partial class Beregnerliste : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.AddMarkupContent(4, @"<div class=""col-12 col-sm-3""><nav id=""navbar-beregner"" class=""navbar navbar-light bg-light""><ul class=""nav nav-pills flex-sm-column""><li class=""nav-item""><a class=""nav-link active"" href=""#retvinklet-trekanter"">Retvinklet
                            trekanter</a></li>
                    <li class=""nav-item""><a class=""nav-link"" href=""#vilkårlige-trekanter"">Vilkårlig trekanter</a></li>
                    <li class=""nav-item""><a class=""nav-link"" href=""#firkanter"">Firkanter</a></li>
                    <li class=""nav-item""><a class=""nav-link"" href=""#femkanter"">Femkanter</a></li></ul></nav></div>
        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "data-spy", "scroll");
            __builder.AddAttribute(9, "data-target", "#navbar-beregner");
            __builder.AddAttribute(10, "data-offset", "0");
            __builder.AddAttribute(11, "class", "scrollspy");
#nullable restore
#line 20 "C:\Users\Markus\Documents\GitHub\geometrifessor\Components\Beregnerliste.razor"
                 foreach (var emne in EmneService.GetEmner())
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "h1");
            __builder.AddAttribute(13, "id", 
#nullable restore
#line 22 "C:\Users\Markus\Documents\GitHub\geometrifessor\Components\Beregnerliste.razor"
                             emne.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(14, 
#nullable restore
#line 22 "C:\Users\Markus\Documents\GitHub\geometrifessor\Components\Beregnerliste.razor"
                                       emne.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 23 "C:\Users\Markus\Documents\GitHub\geometrifessor\Components\Beregnerliste.razor"
                     if (emne.Id == "retvinklet-trekanter")
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(15, "<h4>Indtast dine to værdier</h4>");
            __builder.AddMarkupContent(16, @"<form><div>linje a <input type=""number"" id=""a""></div>
                            <div>linje b <input type=""number"" id=""b""></div><br>
                            <input class=""btn btn-primary"" type=""reset"">
                            <button class=""btn btn-primary"" onclick=""beregnC()"">Beregn</button></form>
                        <p id=""cer""></p>
                        <p id=""Areal""></p>");
            __builder.AddMarkupContent(17, "<svg version=\"1.1\" x=\"0px\" y=\"0px\" viewBox=\"0 0 300 300\" width=\"300px\" height=\"300px\"><polygon id=\"retvinklettrekant\" class=\"st0\" points=\"10,10 10,100 100,100 \"></polygon></svg>");
#nullable restore
#line 40 "C:\Users\Markus\Documents\GitHub\geometrifessor\Components\Beregnerliste.razor"
                    }
                    else if (emne.Id == "vilkårlige-trekanter")
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(18, "<h2>Ligebenet trekant</h2>");
            __builder.AddMarkupContent(19, "<h4>Indtast dine værdier</h4>");
            __builder.AddMarkupContent(20, @"<form><div>linje a <input type=""number"" id=""vilkårlig-a""></div>
                            <div>linje b <input type=""number"" id=""vilkårlig-b""></div><br>
                            <input class=""btn btn-primary"" type=""reset"">
                            <button class=""btn btn-primary"" onclick=""beregnBen()"">Beregn</button></form>
                        <p id=""vilkårlig-cer""></p>
                        <p id=""Areal""></p>");
            __builder.AddMarkupContent(21, "<svg version=\"1.1\" x=\"0px\" y=\"0px\" viewBox=\"0 0 300 300\" width=\"300px\" height=\"300px\"><polygon id=\"ligebenettrekant\" class=\"st0\" points=\"50,10 10,150 100,150 \"></polygon></svg>");
            __builder.AddMarkupContent(22, "<h2>Ligesidet trekant</h2>");
            __builder.AddMarkupContent(23, "<h4>Indtast din værdi</h4>");
            __builder.AddMarkupContent(24, @"<form><div>linje a <input type=""number"" id=""ligesidet-a""></div><br>
                            <input class=""btn btn-primary"" type=""reset"">
                            <button class=""btn btn-primary"" onclick=""beregnSide()"">Beregn</button></form>
                        <p id=""ligesidet-cer""></p>
                        <p id=""Areal""></p>");
            __builder.AddMarkupContent(25, "<svg version=\"1.1\" x=\"0px\" y=\"0px\" viewBox=\"0 0 300 300\" width=\"300px\" height=\"300px\"><polygon id=\"ligesidettrekant\" class=\"st0\" points=\"50,10 10,100 100,100 \"></polygon></svg>");
#nullable restore
#line 77 "C:\Users\Markus\Documents\GitHub\geometrifessor\Components\Beregnerliste.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\Markus\Documents\GitHub\geometrifessor\Components\Beregnerliste.razor"
                     
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonEmneService EmneService { get; set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Markus\Documents\GitHub\geometrifessor\Components\Beregnerliste.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56623bdef38444209f2435308b9e76c95786d719"
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
            __builder.AddAttribute(3, "class", "container position-relative");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row h-100 mt-5");
            __builder.AddMarkupContent(6, @"<aside class=""col-md-3 bg-light"" id=""left""><div class=""mt-5 mb-3 sticky-top"" id=""side""><nav class=""nav flex-md-column flex-row justify-content-between"" id=""Scrollspy""><ul class=""nav nav-pills flex-column""><h1>Emner</h1>
                            <li class=""nav-item""><a class=""nav-link active"" href=""#retvinklet-trekanter"">Retvinklet trekanter</a></li>
                            <li class=""nav-item""><a class=""nav-link"" href=""#ligebenet-trekanter"">Ligebenet trekanter</a></li>
                            <li class=""nav-item""><a class=""nav-link"" href=""#ligesidet-trekanter"">Ligesidet trekanter</a></li></ul></nav></div></aside>
            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col py-5");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "row position-relative");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "tab-content py-3 position-relative");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "tab-pane active position-relative");
            __builder.AddAttribute(17, "id", "tab1");
            __builder.AddAttribute(18, "role", "tabpanel");
#nullable restore
#line 31 "C:\Users\Markus\Documents\GitHub\geometrifessor\Components\Beregnerliste.razor"
                                 foreach (var emne in EmneService.GetEmner())
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "id", 
#nullable restore
#line 33 "C:\Users\Markus\Documents\GitHub\geometrifessor\Components\Beregnerliste.razor"
                                              emne.Id

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(21, "h1");
            __builder.AddContent(22, 
#nullable restore
#line 34 "C:\Users\Markus\Documents\GitHub\geometrifessor\Components\Beregnerliste.razor"
                                             emne.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "<br>");
#nullable restore
#line 35 "C:\Users\Markus\Documents\GitHub\geometrifessor\Components\Beregnerliste.razor"
                                         if (emne.Id == "retvinklet-trekanter")
                                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(24, "<h4>Indtast v??rdierne</h4>");
            __builder.AddMarkupContent(25, "<div>Linje a <input type=\"number\" id=\"a\"></div>\r\n                                            ");
            __builder.AddMarkupContent(26, "<div>Linje b <input type=\"number\" id=\"b\"></div><br>\r\n                                            ");
            __builder.AddMarkupContent(27, "<button class=\"btn btn-primary\" onclick=\"beregnC()\">Beregn</button>");
            __builder.AddMarkupContent(28, "<p id=\"cer\"></p>\r\n                                            <p id=\"Areal\"></p>");
            __builder.AddMarkupContent(29, "<svg version=\"1.1\" x=\"0px\" y=\"0px\" viewBox=\"0 0 300 300\" width=\"300px\" height=\"300px\"><polygon id=\"retvinklettrekant\" class=\"st0\" points=\"10,10 10,100 100,100 \"></polygon></svg>");
#nullable restore
#line 52 "C:\Users\Markus\Documents\GitHub\geometrifessor\Components\Beregnerliste.razor"
                                        }
                                        else if (emne.Id == "ligebenet-trekanter")
                                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(30, "<h2>Ligebenet trekant</h2>");
            __builder.AddMarkupContent(31, "<h4>Indtast v??rdierne</h4>");
            __builder.AddMarkupContent(32, "<div>Linje a <input type=\"number\" id=\"vilk??rlig-a\"></div>\r\n                                            ");
            __builder.AddMarkupContent(33, "<div>Linje b <input type=\"number\" id=\"vilk??rlig-b\"></div><br>\r\n                                            ");
            __builder.AddMarkupContent(34, "<button class=\"btn btn-primary\" onclick=\"beregnBen()\">Beregn</button>\r\n                                            <p id=\"vilk??rlig-cer\"></p>\r\n                                            <p id=\"Areal\"></p>");
            __builder.AddMarkupContent(35, "<svg version=\"1.1\" x=\"0px\" y=\"0px\" viewBox=\"0 0 300 300\" width=\"300px\" height=\"300px\"><polygon id=\"ligebenettrekant\" class=\"st0\" points=\"50,10 10,150 100,150 \"></polygon></svg>");
#nullable restore
#line 70 "C:\Users\Markus\Documents\GitHub\geometrifessor\Components\Beregnerliste.razor"
                                        }
                                        else if (@emne.Id == "ligesidet-trekanter")
                                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(36, "<h2>Ligesidet trekant</h2>");
            __builder.AddMarkupContent(37, "<h4>Indtast v??rdierne</h4>");
            __builder.AddMarkupContent(38, "<div>Linje a <input type=\"number\" id=\"ligesidet-a\"></div><br>\r\n                                            ");
            __builder.AddMarkupContent(39, "<button class=\"btn btn-primary\" onclick=\"beregnSide()\">Beregn</button>\r\n                                            <p id=\"ligesidet-cer\"></p>\r\n                                            <p id=\"Areal\"></p>");
            __builder.AddMarkupContent(40, "<svg version=\"1.1\" x=\"0px\" y=\"0px\" viewBox=\"0 0 300 300\" width=\"300px\" height=\"300px\"><polygon id=\"ligesidettrekant\" class=\"st0\" points=\"50,10 10,100 100,100 \"></polygon></svg>");
#nullable restore
#line 87 "C:\Users\Markus\Documents\GitHub\geometrifessor\Components\Beregnerliste.razor"
                                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 89 "C:\Users\Markus\Documents\GitHub\geometrifessor\Components\Beregnerliste.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
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

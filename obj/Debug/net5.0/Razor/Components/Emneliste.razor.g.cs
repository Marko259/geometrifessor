#pragma checksum "C:\Users\Markus\Documents\GitHub\geometrifessor\Components\Emneliste.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e015f43bcca41f8fb3cdbefd29523635f2644a05"
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
#line 1 "C:\Users\Markus\Documents\GitHub\geometrifessor\Components\Emneliste.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Markus\Documents\GitHub\geometrifessor\Components\Emneliste.razor"
using geometrifessor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Markus\Documents\GitHub\geometrifessor\Components\Emneliste.razor"
using geometrifessor.Services;

#line default
#line hidden
#nullable disable
    public partial class Emneliste : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
#nullable restore
#line 7 "C:\Users\Markus\Documents\GitHub\geometrifessor\Components\Emneliste.razor"
         foreach (var emne in EmneService.GetEmner())
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-4 mb-3 d-flex align-self-stretch");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card");
            __builder.AddAttribute(8, "style", "width: 18rem;");
            __builder.OpenElement(9, "img");
            __builder.AddAttribute(10, "src", 
#nullable restore
#line 11 "C:\Users\Markus\Documents\GitHub\geometrifessor\Components\Emneliste.razor"
                               emne.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "class", "card-img-top");
            __builder.AddAttribute(12, "alt");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "card-body d-flex flex-column");
            __builder.OpenElement(16, "h5");
            __builder.AddAttribute(17, "class", "card-title text-uppercase");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "data-toggle", "modal");
            __builder.AddAttribute(20, "data-target", "#productModal");
            __builder.AddAttribute(21, "class", "btn btn-primary");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\Markus\Documents\GitHub\geometrifessor\Components\Emneliste.razor"
                                                                                                                                                        (e => SelectEmne(emne.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(23, 
#nullable restore
#line 13 "C:\Users\Markus\Documents\GitHub\geometrifessor\Components\Emneliste.razor"
                                                                                                                                                                                     emne.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                        ");
            __builder.OpenElement(25, "p");
            __builder.AddContent(26, 
#nullable restore
#line 14 "C:\Users\Markus\Documents\GitHub\geometrifessor\Components\Emneliste.razor"
                            emne.shortDescription

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 18 "C:\Users\Markus\Documents\GitHub\geometrifessor\Components\Emneliste.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 22 "C:\Users\Markus\Documents\GitHub\geometrifessor\Components\Emneliste.razor"
 if (selectedEmne != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "modal fade");
            __builder.AddAttribute(29, "id", "productModal");
            __builder.AddAttribute(30, "tabindex", "-1");
            __builder.AddAttribute(31, "role", "dialog");
            __builder.AddAttribute(32, "aria-labelledby", "productTitle");
            __builder.AddAttribute(33, "aria-hidden", "true");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "modal-dialog modal-dialog-centered");
            __builder.AddAttribute(36, "role", "document");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "modal-content");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "modal-header");
            __builder.OpenElement(41, "h5");
            __builder.AddAttribute(42, "class", "modal-title");
            __builder.AddAttribute(43, "id", "productTitle");
            __builder.AddContent(44, 
#nullable restore
#line 28 "C:\Users\Markus\Documents\GitHub\geometrifessor\Components\Emneliste.razor"
                                                               selectedEmne.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                    ");
            __builder.AddMarkupContent(46, "<button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "modal-body");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "card");
            __builder.OpenElement(52, "img");
            __builder.AddAttribute(53, "src", 
#nullable restore
#line 35 "C:\Users\Markus\Documents\GitHub\geometrifessor\Components\Emneliste.razor"
                                   selectedEmne.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(54, "class", "card-img-top");
            __builder.AddAttribute(55, "alt");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                        ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "card-body");
            __builder.OpenElement(59, "p");
            __builder.AddAttribute(60, "class", "card-text");
            __builder.AddContent(61, 
#nullable restore
#line 37 "C:\Users\Markus\Documents\GitHub\geometrifessor\Components\Emneliste.razor"
                                                  selectedEmne.shortDescription

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                            <br>\r\n                            ");
            __builder.OpenElement(63, "a");
            __builder.AddAttribute(64, "href", "/Geometri/" + (
#nullable restore
#line 39 "C:\Users\Markus\Documents\GitHub\geometrifessor\Components\Emneliste.razor"
                                                selectedEmne.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(65, "Læs mere her");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 46 "C:\Users\Markus\Documents\GitHub\geometrifessor\Components\Emneliste.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\Markus\Documents\GitHub\geometrifessor\Components\Emneliste.razor"
 
    Emner selectedEmne;
    string selectedEmneId;

    void SelectEmne(string productId)
    {
        selectedEmneId = productId;
        selectedEmne = EmneService.GetEmner().First(x => x.Id == productId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonEmneService EmneService { get; set; }
    }
}
#pragma warning restore 1591

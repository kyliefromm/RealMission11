#pragma checksum "/Users/kyliefromm/Documents/GitHub/RealMission11/Mission10-main-3/Mission 10/Mission7/Pages/Admin/Details.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "004e235b25682b7965774327b3354caef50da829"
// <auto-generated/>
#pragma warning disable 1591
namespace Mission7.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "/Users/kyliefromm/Documents/GitHub/RealMission11/Mission10-main-3/Mission 10/Mission7/Pages/Admin/_imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/kyliefromm/Documents/GitHub/RealMission11/Mission10-main-3/Mission 10/Mission7/Pages/Admin/_imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/kyliefromm/Documents/GitHub/RealMission11/Mission10-main-3/Mission 10/Mission7/Pages/Admin/_imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/kyliefromm/Documents/GitHub/RealMission11/Mission10-main-3/Mission 10/Mission7/Pages/Admin/_imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/kyliefromm/Documents/GitHub/RealMission11/Mission10-main-3/Mission 10/Mission7/Pages/Admin/_imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/kyliefromm/Documents/GitHub/RealMission11/Mission10-main-3/Mission 10/Mission7/Pages/Admin/_imports.razor"
using Mission7.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/books/details/{id:long}")]
    public partial class Details : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"bg-info text-white text-center p-1\">Details</h3>\n\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-sm table-bordered table-striped");
            __builder.AddMarkupContent(3, "\n    ");
            __builder.OpenElement(4, "tbody");
            __builder.AddMarkupContent(5, "\n        ");
            __builder.OpenElement(6, "tr");
            __builder.AddMarkupContent(7, "\n            ");
            __builder.AddMarkupContent(8, "<th>Book ID:</th>\n            ");
            __builder.OpenElement(9, "td");
#nullable restore
#line 9 "/Users/kyliefromm/Documents/GitHub/RealMission11/Mission10-main-3/Mission 10/Mission7/Pages/Admin/Details.razor"
__builder.AddContent(10, book.BookID);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n            ");
            __builder.AddMarkupContent(12, "<th>Title:</th>\n            ");
            __builder.OpenElement(13, "td");
#nullable restore
#line 11 "/Users/kyliefromm/Documents/GitHub/RealMission11/Mission10-main-3/Mission 10/Mission7/Pages/Admin/Details.razor"
__builder.AddContent(14, book.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n            ");
            __builder.AddMarkupContent(16, "<th>Author:</th>\n            ");
            __builder.OpenElement(17, "td");
#nullable restore
#line 13 "/Users/kyliefromm/Documents/GitHub/RealMission11/Mission10-main-3/Mission 10/Mission7/Pages/Admin/Details.razor"
__builder.AddContent(18, book.Author);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n            ");
            __builder.AddMarkupContent(20, "<th>Publisher:</th>\n            ");
            __builder.OpenElement(21, "td");
#nullable restore
#line 15 "/Users/kyliefromm/Documents/GitHub/RealMission11/Mission10-main-3/Mission 10/Mission7/Pages/Admin/Details.razor"
__builder.AddContent(22, book.Publisher);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n            ");
            __builder.AddMarkupContent(24, "<th>ISBN:</th>\n            ");
            __builder.OpenElement(25, "td");
#nullable restore
#line 17 "/Users/kyliefromm/Documents/GitHub/RealMission11/Mission10-main-3/Mission 10/Mission7/Pages/Admin/Details.razor"
__builder.AddContent(26, book.ISBN);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n            ");
            __builder.AddMarkupContent(28, "<th>Classification:</th>\n            ");
            __builder.OpenElement(29, "td");
#nullable restore
#line 19 "/Users/kyliefromm/Documents/GitHub/RealMission11/Mission10-main-3/Mission 10/Mission7/Pages/Admin/Details.razor"
__builder.AddContent(30, book.Classification);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n            ");
            __builder.AddMarkupContent(32, "<th>Category:</th>\n            ");
            __builder.OpenElement(33, "td");
#nullable restore
#line 21 "/Users/kyliefromm/Documents/GitHub/RealMission11/Mission10-main-3/Mission 10/Mission7/Pages/Admin/Details.razor"
__builder.AddContent(34, book.Category);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n            ");
            __builder.AddMarkupContent(36, "<th>PageCount:</th>\n            ");
            __builder.OpenElement(37, "td");
#nullable restore
#line 23 "/Users/kyliefromm/Documents/GitHub/RealMission11/Mission10-main-3/Mission 10/Mission7/Pages/Admin/Details.razor"
__builder.AddContent(38, book.PageCount);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\n            ");
            __builder.AddMarkupContent(40, "<th>Price:</th>\n            ");
            __builder.OpenElement(41, "td");
#nullable restore
#line 25 "/Users/kyliefromm/Documents/GitHub/RealMission11/Mission10-main-3/Mission 10/Mission7/Pages/Admin/Details.razor"
__builder.AddContent(42, book.Price);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(47);
            __builder.AddAttribute(48, "class", "btn btn-warning");
            __builder.AddAttribute(49, "href", 
#nullable restore
#line 33 "/Users/kyliefromm/Documents/GitHub/RealMission11/Mission10-main-3/Mission 10/Mission7/Pages/Admin/Details.razor"
                                        EditUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(51, "Edit");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(52, "\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(53);
            __builder.AddAttribute(54, "class", "btn btn-secondary");
            __builder.AddAttribute(55, "href", "/admin/books");
            __builder.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(57, "Back");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "/Users/kyliefromm/Documents/GitHub/RealMission11/Mission10-main-3/Mission 10/Mission7/Pages/Admin/Details.razor"
       
    [Inject]
    public IBookRepository repo { get; set; }
    [Parameter]
    public long Id { get; set; }

    public Book book { get; set; }

    protected override void OnParametersSet()
    {
        book = repo.Books.FirstOrDefault(x => x.BookID == Id);
    }

    public string EditUrl => $"/admin/books/edit/{book.BookID}";




#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

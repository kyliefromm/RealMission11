#pragma checksum "/Users/kyliefromm/Documents/GitHub/RealMission11/Mission10-main-3/Mission 10/Mission7/Views/Shared/BookSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30e400d6b67163f25ee95a567eadebe9ba113deb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_BookSummary), @"mvc.1.0.view", @"/Views/Shared/BookSummary.cshtml")]
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
#nullable restore
#line 1 "/Users/kyliefromm/Documents/GitHub/RealMission11/Mission10-main-3/Mission 10/Mission7/Views/_ViewImports.cshtml"
using Mission7;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/kyliefromm/Documents/GitHub/RealMission11/Mission10-main-3/Mission 10/Mission7/Views/_ViewImports.cshtml"
using Mission7.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/kyliefromm/Documents/GitHub/RealMission11/Mission10-main-3/Mission 10/Mission7/Views/_ViewImports.cshtml"
using Mission7.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/kyliefromm/Documents/GitHub/RealMission11/Mission10-main-3/Mission 10/Mission7/Views/_ViewImports.cshtml"
using Mission7.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30e400d6b67163f25ee95a567eadebe9ba113deb", @"/Views/Shared/BookSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f974b4488e95e87d78d0b3471fb9df967aeddf28", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_BookSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Purchase", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n\n\n<div class=\"card card-outline-primary m-1 p-1\">\n    <div class=\"bg-faded p-1\">\n        <h4>\n            ");
#nullable restore
#line 14 "/Users/kyliefromm/Documents/GitHub/RealMission11/Mission10-main-3/Mission 10/Mission7/Views/Shared/BookSummary.cshtml"
       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <span class=\"badge badge-pill badge-primary\" style=\"float:right\">\n                <small>Price $");
#nullable restore
#line 16 "/Users/kyliefromm/Documents/GitHub/RealMission11/Mission10-main-3/Mission 10/Mission7/Views/Shared/BookSummary.cshtml"
                         Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\n            </span>\n        </h4>\n    </div>\n    <div class=\"card-text p-1\">\n        <ul>\n            <li>Author: ");
#nullable restore
#line 22 "/Users/kyliefromm/Documents/GitHub/RealMission11/Mission10-main-3/Mission 10/Mission7/Views/Shared/BookSummary.cshtml"
                   Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n            <li>Publisher: ");
#nullable restore
#line 23 "/Users/kyliefromm/Documents/GitHub/RealMission11/Mission10-main-3/Mission 10/Mission7/Views/Shared/BookSummary.cshtml"
                      Write(Model.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n            <li>ISBN: ");
#nullable restore
#line 24 "/Users/kyliefromm/Documents/GitHub/RealMission11/Mission10-main-3/Mission 10/Mission7/Views/Shared/BookSummary.cshtml"
                 Write(Model.ISBN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n            <li>Classification: ");
#nullable restore
#line 25 "/Users/kyliefromm/Documents/GitHub/RealMission11/Mission10-main-3/Mission 10/Mission7/Views/Shared/BookSummary.cshtml"
                           Write(Model.Classification);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n            <li>Category: ");
#nullable restore
#line 26 "/Users/kyliefromm/Documents/GitHub/RealMission11/Mission10-main-3/Mission 10/Mission7/Views/Shared/BookSummary.cshtml"
                     Write(Model.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n            <li>Number of Pages: ");
#nullable restore
#line 27 "/Users/kyliefromm/Documents/GitHub/RealMission11/Mission10-main-3/Mission 10/Mission7/Views/Shared/BookSummary.cshtml"
                            Write(Model.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n        </ul>\n\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30e400d6b67163f25ee95a567eadebe9ba113deb7465", async() => {
                WriteLiteral("\n\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "30e400d6b67163f25ee95a567eadebe9ba113deb7733", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 32 "/Users/kyliefromm/Documents/GitHub/RealMission11/Mission10-main-3/Mission 10/Mission7/Views/Shared/BookSummary.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.BookID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n            <input type=\"hidden\" name=\"returnUrl\"");
                BeginWriteAttribute("value", " value=\"", 944, "\"", 999, 1);
#nullable restore
#line 33 "/Users/kyliefromm/Documents/GitHub/RealMission11/Mission10-main-3/Mission 10/Mission7/Views/Shared/BookSummary.cshtml"
WriteAttributeValue("", 952, ViewContext.HttpContext.Request.PathAndQuery(), 952, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n\n            <span class=\"card-text\">\n                <button type=\"submit\" class=\"btn btn-success btn-sm float-end\">Purchase</button>\n            </span>\n     \n\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
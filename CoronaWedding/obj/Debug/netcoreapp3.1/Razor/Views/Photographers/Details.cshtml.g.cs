#pragma checksum "C:\Users\isako\source\repos\CoronaWedding\CoronaWedding\Views\Photographers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9112553804c7f0cfb4b71e5a48c1d3014a587ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Photographers_Details), @"mvc.1.0.view", @"/Views/Photographers/Details.cshtml")]
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
#line 1 "C:\Users\isako\source\repos\CoronaWedding\CoronaWedding\Views\_ViewImports.cshtml"
using CoronaWedding;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\isako\source\repos\CoronaWedding\CoronaWedding\Views\_ViewImports.cshtml"
using CoronaWedding.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9112553804c7f0cfb4b71e5a48c1d3014a587ea", @"/Views/Photographers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"647b5bc3eaf93b22636f03734877ced82583bc83", @"/Views/_ViewImports.cshtml")]
    public class Views_Photographers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoronaWedding.Models.Photographer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/dynamicFilter.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\isako\source\repos\CoronaWedding\CoronaWedding\Views\Photographers\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-7\">\r\n        <a href=\"#\">\r\n            <img class=\"img-fluid rounded mb-3 mb-md-0 imgDet\"");
            BeginWriteAttribute("src", " src=\"", 218, "\"", 240, 1);
#nullable restore
#line 9 "C:\Users\isako\source\repos\CoronaWedding\CoronaWedding\Views\Photographers\Details.cshtml"
WriteAttributeValue("", 224, Model.imagePath, 224, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </a>\r\n    </div>\r\n    <div class=\"col-md-5 textDetails\">\r\n\r\n        <p>Email: ");
#nullable restore
#line 14 "C:\Users\isako\source\repos\CoronaWedding\CoronaWedding\Views\Photographers\Details.cshtml"
             Write(Model.supplireEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Pricr: ");
#nullable restore
#line 15 "C:\Users\isako\source\repos\CoronaWedding\CoronaWedding\Views\Photographers\Details.cshtml"
             Write(Model.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</p>\r\n\r\n        <button class=\"buttonForSite addToCartButoon\"");
            BeginWriteAttribute("id", " id=", 448, "", 473, 1);
#nullable restore
#line 17 "C:\Users\isako\source\repos\CoronaWedding\CoronaWedding\Views\Photographers\Details.cshtml"
WriteAttributeValue("", 452, Model.PhotographerId, 452, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"Photographer\">Add To Cart</button>\r\n\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9112553804c7f0cfb4b71e5a48c1d3014a587ea5518", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoronaWedding.Models.Photographer> Html { get; private set; }
    }
}
#pragma warning restore 1591

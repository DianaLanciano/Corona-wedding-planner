#pragma checksum "C:\Users\isako\source\repos\CoronaWedding\CoronaWedding\Views\Caterings\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bef4d23526c81a72bb4cdf083f8555d07b73d878"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Caterings_Details), @"mvc.1.0.view", @"/Views/Caterings/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bef4d23526c81a72bb4cdf083f8555d07b73d878", @"/Views/Caterings/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"647b5bc3eaf93b22636f03734877ced82583bc83", @"/Views/_ViewImports.cshtml")]
    public class Views_Caterings_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoronaWedding.Models.Catering>
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
#line 3 "C:\Users\isako\source\repos\CoronaWedding\CoronaWedding\Views\Caterings\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-7\">\r\n        <a href=\"#\">\r\n            <img class=\"img-fluid rounded mb-3 mb-md-0 imgDet\"");
            BeginWriteAttribute("src", " src=\"", 216, "\"", 238, 1);
#nullable restore
#line 10 "C:\Users\isako\source\repos\CoronaWedding\CoronaWedding\Views\Caterings\Details.cshtml"
WriteAttributeValue("", 222, Model.imagePath, 222, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </a>\r\n    </div>\r\n    <div class=\"col-md-5 textDetails\">\r\n        <h3>");
#nullable restore
#line 14 "C:\Users\isako\source\repos\CoronaWedding\CoronaWedding\Views\Caterings\Details.cshtml"
       Write(Model.foodType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <p>Email: ");
#nullable restore
#line 15 "C:\Users\isako\source\repos\CoronaWedding\CoronaWedding\Views\Caterings\Details.cshtml"
             Write(Model.supplireEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Pricr: ");
#nullable restore
#line 16 "C:\Users\isako\source\repos\CoronaWedding\CoronaWedding\Views\Caterings\Details.cshtml"
             Write(Model.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</p>\r\n        <p>Kosher:");
#nullable restore
#line 17 "C:\Users\isako\source\repos\CoronaWedding\CoronaWedding\Views\Caterings\Details.cshtml"
             Write(Model.Kosher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n        <button class=\"buttonForSite addToCartButoon\"");
            BeginWriteAttribute("id", " id=", 515, "", 536, 1);
#nullable restore
#line 19 "C:\Users\isako\source\repos\CoronaWedding\CoronaWedding\Views\Caterings\Details.cshtml"
WriteAttributeValue("", 519, Model.CateringId, 519, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"Catering\">Add To Cart</button>\r\n\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 24 "C:\Users\isako\source\repos\CoronaWedding\CoronaWedding\Views\Caterings\Details.cshtml"
      await Html.RenderPartialAsync("_Popup"); 

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bef4d23526c81a72bb4cdf083f8555d07b73d8786234", async() => {
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
                WriteLiteral("\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoronaWedding.Models.Catering> Html { get; private set; }
    }
}
#pragma warning restore 1591

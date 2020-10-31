#pragma checksum "C:\Users\isako\source\repos\CoronaWedding\CoronaWedding\Views\Caterings\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bf5a0a041621afef98ce9e3f7d83cf6464ceee4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Caterings_Index), @"mvc.1.0.view", @"/Views/Caterings/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bf5a0a041621afef98ce9e3f7d83cf6464ceee4", @"/Views/Caterings/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"647b5bc3eaf93b22636f03734877ced82583bc83", @"/Views/_ViewImports.cshtml")]
    public class Views_Caterings_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CoronaWedding.Models.Catering>>
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
#line 3 "C:\Users\isako\source\repos\CoronaWedding\CoronaWedding\Views\Caterings\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"title\">\r\n    <img src=\"/Media/images/cateringLogo.PNG\" alt=\"title\" class=\"img\">\r\n</div>\r\n<hr>\r\n");
            WriteLiteral(@"
<div class=""filter-nav"">
    <button class=""filter-all filterButton"" data-filter=""all"" value=""all"" name=""Caterings""> Show All</button>
    <button class=""filter filterButton"" data-filter=""asian"" value=""Asian"" name=""Caterings""> Asian</button>
    <button class=""filter filterButton"" data-filter=""meaty"" value=""meaty"" name=""Caterings""> Meaty</button>
    <button class=""filter filterButton"" data-filter=""vegan"" value=""vegan"" name=""Caterings""> Vegan</button>
</div>

");
#nullable restore
#line 20 "C:\Users\isako\source\repos\CoronaWedding\CoronaWedding\Views\Caterings\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"responsive-images\">\r\n        <div class=\"filterDiv\">\r\n");
            WriteLiteral("            <img");
            BeginWriteAttribute("id", " id=", 903, "", 923, 1);
#nullable restore
#line 25 "C:\Users\isako\source\repos\CoronaWedding\CoronaWedding\Views\Caterings\Index.cshtml"
WriteAttributeValue("", 907, item.CateringId, 907, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 923, "\"", 944, 1);
#nullable restore
#line 25 "C:\Users\isako\source\repos\CoronaWedding\CoronaWedding\Views\Caterings\Index.cshtml"
WriteAttributeValue("", 929, item.imagePath, 929, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"imageFilter\" name=\"Caterings\">\r\n            <h5 class=\"mail\">Email: ");
#nullable restore
#line 26 "C:\Users\isako\source\repos\CoronaWedding\CoronaWedding\Views\Caterings\Index.cshtml"
                               Write(item.supplireEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <h5 class=\"mail\">Food Type: ");
#nullable restore
#line 27 "C:\Users\isako\source\repos\CoronaWedding\CoronaWedding\Views\Caterings\Index.cshtml"
                                   Write(item.foodType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <h5>Pricr: ");
#nullable restore
#line 28 "C:\Users\isako\source\repos\CoronaWedding\CoronaWedding\Views\Caterings\Index.cshtml"
                  Write(item.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</h5>\r\n            <button class=\"buttonForSite\">\r\n                Add To Cart\r\n            </button>\r\n\r\n        </div>\r\n    </div>");
#nullable restore
#line 34 "C:\Users\isako\source\repos\CoronaWedding\CoronaWedding\Views\Caterings\Index.cshtml"
          }

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bf5a0a041621afef98ce9e3f7d83cf6464ceee46803", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CoronaWedding.Models.Catering>> Html { get; private set; }
    }
}
#pragma warning restore 1591

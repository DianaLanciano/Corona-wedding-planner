#pragma checksum "C:\Users\isako\source\repos\CoronaWedding\CoronaWedding\Views\Locations\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d6daaa6ec4116777920d1eab9e5281984b6fd14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Locations_Details), @"mvc.1.0.view", @"/Views/Locations/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d6daaa6ec4116777920d1eab9e5281984b6fd14", @"/Views/Locations/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"647b5bc3eaf93b22636f03734877ced82583bc83", @"/Views/_ViewImports.cshtml")]
    public class Views_Locations_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoronaWedding.Models.Location>
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
#line 3 "C:\Users\isako\source\repos\CoronaWedding\CoronaWedding\Views\Locations\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!--for google maps-->
<script src=""https://maps.googleapis.com/maps/api/js?key=API&libraries=&v=weekly""
        defer></script>

<div class=""row"">
    <div class=""col-md-7"">
        <a href=""#"">
            <img class=""img-fluid rounded mb-3 mb-md-0 imgDet""");
            BeginWriteAttribute("src", " src=\"", 348, "\"", 370, 1);
#nullable restore
#line 13 "C:\Users\isako\source\repos\CoronaWedding\CoronaWedding\Views\Locations\Details.cshtml"
WriteAttributeValue("", 354, Model.imagePath, 354, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </a>\r\n    </div>\r\n    <div class=\"col-md-5 textDetails\">\r\n        <h3>");
#nullable restore
#line 17 "C:\Users\isako\source\repos\CoronaWedding\CoronaWedding\Views\Locations\Details.cshtml"
       Write(Model.city);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <p>Email: ");
#nullable restore
#line 18 "C:\Users\isako\source\repos\CoronaWedding\CoronaWedding\Views\Locations\Details.cshtml"
             Write(Model.supplireEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Capacity: ");
#nullable restore
#line 19 "C:\Users\isako\source\repos\CoronaWedding\CoronaWedding\Views\Locations\Details.cshtml"
                Write(Model.placeCapacity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p dir=\"rtl\">Price: ");
#nullable restore
#line 20 "C:\Users\isako\source\repos\CoronaWedding\CoronaWedding\Views\Locations\Details.cshtml"
                       Write(Model.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</p>\r\n        <div id=\"map\">\r\n\r\n        </div>\r\n\r\n        <button class=\"buttonForSite addToCartButoon\"");
            BeginWriteAttribute("id", " id=", 705, "", 726, 1);
#nullable restore
#line 25 "C:\Users\isako\source\repos\CoronaWedding\CoronaWedding\Views\Locations\Details.cshtml"
WriteAttributeValue("", 709, Model.LocationId, 709, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"Location\">Add To Cart</button>\r\n        <input hidden id=\"lon\"");
            BeginWriteAttribute("value", " value=\"", 795, "\"", 819, 1);
#nullable restore
#line 26 "C:\Users\isako\source\repos\CoronaWedding\CoronaWedding\Views\Locations\Details.cshtml"
WriteAttributeValue("", 803, Model.Longitude, 803, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden id=\"lat\"");
            BeginWriteAttribute("value", " value=\"", 855, "\"", 878, 1);
#nullable restore
#line 27 "C:\Users\isako\source\repos\CoronaWedding\CoronaWedding\Views\Locations\Details.cshtml"
WriteAttributeValue("", 863, Model.Latitude, 863, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
    </div>
</div>

<script>

    // Initialize and add the map
    function initMap() {
        const lon = +document.getElementById(""lon"").value;
        const lat = +document.getElementById(""lat"").value;

        // The location of Uluru
        const uluru = { lat: lat, lng: lon };
        // The map, centered at Uluru
        const map = new google.maps.Map(document.getElementById(""map""), {
            zoom: 14,
            center: uluru,
        });
    }
</script>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 49 "C:\Users\isako\source\repos\CoronaWedding\CoronaWedding\Views\Locations\Details.cshtml"
      await Html.RenderPartialAsync("_Popup");

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d6daaa6ec4116777920d1eab9e5281984b6fd147731", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoronaWedding.Models.Location> Html { get; private set; }
    }
}
#pragma warning restore 1591

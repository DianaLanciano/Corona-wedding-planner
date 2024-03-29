#pragma checksum "C:\Users\Diana_Lanciano\Source\Repos\Corona-wedding-planner\CoronaWedding\Views\Accounts\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92d4be1f782fa00b0445744d40c64faf826a278d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_Checkout), @"mvc.1.0.view", @"/Views/Accounts/Checkout.cshtml")]
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
#line 1 "C:\Users\Diana_Lanciano\Source\Repos\Corona-wedding-planner\CoronaWedding\Views\_ViewImports.cshtml"
using CoronaWedding;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Diana_Lanciano\Source\Repos\Corona-wedding-planner\CoronaWedding\Views\_ViewImports.cshtml"
using CoronaWedding.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92d4be1f782fa00b0445744d40c64faf826a278d", @"/Views/Accounts/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"647b5bc3eaf93b22636f03734877ced82583bc83", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoronaWedding.Models.Account>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Accounts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "deleteFromCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "Location", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "Catering", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "Music", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "Photographer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Diana_Lanciano\Source\Repos\Corona-wedding-planner\CoronaWedding\Views\Accounts\Checkout.cshtml"
  
    ViewData["Title"] = "Checkout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""title"">
    <img src=""/Media/images/checkoutLogo.PNG"" alt=""title"" class=""rounded mx-auto d-block"">
</div>
<hr />

<div class=""row why_us_section"">
    <div class=""col-lg-4 col-md-6 mx-auto"">
        <div class=""box"">
            <div class=""img-box"">
                <i class=""fas fa-shopping-cart""></i>
            </div>
            <div class=""detail-box"">
                <h4>Purchase summary:</h4>
                <hr />
                <p>


");
#nullable restore
#line 24 "C:\Users\Diana_Lanciano\Source\Repos\Corona-wedding-planner\CoronaWedding\Views\Accounts\Checkout.cshtml"
                     if (@ViewBag.LocationPrice != 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"row\">\r\n                            <h5>Location: ");
#nullable restore
#line 27 "C:\Users\Diana_Lanciano\Source\Repos\Corona-wedding-planner\CoronaWedding\Views\Accounts\Checkout.cshtml"
                                     Write(ViewBag.LocationPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</h5>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92d4be1f782fa00b0445744d40c64faf826a278d6484", async() => {
                WriteLiteral("<i class=\"fas fa-trash-alt\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 30 "C:\Users\Diana_Lanciano\Source\Repos\Corona-wedding-planner\CoronaWedding\Views\Accounts\Checkout.cshtml"

                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\Diana_Lanciano\Source\Repos\Corona-wedding-planner\CoronaWedding\Views\Accounts\Checkout.cshtml"
                     if (@ViewBag.CateringPrice != 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"row\">\r\n                            <h5>Catering: ");
#nullable restore
#line 35 "C:\Users\Diana_Lanciano\Source\Repos\Corona-wedding-planner\CoronaWedding\Views\Accounts\Checkout.cshtml"
                                     Write(ViewBag.CateringPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</h5>&nbsp\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92d4be1f782fa00b0445744d40c64faf826a278d9340", async() => {
                WriteLiteral("<i class=\"fas fa-trash-alt\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 38 "C:\Users\Diana_Lanciano\Source\Repos\Corona-wedding-planner\CoronaWedding\Views\Accounts\Checkout.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\Diana_Lanciano\Source\Repos\Corona-wedding-planner\CoronaWedding\Views\Accounts\Checkout.cshtml"
                     if (@ViewBag.MusicPrice != 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"row\">\r\n                            <h5>Music: ");
#nullable restore
#line 42 "C:\Users\Diana_Lanciano\Source\Repos\Corona-wedding-planner\CoronaWedding\Views\Accounts\Checkout.cshtml"
                                  Write(ViewBag.MusicPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</h5>&nbsp\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92d4be1f782fa00b0445744d40c64faf826a278d12182", async() => {
                WriteLiteral("<i class=\"fas fa-trash-alt\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                        </div>\r\n");
#nullable restore
#line 46 "C:\Users\Diana_Lanciano\Source\Repos\Corona-wedding-planner\CoronaWedding\Views\Accounts\Checkout.cshtml"

                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\Diana_Lanciano\Source\Repos\Corona-wedding-planner\CoronaWedding\Views\Accounts\Checkout.cshtml"
                     if (@ViewBag.PhotographerPrice != 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"row\">\r\n                            <h5>Photographer: ");
#nullable restore
#line 51 "C:\Users\Diana_Lanciano\Source\Repos\Corona-wedding-planner\CoronaWedding\Views\Accounts\Checkout.cshtml"
                                         Write(ViewBag.PhotographerPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</h5>&nbsp\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92d4be1f782fa00b0445744d40c64faf826a278d15059", async() => {
                WriteLiteral("<i class=\"fas fa-trash-alt\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 54 "C:\Users\Diana_Lanciano\Source\Repos\Corona-wedding-planner\CoronaWedding\Views\Accounts\Checkout.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <hr />\r\n                    <h5>Total price: ");
#nullable restore
#line 56 "C:\Users\Diana_Lanciano\Source\Repos\Corona-wedding-planner\CoronaWedding\Views\Accounts\Checkout.cshtml"
                                Write(ViewBag.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"$</h5>
                </p>
            </div>
        </div>
    </div>
</div>



<aside>

    <!-- start sw-rss-feed code -->
    <script type=""text/javascript"">

<!--
        rssfeed_url = new Array();
        rssfeed_url[0] = ""https://www.jpost.com/rss/rsscoronavirusupdates"";
        rssfeed_frame_width = ""250"";
        rssfeed_frame_height = ""600"";
        rssfeed_scroll = ""on"";
        rssfeed_scroll_step = ""6"";
        rssfeed_scroll_bar = ""off"";
        rssfeed_target = ""_blank"";
        rssfeed_font_size = ""12"";
        rssfeed_font_face = """";
        rssfeed_border = ""on"";
        rssfeed_css_url = """";
        rssfeed_title = ""on"";
        rssfeed_title_name = ""Coronavirus Live Updates"";
        rssfeed_title_bgcolor = ""#ff6699"";
        rssfeed_title_color = ""#fff"";
        rssfeed_title_bgimage = """";
        rssfeed_footer = ""off"";
        rssfeed_footer_name = ""rss feed"";
        rssfeed_footer_bgcolor = ""#fff"";
        rssfeed_footer_color = ""#333"";
        rs");
            WriteLiteral(@"sfeed_footer_bgimage = """";
        rssfeed_item_title_length = ""50"";
        rssfeed_item_title_color = ""#ff6699"";
        rssfeed_item_bgcolor = ""#fff"";
        rssfeed_item_bgimage = """";
        rssfeed_item_border_bottom = ""on"";
        rssfeed_item_source_icon = ""off"";
        rssfeed_item_date = ""on"";
        rssfeed_item_description = ""off"";
        rssfeed_item_description_length = ""120"";
        rssfeed_item_description_color = ""#fff"";
        rssfeed_item_description_link_color = ""#333"";
        rssfeed_item_description_tag = ""off"";
        rssfeed_no_items = ""0"";
        rssfeed_cache = ""8d89267457da06f056143f5a2fe918fa"";
//-->
    </script>
    <script type=""text/javascript"" src=""//feed.surfing-waves.com/js/rss-feed.js""></script>
    <!-- The link below helps keep this service FREE, and helps other people find the SW widget. Please be cool and keep it! Thanks. -->
    <div style=""color:#ccc;font-size:10px; text-align:right; width:250px;"">powered by <a href=""https://surfing-waves.");
            WriteLiteral(@"com"" rel=""noopener"" target=""_blank"" style=""color:#ccc;"">Surfing Waves</a></div>
    <!-- end sw-rss-feed code -->

</aside>


<iframe width=""560"" height=""315"" src=""https://www.youtube.com/embed/CQq51HfgxAA""
        frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write;
  encrypted-media; gyroscope; picture-in-picture"" allowfullscreen>
</iframe>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoronaWedding.Models.Account> Html { get; private set; }
    }
}
#pragma warning restore 1591

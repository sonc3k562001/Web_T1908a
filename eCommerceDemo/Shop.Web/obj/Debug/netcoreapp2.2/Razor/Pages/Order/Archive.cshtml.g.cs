#pragma checksum "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Pages\Order\Archive.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08bb5d1a5fbfcce3f76481625ce9619923b22ae4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Order_Archive), @"mvc.1.0.razor-page", @"/Pages/Order/Archive.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Order/Archive.cshtml", typeof(AspNetCore.Pages_Order_Archive), @"page-{pageNumber:int}/{userId?}")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "page-{pageNumber:int}/{userId?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08bb5d1a5fbfcce3f76481625ce9619923b22ae4", @"/Pages/Order/Archive.cshtml")]
    public class Pages_Order_Archive : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Pages\Order\Archive.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(157, 1126, true);
            WriteLiteral(@"
<style>
    .tblack {
        color: #000;
    }
    /* Breadcum bar */
    .bg-grey {
        background: #efefef
    }

    .breadcrumb {
        background: none;
        margin: 0;
        font-weight: 300;
        padding-left: 0;
        font-size: 13px;
    }

    .breadcrumb a {
        color: #999;
    }

    .breadcrumb > .active {
        color: #696969;
    }

    .breadcrumb > li + li::before {
        content: ""\203A"";
        color: #999;
        padding: 0 8px;
    }
    legend {
        width:inherit; 
        padding:0 5px; 
        border-bottom:none;
        font-size: 20px !important;
        font-weight: bold !important;
        text-align: left !important;
    }

    fieldset {
        border: 1px groove #ddd !important;
        padding: 0 5px 5px 5px !important;
        margin: 0 0 1.5em 0 !important;
        -webkit-box-shadow:  0px 0px 0px 0px #000;
        box-shadow:  0px 0px 0px 0px #000;
    }

    .card {
        border:solid 1px black;
        padding:8px;
        margin-botto");
            WriteLiteral("m:16px;\n        border-radius:4px;\n    }\n\n    h3 {\n        font-size:20px !important;\n    }\n</style>\n\n");
            EndContext();
            BeginContext(1283, 13, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08bb5d1a5fbfcce3f76481625ce9619923b22ae46386", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1296, 211, true);
            WriteLiteral("\n\n\n<div class=\"bread-bar bg-grey my-2\">\n    <div class=\"container\">\n        <div class=\"row\">\n            <div class=\"col-md-8 col-sm-6 col-xs-8\">\n                <ol class=\"breadcrumb\">\n                    <li>");
            EndContext();
            BeginContext(1507, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08bb5d1a5fbfcce3f76481625ce9619923b22ae47945", async() => {
                BeginContext(1551, 4, true);
                WriteLiteral("Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1559, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 76 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Pages\Order\Archive.cshtml"
                     if (!string.IsNullOrEmpty(Model.Order.UserId))
                    {

#line default
#line hidden
            BeginContext(1655, 28, true);
            WriteLiteral("                        <li>");
            EndContext();
            BeginContext(1683, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08bb5d1a5fbfcce3f76481625ce9619923b22ae49869", async() => {
                BeginContext(1771, 7, true);
                WriteLiteral("Profile");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 78 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Pages\Order\Archive.cshtml"
                                                                                   WriteLiteral(Model.Order.UserId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1782, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 79 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Pages\Order\Archive.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1857, 28, true);
            WriteLiteral("                        <li>");
            EndContext();
            BeginContext(1885, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08bb5d1a5fbfcce3f76481625ce9619923b22ae412805", async() => {
                BeginContext(1934, 7, true);
                WriteLiteral("Profile");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1945, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 83 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Pages\Order\Archive.cshtml"
                    }

#line default
#line hidden
            BeginContext(1973, 2810, true);
            WriteLiteral(@"                    <li class=""active"">Archive</li>
                </ol>
            </div>
        </div>
    </div>
</div>

<div class=""container"">
    <div class=""row"">
        <!-- <div class=""col-md-4 bg-secondary"">
            <form method=""POST"">
                <fieldset class=""filter-sidebar border p-2"">
                    <legend class=""auto-w"">Filter Options</legend>
                    <div class=""form-group"">
                        <label>Sort</label>
                        <select class=""form-control"">
                            <option>-- SELECT SORT ORDER --</option>
                            <option>Price asc</option>
                            <option>Price desc</option>
                            <option>Date asc</option>
                            <option>Date desc</option>
                        </select>
                    </div>
                    <fieldset class=""form-group"">
                        <legend>Select date to filter</legend>
                        <div class=");
            WriteLiteral(@"""row"">
                            <div class=""col-md-6"">
                                <label>From</label>
                                <input type=""date"" asp-for=""Order.MinDate"" class=""form-control"" />
                            </div>
                            <div class=""col-md-6"">
                                <label>To</label>
                                <input type=""date"" asp-for=""Order.MaxDate"" class=""form-control"" />
                            </div>
                        </div>
                    </fieldset>
                    <fieldset class=""form-group"">
                        <legend>Select price to filter</legend>
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <label>From</label>
                                <input type=""number"" asp-for=""Order.MinPrice"" class=""form-control"" />
                            </div>
                            <div class=""col-md-6"">
                                <la");
            WriteLiteral(@"bel>To</label>
                                <input type=""number"" asp-for=""Order.MaxPrice"" class=""form-control"" />
                            </div>
                        </div>
                    </fieldset>
                    <div class=""form-group"">
                        <label>Zip code</label>
                        <input class=""form-control"" asp-for=""Order.ZipCode""/>
                    </div>
                    <hr>
                    <input type=""submit"" class=""btn btn-primary""  value=""Find Now""/>
                    <button type=""button"" class=""btn btn-primary"">Reset All</button>
                </fieldset>
            </form>
        </div> -->
        <div class=""col-md-9"">
            <div class=""row"" style=""padding-top:13px;"">
");
            EndContext();
#line 145 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Pages\Order\Archive.cshtml"
                 foreach(var order in Model.Order.Orders)
                {

#line default
#line hidden
            BeginContext(4859, 223, true);
            WriteLiteral("                 <div style=\"width:650px;\">\n                     <div class=\"card\" style=\"background:white\">\n                        <div class=\"card-body\" >\n                            <h5 class=\"card-title\">Order placed: ");
            EndContext();
            BeginContext(5083, 40, false);
#line 150 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Pages\Order\Archive.cshtml"
                                                            Write(order.OrderPlaced.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(5123, 225, true);
            WriteLiteral("</h5>\n                            <ul class=\"nav nav-pills  countlist\" role=\"tablist\">\n                                <li role=\"presentation\">\n                                    <h3>\n                                        ");
            EndContext();
            BeginContext(5349, 13, false);
#line 154 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Pages\Order\Archive.cshtml"
                                   Write(order.Country);

#line default
#line hidden
            EndContext();
            BeginContext(5362, 286, true);
            WriteLiteral(@"<br>
                                        <small>Country</small>
                                    </h3>
                                </li>
                                <li role=""presentation"">
                                    <h3>
                                        ");
            EndContext();
            BeginContext(5649, 10, false);
#line 160 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Pages\Order\Archive.cshtml"
                                   Write(order.City);

#line default
#line hidden
            EndContext();
            BeginContext(5659, 283, true);
            WriteLiteral(@"<br>
                                        <small>City</small>
                                    </h3>
                                </li>
                                <li role=""presentation"">
                                    <h3>
                                        ");
            EndContext();
            BeginContext(5943, 22, false);
#line 166 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Pages\Order\Archive.cshtml"
                                   Write(order.OrderTotalFormat);

#line default
#line hidden
            EndContext();
            BeginContext(5965, 290, true);
            WriteLiteral(@"<br>
                                        <small>Order total</small>
                                    </h3>
                                </li>
                                <li role=""presentation"">
                                    <h3>
                                        ");
            EndContext();
            BeginContext(6255, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08bb5d1a5fbfcce3f76481625ce9619923b22ae420729", async() => {
                BeginContext(6338, 18, false);
#line 172 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Pages\Order\Archive.cshtml"
                                                                                                                     Write(order.UserFullName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 172 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Pages\Order\Archive.cshtml"
                                                                                               WriteLiteral(order.UserId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6360, 207, true);
            WriteLiteral("<br>\n                                        <small>User</small>\n                                    </h3>\n                                </li>\n                            </ul>\n                            ");
            EndContext();
            BeginContext(6567, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08bb5d1a5fbfcce3f76481625ce9619923b22ae423788", async() => {
                BeginContext(6639, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 177 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Pages\Order\Archive.cshtml"
                                                                             WriteLiteral(order.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6650, 82, true);
            WriteLiteral("\n                        </div>\n                    </div>\n                </div>\n");
            EndContext();
#line 181 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Pages\Order\Archive.cshtml"
                }

#line default
#line hidden
            BeginContext(6750, 154, true);
            WriteLiteral("            </div>\n            <!-- <div class=\"btn btn-group row\"> -->\n                <div class=\"col-md-offset-5 col-md-4\" style=\"margin-bottom:16px\">\n");
            EndContext();
#line 185 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Pages\Order\Archive.cshtml"
                     for(int i=1;i<=Model.Order.PageCount;i++)
                    {
                        if(i == Model.Order.Page)
                        {

#line default
#line hidden
            BeginContext(7065, 55, true);
            WriteLiteral("                            <a class=\"btn btn-primary\">");
            EndContext();
            BeginContext(7121, 1, false);
#line 189 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Pages\Order\Archive.cshtml"
                                                  Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(7122, 5, true);
            WriteLiteral("</a>\n");
            EndContext();
#line 190 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Pages\Order\Archive.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(7208, 30, true);
            WriteLiteral("                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 7238, "\"", 7267, 2);
            WriteAttributeValue("", 7245, "/Order/Archive/page-", 7245, 20, true);
#line 193 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Pages\Order\Archive.cshtml"
WriteAttributeValue("", 7265, i, 7265, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7268, 69, true);
            WriteLiteral(" class=\"btn btn-secondary\" style=\"background:#f9f9f9; color:#3c3d41\">");
            EndContext();
            BeginContext(7338, 1, false);
#line 193 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Pages\Order\Archive.cshtml"
                                                                                                                            Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(7339, 5, true);
            WriteLiteral("</a>\n");
            EndContext();
#line 194 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Pages\Order\Archive.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(7392, 84, true);
            WriteLiteral("                </div>\n            <!-- </div> -->\n        </div>\n    </div>\n</div>\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Shop.Web.Pages.ArchiveModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Shop.Web.Pages.ArchiveModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Shop.Web.Pages.ArchiveModel>)PageContext?.ViewData;
        public Shop.Web.Pages.ArchiveModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

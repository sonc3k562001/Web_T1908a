#pragma checksum "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee34ffd821e4f6bf75181ef11efc22eaaf9fec09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Profile), @"mvc.1.0.view", @"/Views/Account/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Profile.cshtml", typeof(AspNetCore.Views_Account_Profile))]
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
#line 1 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\_ViewImports.cshtml"
using Shop.Web;

#line default
#line hidden
#line 2 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\_ViewImports.cshtml"
using Shop.Web.Models;

#line default
#line hidden
#line 2 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
using System.Globalization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee34ffd821e4f6bf75181ef11efc22eaaf9fec09", @"/Views/Account/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"305828443d1bbb5288a5e50c77b527fb67997e89", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Shop.Web.Models.Account.AccountProfileModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary followbtn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Settings", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Food", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(79, 330, true);
            WriteLiteral(@"

<link href=""https://maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css"" rel=""stylesheet"">


<div class=""container"">
    <div class=""row"">
        <div class=""col-md-12 text-center "">
            <div class=""panel"">
                <div class=""userprofile social "">
                    <div class=""userpic""> <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 409, "\"", 430, 1);
#line 13 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
WriteAttributeValue("", 415, Model.ImageUrl, 415, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(431, 97, true);
            WriteLiteral(" alt=\"\" class=\"userpicimg\" style=\"height:100%;\"> </div>\n                    <h3 class=\"username\">");
            EndContext();
            BeginContext(529, 15, false);
#line 14 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                                    Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(544, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(546, 14, false);
#line 14 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                                                     Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(560, 29, true);
            WriteLiteral("</h3>\n                    <p>");
            EndContext();
            BeginContext(591, 13, false);
#line 15 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                   Write(Model.Country);

#line default
#line hidden
            EndContext();
            BeginContext(605, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(608, 10, false);
#line 15 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                                    Write(Model.City);

#line default
#line hidden
            EndContext();
            BeginContext(619, 289, true);
            WriteLiteral(@"</p>
                </div>
                <div class=""col-md-12 border-top border-bottom"">
                    <ul class=""nav nav-pills pull-left countlist"" role=""tablist"">
                        <li role=""presentation"">
                            <h3>
                                ");
            EndContext();
            BeginContext(909, 19, false);
#line 21 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                           Write(Model.BalanceFormat);

#line default
#line hidden
            EndContext();
            BeginContext(928, 238, true);
            WriteLiteral("<br>\n                                <small>Balance</small>\n                            </h3>\n                        </li>\n                        <li role=\"presentation\">\n                            <h3>\n                                ");
            EndContext();
            BeginContext(1167, 16, false);
#line 27 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                           Write(Model.OrderCount);

#line default
#line hidden
            EndContext();
            BeginContext(1183, 244, true);
            WriteLiteral("<br>\n                                <small>Orders placed</small>\n                            </h3>\n                        </li>\n                        <li role=\"presentation\">\n                            <h3>\n                                ");
            EndContext();
            BeginContext(1428, 40, false);
#line 33 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                           Write(Model.MemberSince.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1468, 155, true);
            WriteLiteral("<br>\n                                <small>Member since</small>\n                            </h3>\n                        </li>\n                    </ul>\n");
            EndContext();
#line 38 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                     if(User.IsInRole("Admin"))
                    {

#line default
#line hidden
            BeginContext(1693, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1717, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee34ffd821e4f6bf75181ef11efc22eaaf9fec099693", async() => {
                BeginContext(1805, 36, true);
                WriteLiteral("Settings <i class=\"fas fa-cogs\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 40 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                                                                                         WriteLiteral(Model.Id);

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
            BeginContext(1845, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 41 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1915, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1939, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee34ffd821e4f6bf75181ef11efc22eaaf9fec0912529", async() => {
                BeginContext(1998, 36, true);
                WriteLiteral("Settings <i class=\"fas fa-cogs\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2038, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 45 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                    }

#line default
#line hidden
            BeginContext(2061, 275, true);
            WriteLiteral(@"                </div>
                <div class=""clearfix"" style=""background-color:#f8f8f8""></div>
            </div>
        </div>
        <!-- /.col-md-12 -->
        <div class=col-md-8>
            <div clas=""panel panel-default"">
                <p>Latest orders</p>
");
            EndContext();
#line 54 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                 if(Model.OrderCount == 0)
                {

#line default
#line hidden
            BeginContext(2397, 76, true);
            WriteLiteral("                    <p>It looks like you havn\'t ordered anything yet...</p>\n");
            EndContext();
#line 57 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                }

#line default
#line hidden
            BeginContext(2491, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 58 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                 foreach(var item in Model.LatestOrders)
                {

#line default
#line hidden
            BeginContext(2566, 458, true);
            WriteLiteral(@"                    <div class=""col-md-8 col-sm-12 pull-left posttimeline"">
                        <div class=""panel-group"" id=""accordion"">
                            <div class=""panel panel-default"">
                                <div class=""panel-heading"" style=""background-color: rgba(248,248,248,0.7)"">
                                    <h4 class=""panel-title"">
                                        <p style=""color:rgb(62, 80, 89)"">Order Total: ");
            EndContext();
            BeginContext(3026, 21, false);
#line 65 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                                                                                  Write(item.OrderTotalFormat);

#line default
#line hidden
            EndContext();
            BeginContext(3048, 145, true);
            WriteLiteral("</p>\n                                        <div>\n                                            <a data-toggle=\"collapse\" data-parent=\"#accordion\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3193, "\"", 3229, 2);
            WriteAttributeValue("", 3200, "#collapse-", 3200, 10, true);
#line 67 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
WriteAttributeValue("", 3210, item.GetHashCode(), 3210, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3230, 271, true);
            WriteLiteral(@">
                                                Details
                                            </a>
                                        </div>
                                    </h4>
                                </div>
                                <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3501, "\"", 3534, 2);
            WriteAttributeValue("", 3506, "collapse-", 3506, 9, true);
#line 73 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
WriteAttributeValue("", 3515, item.GetHashCode(), 3515, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3535, 794, true);
            WriteLiteral(@" class=""panel-collapse collapse"">
                                    <div class=""panel-body"">
                                        <table class=""table table-bordered table-striped table-hover table-dark"">
                                            <thead>
                                                <tr>
                                                    <th>Selected amount</th>
                                                    <th>Product</th>
                                                    <th class=""text-right"">Price</th>
                                                    <th class=""text-right"">Subtotal</th>
                                                </tr>
                                            </thead>
                                            <tbody>
");
            EndContext();
#line 85 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                                                 foreach (var line in item.OrderLines)
                                                {

#line default
#line hidden
            BeginContext(4466, 137, true);
            WriteLiteral("                                                    <tr>\n                                                        <td class=\"text-center\">");
            EndContext();
            BeginContext(4604, 11, false);
#line 88 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                                                                           Write(line.Amount);

#line default
#line hidden
            EndContext();
            BeginContext(4615, 84, true);
            WriteLiteral("</td>\n                                                        <td class=\"text-left\">");
            EndContext();
            BeginContext(4699, 115, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee34ffd821e4f6bf75181ef11efc22eaaf9fec0919552", async() => {
                BeginContext(4795, 14, false);
#line 89 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                                                                                                                                                                        Write(line.Food.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 89 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                                                                                                                                                 WriteLiteral(line.Food.Id);

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
            BeginContext(4814, 85, true);
            WriteLiteral("</td>\n                                                        <td class=\"text-right\">");
            EndContext();
            BeginContext(4901, 67, false);
#line 90 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                                                                           Write(line.Price.ToString("c",CultureInfo.CreateSpecificCulture("en-US")));

#line default
#line hidden
            EndContext();
            BeginContext(4969, 146, true);
            WriteLiteral("</td>\n                                                        <td class=\"text-right\">\n                                                            ");
            EndContext();
            BeginContext(5117, 83, false);
#line 92 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                                                        Write((line.Amount * line.Price).ToString("c",CultureInfo.CreateSpecificCulture("en-US")));

#line default
#line hidden
            EndContext();
            BeginContext(5201, 121, true);
            WriteLiteral("\n                                                        </td>\n                                                    </tr>\n");
            EndContext();
#line 95 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                                                }

#line default
#line hidden
            BeginContext(5372, 389, true);
            WriteLiteral(@"                                            </tbody>
                                            <tfoot>
                                                <tr>
                                                    <td colspan=""3"" class=""text-right"">Total:</td>
                                                    <td class=""text-right"">
                                                        ");
            EndContext();
            BeginContext(5763, 21, false);
#line 101 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                                                    Write(item.OrderTotalFormat);

#line default
#line hidden
            EndContext();
            BeginContext(5785, 391, true);
            WriteLiteral(@"
                                                    </td>
                                                </tr>
                                            </tfoot>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div> 
                    </div>
");
            EndContext();
#line 111 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                }

#line default
#line hidden
            BeginContext(6194, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 112 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                 if(Model.OrderCount > Model.LatestOrders.Count())
                {
                    

#line default
#line hidden
#line 114 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                     if(User.IsInRole("Admin"))
                    {

#line default
#line hidden
            BeginContext(6349, 47, true);
            WriteLiteral("                        <a class=\"btn btn-info\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 6396, "\"", 6434, 2);
            WriteAttributeValue("", 6403, "/Order/Archive/page-1/", 6403, 22, true);
#line 116 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
WriteAttributeValue("", 6425, Model.Id, 6425, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6435, 10, true);
            WriteLiteral(">More</a>\n");
            EndContext();
#line 117 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(6514, 87, true);
            WriteLiteral("                        <a class=\"btn btn-info\" href=\"/Order/Archive/page-1\" >More</a>\n");
            EndContext();
#line 121 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                    }

#line default
#line hidden
#line 121 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                     
                }

#line default
#line hidden
            BeginContext(6641, 291, true);
            WriteLiteral(@"            </div>
        </div>
        <div class=""col-md-4 col-sm-12 pull-right"">
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    <h1 class=""page-header small"">Personal Details</h1>
                    <p class=""small"">Name: ");
            EndContext();
            BeginContext(6933, 15, false);
#line 129 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                                      Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(6948, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(6950, 14, false);
#line 129 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                                                       Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(6964, 49, true);
            WriteLiteral("</p>\n                    <p class=\"small\">Email: ");
            EndContext();
            BeginContext(7014, 11, false);
#line 130 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                                       Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(7025, 48, true);
            WriteLiteral("</p>\n                    <p class=\"small\">Role: ");
            EndContext();
            BeginContext(7074, 10, false);
#line 131 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                                      Write(Model.Role);

#line default
#line hidden
            EndContext();
            BeginContext(7084, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 132 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                     if(!string.IsNullOrEmpty(Model.PhoneNumber))
                    {

#line default
#line hidden
            BeginContext(7177, 56, true);
            WriteLiteral("                        <p class=\"small\">Phone number : ");
            EndContext();
            BeginContext(7234, 17, false);
#line 134 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                                                   Write(Model.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(7251, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 135 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                    }

#line default
#line hidden
            BeginContext(7278, 46, true);
            WriteLiteral("                    <p class=\"small\">Country: ");
            EndContext();
            BeginContext(7325, 13, false);
#line 136 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                                         Write(Model.Country);

#line default
#line hidden
            EndContext();
            BeginContext(7338, 48, true);
            WriteLiteral("</p>\n                    <p class=\"small\">City: ");
            EndContext();
            BeginContext(7387, 10, false);
#line 137 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                                      Write(Model.City);

#line default
#line hidden
            EndContext();
            BeginContext(7397, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 138 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                     if(!string.IsNullOrEmpty(Model.AddressLine1))
                    {

#line default
#line hidden
            BeginContext(7491, 52, true);
            WriteLiteral("                        <p class=\"small\">Address 1: ");
            EndContext();
            BeginContext(7544, 18, false);
#line 140 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                                               Write(Model.AddressLine1);

#line default
#line hidden
            EndContext();
            BeginContext(7562, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 141 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                    }

#line default
#line hidden
            BeginContext(7589, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 142 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                     if(!string.IsNullOrEmpty(Model.AddressLine2))
                    {

#line default
#line hidden
            BeginContext(7678, 52, true);
            WriteLiteral("                        <p class=\"small\">Address 2: ");
            EndContext();
            BeginContext(7731, 18, false);
#line 144 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                                               Write(Model.AddressLine2);

#line default
#line hidden
            EndContext();
            BeginContext(7749, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 145 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                    }

#line default
#line hidden
            BeginContext(7776, 348, true);
            WriteLiteral(@"                </div>
            </div>
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    <h1 class=""page-header small"">Most Popular</h1>
                    <p class=""page-subtitle small"">Most popular ordered products</p>
                </div>
                <div class=""col-md-12"">
");
            EndContext();
#line 154 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                     if(Model.MostPopularFoods.Count() == 0)
                    {

#line default
#line hidden
            BeginContext(8207, 80, true);
            WriteLiteral("                        <p>It looks like you havn\'t ordered anything yet...</p>\n");
            EndContext();
#line 157 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                    }

#line default
#line hidden
            BeginContext(8309, 44, true);
            WriteLiteral("                    <ul class=\"list-group\">\n");
            EndContext();
#line 159 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                         foreach(var food in Model.MostPopularFoods)
                        {

#line default
#line hidden
            BeginContext(8448, 56, true);
            WriteLiteral("                            <li class=\"list-group-item\">");
            EndContext();
            BeginContext(8504, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee34ffd821e4f6bf75181ef11efc22eaaf9fec0934622", async() => {
                BeginContext(8574, 9, false);
#line 161 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                                                                                                                        Write(food.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 161 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                                                                                                      WriteLiteral(food.Id);

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
            BeginContext(8588, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 162 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Profile.cshtml"
                        }

#line default
#line hidden
            BeginContext(8620, 100, true);
            WriteLiteral("                    </ul>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Shop.Web.Models.Account.AccountProfileModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

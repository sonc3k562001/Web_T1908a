#pragma checksum "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b71aa42abce12209af1af9498b59e063f298955b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Index.cshtml", typeof(AspNetCore.Views_Account_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b71aa42abce12209af1af9498b59e063f298955b", @"/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"305828443d1bbb5288a5e50c77b527fb67997e89", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Shop.Web.Models.Account.AccountIndexModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("homeSearch"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Search..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AdminProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 151, true);
            WriteLiteral("\n<div class=\"container\">\n\t<div class=\"row\">\n\t\t<div class=\"col-md-12\" style=\"margin-top:32px\">\n\t\t\t<div class=\"col-md-6\" style=\"margin-bottom:32px\">\n\t\t\t\t");
            EndContext();
            BeginContext(200, 169, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b71aa42abce12209af1af9498b59e063f298955b6727", async() => {
                BeginContext(265, 6, true);
                WriteLiteral("\n\t\t\t\t\t");
                EndContext();
                BeginContext(271, 86, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b71aa42abce12209af1af9498b59e063f298955b7116", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 8 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchQuery);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(357, 5, true);
                WriteLiteral("\n\t\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(369, 11, true);
            WriteLiteral("\n\t\t\t</div>\n");
            EndContext();
#line 11 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Index.cshtml"
             if(!string.IsNullOrWhiteSpace(Model.SearchQuery))
			{

#line default
#line hidden
            BeginContext(439, 67, true);
            WriteLiteral("\t\t\t\t<div class=\"col-md-8\">\n\t\t\t\t\t<h3>Search Results</h3>\n\t\t\t\t\t<hr/>\n");
            EndContext();
#line 16 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Index.cshtml"
                     if(!Model.Accounts.Any())
					{

#line default
#line hidden
            BeginContext(545, 84, true);
            WriteLiteral("\t\t\t\t\t\t<div>\n\t\t\t\t\t\t\t<h4>It looks like there is no search result...</h4>\n\t\t\t\t\t\t</div>\n");
            EndContext();
#line 21 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Index.cshtml"
					}

#line default
#line hidden
            BeginContext(636, 11, true);
            WriteLiteral("\t\t\t\t</div>\n");
            EndContext();
#line 23 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Index.cshtml"
			}
			else
			{
				

#line default
#line hidden
#line 26 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Index.cshtml"
                 if(!Model.Accounts.Any())
				{

#line default
#line hidden
            BeginContext(702, 51, true);
            WriteLiteral("\t\t\t\t\t<p>It looks like there are no accounts...</p>\n");
            EndContext();
#line 29 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Index.cshtml"
				}

#line default
#line hidden
#line 29 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Index.cshtml"
                 	
			}

#line default
#line hidden
            BeginContext(765, 3, true);
            WriteLiteral("\t\t\t");
            EndContext();
#line 31 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Index.cshtml"
             foreach(var account in Model.Accounts)
			{

#line default
#line hidden
            BeginContext(813, 226, true);
            WriteLiteral("\t\t\t\t<div class=\"col-md-8 col-sm-12 pull-left posttimeline\">\n\t\t\t\t\t<div class=\"panel-group\" id=\"accordion\">\n\t\t\t\t\t\t<div class=\"panel panel-default\">\n\t\t\t\t\t\t\t<div class=\"panel-heading\">\n\t\t\t\t\t\t\t\t<h4 class=\"panel-title\">\n\t\t\t\t\t\t\t\t\t<p>");
            EndContext();
            BeginContext(1040, 17, false);
#line 38 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Index.cshtml"
                                  Write(account.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1057, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1059, 16, false);
#line 38 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Index.cshtml"
                                                     Write(account.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1075, 80, true);
            WriteLiteral("</p>\n\t\t\t\t\t\t\t\t\t<div>\n\t\t\t\t\t\t\t\t\t\t<a data-toggle=\"collapse\" data-parent=\"#accordion\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1155, "\"", 1194, 2);
            WriteAttributeValue("", 1162, "#collapse-", 1162, 10, true);
#line 40 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Index.cshtml"
WriteAttributeValue("", 1172, account.GetHashCode(), 1172, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1195, 91, true);
            WriteLiteral(">\n\t\t\t\t\t\t\t\t\t\t\tDetails\n\t\t\t\t\t\t\t\t\t\t</a>\n\t\t\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t\t</h4>\n\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t<div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1286, "\"", 1322, 2);
            WriteAttributeValue("", 1291, "collapse-", 1291, 9, true);
#line 46 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Index.cshtml"
WriteAttributeValue("", 1300, account.GetHashCode(), 1300, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1323, 132, true);
            WriteLiteral(" class=\"panel-collapse collapse\">\n\t\t\t\t\t\t\t\t<div class=\"panel-body\">\n\t\t\t\t\t\t\t\t\t<div class=\"jumbotron\">\n\t\t\t\t\t\t\t\t\t\t<h2 class=\"display-4\">");
            EndContext();
            BeginContext(1456, 17, false);
#line 49 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Index.cshtml"
                                                         Write(account.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1473, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1475, 16, false);
#line 49 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Index.cshtml"
                                                                            Write(account.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1491, 144, true);
            WriteLiteral("</h2>\n\t\t\t\t\t\t\t\t\t\t<ul class=\"nav nav-pills pull-left countlist\" role=\"tablist\">\n\t\t\t\t\t\t\t\t\t\t\t<li role=\"presentation\">\n\t\t\t\t\t\t\t\t\t\t\t\t<h3>\n\t\t\t\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1636, 21, false);
#line 53 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Index.cshtml"
                                               Write(account.BalanceFormat);

#line default
#line hidden
            EndContext();
            BeginContext(1657, 142, true);
            WriteLiteral("<br>\n\t\t\t\t\t\t\t\t\t\t\t\t\t<small>Balance</small>\n\t\t\t\t\t\t\t\t\t\t\t\t</h3>\n\t\t\t\t\t\t\t\t\t\t\t</li>\n\t\t\t\t\t\t\t\t\t\t\t<li role=\"presentation\">\n\t\t\t\t\t\t\t\t\t\t\t\t<h3>\n\t\t\t\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1800, 24, false);
#line 59 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Index.cshtml"
                                               Write(account.TotalSpentFormat);

#line default
#line hidden
            EndContext();
            BeginContext(1824, 146, true);
            WriteLiteral("<br>\n\t\t\t\t\t\t\t\t\t\t\t\t\t<small>Total Spent</small>\n\t\t\t\t\t\t\t\t\t\t\t\t</h3>\n\t\t\t\t\t\t\t\t\t\t\t</li>\n\t\t\t\t\t\t\t\t\t\t\t<li role=\"presentation\">\n\t\t\t\t\t\t\t\t\t\t\t\t<h3>\n\t\t\t\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1971, 18, false);
#line 65 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Index.cshtml"
                                               Write(account.OrderCount);

#line default
#line hidden
            EndContext();
            BeginContext(1989, 148, true);
            WriteLiteral("<br>\n\t\t\t\t\t\t\t\t\t\t\t\t\t<small>Orders placed</small>\n\t\t\t\t\t\t\t\t\t\t\t\t</h3>\n\t\t\t\t\t\t\t\t\t\t\t</li>\n\t\t\t\t\t\t\t\t\t\t\t<li role=\"presentation\">\n\t\t\t\t\t\t\t\t\t\t\t\t<h3>\n\t\t\t\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(2138, 42, false);
#line 71 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Index.cshtml"
                                               Write(account.MemberSince.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(2180, 280, true);
            WriteLiteral(@"<br>
													<small>Member since</small>
												</h3>
											</li>
										</ul>
										<div class=""panel panel-default"">
											<div class=""panel-heading"">
												<h1 class=""page-header small"">Personal Details</h1>
												<p class=""small"">Email: ");
            EndContext();
            BeginContext(2461, 13, false);
#line 79 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Index.cshtml"
                                                                   Write(account.Email);

#line default
#line hidden
            EndContext();
            BeginContext(2474, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 80 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Index.cshtml"
                                                 if(!string.IsNullOrEmpty(account.PhoneNumber))
												{

#line default
#line hidden
            BeginContext(2553, 45, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t<p class=\"small\">Phone number : ");
            EndContext();
            BeginContext(2599, 19, false);
#line 82 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Index.cshtml"
                                                                               Write(account.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2618, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 83 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Index.cshtml"
												}

#line default
#line hidden
            BeginContext(2637, 38, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t<p class=\"small\">Country: ");
            EndContext();
            BeginContext(2676, 15, false);
#line 84 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Index.cshtml"
                                                                     Write(account.Country);

#line default
#line hidden
            EndContext();
            BeginContext(2691, 40, true);
            WriteLiteral("</p>\n\t\t\t\t\t\t\t\t\t\t\t\t<p class=\"small\">City: ");
            EndContext();
            BeginContext(2732, 12, false);
#line 85 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Index.cshtml"
                                                                  Write(account.City);

#line default
#line hidden
            EndContext();
            BeginContext(2744, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 86 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Index.cshtml"
                                                 if(!string.IsNullOrEmpty(account.AddressLine1))
												{

#line default
#line hidden
            BeginContext(2824, 41, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t<p class=\"small\">Address 1: ");
            EndContext();
            BeginContext(2866, 20, false);
#line 88 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Index.cshtml"
                                                                           Write(account.AddressLine1);

#line default
#line hidden
            EndContext();
            BeginContext(2886, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 89 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Index.cshtml"
												}

#line default
#line hidden
            BeginContext(2905, 12, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t");
            EndContext();
#line 90 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Index.cshtml"
                                                 if(!string.IsNullOrEmpty(account.AddressLine2))
												{

#line default
#line hidden
            BeginContext(2980, 41, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t<p class=\"small\">Address 2: ");
            EndContext();
            BeginContext(3022, 20, false);
#line 92 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Index.cshtml"
                                                                           Write(account.AddressLine2);

#line default
#line hidden
            EndContext();
            BeginContext(3042, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 93 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Index.cshtml"
												}

#line default
#line hidden
            BeginContext(3061, 35, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t<p class=\"small\">Role: ");
            EndContext();
            BeginContext(3097, 12, false);
#line 94 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Index.cshtml"
                                                                  Write(account.Role);

#line default
#line hidden
            EndContext();
            BeginContext(3109, 50, true);
            WriteLiteral("</p>\n\t\t\t\t\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(3159, 147, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b71aa42abce12209af1af9498b59e063f298955b23811", async() => {
                BeginContext(3289, 13, true);
                WriteLiteral("Go to profile");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 97 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Index.cshtml"
                                                                                                                                                 WriteLiteral(account.Id);

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
            BeginContext(3306, 83, true);
            WriteLiteral("\n\t\t\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t</div>\n\t\t\t\t\t</div> \n\t\t\t\t</div>\n");
            EndContext();
#line 104 "C:\Users\son10\OneDrive\Máy tính\eCommerceDemo\Shop.Web\Views\Account\Index.cshtml"
			}

#line default
#line hidden
            BeginContext(3394, 23, true);
            WriteLiteral("\t\t</div>\n\t</div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Shop.Web.Models.Account.AccountIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

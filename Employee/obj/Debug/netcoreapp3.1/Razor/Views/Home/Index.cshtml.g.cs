#pragma checksum "C:\Users\son10\source\repos\Employee\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e9259883b8d9bb97ffff7a134e87ae3fc05cd5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\son10\source\repos\Employee\Views\_ViewImports.cshtml"
using Employee;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\son10\source\repos\Employee\Views\_ViewImports.cshtml"
using Employee.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e9259883b8d9bb97ffff7a134e87ae3fc05cd5c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e34b09c5bebdb4ae05a509d36335bc47af3a9ad", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    

    <div>
        <table>
            <thead>
                <tr style=""width=250px"">
                    <td>
                        Name
                    </td>
                    <td>
                        Birthday
                    </td>
                    <td>
                        Address
                    </td>
                    <td>
                        Email
                    </td>
                    <td>
                        Salary
                    </td>
                </tr>
            </thead>    
            <tbody>
");
#nullable restore
#line 27 "C:\Users\son10\source\repos\Employee\Views\Home\Index.cshtml"
                 foreach (var p in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 30 "C:\Users\son10\source\repos\Employee\Views\Home\Index.cshtml"
                       Write(p.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 31 "C:\Users\son10\source\repos\Employee\Views\Home\Index.cshtml"
                       Write(p.Birthday);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 32 "C:\Users\son10\source\repos\Employee\Views\Home\Index.cshtml"
                       Write(p.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 33 "C:\Users\son10\source\repos\Employee\Views\Home\Index.cshtml"
                       Write(p.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 34 "C:\Users\son10\source\repos\Employee\Views\Home\Index.cshtml"
                       Write(p.Salary.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 36 "C:\Users\son10\source\repos\Employee\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n        </table>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "D:\Application\Group\1670-App-group\The cool Library\Views\Customer\OrderList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29f6a02af7b7f30481d24ad773f0186ad7bde9e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_OrderList), @"mvc.1.0.view", @"/Views/Customer/OrderList.cshtml")]
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
#line 1 "D:\Application\Group\1670-App-group\The cool Library\Views\_ViewImports.cshtml"
using The_cool_Library;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Application\Group\1670-App-group\The cool Library\Views\_ViewImports.cshtml"
using The_cool_Library.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29f6a02af7b7f30481d24ad773f0186ad7bde9e4", @"/Views/Customer/OrderList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1605e623f181fd5e39f2f180cb413c544321ed1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Customer_OrderList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Order>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Application\Group\1670-App-group\The cool Library\Views\Customer\OrderList.cshtml"
 if (User.Identity.IsAuthenticated && User.IsInRole("Customer"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-info"">
        <tr>
            <th colspan=""4"">Order List</th>
        </tr>
        <tr>
            <th>Id</th>
            <th>Date</th>
            <th>Book ID</th>
            <th>Quantity</th>
            <th>Price</th>

        </tr>
");
#nullable restore
#line 16 "D:\Application\Group\1670-App-group\The cool Library\Views\Customer\OrderList.cshtml"
         foreach (var uni in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 19 "D:\Application\Group\1670-App-group\The cool Library\Views\Customer\OrderList.cshtml"
               Write(uni.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "D:\Application\Group\1670-App-group\The cool Library\Views\Customer\OrderList.cshtml"
               Write(uni.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "D:\Application\Group\1670-App-group\The cool Library\Views\Customer\OrderList.cshtml"
               Write(uni.BookId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "D:\Application\Group\1670-App-group\The cool Library\Views\Customer\OrderList.cshtml"
               Write(uni.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "D:\Application\Group\1670-App-group\The cool Library\Views\Customer\OrderList.cshtml"
               Write(uni.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 25 "D:\Application\Group\1670-App-group\The cool Library\Views\Customer\OrderList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
#nullable restore
#line 27 "D:\Application\Group\1670-App-group\The cool Library\Views\Customer\OrderList.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Order>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

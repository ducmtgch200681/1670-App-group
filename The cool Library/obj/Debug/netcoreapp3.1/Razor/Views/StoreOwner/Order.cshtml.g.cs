#pragma checksum "G:\Git\1670-App-group\The cool Library\Views\StoreOwner\Order.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf9d471fc98b34b81ed604224a02c5a1054fc61c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StoreOwner_Order), @"mvc.1.0.view", @"/Views/StoreOwner/Order.cshtml")]
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
#line 1 "G:\Git\1670-App-group\The cool Library\Views\_ViewImports.cshtml"
using The_cool_Library;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Git\1670-App-group\The cool Library\Views\_ViewImports.cshtml"
using The_cool_Library.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf9d471fc98b34b81ed604224a02c5a1054fc61c", @"/Views/StoreOwner/Order.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1605e623f181fd5e39f2f180cb413c544321ed1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_StoreOwner_Order : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Order>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\Git\1670-App-group\The cool Library\Views\StoreOwner\Order.cshtml"
  
    Layout = "_LayoutBookCRUD";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <table class=""table table-info"">
        <tr>
            <th colspan=""4"">Order List</th>
        </tr>
        <tr>
            <th>Id</th>
            <th>Account</th>
            <th>Date</th>
            <th>Book Name</th>
            <th>Quantity</th>
            <th>Book Price ($)</th>
            <th>Bill ($)</th>
        </tr>

");
#nullable restore
#line 21 "G:\Git\1670-App-group\The cool Library\Views\StoreOwner\Order.cshtml"
         foreach (var order in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 24 "G:\Git\1670-App-group\The cool Library\Views\StoreOwner\Order.cshtml"
               Write(order.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "G:\Git\1670-App-group\The cool Library\Views\StoreOwner\Order.cshtml"
               Write(order.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "G:\Git\1670-App-group\The cool Library\Views\StoreOwner\Order.cshtml"
               Write(order.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "G:\Git\1670-App-group\The cool Library\Views\StoreOwner\Order.cshtml"
               Write(order.Book.Book_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "G:\Git\1670-App-group\The cool Library\Views\StoreOwner\Order.cshtml"
               Write(order.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "G:\Git\1670-App-group\The cool Library\Views\StoreOwner\Order.cshtml"
               Write(order.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "G:\Git\1670-App-group\The cool Library\Views\StoreOwner\Order.cshtml"
               Write(order.Bill);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 32 "G:\Git\1670-App-group\The cool Library\Views\StoreOwner\Order.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>");
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

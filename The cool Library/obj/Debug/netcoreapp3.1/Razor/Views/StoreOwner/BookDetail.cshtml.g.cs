#pragma checksum "G:\Git\1670-App-group\The cool Library\Views\StoreOwner\BookDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a66e54ef63b5de618112309ff443ccf0af4dc6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StoreOwner_BookDetail), @"mvc.1.0.view", @"/Views/StoreOwner/BookDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a66e54ef63b5de618112309ff443ccf0af4dc6f", @"/Views/StoreOwner/BookDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1605e623f181fd5e39f2f180cb413c544321ed1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_StoreOwner_BookDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<The_cool_Library.Models.Book>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row text-center\">\r\n    <div class=\"col\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 105, "\"", 128, 1);
#nullable restore
#line 5 "G:\Git\1670-App-group\The cool Library\Views\StoreOwner\BookDetail.cshtml"
WriteAttributeValue("", 111, Model.Book_image, 111, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"600px\" height=\"750px\">\r\n    </div>\r\n    <div class=\"col\">\r\n        <table class=\"table-bordered bg-light\">\r\n            <tr>\r\n                <th colspan=\"2\" class=\"h3 text-primary\">");
#nullable restore
#line 10 "G:\Git\1670-App-group\The cool Library\Views\StoreOwner\BookDetail.cshtml"
                                                   Write(Model.Book_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            </tr>\r\n            <tr>\r\n                <th>Author</th>\r\n                <td>");
#nullable restore
#line 14 "G:\Git\1670-App-group\The cool Library\Views\StoreOwner\BookDetail.cshtml"
               Write(Model.Book_author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Publisher</th>\r\n                <td>");
#nullable restore
#line 18 "G:\Git\1670-App-group\The cool Library\Views\StoreOwner\BookDetail.cshtml"
               Write(Model.Book_publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Publication date</th>\r\n                <td>");
#nullable restore
#line 22 "G:\Git\1670-App-group\The cool Library\Views\StoreOwner\BookDetail.cshtml"
               Write(Model.Book_date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Price</th>\r\n                <td>");
#nullable restore
#line 26 "G:\Git\1670-App-group\The cool Library\Views\StoreOwner\BookDetail.cshtml"
               Write(Model.Book_price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Description</th>\r\n                <td>");
#nullable restore
#line 30 "G:\Git\1670-App-group\The cool Library\Views\StoreOwner\BookDetail.cshtml"
               Write(Model.Book_description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Quantity</th>\r\n                <td>");
#nullable restore
#line 34 "G:\Git\1670-App-group\The cool Library\Views\StoreOwner\BookDetail.cshtml"
               Write(Model.Book_quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Genre</th>\r\n                <td>\r\n");
            WriteLiteral("                        ");
#nullable restore
#line 40 "G:\Git\1670-App-group\The cool Library\Views\StoreOwner\BookDetail.cshtml"
                   Write(Model.Genre.Genre_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                </td>\r\n            </tr>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<The_cool_Library.Models.Book> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

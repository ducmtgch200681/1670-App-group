#pragma checksum "D:\Application\Group\1670-App-group\The cool Library\Views\Customer\Book.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21b5f891270013bdd8e66ee7ff937dfa4faa3116"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Book), @"mvc.1.0.view", @"/Views/Customer/Book.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21b5f891270013bdd8e66ee7ff937dfa4faa3116", @"/Views/Customer/Book.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1605e623f181fd5e39f2f180cb413c544321ed1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Customer_Book : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Book>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Application\Group\1670-App-group\The cool Library\Views\Customer\Book.cshtml"
  
    Layout = "_LayoutRegister";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"container page-wrapper\">\r\n        <div class=\"page-inner\">\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 10 "D:\Application\Group\1670-App-group\The cool Library\Views\Customer\Book.cshtml"
                 foreach (var book in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"el-wrapper\">\r\n                        <div class=\"box-up\">\r\n                            <img class=\"img\"");
            BeginWriteAttribute("src", " src=\"", 394, "\"", 416, 1);
#nullable restore
#line 14 "D:\Application\Group\1670-App-group\The cool Library\Views\Customer\Book.cshtml"
WriteAttributeValue("", 400, book.Book_image, 400, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 417, "\"", 423, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"img-info\">\r\n                                <div class=\"info-inner\">\r\n                                    <span class=\"p-name\">");
#nullable restore
#line 17 "D:\Application\Group\1670-App-group\The cool Library\Views\Customer\Book.cshtml"
                                                    Write(book.Book_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    <span class=\"p-company\">");
#nullable restore
#line 18 "D:\Application\Group\1670-App-group\The cool Library\Views\Customer\Book.cshtml"
                                                       Write(book.Book_author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </div>\r\n                                <div class=\"a-size size\">Available in storage : <span class=\"size\">");
#nullable restore
#line 20 "D:\Application\Group\1670-App-group\The cool Library\Views\Customer\Book.cshtml"
                                                                                              Write(book.Book_quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></div>
                            </div>
                        </div>

                        <div class=""box-down"">
                            <div class=""h-bg"">
                                <div class=""h-bg-inner""></div>
                            </div>

                            <a class=""cart"" href=""#"">
                                <span class=""price"">$");
#nullable restore
#line 30 "D:\Application\Group\1670-App-group\The cool Library\Views\Customer\Book.cshtml"
                                                Write(book.Book_price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                <span class=""add-to-cart"">
                                    <span class=""txt"">Add in cart</span>
                                </span>
                            </a>
                        </div>


                    </div>
");
#nullable restore
#line 39 "D:\Application\Group\1670-App-group\The cool Library\Views\Customer\Book.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Book>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

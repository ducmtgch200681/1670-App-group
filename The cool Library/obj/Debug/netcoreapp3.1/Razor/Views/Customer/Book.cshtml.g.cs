#pragma checksum "D:\Application\Group\1670-App-group\The cool Library\Views\Customer\Book.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25f62e92122dc5b904c4f48299660ee0042b9e4c"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25f62e92122dc5b904c4f48299660ee0042b9e4c", @"/Views/Customer/Book.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1605e623f181fd5e39f2f180cb413c544321ed1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Customer_Book : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Book>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Application\Group\1670-App-group\The cool Library\Views\Customer\Book.cshtml"
 if (TempData["Message"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h5 class=\"alert alert-danger\">");
#nullable restore
#line 5 "D:\Application\Group\1670-App-group\The cool Library\Views\Customer\Book.cshtml"
                              Write(TempData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 6 "D:\Application\Group\1670-App-group\The cool Library\Views\Customer\Book.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "D:\Application\Group\1670-App-group\The cool Library\Views\Customer\Book.cshtml"
  
    Layout = "_LayoutViewBook";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<hr />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25f62e92122dc5b904c4f48299660ee0042b9e4c5152", async() => {
                WriteLiteral(@"
    <div class=""input-group"">
        <div class=""form-outline"">
            <input type=""search"" name=""key"" class=""form-control"" placeholder=""Search"" />
        </div>
        <button type=""submit"" class=""btn"" style=""background:mediumpurple"">
            <i class=""icon-search""></i>
        </button>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n<div class=\"container page-wrapper\">\r\n    <div class=\"page-inner\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 28 "D:\Application\Group\1670-App-group\The cool Library\Views\Customer\Book.cshtml"
             foreach (var book in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"el-wrapper\">\r\n                    <div class=\"box-up\">\r\n                        <img class=\"img\"");
            BeginWriteAttribute("src", " src=\"", 854, "\"", 876, 1);
#nullable restore
#line 32 "D:\Application\Group\1670-App-group\The cool Library\Views\Customer\Book.cshtml"
WriteAttributeValue("", 860, book.Book_image, 860, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 877, "\"", 883, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"img-info\">\r\n                            <div class=\"info-inner\">\r\n                                <span class=\"p-name\">");
#nullable restore
#line 35 "D:\Application\Group\1670-App-group\The cool Library\Views\Customer\Book.cshtml"
                                                Write(book.Book_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <span class=\"p-company\">");
#nullable restore
#line 36 "D:\Application\Group\1670-App-group\The cool Library\Views\Customer\Book.cshtml"
                                                   Write(book.Book_author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                            <div class=\"a-size size\">Available in storage : <span class=\"size\">");
#nullable restore
#line 38 "D:\Application\Group\1670-App-group\The cool Library\Views\Customer\Book.cshtml"
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
#line 46 "D:\Application\Group\1670-App-group\The cool Library\Views\Customer\Book.cshtml"
                                            Write(book.Book_price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            <span class=\"add-to-cart\">\r\n                                <span class=\"txt\">Add in cart</span>\r\n                            </span>\r\n                        </a>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 53 "D:\Application\Group\1670-App-group\The cool Library\Views\Customer\Book.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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

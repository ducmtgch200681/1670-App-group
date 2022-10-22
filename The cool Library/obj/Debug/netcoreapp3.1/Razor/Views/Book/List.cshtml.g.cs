#pragma checksum "G:\Git\1670-App-group\The cool Library\Views\Book\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88188e34a728ececa2aeaa72e8e4c25acdee5590"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_List), @"mvc.1.0.view", @"/Views/Book/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88188e34a728ececa2aeaa72e8e4c25acdee5590", @"/Views/Book/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1605e623f181fd5e39f2f180cb413c544321ed1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Book_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Book>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-link btn-sm text text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\Git\1670-App-group\The cool Library\Views\Book\List.cshtml"
      if (TempData["Message"] != null){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 class=\"alert alert-info\">");
#nullable restore
#line 4 "G:\Git\1670-App-group\The cool Library\Views\Book\List.cshtml"
                                Write(TempData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 5 "G:\Git\1670-App-group\The cool Library\Views\Book\List.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "G:\Git\1670-App-group\The cool Library\Views\Book\List.cshtml"
     if (Model.Count == 0) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2 class=\"alert alert-warning\">No book in system</h2>\r\n");
#nullable restore
#line 9 "G:\Git\1670-App-group\The cool Library\Views\Book\List.cshtml"
    } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"carousel-item\">\r\n");
#nullable restore
#line 11 "G:\Git\1670-App-group\The cool Library\Views\Book\List.cshtml"
             foreach(var book in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("                <img");
            BeginWriteAttribute("src", " src=\"", 342, "\"", 364, 1);
#nullable restore
#line 12 "G:\Git\1670-App-group\The cool Library\Views\Book\List.cshtml"
WriteAttributeValue("", 348, book.Book_image, 348, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"carousel-caption d-none d-md-block\">\r\n                    <h5>");
#nullable restore
#line 14 "G:\Git\1670-App-group\The cool Library\Views\Book\List.cshtml"
                   Write(book.Book_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88188e34a728ececa2aeaa72e8e4c25acdee55906657", async() => {
                WriteLiteral("Detail");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "G:\Git\1670-App-group\The cool Library\Views\Book\List.cshtml"
                                                                                                                WriteLiteral(book.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 17 "G:\Git\1670-App-group\The cool Library\Views\Book\List.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
            WriteLiteral("    <div class=\"container mt-5 mb-5\">\r\n        <div class=\"d-flex justify-content-center row\">\r\n            <div class=\"col-md-10\">\r\n");
#nullable restore
#line 23 "G:\Git\1670-App-group\The cool Library\Views\Book\List.cshtml"
                 foreach (var book in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"row p-2 bg-white border rounded mt-2\">\r\n                        <div class=\"col-md-3 mt-1\"><img class=\"img-fluid img-responsive rounded product-image\"");
            BeginWriteAttribute("src", " src=\"", 1045, "\"", 1067, 1);
#nullable restore
#line 25 "G:\Git\1670-App-group\The cool Library\Views\Book\List.cshtml"
WriteAttributeValue("", 1051, book.Book_image, 1051, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                        <div class=\"col-md-6 mt-1\">\r\n                            <h5>");
#nullable restore
#line 27 "G:\Git\1670-App-group\The cool Library\Views\Book\List.cshtml"
                           Write(book.Book_name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                            <div class=""d-flex flex-row"">
                                <div class=""ratings mr-2""><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i></div><span>$$$</span>
                            </div>
                            <div class=""mt-1 mb-1 spec-1""><span>Author</span><span class=""dot""></span><span></span><span class=""dot""></span><span>");
#nullable restore
#line 31 "G:\Git\1670-App-group\The cool Library\Views\Book\List.cshtml"
                                                                                                                                             Write(book.Book_author);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br></span></div>\r\n                            <div class=\"mt-1 mb-1 spec-1\"><span>Quantity</span><span class=\"dot\"></span><span></span><span class=\"dot\"></span><span>");
#nullable restore
#line 32 "G:\Git\1670-App-group\The cool Library\Views\Book\List.cshtml"
                                                                                                                                               Write(book.Book_quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br></span></div>\r\n                            <p class=\"text-justify text-truncate para mb-0\">");
#nullable restore
#line 33 "G:\Git\1670-App-group\The cool Library\Views\Book\List.cshtml"
                                                                       Write(book.Book_description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br><br></p>
                        </div>
                        <div class=""align-items-center align-content-center col-md-3 border-left mt-1"">
                            <div class=""d-flex flex-row align-items-center"">
                                <h4 class=""mr-1"">");
#nullable restore
#line 37 "G:\Git\1670-App-group\The cool Library\Views\Book\List.cshtml"
                                            Write(book.Book_price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            </div>\r\n                            <h6 class=\"text-success\">Free shipping</h6>\r\n                            <div class=\"d-flex flex-column mt-4\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88188e34a728ececa2aeaa72e8e4c25acdee559013086", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "G:\Git\1670-App-group\The cool Library\Views\Book\List.cshtml"
                                                                                                                   WriteLiteral(book.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <button class=\"btn btn-outline-primary btn-sm mt-2\" type=\"button\">Add to wishlist</button>\r\n                             </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 46 "G:\Git\1670-App-group\The cool Library\Views\Book\List.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 50 "G:\Git\1670-App-group\The cool Library\Views\Book\List.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
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

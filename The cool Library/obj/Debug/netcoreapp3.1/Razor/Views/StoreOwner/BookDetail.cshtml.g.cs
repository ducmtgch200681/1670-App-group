<<<<<<< HEAD
#pragma checksum "D:\Application\Group\1670-App-group\The cool Library\Views\StoreOwner\BookDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b48cd7abdd859dc50f454f249907b060b3e90ac7"
=======
#pragma checksum "G:\Git\1670-App-group\The cool Library\Views\StoreOwner\BookDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "549796af615952df6ac87aec65d2ba12100a757c"
>>>>>>> 5262b9f4535c34dc0a66404cdd3864a877cb17d2
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
<<<<<<< HEAD
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b48cd7abdd859dc50f454f249907b060b3e90ac7", @"/Views/StoreOwner/BookDetail.cshtml")]
=======
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"549796af615952df6ac87aec65d2ba12100a757c", @"/Views/StoreOwner/BookDetail.cshtml")]
>>>>>>> 5262b9f4535c34dc0a66404cdd3864a877cb17d2
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1605e623f181fd5e39f2f180cb413c544321ed1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_StoreOwner_BookDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<The_cool_Library.Models.Book>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background:burlywood; color:white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "StoreOwner", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditBook", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BookSameGenre", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Application\Group\1670-App-group\The cool Library\Views\StoreOwner\BookDetail.cshtml"
  
    Layout = "_LayoutBookCRUD";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b48cd7abdd859dc50f454f249907b060b3e90ac76720", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "549796af615952df6ac87aec65d2ba12100a757c6664", async() => {
>>>>>>> 5262b9f4535c34dc0a66404cdd3864a877cb17d2
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <section style=""background-color: #eee;"">
        <div class=""container py-5"">
            <div class=""row justify-content-center"">
                <div class=""col-md-8 col-lg-6 col-xl-4"">
                    <div class=""card text-black"">
                        <i class=""fab icon-apple fa-lg pt-3 pb-1 px-3""></i>
                        <img");
            BeginWriteAttribute("src", " src=\"", 665, "\"", 688, 1);
#nullable restore
<<<<<<< HEAD
#line 17 "D:\Application\Group\1670-App-group\The cool Library\Views\StoreOwner\BookDetail.cshtml"
=======
#line 17 "G:\Git\1670-App-group\The cool Library\Views\StoreOwner\BookDetail.cshtml"
>>>>>>> 5262b9f4535c34dc0a66404cdd3864a877cb17d2
WriteAttributeValue("", 671, Model.Book_image, 671, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" />\r\n\r\n                        <div class=\"card-body\">\r\n                            <div class=\"text-center\">\r\n                                <h5 class=\"card-title\">ID: ");
#nullable restore
#line 21 "D:\Application\Group\1670-App-group\The cool Library\Views\StoreOwner\BookDetail.cshtml"
                                                      Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <p class=\"text-muted mb-4\">Name: ");
#nullable restore
#line 22 "D:\Application\Group\1670-App-group\The cool Library\Views\StoreOwner\BookDetail.cshtml"
                                                            Write(Model.Book_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
            WriteLiteral("                                ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b48cd7abdd859dc50f454f249907b060b3e90ac79989", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "549796af615952df6ac87aec65d2ba12100a757c9891", async() => {
>>>>>>> 5262b9f4535c34dc0a66404cdd3864a877cb17d2
                WriteLiteral("<i class=\"material-icons\" data-toggle=\"tooltip\" title=\"Edit\">&#xE254;</i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "D:\Application\Group\1670-App-group\The cool Library\Views\StoreOwner\BookDetail.cshtml"
                                                                                                    WriteLiteral(Model.Id);

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
            WriteLiteral("\r\n                                ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b48cd7abdd859dc50f454f249907b060b3e90ac712602", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "549796af615952df6ac87aec65d2ba12100a757c12490", async() => {
>>>>>>> 5262b9f4535c34dc0a66404cdd3864a877cb17d2
                WriteLiteral("<i class=\"material-icons\" data-toggle=\"tooltip\" title=\"Delete\">&#xE872;</i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "D:\Application\Group\1670-App-group\The cool Library\Views\StoreOwner\BookDetail.cshtml"
                                                                                                    WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1429, "return", 1429, 6, true);
            AddHtmlAttributeValue(" ", 1435, "confirm(\'Delete", 1436, 16, true);
#nullable restore
<<<<<<< HEAD
#line 26 "D:\Application\Group\1670-App-group\The cool Library\Views\StoreOwner\BookDetail.cshtml"
=======
#line 26 "G:\Git\1670-App-group\The cool Library\Views\StoreOwner\BookDetail.cshtml"
>>>>>>> 5262b9f4535c34dc0a66404cdd3864a877cb17d2
AddHtmlAttributeValue(" ", 1451, Model.Book_name, 1452, 16, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1468, "?\');", 1468, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <div>\r\n                                    <div class=\"d-flex justify-content-between\">\r\n                                        <span>Author</span><span>");
#nullable restore
#line 29 "D:\Application\Group\1670-App-group\The cool Library\Views\StoreOwner\BookDetail.cshtml"
                                                            Write(Model.Book_author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </div>\r\n                                    <div class=\"d-flex justify-content-between\">\r\n                                        <span>Publisher</span><span>");
#nullable restore
#line 32 "D:\Application\Group\1670-App-group\The cool Library\Views\StoreOwner\BookDetail.cshtml"
                                                               Write(Model.Book_publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </div>\r\n                                    <div class=\"d-flex justify-content-between\">\r\n                                        <span>Publisher date</span><span>");
#nullable restore
#line 35 "D:\Application\Group\1670-App-group\The cool Library\Views\StoreOwner\BookDetail.cshtml"
                                                                    Write(Model.Book_date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </div>\r\n                                    <div class=\"d-flex justify-content-between\">\r\n                                        <span>Price</span><span>");
#nullable restore
#line 38 "D:\Application\Group\1670-App-group\The cool Library\Views\StoreOwner\BookDetail.cshtml"
                                                           Write(Model.Book_price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </div>\r\n                                    <div class=\"d-flex justify-content-between\">\r\n                                        <span>Quantity</span><span>");
#nullable restore
#line 41 "D:\Application\Group\1670-App-group\The cool Library\Views\StoreOwner\BookDetail.cshtml"
                                                              Write(Model.Book_quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>
                                    <div class=""d-flex justify-content-between"">
                                        <span>Genre</span>
                                        <span>
                                            ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b48cd7abdd859dc50f454f249907b060b3e90ac718681", async() => {
                WriteLiteral("\r\n                                            ");
#nullable restore
#line 48 "D:\Application\Group\1670-App-group\The cool Library\Views\StoreOwner\BookDetail.cshtml"
                                       Write(Model.Genre.Genre_name);
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "549796af615952df6ac87aec65d2ba12100a757c18471", async() => {
                WriteLiteral("\r\n                                                ");
#nullable restore
#line 47 "G:\Git\1670-App-group\The cool Library\Views\StoreOwner\BookDetail.cshtml"
                                           Write(Model.Genre.Genre_name);
>>>>>>> 5262b9f4535c34dc0a66404cdd3864a877cb17d2

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
<<<<<<< HEAD
#line 47 "D:\Application\Group\1670-App-group\The cool Library\Views\StoreOwner\BookDetail.cshtml"
                                              WriteLiteral(Model.Genre.Id);
=======
#line 46 "G:\Git\1670-App-group\The cool Library\Views\StoreOwner\BookDetail.cshtml"
                                                                                                        WriteLiteral(Model.Genre.Id);
>>>>>>> 5262b9f4535c34dc0a66404cdd3864a877cb17d2

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
            WriteLiteral(@"
                                        </span>
                                    </div>
                                    <div class=""d-flex justify-content-between"">
                                        <span>Description</span>
                                        <span>
                                            <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#exampleModalLong"">
                                                Enter
                                            </button>
                                        </span>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- Modal -->
    <div class=""modal fade"" id=""exampleModalLong"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLongTitle"" aria-hidden=""true"">
        <div ");
            WriteLiteral(@"class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLongTitle"">Description</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                     <div class=""modal-body"">                  
                        ");
#nullable restore
<<<<<<< HEAD
#line 80 "D:\Application\Group\1670-App-group\The cool Library\Views\StoreOwner\BookDetail.cshtml"
=======
#line 79 "G:\Git\1670-App-group\The cool Library\Views\StoreOwner\BookDetail.cshtml"
>>>>>>> 5262b9f4535c34dc0a66404cdd3864a877cb17d2
                   Write(Model.Book_description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>          
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                </div>
            </div>
        </div>
    </div>
");
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

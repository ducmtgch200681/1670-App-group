#pragma checksum "D:\Application\Group\1670-App-group\The cool Library\Views\GenreRequest\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fe61d09b5436c6c4ffdb613c3a9c3c1ba6be2ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GenreRequest_Index), @"mvc.1.0.view", @"/Views/GenreRequest/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fe61d09b5436c6c4ffdb613c3a9c3c1ba6be2ea", @"/Views/GenreRequest/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1605e623f181fd5e39f2f180cb413c544321ed1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_GenreRequest_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GenreRequest>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Genre", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Accept", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "GenreRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Reject", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Application\Group\1670-App-group\The cool Library\Views\GenreRequest\Index.cshtml"
  
    Layout = "~/Views/Shared/_LayoutBookCRUD.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\Application\Group\1670-App-group\The cool Library\Views\GenreRequest\Index.cshtml"
 if (TempData["Message"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h5 class=\"alert alert-info\">");
#nullable restore
#line 9 "D:\Application\Group\1670-App-group\The cool Library\Views\GenreRequest\Index.cshtml"
                            Write(TempData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 10 "D:\Application\Group\1670-App-group\The cool Library\Views\GenreRequest\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 12 "D:\Application\Group\1670-App-group\The cool Library\Views\GenreRequest\Index.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2 class=\"alert alert-danger\">No Category</h2>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fe61d09b5436c6c4ffdb613c3a9c3c1ba6be2ea7006", async() => {
                WriteLiteral("\r\n        Add\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 18 "D:\Application\Group\1670-App-group\The cool Library\Views\GenreRequest\Index.cshtml"
} else {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"     <div class=""container-xl"">
	<div class=""table-responsive"">
		<div class=""table-wrapper"">
			<div class=""table-title"">
				<div class=""row"">
					<div class=""col-sm-6"">
						<h2>Request <b>Category</b></h2>
					</div>
					<div class=""col-sm-6"">
						");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fe61d09b5436c6c4ffdb613c3a9c3c1ba6be2ea8956", async() => {
                WriteLiteral("<i class=\"material-icons\">&#xE147;</i> <span>Add New Genre</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"					
					</div>
				</div>
			</div>
			<table class=""table table-striped table-hover"">
				<thead>
					<tr>
						
						<th>ID</th>
						<th>Name</th>
						<th>Description</th>
						<th>Status</th>
						<th>Menu</th>
					</tr>
				</thead>
				<tbody>
");
#nullable restore
#line 44 "D:\Application\Group\1670-App-group\The cool Library\Views\GenreRequest\Index.cshtml"
                     foreach(var request in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 46 "D:\Application\Group\1670-App-group\The cool Library\Views\GenreRequest\Index.cshtml"
                       Write(request.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 47 "D:\Application\Group\1670-App-group\The cool Library\Views\GenreRequest\Index.cshtml"
                       Write(request.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
						<td>
							<button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#exampleModalLong""> Description </button>
						</td>

								<!-- Modal -->
								<div class=""modal fade"" id=""exampleModalLong"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLongTitle"" aria-hidden=""true"">
									<div class=""modal-dialog"" role=""document"">
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
#line 63 "D:\Application\Group\1670-App-group\The cool Library\Views\GenreRequest\Index.cshtml"
                                           Write(request.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t<div class=\"modal-footer\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Close</button>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</div>\r\n\r\n\r\n");
#nullable restore
#line 74 "D:\Application\Group\1670-App-group\The cool Library\Views\GenreRequest\Index.cshtml"
                         if(request.Status == 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<td><h6>Pending</h6></td>\r\n\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fe61d09b5436c6c4ffdb613c3a9c3c1ba6be2ea13308", async() => {
                WriteLiteral("<i class=\"material-icons\" data-toggle=\"tooltip\" title=\"Accept\">&#xE254;</i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 77 "D:\Application\Group\1670-App-group\The cool Library\Views\GenreRequest\Index.cshtml"
                                                                                                    WriteLiteral(request.Id);

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
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fe61d09b5436c6c4ffdb613c3a9c3c1ba6be2ea15907", async() => {
                WriteLiteral("<i class=\"material-icons\" data-toggle=\"tooltip\" title=\"Reject\">&#xE872;</i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "D:\Application\Group\1670-App-group\The cool Library\Views\GenreRequest\Index.cshtml"
                                                                                                      WriteLiteral(request.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 8, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2579, "return", 2579, 6, true);
            AddHtmlAttributeValue(" ", 2585, "confirm(\'Do", 2586, 12, true);
            AddHtmlAttributeValue(" ", 2597, "you", 2598, 4, true);
            AddHtmlAttributeValue(" ", 2601, "want", 2602, 5, true);
            AddHtmlAttributeValue(" ", 2606, "reject", 2607, 7, true);
            AddHtmlAttributeValue(" ", 2613, "Genre:", 2614, 7, true);
#nullable restore
#line 78 "D:\Application\Group\1670-App-group\The cool Library\Views\GenreRequest\Index.cshtml"
AddHtmlAttributeValue(" ", 2620, request.Name, 2621, 13, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2634, "\');", 2634, 3, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t</td>\r\n");
#nullable restore
#line 80 "D:\Application\Group\1670-App-group\The cool Library\Views\GenreRequest\Index.cshtml"
							
						} else if (request.Status == 1){

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<td><h6>Accept</h6></td>\r\n\t\t\t\t\t\t\t<td>No Action</td>\r\n");
#nullable restore
#line 84 "D:\Application\Group\1670-App-group\The cool Library\Views\GenreRequest\Index.cshtml"
						} else if (request.Status == -1) {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<td><h6>Reject</h6></td>\r\n\t\t\t\t\t\t\t<td>No Action</td>\r\n");
#nullable restore
#line 87 "D:\Application\Group\1670-App-group\The cool Library\Views\GenreRequest\Index.cshtml"
						}						

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t</tr>\t\t\t\t\t\t\r\n");
#nullable restore
#line 89 "D:\Application\Group\1670-App-group\The cool Library\Views\GenreRequest\Index.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t</tbody>\r\n\t\t\t</table>\r\n\t\t\t\r\n\t\t</div>\r\n\t</div>        \r\n</div>\r\n");
#nullable restore
#line 96 "D:\Application\Group\1670-App-group\The cool Library\Views\GenreRequest\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GenreRequest>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\Admin\Order\ManageOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b73afab88dbb4988b36f327bdc4c298fdb1a9dac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Pizzerito.Pages.Admin.Order.Pages_Admin_Order_ManageOrder), @"mvc.1.0.razor-page", @"/Pages/Admin/Order/ManageOrder.cshtml")]
namespace Pizzerito.Pages.Admin.Order
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
#line 1 "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\_ViewImports.cshtml"
using Pizzerito;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\Admin\Order\ManageOrder.cshtml"
using Pizzerito.Utility;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\Admin\Order\ManageOrder.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b73afab88dbb4988b36f327bdc4c298fdb1a9dac", @"/Pages/Admin/Order/ManageOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f63c83786526e2b94e2d51e16d92b23e4f7db7c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Order_ManageOrder : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded border form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100%;height:75px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary form-control mb-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "OrderPrepare", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success form-control mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "OrderReady", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning form-control mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "OrderCancel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger form-control mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "OrderRefund", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/countTimer.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n    <h1 class=\"text-primary py-3\">");
#nullable restore
#line 8 "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\Admin\Order\ManageOrder.cshtml"
                             Write(Localizer["Manage Order's"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b73afab88dbb4988b36f327bdc4c298fdb1a9dac9033", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\Admin\Order\ManageOrder.cshtml"
     if (Model.orderDetailsVM.Count > 0)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"container row bg-white p-2 border mb-3 rounded\">\r\n");
#nullable restore
#line 14 "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\Admin\Order\ManageOrder.cshtml"
             foreach (var item in Model.orderDetailsVM)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                <div class=""col-12 card-product pb-3 pt-3 mt-4 border rounded"">
                    <div class=""bg-white  "">
                        <div class=""row"" id=""demo"">
                            <div class=""col-12 col-sm-4"">
                                ");
#nullable restore
#line 20 "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\Admin\Order\ManageOrder.cshtml"
                           Write(Localizer["Order Number"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" : ");
#nullable restore
#line 20 "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\Admin\Order\ManageOrder.cshtml"
                                                        Write(item.OrderHeader.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                <ul class=\"text-info\">\r\n");
#nullable restore
#line 22 "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\Admin\Order\ManageOrder.cshtml"
                                     foreach (var details in item.OrderDetails)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <li id=\"orderName\" class=\"d-flex text-capitalize text-nowrap\">");
#nullable restore
#line 24 "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\Admin\Order\ManageOrder.cshtml"
                                                                                                 Write(details.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("  <span class=\"text-lowercase ml-1\"> x ");
#nullable restore
#line 24 "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\Admin\Order\ManageOrder.cshtml"
                                                                                                                                                     Write(details.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></li>\r\n");
#nullable restore
#line 25 "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\Admin\Order\ManageOrder.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                </ul>
                            </div>
                            <div class=""col-12 col-sm-4 pb-2"">
                                <div class=""input-group pb-2"">
                                    <div class=""input-group-append"">
                                        <span class=""input-group-text"">");
#nullable restore
#line 31 "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\Admin\Order\ManageOrder.cshtml"
                                                                  Write(Localizer["Pickup Time:"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                    </div>\r\n                                    <p hidden class=\"exp1\"> ");
#nullable restore
#line 33 "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\Admin\Order\ManageOrder.cshtml"
                                                       Write(item.OrderHeader.PickUpTime);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </p>\r\n                                    <input type=\"text\" class=\" border rounded form-control\" readonly");
                BeginWriteAttribute("value", " value=\"", 1791, "\"", 1827, 1);
#nullable restore
#line 34 "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\Admin\Order\ManageOrder.cshtml"
WriteAttributeValue("", 1799, item.OrderHeader.PickUpTime, 1799, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                </div>\r\n");
#nullable restore
#line 36 "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\Admin\Order\ManageOrder.cshtml"
                                  
                                    var comments = item.OrderHeader.Comments;
                                    if (comments == null || comments.Trim().Length == 0)
                                    {

                                        item.OrderHeader.Comments = @Localizer["No Instructions."].Value;
                                        

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b73afab88dbb4988b36f327bdc4c298fdb1a9dac14619", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#nullable restore
#line 42 "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\Admin\Order\ManageOrder.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => item.OrderHeader.Comments);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("readonly", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 43 "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\Admin\Order\ManageOrder.cshtml"

                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b73afab88dbb4988b36f327bdc4c298fdb1a9dac17364", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#nullable restore
#line 47 "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\Admin\Order\ManageOrder.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => item.OrderHeader.Comments);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("readonly", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 48 "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\Admin\Order\ManageOrder.cshtml"

                                    }
                                

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </div>\r\n                            <div class=\"col-12 col-sm-3 offset-sm-1 d-flex  align-content-center\">\r\n                                <div class=\"col-12\">\r\n\r\n");
                WriteLiteral(@"                                    <div class=""progress"">
                                        <div class=""progressTimer progress-bar progress-bar-striped progress-bar-animated""></div>
                                    </div>
                                    <div class=""col-12 timer text-center text-wrap font-weight-light mb-4"" style=""font-size:14px;""></div>
");
                WriteLiteral("\r\n");
#nullable restore
#line 62 "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\Admin\Order\ManageOrder.cshtml"
                                     if (item.OrderHeader.Status.Equals(Pizzerito.Utility.SD.StatusSubmitted))
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b73afab88dbb4988b36f327bdc4c298fdb1a9dac20765", async() => {
                    WriteLiteral("\r\n                                    <i class=\"fas fa-check\"></i> &nbsp; ");
#nullable restore
#line 65 "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\Admin\Order\ManageOrder.cshtml"
                                                                   Write(Localizer["Start Cooking"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-OrderId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\Admin\Order\ManageOrder.cshtml"
                                                                                                                                       WriteLiteral(item.OrderHeader.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["OrderId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-OrderId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["OrderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 67 "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\Admin\Order\ManageOrder.cshtml"
                                    }
                                    else
                                    {
                                        if (item.OrderHeader.Status.Equals(Pizzerito.Utility.SD.StatusInProcess))
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b73afab88dbb4988b36f327bdc4c298fdb1a9dac24344", async() => {
                    WriteLiteral("\r\n                                    <i class=\"fas fa-flag-checkered\"></i> &nbsp; ");
#nullable restore
#line 73 "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\Admin\Order\ManageOrder.cshtml"
                                                                            Write(Localizer["Order Ready"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-OrderId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\Admin\Order\ManageOrder.cshtml"
                                                                                                                                     WriteLiteral(item.OrderHeader.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["OrderId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-OrderId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["OrderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 75 "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\Admin\Order\ManageOrder.cshtml"
                                        }
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b73afab88dbb4988b36f327bdc4c298fdb1a9dac27741", async() => {
                    WriteLiteral("\r\n                                    <i class=\"fas fa-times\"></i> &nbsp; ");
#nullable restore
#line 78 "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\Admin\Order\ManageOrder.cshtml"
                                                                   Write(Localizer["Cancel Order"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-OrderId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 77 "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\Admin\Order\ManageOrder.cshtml"
                                                                                                                                      WriteLiteral(item.OrderHeader.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["OrderId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-OrderId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["OrderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b73afab88dbb4988b36f327bdc4c298fdb1a9dac30820", async() => {
                    WriteLiteral("\r\n                                    <i class=\"fas fa-times\"></i> &nbsp; ");
#nullable restore
#line 81 "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\Admin\Order\ManageOrder.cshtml"
                                                                   Write(Localizer["Refund Order"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-OrderId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 80 "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\Admin\Order\ManageOrder.cshtml"
                                                                                                                                     WriteLiteral(item.OrderHeader.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["OrderId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-OrderId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["OrderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 89 "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\Admin\Order\ManageOrder.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 92 "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\Admin\Order\ManageOrder.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"card\">\r\n            <div class=\"card-body text-center bg-light\"><h2>");
#nullable restore
#line 96 "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\Admin\Order\ManageOrder.cshtml"
                                                       Write(Localizer["No Orders yet.."]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2> </div>\r\n        </div>\r\n");
#nullable restore
#line 98 "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\Admin\Order\ManageOrder.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b73afab88dbb4988b36f327bdc4c298fdb1a9dac36527", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pizzerito.Pages.Admin.Order.ManageOrderModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pizzerito.Pages.Admin.Order.ManageOrderModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pizzerito.Pages.Admin.Order.ManageOrderModel>)PageContext?.ViewData;
        public Pizzerito.Pages.Admin.Order.ManageOrderModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

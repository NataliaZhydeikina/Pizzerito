#pragma checksum "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17cc6087feac1100d8658fbf2d1f909d993601f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Pizzerito.Pages.Pages_Error), @"mvc.1.0.razor-page", @"/Pages/Error.cshtml")]
namespace Pizzerito.Pages
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
#line 6 "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\Error.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17cc6087feac1100d8658fbf2d1f909d993601f5", @"/Pages/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f63c83786526e2b94e2d51e16d92b23e4f7db7c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Error : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-danger\">");
#nullable restore
#line 9 "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\Error.cshtml"
                   Write(SharedLocalizer["Error"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</h1>\r\n<h2 class=\"text-danger\">");
#nullable restore
#line 10 "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\Error.cshtml"
                   Write(SharedLocalizer["An error occurred while processing your request"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</h2>\r\n\r\n");
#nullable restore
#line 12 "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\Error.cshtml"
 if (Model.ShowRequestId)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n    <strong>Request ID:</strong> <code>");
#nullable restore
#line 15 "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\Error.cshtml"
                                  Write(Model.RequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code>\r\n</p>\r\n");
#nullable restore
#line 17 "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\Error.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>");
#nullable restore
#line 19 "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\Error.cshtml"
Write(SharedLocalizer["Development Mode"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<p>\r\n    ");
#nullable restore
#line 21 "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\Error.cshtml"
Write(SharedLocalizer["Swapping to the <strong>Development</strong> environment displays detailed information about the error that occurred."]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<p>\r\n    ");
#nullable restore
#line 24 "C:\Users\natai\Downloads\Pizzaritto\Pizzaritto\Pizzerito\Pizzerito\Pages\Error.cshtml"
Write(SharedLocalizer["<strong>The Development environment shouldn't be enabled for deployed applications.</strong> It can result in displaying sensitive information from exceptions to end users. For local debugging, enable the <strong>Development</strong> environment by setting the <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to <strong>Development</strong> and restarting the app."]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHtmlLocalizer<SharedResource> SharedLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ErrorModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ErrorModel>)PageContext?.ViewData;
        public ErrorModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
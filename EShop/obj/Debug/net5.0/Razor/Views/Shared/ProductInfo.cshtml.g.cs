#pragma checksum "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Views\Shared\ProductInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6717a07a0ed80f3d7ec1d5d71adea77ece834239"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ProductInfo), @"mvc.1.0.view", @"/Views/Shared/ProductInfo.cshtml")]
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
#line 1 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Views\_ViewImports.cshtml"
using EShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Views\_ViewImports.cshtml"
using EShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Views\_ViewImports.cshtml"
using EntityLayer.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6717a07a0ed80f3d7ec1d5d71adea77ece834239", @"/Views/Shared/ProductInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cff9734049d8e882bad1b5660424c0432dd36f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ProductInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Views\Shared\ProductInfo.cshtml"
  
    ViewData["Title"] = "ProductInfo";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Views\Shared\ProductInfo.cshtml"
 if (ViewBag.info != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("     <div class=\"container\">\r\n         <div class=\"row\">\r\n             <div class=\"col-md-6\">\r\n                 <div class=\"alert alert-success\">");
#nullable restore
#line 11 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Views\Shared\ProductInfo.cshtml"
                                             Write(ViewBag.info);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n             </div>\r\n         </div>\r\n     </div>\r\n");
#nullable restore
#line 15 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Views\Shared\ProductInfo.cshtml"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

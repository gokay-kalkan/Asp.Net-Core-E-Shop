#pragma checksum "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Areas\Admin\Views\StockManagement\OutOfStock.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c17374bd800857e50e573ae1a55c6ca49cf11c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_StockManagement_OutOfStock), @"mvc.1.0.view", @"/Areas/Admin/Views/StockManagement/OutOfStock.cshtml")]
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
#line 1 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Areas\_ViewImports.cshtml"
using EShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Areas\_ViewImports.cshtml"
using EShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Areas\_ViewImports.cshtml"
using EShop.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Areas\_ViewImports.cshtml"
using EntityLayer.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c17374bd800857e50e573ae1a55c6ca49cf11c9", @"/Areas/Admin/Views/StockManagement/OutOfStock.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f04994214744e257bc4e709e8f5fb610781bf95", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Admin_Views_StockManagement_OutOfStock : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("70"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("70"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Areas\Admin\Views\StockManagement\OutOfStock.cshtml"
  
    ViewData["Title"] = "OutOfStock";
    Layout = "~/Areas/Admin/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Areas\Admin\Views\StockManagement\OutOfStock.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-6\">\r\n                <div class=\"alert alert-success\">Henüz stoğu bitmiş bir ürün yok</div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 16 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Areas\Admin\Views\StockManagement\OutOfStock.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-bordered table table-striped\">\r\n        <tr>\r\n            <th>Resim</th>\r\n            <th>Ad</th>\r\n            <th>Fiyat</th>\r\n            <th>Stok Adeti</th>\r\n        </tr>\r\n        <tbody>\r\n");
#nullable restore
#line 27 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Areas\Admin\Views\StockManagement\OutOfStock.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3c17374bd800857e50e573ae1a55c6ca49cf11c95903", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 735, "~/img/", 735, 6, true);
#nullable restore
#line 30 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Areas\Admin\Views\StockManagement\OutOfStock.cshtml"
AddHtmlAttributeValue("", 741, item.Images.Where(x=>x.ProductId==item.ProductId).Select(x=>x.ImageName).FirstOrDefault(), 741, 90, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Areas\Admin\Views\StockManagement\OutOfStock.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Areas\Admin\Views\StockManagement\OutOfStock.cshtml"
                   Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Areas\Admin\Views\StockManagement\OutOfStock.cshtml"
                   Write(item.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 35 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Areas\Admin\Views\StockManagement\OutOfStock.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 39 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Areas\Admin\Views\StockManagement\OutOfStock.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Views\User\OrderList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cf7e0916ae71b8ec1ba63110f2f6a7f85cf846a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_OrderList), @"mvc.1.0.view", @"/Views/User/OrderList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cf7e0916ae71b8ec1ba63110f2f6a7f85cf846a", @"/Views/User/OrderList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cff9734049d8e882bad1b5660424c0432dd36f1", @"/Views/_ViewImports.cshtml")]
    public class Views_User_OrderList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Order>>
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Views\User\OrderList.cshtml"
  
    ViewData["Title"] = "OrderList";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Views\User\OrderList.cshtml"
 if (ViewBag.info != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-6\" style=\"margin-top:10px;\">\r\n                <div class=\"alert alert-success\">");
#nullable restore
#line 14 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Views\User\OrderList.cshtml"
                                            Write(ViewBag.info);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 18 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Views\User\OrderList.cshtml"
}
else if (Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6"" style=""margin-top:10px;"">
                <div class=""alert alert-success"">Daha önceden vermiş olduğunuz siparişleriniz bulunmamaktadır.</div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 28 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Views\User\OrderList.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6"">
                <table class=""table table-bordered table table-striped"" id=""table"">
                    <tr>
                        <th>Ürün</th>
                        <th>Resim</th>
                        <th>Fiyat</th>
                        <th>Adet</th>
                        <th>Sipariş Durumu</th>
                        <th>Siparişi İptal Et</th>


                    </tr>
                    <tbody>
");
#nullable restore
#line 46 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Views\User\OrderList.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 49 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Views\User\OrderList.cshtml"
                               Write(item.Products.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1cf7e0916ae71b8ec1ba63110f2f6a7f85cf846a6974", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1458, "~/img/", 1458, 6, true);
#nullable restore
#line 50 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Views\User\OrderList.cshtml"
AddHtmlAttributeValue("", 1464, item.ProductImage, 1464, 18, false);

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
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 51 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Views\User\OrderList.cshtml"
                               Write(item.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 52 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Views\User\OrderList.cshtml"
                               Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 53 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Views\User\OrderList.cshtml"
                               Write(item.OrderState);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 54 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Views\User\OrderList.cshtml"
                                   var orderstate = OrderState.Hazırlanıyor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Views\User\OrderList.cshtml"
                                 if (item.OrderState == orderstate)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td><a id=\"delete\" data-id=\"");
#nullable restore
#line 57 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Views\User\OrderList.cshtml"
                                                           Write(item.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"btn btn-danger\"><i class=\"fa fa-trash\"></i></a></td>\r\n");
#nullable restore
#line 58 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Views\User\OrderList.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </tr>\r\n");
#nullable restore
#line 61 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Views\User\OrderList.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 68 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Views\User\OrderList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script type=""text/javascript"">

    $(""#table"").on(""click"", ""#delete"", function () {
        var id = $(this).data(""id"");
        swal({
            title: 'Sipariş İptal Edilecek!',
            text: ""Siparişinizi iptal etmek istediğinize emin misiniz?"",
            icon: 'warning',
            buttons: true,
            dangerMode: true,
        }).then((willDelete) => {

            if (willDelete) {

                $.ajax({
                    type: 'GET',
                    url: '/User/OrderCancellation/' + id,
                    success: function () {
                        toastr.error('Sipariş İptal Etme İşlemi Başarıyla Gerçekleşti')


                    }
                });

                $(this).parent('td').parent('tr').remove();

            }

        });

    });
</script>




");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Views\User\FavoriteProducts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66b732e55775c462071432dde75700fd45000374"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_FavoriteProducts), @"mvc.1.0.view", @"/Views/User/FavoriteProducts.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66b732e55775c462071432dde75700fd45000374", @"/Views/User/FavoriteProducts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cff9734049d8e882bad1b5660424c0432dd36f1", @"/Views/_ViewImports.cshtml")]
    public class Views_User_FavoriteProducts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Favorite>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("70"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("70"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Views\User\FavoriteProducts.cshtml"
  
    ViewData["Title"] = "FavoriteProducts";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Views\User\FavoriteProducts.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6"" style=""margin-top:10px;"">
                <div class=""alert alert-success"">Favorilere eklemiş olduğunuz bir ürün bulunamadı.</div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 16 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Views\User\FavoriteProducts.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <section id=""cart-view"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""cart-view-area"">
                        <div class=""cart-view-table aa-wishlist-table"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66b732e55775c462071432dde75700fd450003745905", async() => {
                WriteLiteral(@"
                                <div class=""table-responsive"">
                                    <table class=""table"" id=""table"">
                                        <thead>
                                            <tr>
                                                <th></th>
                                                <th></th>
                                                <th>Ürün</th>
                                                <th>Fiyat</th>
                                                <th>Resim</th>
                                                <th>Sil</th>
                                            </tr>
                                        </thead>
                                        <tbody>
");
#nullable restore
#line 39 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Views\User\FavoriteProducts.cshtml"
                                             foreach (var item in Model)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <tr>\r\n                                                <td></td>\r\n                                                <td></td>\r\n                                                <td>");
#nullable restore
#line 44 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Views\User\FavoriteProducts.cshtml"
                                               Write(item.Product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                <td>$ ");
#nullable restore
#line 45 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Views\User\FavoriteProducts.cshtml"
                                                 Write(item.Product.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                <td>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "66b732e55775c462071432dde75700fd450003748171", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1955, "~/img/", 1955, 6, true);
#nullable restore
#line 46 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Views\User\FavoriteProducts.cshtml"
AddHtmlAttributeValue("", 1961, item.Product.Images.Where(x=>x.ProductId==item.Product.ProductId).Select(x=>x.ImageName).FirstOrDefault(), 1961, 106, false);

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
                WriteLiteral("</td>\r\n                                                <td><a class=\"btn btn-danger\" id=\"delete\" data-id=\"");
#nullable restore
#line 47 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Views\User\FavoriteProducts.cshtml"
                                                                                              Write(item.FavoriteId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"><i class=\"fa fa-trash\"></i></a></td>\r\n\r\n                                            </tr>\r\n");
#nullable restore
#line 50 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Views\User\FavoriteProducts.cshtml"
                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral("                                        </tbody>\r\n                                    </table>\r\n                                </div>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n");
#nullable restore
#line 78 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\EShop\EShop\Views\User\FavoriteProducts.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<script type=""text/javascript"">

    $(""#table"").on(""click"", ""#delete"", function () {
        var id = $(this).data(""id"");
        swal({
            title: 'Favorilerden Silinecek!',
            text: ""Silmek istediğinize emin misiniz?"",
            icon: 'warning',
            buttons: true,
            dangerMode: true,
        }).then((willDelete) => {

            if (willDelete) {

                $.ajax({
                    type: 'GET',
                    url: '/Product/FavoriteDelete/' + id,
                    success: function () {
                        toastr.error('Favorilerden Silme İşlemi Başarıyla Gerçekleşti')


                    }
                });

                $(this).parent('td').parent('tr').remove();

            }

        });

    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Favorite>> Html { get; private set; }
    }
}
#pragma warning restore 1591

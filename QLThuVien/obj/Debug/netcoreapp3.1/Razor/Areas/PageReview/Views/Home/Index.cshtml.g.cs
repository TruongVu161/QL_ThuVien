#pragma checksum "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\PageReview\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2df19ba017fd7669b7d6502decd39366d2e26859"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_PageReview_Views_Home_Index), @"mvc.1.0.view", @"/Areas/PageReview/Views/Home/Index.cshtml")]
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
#line 1 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\PageReview\_ViewImports.cshtml"
using QLThuVien;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\PageReview\_ViewImports.cshtml"
using QLThuVien.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2df19ba017fd7669b7d6502decd39366d2e26859", @"/Areas/PageReview/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01766513dca41114e40f89b458a8a274af3bbe90", @"/Areas/PageReview/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_PageReview_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2df19ba017fd7669b7d6502decd39366d2e268593288", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\PageReview\Views\Home\Index.cshtml"
      
        ViewData["Title"] = "Index";
        Layout = "~/Areas/PageReview/Views/Shared/_LayoutReView.cshtml";
    

#line default
#line hidden
#nullable disable
                WriteLiteral("    <div class=\"col-md-3\">\r\n        <h3>Thành viên </h3>\r\n        <ul class=\"list-unstyled footer-link\">\r\n            <li class=\"d-block\">Bùi Cảnh Long </li>\r\n\r\n        </ul>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2df19ba017fd7669b7d6502decd39366d2e268594794", async() => {
                WriteLiteral(@"
    <section class=""home-slider owl-carousel"">
        <div id=""myCarousel"" class=""carousel slide border"" data-ride=""carousel"">
            <div class=""carousel-inner"">
                <div class=""carousel-item active"">
                    <img class=""d-block w-100"" src=""/img/meo.jpg"" alt=""Logo"">
                </div>
            </div>
            <!-- Controls -->
            <a class=""carousel-control-prev"" href=""#myCarousel"" role=""button"" data-slide=""prev"">
                <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Previous</span>
            </a>
            <a class=""carousel-control-next"" href=""#myCarousel"" role=""button"" data-slide=""next"">
                <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Next</span>
            </a>
        </div>
    </section>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<!-- END slider -->
<section class=""section bg-light"">
    <img class=""d-block"" src=""/img/jpg5f02ab979521a.jpg"" style=""width: 1700px;height:10000 "" />
</section>

<section class=""section bg-light"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 col-lg-4 element-animate "">
                <div class=""media block-6 d-block text-center"">
                    <div class=""icon mb-3""><span class=""ion-bookmark text-primary""></span></div>

                    <div class=""media-body"">
                        <h3  class=""heading"">");
#nullable restore
#line 49 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\PageReview\Views\Home\Index.cshtml"
                                        Write(ViewBag.SoLuongSach);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Sản phẩm</h3>
                        <p>Sách có thể ít đi một chút, nhưng phải tốt đẹp hơn. Không nên đặt một cuốn sách tầm thường lên giá sách.</p>
                    </div>
                </div>

            </div>
            <div class=""col-md-6 col-lg-4 element-animate "">
                <div class=""media block-6 d-block text-center"">
                    <div class=""icon mb-3""><span class=""ion-heart text-primary""></span></div>
                    <div class=""media-body"">
                        <h3 class=""heading"">");
#nullable restore
#line 59 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\PageReview\Views\Home\Index.cshtml"
                                       Write(ViewBag.SoLuongDocGia);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Độc giả</h3>
                        <p>Thư viện trường học là hữu ích cho tất cả mọi người cho dù học sinh, giáo viên hoặc bất kỳ nhân viên khác.</p>
                    </div>
                </div>

            </div>
            <div class=""col-md-6 col-lg-4 element-animate "">
                <div class=""media block-6 d-block text-center"">
                    <div class=""icon mb-3""><span class=""ion-leaf text-primary""></span></div>
                    <div class=""media-body"">
                        <h3 class=""heading""> Chi nhánh </h3>
                        <p>Nguồn tài liệu phong phú,lối kiến trúc độc đáo gợi cho người đọc cảm giác đi vào núi sách.</p>
                    </div>
                </div>

            </div>
        </div>
    </div>
</section>


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\PageReview\Views\Product\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36bd5f2b38fea86dce567155905959966984c373"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_PageReview_Views_Product_Detail), @"mvc.1.0.view", @"/Areas/PageReview/Views/Product/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36bd5f2b38fea86dce567155905959966984c373", @"/Areas/PageReview/Views/Product/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01766513dca41114e40f89b458a8a274af3bbe90", @"/Areas/PageReview/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_PageReview_Views_Product_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QLThuVien.Models.Sach>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\PageReview\Views\Product\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Areas/PageReview/Views/Shared/_LayoutReView.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""col-md-3"">
    <h3>Thành viên </h3>
    <ul class=""list-unstyled footer-link"">
        <li class=""d-block"">Bùi Cảnh Long </li>

    </ul>
</div>
<div class=""container-fluid"">
    
    <div class=""row"">
        <div class=""col-sm-3"">
            <img class=""detailImage""");
            BeginWriteAttribute("src", " src=\"", 430, "\"", 451, 1);
#nullable restore
#line 18 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\PageReview\Views\Product\Detail.cshtml"
WriteAttributeValue("", 436, Model.ImageUrl, 436, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 300px; \" />\r\n        </div>\r\n        <div class=\"col-sm-9\" style=\"background-color:ghostwhite;\">\r\n            <p style=\"background-color:crimson; font-size:xx-large; color:white; font-family:\'Arial\'\" >");
#nullable restore
#line 21 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\PageReview\Views\Product\Detail.cshtml"
                                                                                                  Write(Html.DisplayFor(model => model.TenSach));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n\r\n            <p style=\"font-family: \'Arial\'\"> ");
#nullable restore
#line 23 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\PageReview\Views\Product\Detail.cshtml"
                                        Write(Html.DisplayFor(model => model.MieuTa));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        </div>\r\n       \r\n    </div>\r\n</div>\r\n\r\n<div class=\"container-fluid\">\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\PageReview\Views\Product\Detail.cshtml"
       Write(Html.DisplayNameFor(model => model.MaSach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\PageReview\Views\Product\Detail.cshtml"
       Write(Html.DisplayFor(model => model.MaSach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n      \r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 41 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\PageReview\Views\Product\Detail.cshtml"
       Write(Html.DisplayNameFor(model => model.TenTG));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 44 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\PageReview\Views\Product\Detail.cshtml"
       Write(Html.DisplayFor(model => model.TenTG));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 47 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\PageReview\Views\Product\Detail.cshtml"
       Write(Html.DisplayNameFor(model => model.NhaXB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 50 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\PageReview\Views\Product\Detail.cshtml"
       Write(Html.DisplayFor(model => model.NhaXB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 53 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\PageReview\Views\Product\Detail.cshtml"
       Write(Html.DisplayNameFor(model => model.TheLoai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 56 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\PageReview\Views\Product\Detail.cshtml"
       Write(Html.DisplayFor(model => model.TheLoai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QLThuVien.Models.Sach> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

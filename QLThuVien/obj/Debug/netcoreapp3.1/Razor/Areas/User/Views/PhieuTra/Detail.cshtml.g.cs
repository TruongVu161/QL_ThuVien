#pragma checksum "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "781535ac4ac0f23d92858a3cff3bcf7470e50a36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_PhieuTra_Detail), @"mvc.1.0.view", @"/Areas/User/Views/PhieuTra/Detail.cshtml")]
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
#line 1 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\_ViewImports.cshtml"
using QLThuVien;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\_ViewImports.cshtml"
using QLThuVien.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"781535ac4ac0f23d92858a3cff3bcf7470e50a36", @"/Areas/User/Views/PhieuTra/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01766513dca41114e40f89b458a8a274af3bbe90", @"/Areas/User/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_User_Views_PhieuTra_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QLThuVien.Models.CTPM>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Areas/User/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <h1 class=""mt-4"">Chi tiết</h1>
    <ol class=""breadcrumb mb-4"">
        <li class=""breadcrumb-item""><a href=""/User/Home"">Trang chủ</a></li>
        <li class=""breadcrumb-item active"">Chi tiết</li>
    </ol>
    <div class=""card mb-4"">
        <div class=""card-header"">
            <a class=""btn btn-success"" href=""/User/PhieuTra/Index"""">Về danh sách</a>
        </div>
        <div>
            <h4>CTPM</h4>
            <hr />
            <dl class=""row"">
                <dt class=""col-sm-2"">
                    ");
#nullable restore
#line 23 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\Detail.cshtml"
               Write(Html.DisplayNameFor(model => model.MaPM));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 26 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\Detail.cshtml"
               Write(Html.DisplayFor(model => model.MaPM));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 29 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\Detail.cshtml"
               Write(Html.DisplayNameFor(model => model.MaSach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 32 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\Detail.cshtml"
               Write(Html.DisplayFor(model => model.MaSach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 35 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\Detail.cshtml"
               Write(Html.DisplayNameFor(model => model.NgayTra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 38 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\Detail.cshtml"
               Write(Html.DisplayFor(model => model.NgayTra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 41 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\Detail.cshtml"
               Write(Html.DisplayNameFor(model => model.TinhTrangSach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 44 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\Detail.cshtml"
               Write(Html.DisplayFor(model => model.TinhTrangSach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 47 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\Detail.cshtml"
               Write(Html.DisplayNameFor(model => model.TinhTrangTra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 50 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\Detail.cshtml"
               Write(Html.DisplayFor(model => model.TinhTrangTra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 53 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\Detail.cshtml"
               Write(Html.DisplayNameFor(model => model.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 56 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\Detail.cshtml"
               Write(Html.DisplayFor(model => model.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 59 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\Detail.cshtml"
               Write(Html.DisplayNameFor(model => model.GhiChu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 62 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\Detail.cshtml"
               Write(Html.DisplayFor(model => model.GhiChu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n            <div>\r\n\r\n                <a href=\"/User/PhieuMuon/Edit/ ");
#nullable restore
#line 67 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\Detail.cshtml"
                                          Write(Model.MaPM);

#line default
#line hidden
#nullable disable
            WriteLiteral(",");
#nullable restore
#line 67 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\Detail.cshtml"
                                                      Write(Model.MaSach);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Sửa</a>\r\n\r\n            </div>\r\n\r\n        </div>\r\n\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QLThuVien.Models.CTPM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

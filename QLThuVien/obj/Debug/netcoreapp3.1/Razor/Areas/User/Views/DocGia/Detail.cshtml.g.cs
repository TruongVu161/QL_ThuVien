#pragma checksum "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\DocGia\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3848251bd1bce86a85e66b67efe92f1d0fda9722"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_DocGia_Detail), @"mvc.1.0.view", @"/Areas/User/Views/DocGia/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3848251bd1bce86a85e66b67efe92f1d0fda9722", @"/Areas/User/Views/DocGia/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01766513dca41114e40f89b458a8a274af3bbe90", @"/Areas/User/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_User_Views_DocGia_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QLThuVien.Models.DocGia>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\DocGia\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Areas/User/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-fluid"">
    <h1 class=""mt-4"">Chi tiết</h1>
    <ol class=""breadcrumb mb-4"">
        <li class=""breadcrumb-item""><a href=""/User/Home"">Trang chủ</a></li>
        <li class=""breadcrumb-item active"">Chi tiết</li>
    </ol>
    <div class=""card mb-4"">
        <div class=""card-header"">
            <a class=""btn btn-success""  href=""/User/DocGia/Index"">Về danh sách</a>
        </div>
        <div>
            <h4>DocGia</h4>
            <hr />
            <dl class=""row"">
                <dt class=""col-sm-2"">
                    ");
#nullable restore
#line 22 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\DocGia\Detail.cshtml"
               Write(Html.DisplayNameFor(model => model.MaDG));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 25 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\DocGia\Detail.cshtml"
               Write(Html.DisplayFor(model => model.MaDG));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 28 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\DocGia\Detail.cshtml"
               Write(Html.DisplayNameFor(model => model.TenDG));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 31 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\DocGia\Detail.cshtml"
               Write(Html.DisplayFor(model => model.TenDG));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 34 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\DocGia\Detail.cshtml"
               Write(Html.DisplayNameFor(model => model.SDT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 37 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\DocGia\Detail.cshtml"
               Write(Html.DisplayFor(model => model.SDT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 40 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\DocGia\Detail.cshtml"
               Write(Html.DisplayNameFor(model => model.DiaChi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 43 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\DocGia\Detail.cshtml"
               Write(Html.DisplayFor(model => model.DiaChi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 46 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\DocGia\Detail.cshtml"
               Write(Html.DisplayNameFor(model => model.GioiTinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 49 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\DocGia\Detail.cshtml"
               Write(Html.DisplayFor(model => model.GioiTinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 52 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\DocGia\Detail.cshtml"
               Write(Html.DisplayNameFor(model => model.MatSach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 55 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\DocGia\Detail.cshtml"
               Write(Html.DisplayFor(model => model.MatSach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n            <div>\r\n                \r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2207, "\"", 2244, 2);
            WriteAttributeValue("", 2214, "/User/DocGia/Edit/", 2214, 18, true);
#nullable restore
#line 60 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\DocGia\Detail.cshtml"
WriteAttributeValue(" ", 2232, Model.MaDG, 2233, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sửa</a>\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QLThuVien.Models.DocGia> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Views\Product\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "710bd39031ab7e6e2690257f7cf7b4660caf63e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Detail), @"mvc.1.0.view", @"/Views/Product/Detail.cshtml")]
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
#line 1 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Views\_ViewImports.cshtml"
using QLThuVien;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Views\_ViewImports.cshtml"
using QLThuVien.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"710bd39031ab7e6e2690257f7cf7b4660caf63e7", @"/Views/Product/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01766513dca41114e40f89b458a8a274af3bbe90", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QLThuVien.Models.Sach>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Views\Product\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container-fluid"">
        <h1 class=""mt-4"">Chi tiết Sách</h1>
        <ol class=""breadcrumb mb-4"">
            <li class=""breadcrumb-item""><a href=""/Home"">Trang chủ</a></li>
            <li class=""breadcrumb-item active"">Chi tiết Sách</li>
        </ol>
        <div class=""card mb-4"">
            <div class=""card-header"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "710bd39031ab7e6e2690257f7cf7b4660caf63e74694", async() => {
                WriteLiteral("Về danh sách Sách");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                <h4 style=\"padding-left: 5px; padding-top: \">Chi tiết Sách ");
#nullable restore
#line 18 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Views\Product\Detail.cshtml"
                                                                      Write(Html.DisplayFor(model => model.MaSach));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <hr />\r\n                <dl class=\"row\" style=\"padding-left: 5px;\">\r\n                    <dt class=\"col-sm-3\">\r\n                        ");
#nullable restore
#line 22 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Views\Product\Detail.cshtml"
                   Write(Html.DisplayNameFor(model => model.MaSach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-9\">\r\n                        ");
#nullable restore
#line 25 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Views\Product\Detail.cshtml"
                   Write(Html.DisplayFor(model => model.MaSach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-3\">\r\n                        ");
#nullable restore
#line 28 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Views\Product\Detail.cshtml"
                   Write(Html.DisplayNameFor(model => model.TenSach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-9\">\r\n                        ");
#nullable restore
#line 31 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Views\Product\Detail.cshtml"
                   Write(Html.DisplayFor(model => model.TenSach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-3\">\r\n                        ");
#nullable restore
#line 34 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Views\Product\Detail.cshtml"
                   Write(Html.DisplayNameFor(model => model.TenTG));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-9\">\r\n                        ");
#nullable restore
#line 37 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Views\Product\Detail.cshtml"
                   Write(Html.DisplayFor(model => model.TenTG));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-3\">\r\n                        ");
#nullable restore
#line 40 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Views\Product\Detail.cshtml"
                   Write(Html.DisplayNameFor(model => model.NhaXB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-9\">\r\n                        ");
#nullable restore
#line 43 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Views\Product\Detail.cshtml"
                   Write(Html.DisplayFor(model => model.NhaXB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-3\">\r\n                        ");
#nullable restore
#line 46 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Views\Product\Detail.cshtml"
                   Write(Html.DisplayNameFor(model => model.TheLoai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-9\">\r\n                        ");
#nullable restore
#line 49 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Views\Product\Detail.cshtml"
                   Write(Html.DisplayFor(model => model.TheLoai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-3\">\r\n                        ");
#nullable restore
#line 52 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Views\Product\Detail.cshtml"
                   Write(Html.DisplayNameFor(model => model.SoLuong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-9\">\r\n                        ");
#nullable restore
#line 55 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Views\Product\Detail.cshtml"
                   Write(Html.DisplayFor(model => model.SoLuong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-3\">\r\n                        ");
#nullable restore
#line 58 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Views\Product\Detail.cshtml"
                   Write(Html.DisplayNameFor(model => model.GiaTien));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-9\">\r\n                        ");
#nullable restore
#line 61 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Views\Product\Detail.cshtml"
                   Write(Html.DisplayFor(model => model.GiaTien));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                </dl>              \r\n            </div>         \r\n        </div>\r\n    </div>");
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
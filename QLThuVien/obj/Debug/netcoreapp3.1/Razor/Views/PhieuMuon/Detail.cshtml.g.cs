#pragma checksum "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Views\PhieuMuon\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2526bbea16298c0aeefa1d86a544fde7b33fe41"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PhieuMuon_Detail), @"mvc.1.0.view", @"/Views/PhieuMuon/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2526bbea16298c0aeefa1d86a544fde7b33fe41", @"/Views/PhieuMuon/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01766513dca41114e40f89b458a8a274af3bbe90", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_PhieuMuon_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QLThuVien.Models.PhieuMuon>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PhieuMuon", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Views\PhieuMuon\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container-fluid"">
    <h1 class=""mt-4"">Chi tiết Phiếu mượn</h1>
    <ol class=""breadcrumb mb-4"">
        <li class=""breadcrumb-item""><a href=""/Home"">Trang chủ</a></li>
        <li class=""breadcrumb-item active"">Chi tiết Phiếu mượn</li>
    </ol>
    <div class=""card mb-4"">
        <div class=""card-header"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2526bbea16298c0aeefa1d86a544fde7b33fe414693", async() => {
                WriteLiteral("Về danh sách Phiếu mượn");
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
            WriteLiteral("\r\n        </div>\r\n\r\n        <div>\r\n            <h4>Chi tiết Phiếu mượn ");
#nullable restore
#line 21 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Views\PhieuMuon\Detail.cshtml"
                               Write(Html.DisplayFor(model => model.MaPM));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            <hr />\r\n            <dl class=\"row\" style=\"padding-left: 5px;\">\r\n                <dt class=\"col-sm-3\">\r\n                    ");
#nullable restore
#line 25 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Views\PhieuMuon\Detail.cshtml"
               Write(Html.DisplayNameFor(model => model.MaPM));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-9\">\r\n                    ");
#nullable restore
#line 28 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Views\PhieuMuon\Detail.cshtml"
               Write(Html.DisplayFor(model => model.MaPM));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-3\">\r\n                    ");
#nullable restore
#line 31 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Views\PhieuMuon\Detail.cshtml"
               Write(Html.DisplayNameFor(model => model.MaDG));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-9\">\r\n                    ");
#nullable restore
#line 34 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Views\PhieuMuon\Detail.cshtml"
               Write(Html.DisplayFor(model => model.MaDG));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-3\">\r\n                    ");
#nullable restore
#line 37 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Views\PhieuMuon\Detail.cshtml"
               Write(Html.DisplayNameFor(model => model.NgayMuon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-9\">\r\n                    ");
#nullable restore
#line 40 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Views\PhieuMuon\Detail.cshtml"
               Write(Html.DisplayFor(model => model.NgayMuon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-3\">\r\n                    ");
#nullable restore
#line 43 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Views\PhieuMuon\Detail.cshtml"
               Write(Html.DisplayNameFor(model => model.NgayHenTra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-9\">\r\n                    ");
#nullable restore
#line 46 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Views\PhieuMuon\Detail.cshtml"
               Write(Html.DisplayFor(model => model.NgayHenTra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-3\">\r\n                    ");
#nullable restore
#line 49 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Views\PhieuMuon\Detail.cshtml"
               Write(Html.DisplayNameFor(model => model.SoLuongMuon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-9\">\r\n                    ");
#nullable restore
#line 52 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Views\PhieuMuon\Detail.cshtml"
               Write(Html.DisplayFor(model => model.SoLuongMuon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-3\">\r\n                    ");
#nullable restore
#line 55 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Views\PhieuMuon\Detail.cshtml"
               Write(Html.DisplayNameFor(model => model.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-9\">\r\n                    ");
#nullable restore
#line 58 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Views\PhieuMuon\Detail.cshtml"
               Write(Html.DisplayFor(model => model.User));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </dd>
            </dl>
            <div style=""margin-left: 10px; margin-bottom: 10px;""> 
                <button class=""btn-outline-success"" onclick=""myfunction()"" >In PDF</button>
            </div>
            
            <script>
                function myfunction() {

                    var doc = new jsPDF()
                    var h1 = document.querySelector('#data')
                    doc.fromHTML(h1, 15, 15)
                    doc.save(""output.pdf"")
                }
            </script>
            <src=""https://cdnjs.cloudflare.com/ajax/libs/jspdf/1.5.3/jspdf.min.js""></script>
        </div>
        </div>
    </div>
</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QLThuVien.Models.PhieuMuon> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

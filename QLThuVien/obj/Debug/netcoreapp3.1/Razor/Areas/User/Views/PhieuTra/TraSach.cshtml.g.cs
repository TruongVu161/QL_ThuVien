#pragma checksum "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\TraSach.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4841c696255825ab0da1676fbb70be7ebd7d4814"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_PhieuTra_TraSach), @"mvc.1.0.view", @"/Areas/User/Views/PhieuTra/TraSach.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4841c696255825ab0da1676fbb70be7ebd7d4814", @"/Areas/User/Views/PhieuTra/TraSach.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01766513dca41114e40f89b458a8a274af3bbe90", @"/Areas/User/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_User_Views_PhieuTra_TraSach : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<QLThuVien.Models.PhieuMuonInCTPM>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/User/PhieuTra/EditTraSach"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/User/PhieuTra/Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\TraSach.cshtml"
  
    ViewData["Title"] = "TraSach";
    Layout = "~/Areas/User/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        setTimeout(function () {\r\n            $(\'#msgAlert\').fadeOut(\'slow\');\r\n        }, 2000);</script>\r\n");
            }
            );
            WriteLiteral(@"<div class=""container-fluid"">
    <h1 class=""mt-4"">Danh Sách Phiếu Chưa Trả</h1>
    <ol class=""breadcrumb mb-4"">
        <li class=""breadcrumb-item""><a href=""/Home"">Trang chủ</a></li>
        <li class=""breadcrumb-item active"">Danh sách phhiếu chưa trả</li>
    </ol>
    <div class=""card-body"">
        <div class=""row"">
");
#nullable restore
#line 21 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\TraSach.cshtml"
             if (ViewBag.SuccessMsg != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div id=\"msgAlert\" class=\"alert alert-success\" role=\"alert\">\r\n                    ");
#nullable restore
#line 24 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\TraSach.cshtml"
               Write(ViewBag.SuccessMsg);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>");
#nullable restore
#line 25 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\TraSach.cshtml"
                      }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
        <div class=""card mb-4"">
            <div class=""card-header""><i class=""fas fa-table mr-1""></i>Phiếu mượn</div>
            <div class=""card-body"">
                <div class=""table-responsive"">
                    <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                        <thead>
                            <tr>
                                <th>
                                    ");
#nullable restore
#line 35 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\TraSach.cshtml"
                               Write(Html.DisplayNameFor(model => model.MaPM));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 38 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\TraSach.cshtml"
                               Write(Html.DisplayNameFor(model => model.MaDG));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 41 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\TraSach.cshtml"
                               Write(Html.DisplayNameFor(model => model.MaSach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 44 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\TraSach.cshtml"
                               Write(Html.DisplayNameFor(model => model.NgayHenTra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 47 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\TraSach.cshtml"
                               Write(Html.DisplayNameFor(model => model.NgayTra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 50 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\TraSach.cshtml"
                               Write(Html.DisplayNameFor(model => model.TinhTrangSach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 53 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\TraSach.cshtml"
                               Write(Html.DisplayNameFor(model => model.TinhTrangTra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 56 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\TraSach.cshtml"
                               Write(Html.DisplayNameFor(model => model.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 59 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\TraSach.cshtml"
                               Write(Html.DisplayNameFor(model => model.GhiChu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 62 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\TraSach.cshtml"
                               Write(Html.DisplayNameFor(model => model.TienPhat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th></th>\r\n                                <th></th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 69 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\TraSach.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 73 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\TraSach.cshtml"
                               Write(Html.DisplayFor(modelItem => item.MaPM));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 76 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\TraSach.cshtml"
                               Write(Html.DisplayFor(modelItem => item.MaDG));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 79 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\TraSach.cshtml"
                               Write(Html.DisplayFor(modelItem => item.MaSach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 82 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\TraSach.cshtml"
                               Write(Html.DisplayFor(modelItem => item.NgayHenTra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 85 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\TraSach.cshtml"
                               Write(Html.DisplayFor(modelItem => item.NgayTra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 88 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\TraSach.cshtml"
                               Write(Html.DisplayFor(modelItem => item.TinhTrangSach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 91 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\TraSach.cshtml"
                               Write(Html.DisplayFor(modelItem => item.TinhTrangTra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 94 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\TraSach.cshtml"
                               Write(Html.DisplayFor(modelItem => item.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 97 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\TraSach.cshtml"
                               Write(Html.DisplayFor(modelItem => item.GhiChu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 100 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\TraSach.cshtml"
                               Write(Html.DisplayFor(modelItem => item.TienPhat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4841c696255825ab0da1676fbb70be7ebd7d481415261", async() => {
                WriteLiteral("\r\n                                        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 4902, "\"", 4920, 1);
#nullable restore
#line 104 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\TraSach.cshtml"
WriteAttributeValue("", 4910, item.MaPM, 4910, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"id\" />\r\n                                        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 4996, "\"", 5016, 1);
#nullable restore
#line 105 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\TraSach.cshtml"
WriteAttributeValue("", 5004, item.MaSach, 5004, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"mas\" />\r\n                                        <input type=\"submit\" value=\"Trả sách\" class=\"btn btn-outline-success\" />\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4841c696255825ab0da1676fbb70be7ebd7d481418263", async() => {
                WriteLiteral("\r\n                                        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 5416, "\"", 5434, 1);
#nullable restore
#line 111 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\TraSach.cshtml"
WriteAttributeValue("", 5424, item.MaPM, 5424, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"id\" />\r\n                                        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 5510, "\"", 5530, 1);
#nullable restore
#line 112 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\TraSach.cshtml"
WriteAttributeValue("", 5518, item.MaSach, 5518, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"mas\" />\r\n                                        <input type=\"submit\" value=\"Sửa\" class=\"btn btn-outline-warning\" />\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 117 "D:\LapTrinhWEB_CNPMNC\Framework đồ án\QLThuVien\Areas\User\Views\PhieuTra\TraSach.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<QLThuVien.Models.PhieuMuonInCTPM>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
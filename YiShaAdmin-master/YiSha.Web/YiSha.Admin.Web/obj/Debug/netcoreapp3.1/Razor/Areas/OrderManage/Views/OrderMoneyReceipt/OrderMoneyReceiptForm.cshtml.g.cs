#pragma checksum "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderMoneyReceipt\OrderMoneyReceiptForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2afe26b406d133169f7e1d7455ac33f10d85989f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_OrderManage_Views_OrderMoneyReceipt_OrderMoneyReceiptForm), @"mvc.1.0.view", @"/Areas/OrderManage/Views/OrderMoneyReceipt/OrderMoneyReceiptForm.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
#nullable restore
#line 3 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\_ViewImports.cshtml"
using YiSha.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\_ViewImports.cshtml"
using YiSha.Util.Extension;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\_ViewImports.cshtml"
using YiSha.Util.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\_ViewImports.cshtml"
using YiSha.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\_ViewImports.cshtml"
using YiSha.Enum.OrganizationManage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\_ViewImports.cshtml"
using YiSha.Web.Code;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2afe26b406d133169f7e1d7455ac33f10d85989f", @"/Areas/OrderManage/Views/OrderMoneyReceipt/OrderMoneyReceiptForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e45dbd51f3d139278b58e1807e343bf3fa8e8229", @"/Areas/OrderManage/_ViewImports.cshtml")]
    public class Areas_OrderManage_Views_OrderMoneyReceipt_OrderMoneyReceiptForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal m"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderMoneyReceipt\OrderMoneyReceiptForm.cshtml"
  
    Layout = "~/Views/Shared/_FormWhite.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"wrapper animated fadeInRight\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2afe26b406d133169f7e1d7455ac33f10d85989f5581", async() => {
                WriteLiteral(@"
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">标题<font class=""red""> *</font></label>
            <div class=""col-sm-8"">
                <input id=""title"" col=""Title"" type=""text"" class=""form-control"" />
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">交款项目<font class=""red""> *</font></label>
            <div class=""col-sm-8"">
                <input id=""payManItme"" col=""PayManItme"" type=""text"" class=""form-control"" />
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">交款人<font class=""red""> *</font></label>
            <div class=""col-sm-8"">
                <input id=""payManName"" col=""PayManName"" type=""text"" class=""form-control"" />
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">收款单位<font class=""red""> *</font></label>
            <div class=""col-sm-8"">
");
                WriteLiteral(@"                <input id=""companyTxt"" col=""CompanyTxt"" type=""text"" class=""form-control"" />
                <input type=""hidden"" id=""companyId"" col=""CompanyId"" />
            </div>
            <div class=""col-sm-2 roleCode_op"">
                <button type=""button"" class=""btn btn-primary btn-sm"" onclick=""setParent()"">选 择</button><br />
            </div>
          
        </div>
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">业务员<font class=""red""> *</font></label>
            <div class=""col-sm-8"">
                <input id=""saleManTxt"" col=""SaleManTxt"" type=""text"" class=""form-control"" />
                <input type=""hidden"" id=""saleManId"" col=""SaleManId"" />
            </div>
            <div class=""col-sm-2 roleCode_op"">
                <button type=""button"" class=""btn btn-primary btn-sm"" onclick=""setParent()"">选 择</button><br />
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">备注</la");
                WriteLiteral("bel>\r\n            <div class=\"col-sm-8\">\r\n                <textarea id=\"remark\" col=\"Remark\" class=\"form-control\" style=\"height:60px\"></textarea>\r\n            </div>\r\n        </div>\r\n        \r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>

<script type=""text/javascript"">
    var id = ys.request(""id"");
    $(function () {
        getForm();

        $('#form').validate({
            rules: {
                title: { required: true },
                payManItme: { required: true },
                payManName: { required: true },
                companyName: { required: true },
                saleManTxt: { required: true },
            }
        });
    });

    function getForm() {
        if (id > 0) {
            ys.ajax({
                url: '");
#nullable restore
#line 75 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderMoneyReceipt\OrderMoneyReceiptForm.cshtml"
                 Write(Url.Content("~/OrderManage/OrderMoneyReceipt/GetFormJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '?id=' + id,
                type: 'get',
                success: function (obj) {
                    if (obj.Tag == 1) {
                        $('#form').setWebControls(obj.Data);
                    }
                }
            });
        }
        else {
            var defaultData = {};
            $('#form').setWebControls(defaultData);
        }
    }

    function saveForm(index) {
        if ($('#form').validate().form()) {
            var postData = $('#form').getWebControls({ Id: id });
            ys.ajax({
                url: '");
#nullable restore
#line 94 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderMoneyReceipt\OrderMoneyReceiptForm.cshtml"
                 Write(Url.Content("~/OrderManage/OrderMoneyReceipt/SaveFormJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                type: 'post',
                data: postData,
                success: function (obj) {
                    if (obj.Tag == 1) {
                        ys.msgSuccess(obj.Message);
                        parent.searchGrid();
                        parent.layer.close(index);
                    }
                    else {
                        ys.msgError(obj.Message);
                    }
                }
            });
        }
    }



    /**设置收款单位 */
    function setCompany() {
        ys.openDialog({
            title:  ""设置上级"",
            content: '");
#nullable restore
#line 117 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderMoneyReceipt\OrderMoneyReceiptForm.cshtml"
                 Write(Url.Content("~/SystemManage/SysReceiptConfig/SysReceiptConfigIndexSelect"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            width: ""868px"",
            height: ""470px"",
             callback: function (index, layero) {
                var iframeWin = window[layero.find('iframe')[0]['name']];
                 var select_data = iframeWin.chooseUserOK();
                 if (IsNullEmpty(select_data.ids)) {
                    ys.alertError('请先选择,再操作');
                }
                else {
                    //设置 操作人 saleId
                     $(""#companyId"").val(select_data.ids);
                     $(""#companyTxt"").val(select_data.txts);
                     layer.close(index);

                }
            }
        });

    }


    /**选择业务员 */
    function setParent() {
        ys.openDialog({
            title:  ""设置上级"",
            content: '");
#nullable restore
#line 143 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderMoneyReceipt\OrderMoneyReceiptForm.cshtml"
                 Write(Url.Content("~/OrganizationManage/User/UserIndexSelect"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            width: ""868px"",
            height: ""470px"",
             callback: function (index, layero) {
                var iframeWin = window[layero.find('iframe')[0]['name']];
                 var select_data = iframeWin.chooseUserOK();
                 if (IsNullEmpty(select_data.ids)) {
                     ys.alertError('请先业务员,再操作');
                }
                else {
                    //设置 操作人 saleId
                     $(""#saleId"").val(select_data.ids);
                     $(""#saleTxt"").val(select_data.txts);
                     layer.close(index);

                }
            }
        });

    }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

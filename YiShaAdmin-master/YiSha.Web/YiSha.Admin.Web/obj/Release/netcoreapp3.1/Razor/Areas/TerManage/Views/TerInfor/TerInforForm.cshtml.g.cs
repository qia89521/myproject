#pragma checksum "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\TerManage\Views\TerInfor\TerInforForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b619fe286fa164d202b1fabb2c285ba6eb3d8dac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_TerManage_Views_TerInfor_TerInforForm), @"mvc.1.0.view", @"/Areas/TerManage/Views/TerInfor/TerInforForm.cshtml")]
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
#line 2 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\TerManage\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\TerManage\_ViewImports.cshtml"
using YiSha.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\TerManage\_ViewImports.cshtml"
using YiSha.Util.Extension;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\TerManage\_ViewImports.cshtml"
using YiSha.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\TerManage\_ViewImports.cshtml"
using YiSha.Enum.OrganizationManage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\TerManage\_ViewImports.cshtml"
using YiSha.Enum.SystemManage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\TerManage\_ViewImports.cshtml"
using YiSha.Web.Code;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b619fe286fa164d202b1fabb2c285ba6eb3d8dac", @"/Areas/TerManage/Views/TerInfor/TerInforForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fff452d81302d3bae40575f5c9db46ed73b4e31f", @"/Areas/TerManage/_ViewImports.cshtml")]
    public class Areas_TerManage_Views_TerInfor_TerInforForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\TerManage\Views\TerInfor\TerInforForm.cshtml"
  
    Layout = "~/Views/Shared/_FormWhite.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"wrapper animated fadeInRight\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b619fe286fa164d202b1fabb2c285ba6eb3d8dac5452", async() => {
                WriteLiteral(@"

        <div class=""tabs-container"">

            <div class=""tabs-container"">
                <ul class=""nav nav-tabs"">
                    <li class=""active"">
                        <a data-toggle=""tab"" href=""#tab-8"">基本信息</a>
                    </li>
                    <li");
                BeginWriteAttribute("class", " class=\"", 438, "\"", 446, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        <a data-toggle=""tab"" href=""#tab-9"">状态信息</a>
                    </li>
                </ul>
                <div class=""tab-content "">
                    <div id=""tab-8"" class=""tab-pane active"">
                        <div class=""panel-body"">
                            <div class=""form-group"">
                                <label class=""col-sm-3 control-label "">设备名称<font class=""red""> *</font></label>
                                <div class=""col-sm-8"">
                                    <input id=""terName"" col=""TerName"" type=""text"" class=""form-control"" />
                                </div>
                            </div>
                            <div class=""form-group"">
                                <label class=""col-sm-3 control-label "">设备编号</label>
                                <div class=""col-sm-8"">
                                    <input id=""terNumber"" col=""TerNumber"" type=""text"" class=""form-control"" />
                                </d");
                WriteLiteral(@"iv>
                            </div>
                            <div class=""form-group"">
                                <label class=""col-sm-3 control-label "">设备部件</label>
                                <div class=""col-sm-4"">
                                    <div id=""terParts"" col=""TerParts""></div>
                                </div>
                            </div>
                            <div class=""form-group"" style=""display:none"">
                                <label class=""col-sm-3 control-label "">运营商</label>
                                <div class=""col-sm-8"">
                                    <input id=""busyName"" col=""BusyName"" type=""text"" class=""form-control"" />
                                </div>
                            </div>
                            <div class=""form-group"" style=""display:none"">
                                <label class=""col-sm-3 control-label "">联系方式</label>
                                <div class=""col-sm-8"">
                  ");
                WriteLiteral(@"                  <input id=""busyLink"" col=""BusyLink"" type=""text""  onkeyup=""this.value=CheckIsFormatNumber(this.value, 0)"" class=""form-control"" />
                                </div>
                            </div>
                            <div class=""form-group"">
                                <label class=""col-sm-3 control-label "">关机密码</label>
                                <div class=""col-sm-8"">
                                    <input id=""closePwd"" col=""ClosePwd"" onkeyup=""this.value=CheckIsFormatNumber(this.value, 0)"" type=""text"" class=""form-control"" />
                                </div>
                            </div>
                            <div class=""form-group"" style=""display:none"">
                                <label class=""col-sm-3 control-label "">商户号</label>
                                <div class=""col-sm-8"">
                                    <input id=""mchId"" col=""MchId"" type=""text"" class=""form-control"" />
                                </div>
      ");
                WriteLiteral(@"                      </div>
                            <div class=""form-group"" style=""display:none"">
                                <label class=""col-sm-3 control-label "">商户名称</label>
                                <div class=""col-sm-8"">
                                    <input id=""mchName"" col=""MchName"" type=""text"" class=""form-control"" />
                                </div>
                            </div>
                        </div>
                    </div>
                    <div id=""tab-9"" class=""tab-pane"">
                        <div class=""panel-body"">

                            <div class=""form-group"">
                                <label class=""col-sm-3 control-label "">累计使用水量</label>
                                <div class=""col-sm-8"">
                                    <input id=""waterNum"" col=""WaterNum"" type=""text""  onkeyup=""this.value=CheckIsFormatNumber(this.value, 0)"" class=""form-control"" />
                                </div>
                         ");
                WriteLiteral(@"   </div>
                            <div class=""form-group"">
                                <label class=""col-sm-3 control-label "">累计使用时长</label>
                                <div class=""col-sm-8"">
                                    <input id=""timeLen"" col=""TimeLen"" type=""text""  onkeyup=""this.value=CheckIsFormatNumber(this.value, 0)"" class=""form-control"" />
                                </div>
                            </div>
                            <div class=""form-group"">
                                <label class=""col-sm-3 control-label "">当前网络信号</label>
                                <div class=""col-sm-8"">
                                    <input id=""netSignal"" col=""NetSignal"" type=""text""  onkeyup=""this.value=CheckIsFormatNumber(this.value, 0)"" class=""form-control"" />
                                </div>
                            </div>
                            <div class=""form-group"" style=""display:none"">
                                <label class=""col-sm-3 contr");
                WriteLiteral(@"ol-label "">业主</label>
                                <div class=""col-sm-8"">
                                    <input id=""manageId"" col=""ManageId"" type=""text"" class=""form-control"" />
                                </div>
                            </div>
                            <div class=""form-group"">
                                <label class=""col-sm-3 control-label "">排放位置</label>
                                <div class=""col-sm-8"">
                                    <input id=""position"" col=""Position"" type=""text"" class=""form-control"" />
                                </div>
                            </div>
                            <div class=""form-group"">
                                <label class=""col-sm-3 control-label "">地球经度</label>
                                <div class=""col-sm-8"">
                                    <input id=""longitude"" col=""Longitude"" type=""text""  onkeyup=""this.value=CheckIsFormatNumber(this.value, 2)"" class=""form-control"" />
                 ");
                WriteLiteral(@"               </div>
                            </div>
                            <div class=""form-group"">
                                <label class=""col-sm-3 control-label "">地球纬度</label>
                                <div class=""col-sm-8"">
                                    <input id=""latitude"" col=""Latitude"" type=""text""  onkeyup=""this.value=CheckIsFormatNumber(this.value, 2)"" class=""form-control"" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            </div>

        </div>


    ");
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
            WriteLiteral("\r\n</div>\r\n\r\n<script type=\"text/javascript\">\r\n    var id = ys.request(\"id\");\r\n    $(function () {\r\n        getForm();\r\n         $(\"#terParts\").ysComboBox({\r\n            url: \'");
#nullable restore
#line 134 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\TerManage\Views\TerInfor\TerInforForm.cshtml"
             Write(Url.Content("~/TerManage/Parts/GetListJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            //dataName: ""Result"",
            key: ""PartCode"",
            value: ""PartName"",
            class: ""form-control"",
             multiple: true,
         });
        //$(""#terParts_select"").attr(""disabled"", ""disabled"");

        $('#form').validate({
            rules: {
                terName: { required: true }
            }
        });

    });

    function getForm() {
        if (id > 0) {
            ys.ajax({
                url: '");
#nullable restore
#line 154 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\TerManage\Views\TerInfor\TerInforForm.cshtml"
                 Write(Url.Content("~/TerManage/TerInfor/GetFormJson"));

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
#line 173 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\TerManage\Views\TerInfor\TerInforForm.cshtml"
                 Write(Url.Content("~/TerManage/TerInfor/SaveFormJson"));

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

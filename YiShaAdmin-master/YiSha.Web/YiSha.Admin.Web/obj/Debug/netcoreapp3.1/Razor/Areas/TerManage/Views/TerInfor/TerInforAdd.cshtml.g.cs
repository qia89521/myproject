#pragma checksum "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\TerManage\Views\TerInfor\TerInforAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50b9a416f8943dafe4a8418aafec68f36ff61a75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_TerManage_Views_TerInfor_TerInforAdd), @"mvc.1.0.view", @"/Areas/TerManage/Views/TerInfor/TerInforAdd.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50b9a416f8943dafe4a8418aafec68f36ff61a75", @"/Areas/TerManage/Views/TerInfor/TerInforAdd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fff452d81302d3bae40575f5c9db46ed73b4e31f", @"/Areas/TerManage/_ViewImports.cshtml")]
    public class Areas_TerManage_Views_TerInfor_TerInforAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\TerManage\Views\TerInfor\TerInforAdd.cshtml"
  
    Layout = "~/Views/Shared/_FormWhite.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"wrapper animated fadeInRight\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50b9a416f8943dafe4a8418aafec68f36ff61a755446", async() => {
                WriteLiteral(@"

        <div class=""tabs-container"">

            <div class=""tabs-container"">
                <ul class=""nav nav-tabs"">
                    <li class=""active"">
                        <a data-toggle=""tab"" href=""#tab-8"">基本数据</a>
                    </li>
                </ul>
                <div class=""tab-content "">
                    <div id=""tab-8"" class=""tab-pane active"">
                        <div class=""panel-body"">
                            <div class=""form-group"">
                                <label class=""col-sm-2 control-label "">设备类型<font class=""red""> *</font></label>
                                <div class=""col-sm-4"">
                                    <div id=""terPartId"" col=""TerPartId""></div>
                                </div>
                            </div>
                            <div class=""form-group"">
                                <label class=""col-sm-2 control-label "">设备名称<font class=""red""> *</font></label>
                                <di");
                WriteLiteral(@"v class=""col-sm-8"">
                                    <input id=""terName"" col=""TerName"" type=""text"" placeholder=""输入设备名称"" class=""form-control"" />
                                </div>
                            </div>
                            <div class=""form-group"">
                                <label class=""col-sm-2 control-label "">起始编号<font class=""red""> *</font></label>
                                <div class=""col-sm-8"">
                                    <input id=""startNumber"" col=""StartNumber"" type=""text"" onfocus=""this.blur()"" placeholder=""输入数字,不能以0开头"" class=""form-control"" />
                                </div>
                                <div class=""col-sm-2 roleCode_op"">
                                    <button type=""button"" class=""btn btn-primary btn-sm"" onclick=""getMaxNumber()"">生成</button><br />
                                </div>
                            </div>
                            <div class=""form-group"">
                                <label clas");
                WriteLiteral(@"s=""col-sm-2 control-label "">新增数量<font class=""red""> *</font></label>
                                <div class=""col-sm-8"">
                                    <input id=""count"" col=""Count"" type=""text"" value=""1"" class=""form-control"" />
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
            WriteLiteral("\r\n</div>\r\n\r\n<script type=\"text/javascript\">\r\n    $(function () {\r\n        $(\"#terPartId\").ysComboBox({\r\n            url: \'");
#nullable restore
#line 60 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\TerManage\Views\TerInfor\TerInforAdd.cshtml"
             Write(Url.Content("~/TerManage/Parts/GetListJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            //dataName: ""Result"",
            key: ""Id"",
            value: ""PartName"",
            class: ""form-control"",
             multiple: false,
         });
        //$(""#terParts_select"").attr(""disabled"", ""disabled"");

        $('#form').validate({
            rules: {
                terName: { required: true },
                startNumber: {
                    required: true,
                    minlength: 8,
                    maxlength: 8
                },
                count: { required: true },
                terPartId_select: {
                    required: true,
                    min: 1 },
            }, messages: {
                startNumber: {
                    required: ""起始编号不能为空"",
                    minlength: ""长度8位"",
                    maxlength: ""长度8位"",
                },
            }
        });

    });



    function saveForm(index) {
        if ($('#form').validate().form()) {
            var postData = $('#form').getWebControls");
            WriteLiteral("();\r\n            ys.ajax({\r\n                url: \'");
#nullable restore
#line 98 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\TerManage\Views\TerInfor\TerInforAdd.cshtml"
                 Write(Url.Content("~/TerManage/TerInfor/BateSaveFormJson"));

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

    function getMaxNumber() {
         var postData = $('#form').getWebControls();
         ys.ajax({
            url: '");
#nullable restore
#line 118 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\TerManage\Views\TerInfor\TerInforAdd.cshtml"
             Write(Url.Content("~/TerManage/TerInfor/GetMaxNumber"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            type: 'post',
            data: {},
            success: function (obj) {
                 alert(JSON.stringify(obj));
                    if (obj.Tag == 1) {
                        var number = obj.Data;
                        $(""#startNumber"").val((parseInt(number)+1));
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

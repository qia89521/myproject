#pragma checksum "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\User\UserForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0e1b430032c4d23a23076b8add462b3ddbc55c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_OrganizationManage_Views_User_UserForm), @"mvc.1.0.view", @"/Areas/OrganizationManage/Views/User/UserForm.cshtml")]
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
#line 3 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\_ViewImports.cshtml"
using YiSha.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\_ViewImports.cshtml"
using YiSha.Util.Extension;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\_ViewImports.cshtml"
using YiSha.Util.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\_ViewImports.cshtml"
using YiSha.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\_ViewImports.cshtml"
using YiSha.Enum.OrganizationManage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\_ViewImports.cshtml"
using YiSha.Web.Code;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e1b430032c4d23a23076b8add462b3ddbc55c6", @"/Areas/OrganizationManage/Views/User/UserForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e45dbd51f3d139278b58e1807e343bf3fa8e8229", @"/Areas/OrganizationManage/_ViewImports.cshtml")]
    public class Areas_OrganizationManage_Views_User_UserForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\User\UserForm.cshtml"
  
    Layout = "~/Views/Shared/_FormWhite.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"wrapper animated fadeInRight\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0e1b430032c4d23a23076b8add462b3ddbc55c65523", async() => {
                WriteLiteral(@"
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">登录名称<font class=""red""> *</font></label>
            <div class=""col-sm-4"">
                <input id=""userName"" col=""UserName"" type=""text"" class=""form-control"" />
            </div>
            <label class=""col-sm-2 control-label "">登录密码<font class=""red""> *</font></label>
            <div class=""col-sm-4"">
                <input id=""password"" col=""Password"" type=""password"" class=""form-control"" />
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">姓名</label>
            <div class=""col-sm-4"">
                <input id=""realName"" col=""RealName"" type=""text"" class=""form-control"" />
            </div>
            <label class=""col-sm-2 control-label "">性别</label>
            <div class=""col-sm-4"" id=""gender"" col=""Gender""></div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">生日</label>
         ");
                WriteLiteral(@"   <div class=""col-sm-4"">
                <input id=""birthday"" col=""Birthday"" type=""text"" class=""form-control"" />
            </div>

            <label class=""col-sm-2 control-label "">部门</label>
            <div class=""col-sm-4"">
                <div id=""departmentId"" col=""DepartmentId""></div>
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">手机</label>
            <div class=""col-sm-4"">
                <input id=""mobile"" col=""Mobile"" type=""text"" class=""form-control"" />
            </div>
            <label class=""col-sm-2 control-label "">职位</label>
            <div class=""col-sm-4"">
                <div id=""positionId"" col=""PositionIds""></div>
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">邮箱</label>
            <div class=""col-sm-4"">
                <input id=""email"" col=""Email"" type=""text"" class=""form-control"" />
            </div>
            <");
                WriteLiteral(@"label class=""col-sm-2 control-label"">状态</label>
            <div class=""col-sm-4"" id=""userStatus"" col=""UserStatus""></div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-2 control-label"">角色</label>
            <div class=""col-sm-10"" id=""role"" col=""RoleIds""></div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">上级</label>
            <div class=""col-sm-8"">
                <input id=""parentTxt"" col=""ParentTxt""  onfocus=""this.blur()"" type=""text"" class=""form-control"" />
                <input type=""hidden"" id=""parentId"" col=""ParentId"" />
            </div>
            <div class=""col-sm-2"">
                <button type=""button"" class=""btn btn-primary btn-sm"" onclick=""setParent()"">设 置</button><br />
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">代理区域</label>
            <div class=""col-sm-8"">
                <textarea id=""delegetZoneTxt"" col=");
                WriteLiteral(@"""DelegetZoneTxt"" onfocus=""this.blur()"" class=""form-control"" style=""height:60px""></textarea>
                <input type=""hidden"" id=""delegetZoneId"" col=""DelegetZoneId"" />
            </div>
            <div class=""col-sm-2"">
                <button type=""button"" class=""btn btn-primary btn-sm"" onclick=""setZone()"">设 置</button><br />
                <button type=""button"" class=""btn btn-default btn-sm"" onclick=""clearZone()"">清 空</button>
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">备注</label>
            <div class=""col-sm-10"">
                <textarea id=""remark""  col=""Remark"" class=""form-control"" style=""height:60px""></textarea>
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
            WriteLiteral("\r\n</div>\r\n\r\n<script type=\"text/javascript\">\r\n    var id = ys.request(\"id\");\r\n    $(function () {\r\n        $(\"#userStatus\").ysRadioBox({ data: ys.getJson(");
#nullable restore
#line 91 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\User\UserForm.cshtml"
                                                  Write(Html.Raw(typeof(StatusEnum).EnumToDictionaryString()));

#line default
#line hidden
#nullable disable
            WriteLiteral(") });\r\n        $(\"#gender\").ysRadioBox({ data: ys.getJson(");
#nullable restore
#line 92 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\User\UserForm.cshtml"
                                              Write(Html.Raw(typeof(YiSha.Enum.OrganizationManage.GenderTypeEnum).EnumToDictionaryString()));

#line default
#line hidden
#nullable disable
            WriteLiteral(") });\r\n\r\n        $(\"#role\").ysCheckBox({\r\n            url: \'");
#nullable restore
#line 95 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\User\UserForm.cshtml"
             Write(Url.Content("~/SystemManage/Role/GetListJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n            key: \"Id\",\r\n            value: \"RoleName\"\r\n        });\r\n\r\n        $(\"#positionId\").ysComboBox({\r\n            url: \'");
#nullable restore
#line 101 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\User\UserForm.cshtml"
             Write(Url.Content("~/OrganizationManage/Position/GetListJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n            key: \"Id\",\r\n            value: \"PositionName\",\r\n            class: \"form-control\",\r\n            multiple: true\r\n        });\r\n\r\n        $(\'#departmentId\').ysComboBoxTree({ url: \'");
#nullable restore
#line 108 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\User\UserForm.cshtml"
                                             Write(Url.Content("~/OrganizationManage/Department/GetDepartmentTreeListJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' });

        laydate.render({ elem: '#birthday', format: 'yyyy-MM-dd' });

        getForm(id);

        $(""#form"").validate({
            rules: {
                userName: { required: true },
                password: {
                    required: true,
                    minlength: 6,
                    maxlength: 20
                },
                mobile: { isPhone: true},
                email: { email: true}
            }
        });
    });

    function getForm() {
        if (id > 0) {
            $('#password').attr(""readonly"", ""readonly"").attr(""disabled"", ""disabled"");

            ys.ajax({
                url: '");
#nullable restore
#line 133 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\User\UserForm.cshtml"
                 Write(Url.Content("~/OrganizationManage/User/GetFormJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '?id=' + id,
                type: ""get"",
                success: function (obj) {
                    if (obj.Tag == 1) {
                        var result = obj.Data;
                        $(""#form"").setWebControls(result);
                    }
                }
            });
        }
        else {
            var defaultData = {};
            defaultData.UserName = """";
            defaultData.Password = """"
            defaultData.UserStatus = """);
#nullable restore
#line 147 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\User\UserForm.cshtml"
                                 Write(StatusEnum.Yes.ParseToInt());

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";
            $(""#form"").setWebControls(defaultData);
        }
    }

    function saveForm(index) {
        if ($(""#form"").validate().form()) {
            var postData = $(""#form"").getWebControls({ Id: id });
           
            postData.DepartmentId = ys.getLastValue(postData.DepartmentId);
            ys.ajax({
                url: '");
#nullable restore
#line 158 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\User\UserForm.cshtml"
                 Write(Url.Content("~/OrganizationManage/User/SaveFormJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                type: ""post"",
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

    /**设置代理区域 */
    function setZone() {
        ys.openDialog({
            title:  ""设置代理区域"",
            content: '");
#nullable restore
#line 179 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\User\UserForm.cshtml"
                 Write(Url.Content("~/SystemManage/Area/AreaIndexSelect"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            width: ""868px"",
            height: ""430px"",
             callback: function (index, layero) {
                 var iframeWin = window[layero.find('iframe')[0]['name']];
                 var select_data = iframeWin.getSelectZone();
                 setZoneVaule(select_data);
                 //getSelectZone
                 layer.close(index);
            }
        });

    }

    /**设置上级 */
    function setParent() {
        ys.openDialog({
            title:  ""设置上级"",
            content: '");
#nullable restore
#line 197 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\User\UserForm.cshtml"
                 Write(Url.Content("~/OrganizationManage/User/UserIndexSelect"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + ""?curUserId="" + id,
            width: ""868px"",
            height: ""470px"",
             callback: function (index, layero) {
                var iframeWin = window[layero.find('iframe')[0]['name']];
                 var select_data = iframeWin.chooseUserOK();
                 if (IsNullEmpty(select_data.ids)) {
                    ys.alertError('请先选择用户,再操作');
                }
                else {
                    //设置 操作人
                     $(""#parentId"").val(select_data.ids);
                     $(""#parentTxt"").val(select_data.txts);
                     layer.close(index);
                     
                }
            }
        });

    }
    /*清空区域 */
    function clearZone() {
        $(""#delegetZoneTxt"").val("""");
        $(""#delegetZoneId"").val("""");
    }
    function setZoneVaule(select_data) {
        var delegetZoneTxt = $(""#delegetZoneTxt"").val();
        var delegetZoneId = $(""#delegetZoneId"").val();
        if (delegetZoneId != """") {
            $(""");
            WriteLiteral(@"#delegetZoneTxt"").val(delegetZoneTxt+"",""+select_data.txts);
            $(""#delegetZoneId"").val(delegetZoneId+"",""+select_data.ids);
        }
        else {
            $(""#delegetZoneTxt"").val(select_data.txts);
            $(""#delegetZoneId"").val(select_data.ids);
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

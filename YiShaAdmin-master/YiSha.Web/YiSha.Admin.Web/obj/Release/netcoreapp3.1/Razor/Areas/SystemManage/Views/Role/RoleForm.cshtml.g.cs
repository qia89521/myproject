#pragma checksum "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\Role\RoleForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e4492f9cccd66cfc637a91efcfb54d0a9d76643"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SystemManage_Views_Role_RoleForm), @"mvc.1.0.view", @"/Areas/SystemManage/Views/Role/RoleForm.cshtml")]
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
#line 2 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\_ViewImports.cshtml"
using YiSha.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\_ViewImports.cshtml"
using YiSha.Util.Extension;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\_ViewImports.cshtml"
using YiSha.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\_ViewImports.cshtml"
using YiSha.Enum.OrganizationManage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\_ViewImports.cshtml"
using YiSha.Enum.SystemManage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\_ViewImports.cshtml"
using YiSha.Web.Code;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e4492f9cccd66cfc637a91efcfb54d0a9d76643", @"/Areas/SystemManage/Views/Role/RoleForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fff452d81302d3bae40575f5c9db46ed73b4e31f", @"/Areas/SystemManage/_ViewImports.cshtml")]
    public class Areas_SystemManage_Views_Role_RoleForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\Role\RoleForm.cshtml"
  
    Layout = "~/Views/Shared/_FormWhite.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"wrapper animated fadeInRight\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e4492f9cccd66cfc637a91efcfb54d0a9d766435446", async() => {
                WriteLiteral(@"
        <div class=""form-group"">
            <label class=""col-sm-3 control-label "">角色名称<font class=""red""> *</font></label>
            <div class=""col-sm-8"">
                <input id=""roleName"" col=""RoleName"" type=""text"" class=""form-control"" />
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-3 control-label "">角色代码<font class=""red""> *</font></label>
            <div class=""col-sm-8"">
                <div id=""roleCode"" col=""RoleCode"">
                </div>
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-3 control-label "">显示顺序</label>
            <div class=""col-sm-8"">
                <input id=""roleSort"" col=""RoleSort"" type=""text"" class=""form-control"" />
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-3 control-label "">状态</label>
            <div class=""col-sm-8"" id=""roleStatus"" col=""RoleStatus"">
            </div>
        </div>");
                WriteLiteral(@"
        <div class=""form-group"">
            <label class=""col-sm-3 control-label "">备注</label>
            <div class=""col-sm-8"">
                <input id=""remark"" col=""Remark"" type=""text"" class=""form-control"" />
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-3 control-label "">菜单权限</label>
            <div class=""col-sm-8"">
                <div id=""menuTree"" class=""ztree""></div>
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
            WriteLiteral("\r\n</div>\r\n\r\n<script type=\"text/javascript\">\r\n    var id = ys.request(\"id\");\r\n    $(function () {\r\n        $(\"#roleStatus\").ysRadioBox({ data: ys.getJson(");
#nullable restore
#line 49 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\Role\RoleForm.cshtml"
                                                  Write(Html.Raw(typeof(StatusEnum).EnumToDictionaryString()));

#line default
#line hidden
#nullable disable
            WriteLiteral(") });\r\n        $(\"#roleCode\").ysComboBox({ data: ys.getJson(");
#nullable restore
#line 50 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\Role\RoleForm.cshtml"
                                                Write(Html.Raw(typeof(SysRoleEnum).EnumToDictionaryString()));

#line default
#line hidden
#nullable disable
            WriteLiteral(@") });
        
        loadMenuTree();

        getForm();

        $(""#form"").validate({
            rules: {
                roleName: { required: true }
            }
        });
    });

    function loadMenuTree() {
        $('#menuTree').ysTree({
            async: false,
            url: '");
#nullable restore
#line 66 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\Role\RoleForm.cshtml"
             Write(Url.Content("~/SystemManage/Menu/GetMenuTreeListJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n            check: { enable: true },\r\n            expandLevel: 0\r\n        })\r\n    }\r\n\r\n    function getForm() {\r\n        if (id > 0) {\r\n            ys.ajax({\r\n                url: \'");
#nullable restore
#line 75 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\Role\RoleForm.cshtml"
                 Write(Url.Content("~/SystemManage/Role/GetFormJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '?id=' + id,
                type: ""get"",
                success: function (obj) {
                    if (obj.Tag == 1) {
                        $(""#form"").setWebControls(obj.Data);
                        $('#menuTree').ysTree(""setCheckedNodes"", obj.Data.MenuIds);
                    }
                }
            });
        }
        else {
            ys.ajax({
                url: '");
#nullable restore
#line 87 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\Role\RoleForm.cshtml"
                 Write(Url.Content("~/SystemManage/Role/GetMaxSortJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                type: ""get"",
                success: function (obj) {
                    if (obj.Tag == 1) {
                        var defaultData = {};
                        defaultData.RoleSort = obj.Data;
                        defaultData.RoleStatus = """);
#nullable restore
#line 93 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\Role\RoleForm.cshtml"
                                             Write(StatusEnum.Yes.ParseToInt());

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";
                        $(""#form"").setWebControls(defaultData);
                    }
                }
            });
        }
    }

    function saveForm(index) {
        if ($(""#form"").validate().form()) {
            var postData = $(""#form"").getWebControls({ Id: id });
            postData.MenuIds = $('#menuTree').ysTree(""getCheckedNodes"");
            ys.ajax({
                url: '");
#nullable restore
#line 106 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\Role\RoleForm.cshtml"
                 Write(Url.Content("~/SystemManage/Role/SaveFormJson"));

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

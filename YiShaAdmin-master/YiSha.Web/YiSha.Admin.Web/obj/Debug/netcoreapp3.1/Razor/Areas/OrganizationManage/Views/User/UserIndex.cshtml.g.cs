#pragma checksum "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\User\UserIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5dc093dfc9fa3fbb3396618e43f39fa0ad85a47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_OrganizationManage_Views_User_UserIndex), @"mvc.1.0.view", @"/Areas/OrganizationManage/Views/User/UserIndex.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5dc093dfc9fa3fbb3396618e43f39fa0ad85a47", @"/Areas/OrganizationManage/Views/User/UserIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e45dbd51f3d139278b58e1807e343bf3fa8e8229", @"/Areas/OrganizationManage/_ViewImports.cshtml")]
    public class Areas_OrganizationManage_Views_User_UserIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\User\UserIndex.cshtml"
  
    Layout = "~/Views/Shared/_Index.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("header", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 6 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\User\UserIndex.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/zTree/v3/css/metroStyle/metroStyle.min.css")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 7 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\User\UserIndex.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/zTree/v3/js/ztree.min.js")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 9 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\User\UserIndex.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/jquery.layout/1.4.4/jquery.layout-latest.min.css")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 10 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\User\UserIndex.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/jquery.layout/1.4.4/jquery.layout-latest.min.js")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"
<div class=""ui-layout-west"">
    <div class=""main-content"">
        <div class=""box box-main"">
            <div class=""box-header"">
                <div class=""box-title"">
                    组织机构
                </div>
                <div class=""box-tools pull-right"">
                    <a type=""button"" class=""btn btn-box-tool menuItem"" href=""#"" onclick=""showDepartmentForm()"" title=""管理部门""><i class=""fa fa-edit""></i></a>
                    <button type=""button"" class=""btn btn-box-tool"" id=""btnExpand"" title=""展开"" style=""display:none;""><i class=""fa fa-chevron-up""></i></button>
                    <button type=""button"" class=""btn btn-box-tool"" id=""btnCollapse"" title=""折叠""><i class=""fa fa-chevron-down""></i></button>
                    <button type=""button"" class=""btn btn-box-tool"" id=""btnRefresh"" title=""刷新部门""><i class=""fa fa-refresh""></i></button>
                </div>
            </div>
            <div class=""ui-layout-content"">
                <div id=""departmentTree"" class=""ztree""></div>
 ");
            WriteLiteral(@"           </div>
        </div>
    </div>
</div>

<div class=""container-div ui-layout-center"">
    <div class=""row"">
        <div id=""searchDiv"" class=""col-sm-12 search-collapse"">
            <input type=""hidden"" id=""departmentId"" col=""DepartmentId"">
            <div class=""select-list"">
                <ul>
                    <li>
                        登录名称：<input id=""userName"" col=""UserName"" type=""text"" />
                    </li>
                    <li>
                        手机号码：<input id=""mobile"" col=""Mobile"" type=""text"" />
                    </li>
                    <li>
                        用户状态：<span id=""userStatus"" col=""UserStatus""></span>
                    </li>
                    <li class=""select-time"">
                        <label>创建时间： </label>
                        <input id=""startTime"" col=""StartTime"" type=""text"" class=""time-input"" placeholder=""开始时间"" />
                        <span>-</span>
                        <input id=""endTime"" col=""EndTime"" ");
            WriteLiteral(@"type=""text"" class=""time-input"" placeholder=""结束时间"" />
                    </li>
                    <li>
                        <a id=""btnSearch"" class=""btn btn-primary btn-sm"" onclick=""searchGrid()""><i class=""fa fa-search""></i>&nbsp;搜索</a>
                    </li>
                </ul>
            </div>
        </div>

        <div id=""toolbar"" class=""btn-group-sm"">
            <a id=""btnAdd"" class=""btn btn-success"" onclick=""showSaveForm(true)""><i class=""fa fa-plus""></i> 新增</a>
            <a id=""btnEdit"" class=""btn btn-primary disabled"" onclick=""showSaveForm(false)""><i class=""fa fa-edit""></i> 修改</a>
            <a id=""btnDelete"" class=""btn btn-danger disabled"" onclick=""deleteForm()""><i class=""fa fa-remove""></i> 删除</a>
            <a id=""btnImport"" class=""btn btn-info"" onclick=""importForm()""><i class=""fa fa-upload""></i> 导入</a>
            <a id=""btnExport"" class=""btn btn-warning"" onclick=""exportForm()""><i class=""fa fa-download""></i> 导出</a>
        </div>

        <div class=""col-sm-12 sele");
            WriteLiteral(@"ct-table table-striped"">
            <table id=""gridTable"" data-mobile-responsive=""true""></table>
        </div>
    </div>
</div>

<script type=""text/javascript"">
    $(function () {
        initGrid();
        initTree();

        $('body').layout({ west__size: 185 });

        laydate.render({ elem: '#startTime', format: 'yyyy-MM-dd' });
        laydate.render({ elem: '#endTime', format: 'yyyy-MM-dd' });

       $(""#userStatus"").ysComboBox({ data: ys.getJson(");
#nullable restore
#line 86 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\User\UserIndex.cshtml"
                                                 Write(Html.Raw(typeof(StatusEnum).EnumToDictionaryString()));

#line default
#line hidden
#nullable disable
            WriteLiteral(@") });

        $('#btnExpand').click(function () {
            var tree = $.fn.zTree.getZTreeObj(""departmentTree"");
            tree.expandAll(true);
            $(this).hide();
            $('#btnCollapse').show();
        });

        $('#btnCollapse').click(function () {
            var tree = $.fn.zTree.getZTreeObj(""departmentTree"");
            tree.expandAll(false);
            $(this).hide();
            $('#btnExpand').show();
        });

        $('#btnRefresh').click(function () {
            initTree();
        });
    });

    function initTree() {
        $('#departmentTree').ysTree({
            url: '");
#nullable restore
#line 109 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\User\UserIndex.cshtml"
             Write(Url.Content("~/OrganizationManage/Department/GetDepartmentTreeListJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            async: true,
            expandLevel: 2,
            maxHeight: ""700px"",
            callback: {
                onClick: function (event, treeId, treeNode) {
                    $(""#departmentId"").val(treeNode.id);
                    searchGrid();
                }
            }
        });
    }

    function initGrid() {
        var queryUrl = '");
#nullable restore
#line 123 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\User\UserIndex.cshtml"
                   Write(Url.Content("~/OrganizationManage/User/GetPageListJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
        $('#gridTable').ysTable({
            url: queryUrl,
            columns: [
                { checkbox: true, visible: true },
                { field: 'Id', title: 'Id', visible: false },
                { field: 'UserName', title: '登录名', sortable: true },
                { field: 'RealName', title: '姓名', sortable: false },
                { field: 'DepartmentName', title: '部门', sortable: false },
                { field: 'Mobile', title: '手机', sortable: false },
                {
                    field: 'UserStatus', title: '状态', formatter: function (value, row, index) {
                        if (row.UserStatus == """);
#nullable restore
#line 135 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\User\UserIndex.cshtml"
                                          Write(StatusEnum.Yes.ParseToInt());

#line default
#line hidden
#nullable disable
            WriteLiteral("\") {\r\n                            return \'<span class=\"badge badge-primary\">\' + \"");
#nullable restore
#line 136 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\User\UserIndex.cshtml"
                                                                      Write(StatusEnum.Yes.GetDescription());

#line default
#line hidden
#nullable disable
            WriteLiteral("\" + \'</span>\';\r\n                        } else {\r\n                            return \'<span class=\"badge badge-warning\">\' + \"");
#nullable restore
#line 138 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\User\UserIndex.cshtml"
                                                                      Write(StatusEnum.No.GetDescription());

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" + '</span>';
                        }
                    }
                },
                {
                    field: 'BaseModifyTime', title: '创建时间', formatter: function (value, row, index) {
                        return ys.formatDate(value, ""yyyy-MM-dd HH:mm:ss"");
                    }
                },
                {
                    title: '操作',
                    align: 'center',
                    formatter: function (value, row, index) {
                        var actions = [];
                        actions.push('<a class=""btn btn-warning btn-xs"" href=""#"" onclick=""showResetPasswordForm(\'' + row.Id + '\')""><i class=""fa fa-key""></i>重置</a>');
                        return actions.join('');
                    }
                }
            ],
            queryParams: function (params) {
                var pagination = $('#gridTable').ysTable('getPagination', params);
                var queryString = $(""#searchDiv"").getWebControls(pagination);
             ");
            WriteLiteral(@"   return queryString;
            }
        });
    }

    function searchGrid() {
        $('#gridTable').ysTable('search');
        resetToolbarStatus();
    }

    function showSaveForm(bAdd) {
        var id = 0;
        if (!bAdd) {
            var selectedRow = $(""#gridTable"").bootstrapTable(""getSelections"");
            if (!ys.checkRowEdit(selectedRow)) {
                return;
            }
            else {
                id = selectedRow[0].Id;
            }
        }
        ys.openDialog({
            width: ""1000px"",
            height: ""540px"",
            title: id > 0 ? ""编辑用户"" : ""添加用户"",
            content: '");
#nullable restore
#line 185 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\User\UserIndex.cshtml"
                 Write(Url.Content("~/OrganizationManage/User/UserForm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '?id=' + id,
            callback: function (index, layero) {
                var iframeWin = window[layero.find('iframe')[0]['name']];
                iframeWin.saveForm(index);
            }
        });
    }

    function deleteForm() {
        var selectedRow = $(""#gridTable"").bootstrapTable(""getSelections"");
        if (ys.checkRowDelete(selectedRow)) {
            ys.confirm(""确认要删除选中的"" + selectedRow.length + ""条数据吗？"", function () {
                var ids = ys.getIds(selectedRow);
                ys.ajax({
                    url: '");
#nullable restore
#line 199 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\User\UserIndex.cshtml"
                     Write(Url.Content("~/OrganizationManage/User/DeleteFormJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '?ids=' + ids,
                    type: ""post"",
                    error: ys.ajaxError,
                    success: function (obj) {
                        if (obj.Tag == 1) {
                            ys.msgSuccess(obj.Message);
                            searchGrid();
                        }
                        else {
                            ys.msgError(obj.Message);
                        }
                    }
                });
            });
        }
    }

    function showDepartmentForm() {
        var url = '");
#nullable restore
#line 217 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\User\UserIndex.cshtml"
              Write(Url.Content("~/OrganizationManage/Department/DepartmentIndex"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n        createMenuItem(url, \"部门管理\");\r\n    }\r\n\r\n    function showResetPasswordForm(id) {\r\n        ys.openDialog({\r\n            title: \"重置密码\",\r\n            content: \'");
#nullable restore
#line 224 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\User\UserIndex.cshtml"
                 Write(Url.Content("~/OrganizationManage/User/ResetPassword"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '?id=' + id,
            height: ""220px"",
            callback: function (index, layero) {
                var iframeWin = window[layero.find('iframe')[0]['name']];
                iframeWin.saveForm(index);
            }
        });
    }

    function exportForm() {
        var url = '");
#nullable restore
#line 234 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\User\UserIndex.cshtml"
              Write(Url.Content("~/OrganizationManage/User/ExportUserJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n        var postData = $(\"#searchDiv\").getWebControls();\r\n        ys.exportExcel(url, postData);\r\n    }\r\n\r\n    function importForm() {\r\n      ys.openDialog({\r\n            title: \"导入用户数据\",\r\n            content: \'");
#nullable restore
#line 242 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\User\UserIndex.cshtml"
                 Write(Url.Content("~/OrganizationManage/User/UserImport"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n            height: \"280px\",\r\n            callback: function (index, layero) {\r\n                var iframeWin = window[layero.find(\'iframe\')[0][\'name\']];\r\n                iframeWin.saveForm(index);\r\n            }\r\n        });\r\n    }\r\n</script>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Hosting.IWebHostEnvironment HostingEnvironment { get; private set; }
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

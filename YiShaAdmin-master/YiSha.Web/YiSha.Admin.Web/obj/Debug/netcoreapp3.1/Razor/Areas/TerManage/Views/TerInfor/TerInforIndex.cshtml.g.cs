#pragma checksum "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\TerManage\Views\TerInfor\TerInforIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40b425301b365a54b7f68f9a34783b878fd857b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_TerManage_Views_TerInfor_TerInforIndex), @"mvc.1.0.view", @"/Areas/TerManage/Views/TerInfor/TerInforIndex.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40b425301b365a54b7f68f9a34783b878fd857b4", @"/Areas/TerManage/Views/TerInfor/TerInforIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fff452d81302d3bae40575f5c9db46ed73b4e31f", @"/Areas/TerManage/_ViewImports.cshtml")]
    public class Areas_TerManage_Views_TerInfor_TerInforIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\TerManage\Views\TerInfor\TerInforIndex.cshtml"
  
    Layout = "~/Views/Shared/_Index.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("header", async() => {
                WriteLiteral("\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 82, "\"", 176, 1);
#nullable restore
#line 6 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\TerManage\Views\TerInfor\TerInforIndex.cshtml"
WriteAttributeValue("", 89, Url.Content("~/lib/bootstrap.table/1.12.0/extensions/editable/bootstrap-editable.css"), 89, 87, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\">\r\n    <script");
                BeginWriteAttribute("src", " src=\'", 224, "\'", 320, 1);
#nullable restore
#line 7 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\TerManage\Views\TerInfor\TerInforIndex.cshtml"
WriteAttributeValue("", 230, Url.Content("~/lib/bootstrap.table/1.12.0/extensions/editable/bootstrap-editable.min.js"), 230, 90, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text/javascript\"></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\'", 367, "\'", 465, 1);
#nullable restore
#line 8 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\TerManage\Views\TerInfor\TerInforIndex.cshtml"
WriteAttributeValue("", 373, Url.Content("~/lib/bootstrap.table/1.12.0/extensions/editable/bootstrap-table-editable.js"), 373, 92, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text/javascript\"></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\'", 512, "\'", 612, 1);
#nullable restore
#line 9 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\TerManage\Views\TerInfor\TerInforIndex.cshtml"
WriteAttributeValue("", 518, Url.Content("~/lib/bootstrap.table/1.12.0/extensions/editable/bootstrap-datepicker.zh-CN.js"), 518, 94, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text/javascript\"></script>\r\n");
            }
            );
            WriteLiteral(@"<div class=""container-div"">
    <div class=""row"">
        <div id=""searchDiv"" class=""col-sm-12 search-collapse"">
            <div class=""select-list"">
                <ul>
                    <li>
                        设备名称：<input id=""terName"" col=""TerName"" type=""text"" />
                    </li>
                    <li>
                        设备编号：<input id=""terName"" col=""TerNumber"" type=""text"" />
                    </li>
                    <li>
                        <a id=""btnSearch"" class=""btn btn-primary btn-sm"" onclick=""searchGrid()""><i class=""fa fa-search""></i>&nbsp;搜索</a>
                    </li>
                </ul>
            </div>
        </div>
        <div class=""btn-group-sm hidden-xs"" id=""toolbar"">
            <a id=""btnAdd"" class=""btn btn-success"" onclick=""showSaveForm(true)""><i class=""fa fa-plus""></i> 新增</a>
            <a id=""btnEdit"" class=""btn btn-primary disabled"" onclick=""showSaveForm(false)""><i class=""fa fa-edit""></i> 修改</a>
            <a id=""btnDelete"" c");
            WriteLiteral(@"lass=""btn btn-danger disabled"" onclick=""deleteForm()""><i class=""fa fa-remove""></i> 删除</a>
        </div>
        <div class=""col-sm-12 select-table table-striped"">
            <table id=""gridTable"" data-mobile-responsive=""true""></table>
        </div>
    </div>
</div>

<script type=""text/javascript"">
    $(function () {
        initGrid();
    });

    function initGrid() {
        var queryUrl = '");
#nullable restore
#line 45 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\TerManage\Views\TerInfor\TerInforIndex.cshtml"
                   Write(Url.Content("~/TerManage/TerInfor/GetPageListJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
        $('#gridTable').ysTable({
            url: queryUrl,
            onEditableSave: onEditableSave,
            columns: [
                { checkbox: true, visible: true },
                { field: 'Id', title: 'Id', visible: false },
                {
                    field: 'TerName', title: '设备名称',
                    editable: {
                        type: 'text',
                        emptytext: ""【设备名称】为空"",
                        validate: function (value) {
                            if (value.length > 20) {
                                return '设备名称不能超过20个字符';
                            }
                            if (value.length == 0) {
                                return '设备名称为空';
                            }

                        }
                    }
                },
                {
                    field: 'TerNumber', title: '设备编号',
                    editable: {
                        type: 'text',
                        emptyt");
            WriteLiteral(@"ext: ""【设备编号】为空"",
                        validate: function (value) {
                            if (value.length > 20) {
                                return '设备编号不能超过20个字符';
                            }
                            if (value.length == 0) {
                                return '设备编号不能为空';
                            }
                            else {
                                if (!CheckIsNumber(value)) {
                                    return '设备编号必须为数字';
                                }
                            }
                        }
                    }
                },
                {
                    field: 'BusyName', title: '运营商',
                    formatter: function (value, row, index) {
                        return ""<span>"" + value + "" <button type=\""button\"" class=\""btn btn-primary btn-xs\"" onclick=\""setManage('"" + row[""Id""]+""')\"">设 置</button></span>"";
                    }},
                {
                    field: 'B");
            WriteLiteral(@"usyLink', title: '联系方式',
                    editable: {
                        type: 'text',
                        emptytext: ""【联系方式】为空"",
                        validate: function (value) {
                            if (value.length != 11) {
                                return '手机号必须为11位';
                            }

                        }
                    } },
                {
                    field: 'Position', title: '位置'
                },
                {
                    field: 'BaseCreateTime', title: '创建时间', align: ""left"",
                    formatter: function (value, row, index) {
                        return ys.formatDate(value, ""yyyy-MM-dd HH:mm:ss"");
                    }
                },
                { field: 'BaseCreatorTxt', title: '创建人' },
                {
                    field: 'BaseModifyTime', title: '修改时间', align: ""left"",
                    formatter: function (value, row, index) {
                        return ys.formatDat");
            WriteLiteral(@"e(value, ""yyyy-MM-dd HH:mm:ss"");
                    }
                },
                { field: 'BaseModifierTxt', title: '修改人' },
            ],
            queryParams: function (params) {
                var pagination = $('#gridTable').ysTable('getPagination', params);
                var queryString = $('#searchDiv').getWebControls(pagination);
                return queryString;
            }
        });
    }

    function searchGrid() {
        $('#gridTable').ysTable('search');
        resetToolbarStatus();
    }

    function onEditableSave(field, row, oldValue, $el) {
        //alert(""字段名："" + field + ""，当前值："" + row[field] + ""，旧值："" + oldValue);
        var url = '';
        var data = { id: row[""Id""], value: row[field] };
        if (field == ""TerName"") {
            url = '");
#nullable restore
#line 141 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\TerManage\Views\TerInfor\TerInforIndex.cshtml"
              Write(Url.Content("~/TerManage/TerInfor/ModifyTerName"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n        }\r\n        else if (field == \"BusyLink\") {\r\n            url = \'");
#nullable restore
#line 144 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\TerManage\Views\TerInfor\TerInforIndex.cshtml"
              Write(Url.Content("~/TerManage/TerInfor/ModifyBusyLink"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n        }\r\n        else {\r\n            url = \'");
#nullable restore
#line 147 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\TerManage\Views\TerInfor\TerInforIndex.cshtml"
              Write(Url.Content("~/TerManage/TerInfor/ModifyTerNumber"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
        }
        MoidfyFieldValue(row[""Id""], row[field], url);
    }

    /**
     * 修改字段信息
     * id id
     * value_str 值
     * url 当前url
     */
    function MoidfyFieldValue(id,value_str,urls) {
        var data = { id: id, value: value_str};
        ys.ajax({
            url: urls,
            type: 'post',
            data: data,
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
    }

    /*设置运营商 */
    function setManage(id) {
         ys.openDialog({
            title:  ""设置运营商"",
            content: '");
#nullable restore
#line 180 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\TerManage\Views\TerInfor\TerInforIndex.cshtml"
                 Write(Url.Content("~/OrganizationManage/User/UserIndexSelect"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            width: ""968px"",
            height: ""600px"",
             callback: function (index, layero) {
                var iframeWin = window[layero.find('iframe')[0]['name']];
                var ids = iframeWin.chooseUserOK();
                if (IsNullEmpty(ids)) {
                    ys.alertError('请先选择用户,再操作');
                }
                else {
                    //设置 操作人
                    var urls = '");
#nullable restore
#line 191 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\TerManage\Views\TerInfor\TerInforIndex.cshtml"
                           Write(Url.Content("~/TerManage/TerInfor/ModifyManageId"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
                    layer.close(index);
                    MoidfyFieldValue(id, ids, urls);
                }
            }
        });
    }



    function showSaveForm(bAdd) {
        var id = 0;
        if (!bAdd) {
            var selectedRow = $('#gridTable').bootstrapTable('getSelections');
            if (!ys.checkRowEdit(selectedRow)) {
                return;
            }
            else {
                id = selectedRow[0].Id;
            }
        }
        ys.openDialog({
            title: id > 0 ? '编辑' : '添加',
            content: '");
#nullable restore
#line 214 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\TerManage\Views\TerInfor\TerInforIndex.cshtml"
                 Write(Url.Content("~/TerManage/TerInfor/TerInforForm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '?id=' + id,
            width: '768px',
            height: '550px',
            callback: function (index, layero) {
                var iframeWin = window[layero.find('iframe')[0]['name']];
                iframeWin.saveForm(index);
            }
        });
    }

    function deleteForm() {
        var selectedRow = $('#gridTable').bootstrapTable('getSelections');
        if (ys.checkRowDelete(selectedRow)) {
            ys.confirm('确认要删除选中的' + selectedRow.length + '条数据吗？', function () {
                var ids = ys.getIds(selectedRow);
                ys.ajax({
                    url: '");
#nullable restore
#line 230 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\TerManage\Views\TerInfor\TerInforIndex.cshtml"
                     Write(Url.Content("~/TerManage/TerInfor/DeleteFormJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '?ids=' + ids,
                    type: 'post',
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

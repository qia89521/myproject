#pragma checksum "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderMateriel\OrderMaterielIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e25c7b37c21ce9db8180e0d546fac71ea944a37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_OrderManage_Views_OrderMateriel_OrderMaterielIndex), @"mvc.1.0.view", @"/Areas/OrderManage/Views/OrderMateriel/OrderMaterielIndex.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e25c7b37c21ce9db8180e0d546fac71ea944a37", @"/Areas/OrderManage/Views/OrderMateriel/OrderMaterielIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e45dbd51f3d139278b58e1807e343bf3fa8e8229", @"/Areas/OrderManage/_ViewImports.cshtml")]
    public class Areas_OrderManage_Views_OrderMateriel_OrderMaterielIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderMateriel\OrderMaterielIndex.cshtml"
  
    Layout = "~/Views/Shared/_Index.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("header", async() => {
                WriteLiteral("\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 82, "\"", 176, 1);
#nullable restore
#line 6 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderMateriel\OrderMaterielIndex.cshtml"
WriteAttributeValue("", 89, Url.Content("~/lib/bootstrap.table/1.12.0/extensions/editable/bootstrap-editable.css"), 89, 87, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\">\r\n    <script");
                BeginWriteAttribute("src", " src=\'", 224, "\'", 320, 1);
#nullable restore
#line 7 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderMateriel\OrderMaterielIndex.cshtml"
WriteAttributeValue("", 230, Url.Content("~/lib/bootstrap.table/1.12.0/extensions/editable/bootstrap-editable.min.js"), 230, 90, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text/javascript\"></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\'", 367, "\'", 465, 1);
#nullable restore
#line 8 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderMateriel\OrderMaterielIndex.cshtml"
WriteAttributeValue("", 373, Url.Content("~/lib/bootstrap.table/1.12.0/extensions/editable/bootstrap-table-editable.js"), 373, 92, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text/javascript\"></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\'", 512, "\'", 612, 1);
#nullable restore
#line 9 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderMateriel\OrderMaterielIndex.cshtml"
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
                        物料名称：<input id=""materielName"" col=""MaterielName"" type=""text"" />
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
            <a id=""btnDetail"" class=""btn btn-success disabled"" onclick=""viewDetial()""><i class=""fa fa-remove""></i>查看明细</a>
        </div>
        <div cl");
            WriteLiteral(@"ass=""col-sm-12 select-table table-striped"">
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
#line 42 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderMateriel\OrderMaterielIndex.cshtml"
                   Write(Url.Content("~/OrderManage/OrderMateriel/GetPageListJson"));

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
                { field: 'MaterielName', title: '物料名称' },
                {
                    field: 'MaterielTotal', title: '当前库存',
                    editable: {
                        type: 'text',
                        emptytext: ""库存不能为空"",
                        validate: function (value) {
                            if (value.length > 6) {
                                return '库存超过6个字符';
                            }
                            if (value.length == 0) {
                                return '库存不能为空';
                            }
                            else {
                                if (!CheckIsNumber(value)) {
                                    return '必须为数字';
                                }
      ");
            WriteLiteral(@"                      }
                        }
                    }
                },
                {
                    field: 'BaseModifyTime', title: '修改时间', align: ""left"",
                    formatter: function (value, row, index) {
                        return ys.formatDate(value, ""yyyy-MM-dd HH:mm:ss"");
                    }
                },
                {
                    field: 'BaseCreateTime', title: '创建时间', align: ""left"",
                    formatter: function (value, row, index) {
                        return ys.formatDate(value, ""yyyy-MM-dd HH:mm:ss"");
                    }
                },
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
 ");
            WriteLiteral(@"       resetToolbarStatus();
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
#line 109 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderMateriel\OrderMaterielIndex.cshtml"
                 Write(Url.Content("~/OrderManage/OrderMateriel/OrderMaterielForm"));

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

    function onEditableSave(field, row, oldValue, $el) {
        //alert(""字段名："" + field + ""，当前值："" + row[field] + ""，旧值："" + oldValue);
        var url = '';
        var data = { id: row[""Id""], value: row[field] };
            ModifyMaterielTotal(row[""Id""], row[field], ""进货补充数量"");
    }

      function viewDetial() {
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
#line 139 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderMateriel\OrderMaterielIndex.cshtml"
                 Write(Url.Content("~/OrderManage/OrderUserForm/OrderMaterielDetailIndex"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '?materielId=' + id,
            width: '1068px',
            height: '550px',
            callback: function (index, layero) {
                var iframeWin = window[layero.find('iframe')[0]['name']];
                iframeWin.saveForm(index);
            }
        });
    }

    /*追加库存 */
    function ModifyMaterielTotal(id, num, remark) {
        //ModifyMaterielTotal
        var data = { id: id, num: num, remark: remark };
        var urls=
        ys.ajax({
            //ModifyMaterielTotal(string id, string num, string remark)
            url: '");
#nullable restore
#line 156 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderMateriel\OrderMaterielIndex.cshtml"
             Write(Url.Content("~/OrderManage/OrderMateriel/ModifyMaterielTotal"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
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

    function deleteForm() {
        var selectedRow = $('#gridTable').bootstrapTable('getSelections');
        if (ys.checkRowDelete(selectedRow)) {
            ys.confirm('确认要删除选中的' + selectedRow.length + '条数据吗？', function () {
                var ids = ys.getIds(selectedRow);
                ys.ajax({
                    url: '");
#nullable restore
#line 177 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderMateriel\OrderMaterielIndex.cshtml"
                     Write(Url.Content("~/OrderManage/OrderMateriel/DeleteFormJson"));

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

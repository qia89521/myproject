#pragma checksum "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderPrintIssue\OrderPrintIssueIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "994a9b6a92c48a91a92d859455af693067a199c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_OrderManage_Views_OrderPrintIssue_OrderPrintIssueIndex), @"mvc.1.0.view", @"/Areas/OrderManage/Views/OrderPrintIssue/OrderPrintIssueIndex.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"994a9b6a92c48a91a92d859455af693067a199c8", @"/Areas/OrderManage/Views/OrderPrintIssue/OrderPrintIssueIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e45dbd51f3d139278b58e1807e343bf3fa8e8229", @"/Areas/OrderManage/_ViewImports.cshtml")]
    public class Areas_OrderManage_Views_OrderPrintIssue_OrderPrintIssueIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderPrintIssue\OrderPrintIssueIndex.cshtml"
  
    Layout = "~/Views/Shared/_Index.cshtml";
 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-div"">
    <div class=""row"">
        <div id=""searchDiv"" class=""col-sm-12 search-collapse"">
            <div class=""select-list"">
                <ul>
                    <li>
                        客户：<input id=""custName"" col=""CustName"" type=""text"" />
                    </li>
                    <li>
                        联系人：<input id=""linkName"" col=""LinkName"" type=""text"" />
                    </li>
                    <li>
                        联系电话：<input id=""linkPhone"" col=""LinkPhone"" type=""text"" />
                    </li>
                    <li class=""select-time"">
                        <label>创建时间： </label>
                        <input id=""startTime"" col=""StartTime"" type=""text"" class=""time-input"" placeholder=""开始时间"" />
                        <span>-</span>
                        <input id=""endTime"" col=""EndTime"" type=""text"" class=""time-input"" placeholder=""结束时间"" />
                    </li>
                    <li>
                        <a id=""b");
            WriteLiteral(@"tnSearch"" class=""btn btn-primary btn-sm"" onclick=""searchGrid()""><i class=""fa fa-search""></i>&nbsp;搜索</a>
                    </li>
                </ul>
            </div>
        </div>
        <div class=""btn-group-sm hidden-xs"" id=""toolbar"" style=""display:none"">
            <a id=""btnAdd"" class=""btn btn-success"" onclick=""showSaveForm(true)""><i class=""fa fa-plus""></i> 新增</a>
            <a id=""btnEdit"" class=""btn btn-primary disabled"" onclick=""showSaveForm(false)""><i class=""fa fa-edit""></i> 修改</a>
            <a id=""btnDelete"" class=""btn btn-danger disabled"" onclick=""deleteForm()""><i class=""fa fa-remove""></i> 删除</a>
           
        </div>
        <div class=""col-sm-12 select-table table-striped"">
            <table id=""gridTable"" data-mobile-responsive=""true""></table>
        </div>
    </div>
</div>

<script type=""text/javascript"">
    $(function () {
        laydate.render({ elem: '#startTime', format: 'yyyy-MM-dd' });
        laydate.render({ elem: '#endTime', format: 'yyyy-MM-dd'");
            WriteLiteral(" });\r\n\r\n        initGrid();\r\n    });\r\n\r\n    function initGrid() {\r\n        var queryUrl = \'");
#nullable restore
#line 51 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderPrintIssue\OrderPrintIssueIndex.cshtml"
                   Write(Url.Content("~/OrderManage/OrderPrintIssue/GetPageListJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
        $('#gridTable').ysTable({
            url: queryUrl,
            columns: [
                { checkbox: true, visible: true },
                { field: 'Id', title: 'Id', visible: false },
                { field: 'PrintOrderNumber', title: '打印单号' },
                { field: 'CustName', title: '客户名称' },
                { field: 'LinkName', title: '联系人' },
                { field: 'LinkPhone', title: '联系电话' },
                { field: 'PrintDay', title: '打印日期' },
                { field: 'OrderTerIssueIds', title: '出货订单id' },
                { field: 'BaseCreatorTxt', title: '创建人' },
                {
                    field: 'BaseCreateTime', title: '创建时间', align: ""left"",
                    formatter: function (value, row, index) {
                        return ys.formatDate(value, ""yyyy-MM-dd HH:mm:ss"");
                    }
                },
                {
                    field: '', title: '操作', align: ""left"",
                    formatter: function (value, row, ");
            WriteLiteral(@"index) {
                        var html = ""<button type=\""button\"" onclick=\""printForm('"" + row.PrintOrderNumber +""')\"" class=\""btn btn-w-m btn-info\"">重新打印</button>"";
                        return html;
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
        resetToolbarStatus();
    }

    function printForm(ids) {
        ys.openDialog({
        title: '打印出货单',
        content: '");
#nullable restore
#line 94 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderPrintIssue\OrderPrintIssueIndex.cshtml"
             Write(Url.Content("~/OrderManage/OrderTerIssue/OrderTerIssuePrint"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '?ids=' + ids +""&isRePrint=1"",
        width: '900px',
        btn_es: ['打印', '关闭'],
        height: '480px',
        callback: function (index, layero) {
            var iframeWin = window[layero.find('iframe')[0]['name']];
                iframeWin.saveForm(index);
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
#line 118 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderPrintIssue\OrderPrintIssueIndex.cshtml"
                 Write(Url.Content("~/OrderManage/OrderPrintIssue/OrderPrintIssueForm"));

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
#line 134 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderPrintIssue\OrderPrintIssueIndex.cshtml"
                     Write(Url.Content("~/OrderManage/OrderPrintIssue/DeleteFormJson"));

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

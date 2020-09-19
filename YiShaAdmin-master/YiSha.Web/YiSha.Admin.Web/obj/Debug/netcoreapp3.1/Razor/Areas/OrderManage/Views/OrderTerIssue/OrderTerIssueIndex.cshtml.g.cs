#pragma checksum "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssueIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bac4039f7a7a532ca756a05eeb76ffc51dcc32d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_OrderManage_Views_OrderTerIssue_OrderTerIssueIndex), @"mvc.1.0.view", @"/Areas/OrderManage/Views/OrderTerIssue/OrderTerIssueIndex.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bac4039f7a7a532ca756a05eeb76ffc51dcc32d7", @"/Areas/OrderManage/Views/OrderTerIssue/OrderTerIssueIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e45dbd51f3d139278b58e1807e343bf3fa8e8229", @"/Areas/OrderManage/_ViewImports.cshtml")]
    public class Areas_OrderManage_Views_OrderTerIssue_OrderTerIssueIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssueIndex.cshtml"
  
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
                        销售人：<input id=""saleTxt"" col=""SaleTxt"" type=""text"" />
                    </li>
                    <li class=""select-time"">
                        <label>创建时间： </label>
                        <input id=""startTime"" col=""StartTime"" type=""text"" class=""time-input"" placeholder=""开始时间"" />
                        <span>-</span>
                        <input id=""endTime"" col=""EndTime"" type=""text"" class=""time-input"" placeholder=""结束时间"" />
                    </li>
                    <li>
                        <a id=""btnSearch"" class=""btn btn-primary btn-sm"" onclick=""searchGrid()""><i class=""fa fa-search""></i>&nbsp;搜索</a>
                    </li>
                </ul>
            </div>
        </div>
        <div class=""btn-group-sm hidden-xs"" id=""toolbar"">
            <a id=""");
            WriteLiteral(@"btnAdd"" class=""btn btn-success"" onclick=""showSaveForm(true)""><i class=""fa fa-plus""></i> 新增</a>
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
        laydate.render({ elem: '#endTime', format: 'yyyy-MM-dd' });

        initGrid();
    });

    function initGrid() {
        var queryUrl = '");
#nullable restore
#line 44 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssueIndex.cshtml"
                   Write(Url.Content("~/OrderManage/OrderTerIssue/GetPageListJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
        $('#gridTable').ysTable({
            url: queryUrl,
            columns: [
                { checkbox: true, visible: true },
                { field: 'Id', title: 'Id', visible: false },
                { field: 'SaleTxt', title: '销售人' },
                { field: 'SaleNum', title: '数量' },
                { field: 'SalePrice', title: '售价' },
                { field: 'SrcPrice', title: '拿货价' },
                { field: 'TotalPrice', title: '销售总额' },
                { field: 'FactMoney', title: '实收额' },
                { field: 'DiffPrice', title: '利润' },
                { field: 'ShenHeManTxt', title: '审核人' },
                {
                    field: 'ShenHeStatus', title: '审核状态',
                    formatter: function (value, row, index) {
                        //审核状态 0未审核,1:审核通过,2拒绝
                        var html = ""拒绝"";
                        if (value == 0) {
                            html = ""未审核"";
                        }
                        else if (valu");
            WriteLiteral(@"e == 1) {
                            html = ""审核通过"";
                        }
                        return html;
                    }
                },
                { field: 'SentManTxt', title: '售后' },
                {
                    field: 'Step', title: '流程步骤',
                    formatter: function (value, row, index) {
                        //步骤  0:草稿,1:财务审核,2:售后发货,3:流程结束
                        var html = ""流程结束"";
                        if (value == 0) {
                            html = ""草稿"";
                        }
                        else if (value == 1) {
                            html = ""财务审核"";
                        }
                        else if (value == 2) {
                            html = ""售后发货"";
                        }
                        return html;
                    }
                },
                {
                    field: 'TakeType', title: '提货方式'
                    ,
                    formatter: function (valu");
            WriteLiteral(@"e, row, index) {
                        //提货方式 0:快递1:自提
                        var html = ""自提"";
                        if (value == 0) {
                            html = ""快递"";
                        }
                        return html;
                    }
                },
                { field: 'ExpressCompany', title: '快递公司' },
                { field: 'ExpressNumber', title: '快递单号' },
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
   ");
            WriteLiteral(@"     $('#gridTable').ysTable('search');
        resetToolbarStatus();
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
#line 137 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssueIndex.cshtml"
                 Write(Url.Content("~/OrderManage/OrderTerIssue/OrderTerIssueForm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '?id=' + id,
            width: '968px',
            //btn_es: ['存为草稿','提交', '关闭'],
            height: '580px',
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
#line 154 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssueIndex.cshtml"
                     Write(Url.Content("~/OrderManage/OrderTerIssue/DeleteFormJson"));

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

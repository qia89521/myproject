#pragma checksum "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\Views\Table\Editable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff84c5e1ecc16b5ba673f027388497afda14e814"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_DemoManage_Views_Table_Editable), @"mvc.1.0.view", @"/Areas/DemoManage/Views/Table/Editable.cshtml")]
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
#line 3 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\_ViewImports.cshtml"
using YiSha.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\_ViewImports.cshtml"
using YiSha.Util.Extension;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\_ViewImports.cshtml"
using YiSha.Util.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\_ViewImports.cshtml"
using YiSha.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\_ViewImports.cshtml"
using YiSha.Web.Code;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff84c5e1ecc16b5ba673f027388497afda14e814", @"/Areas/DemoManage/Views/Table/Editable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5b622e924f35698514110c8d85c04ddd5a27d39", @"/Areas/DemoManage/_ViewImports.cshtml")]
    public class Areas_DemoManage_Views_Table_Editable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\Views\Table\Editable.cshtml"
  
    Layout = "~/Views/Shared/_Index.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("header", async() => {
                WriteLiteral("\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 80, "\"", 174, 1);
#nullable restore
#line 5 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\Views\Table\Editable.cshtml"
WriteAttributeValue("", 87, Url.Content("~/lib/bootstrap.table/1.12.0/extensions/editable/bootstrap-editable.css"), 87, 87, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\">\r\n    <script");
                BeginWriteAttribute("src", " src=\'", 222, "\'", 318, 1);
#nullable restore
#line 6 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\Views\Table\Editable.cshtml"
WriteAttributeValue("", 228, Url.Content("~/lib/bootstrap.table/1.12.0/extensions/editable/bootstrap-editable.min.js"), 228, 90, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text/javascript\"></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\'", 365, "\'", 463, 1);
#nullable restore
#line 7 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\Views\Table\Editable.cshtml"
WriteAttributeValue("", 371, Url.Content("~/lib/bootstrap.table/1.12.0/extensions/editable/bootstrap-table-editable.js"), 371, 92, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text/javascript\"></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\'", 510, "\'", 610, 1);
#nullable restore
#line 8 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\Views\Table\Editable.cshtml"
WriteAttributeValue("", 516, Url.Content("~/lib/bootstrap.table/1.12.0/extensions/editable/bootstrap-datepicker.zh-CN.js"), 516, 94, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text/javascript\"></script>\r\n");
            }
            );
            WriteLiteral(@"<div class=""container-div"">
    <div class=""row"">
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
#line 24 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\Views\Table\Editable.cshtml"
                   Write(Url.Content("~/DemoManage/Table/GetPageListJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
        $('#gridTable').ysTable({
            url: queryUrl,
            onEditableSave: onEditableSave,
            columns: [
                { checkbox: true, visible: true },
                { field: 'Id', title: '用户编号' },
                {
                    field: 'RealName', title: '用户姓名',
                    editable: {
                        type: 'text',
                        emptytext: ""【用户姓名】为空"",
                        validate: function (value) {
                            if (value.length > 20) {
                                return '用户姓名不能超过20个字符';
                            }
                            if (value.length == 0) {
                                return '用户姓名不能为空';
                            }
                        }
                    }
                },
                { field: 'Mobile', title: '手机' },
                { field: 'Email', title: '邮箱' },
                {
                    field: 'Birthday', title: '生日',
                 ");
            WriteLiteral(@"   editable: {
                        type: 'date',
                        emptytext: ""【生日】为空"",
                        clear: false,
                        datepicker: { language: 'zh-CN' },//中文支持
                        validate: function (value) {
                            if (value == '') { return '生日不能为空!' }
                        }
                    }
                },
                {
                    field: 'UserStatus', title: '状态',
                    align: 'center',
                    editable: {
                        type: 'select',
                        source: [{
                            value: 0,
                            text: ""停用""
                        }, {
                            value: 1,
                            text: ""正常""
                        }]
                    }
                },
                {
                    title: '操作',
                    align: 'center',
                    formatter: function (value, row, in");
            WriteLiteral(@"dex) {
                        var actions = [];
                        actions.push('<a class=""btn btn-success btn-xs"" href=""#""><i class=""fa fa-edit""></i>编辑</a> ');
                        actions.push('<a class=""btn btn-danger btn-xs"" href=""#""><i class=""fa fa-remove""></i>删除</a>');
                        return actions.join('');
                    }
                }
            ],
            queryParams: function (params) {
                var pagination = $('#gridTable').ysTable('getPagination', params);
                var queryString = $('#searchDiv').getWebControls(pagination);
                return queryString;
            }
        });
    }

    function onEditableSave(field, row, oldValue, $el) {
        alert(""字段名："" + field + ""，当前值："" + row[field] + ""，旧值："" + oldValue);
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

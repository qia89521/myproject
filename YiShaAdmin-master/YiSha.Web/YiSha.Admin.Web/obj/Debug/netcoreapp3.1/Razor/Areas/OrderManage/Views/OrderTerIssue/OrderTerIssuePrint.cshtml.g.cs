#pragma checksum "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssuePrint.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1efd983188b4395bcfdbe4c041ea041341153e3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_OrderManage_Views_OrderTerIssue_OrderTerIssuePrint), @"mvc.1.0.view", @"/Areas/OrderManage/Views/OrderTerIssue/OrderTerIssuePrint.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1efd983188b4395bcfdbe4c041ea041341153e3a", @"/Areas/OrderManage/Views/OrderTerIssue/OrderTerIssuePrint.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e45dbd51f3d139278b58e1807e343bf3fa8e8229", @"/Areas/OrderManage/_ViewImports.cshtml")]
    public class Areas_OrderManage_Views_OrderTerIssue_OrderTerIssuePrint : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<YiSha.Model.Result.OrderManage.Response_OrderPrintIssue>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssuePrint.cshtml"
  
    Layout = "~/Views/Shared/_FormWhite.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""wrapper animated fadeInRight"">
    <div id=""tb_print"">
        <style>
            .tb_print {
                text-align: center;
                border-collapse: collapse;
                border: 1px solid #000;
                width: 710px;
                font-size: 12px;
            }

                .tb_print td {
                    border: 1px solid #000;
                    line-height: 20px;
                }

                .tb_print .remark {
                    text-align: left;
                    vertical-align: top;
                    text-indent: 10px;
                }
            .tb_left {
                text-align:left;
                text-indent:10px;
            }
        </style>
        <table class=""tb_print"">
            <tr>
                <td colspan=""8"">
                    <h3>
                        ");
#nullable restore
#line 36 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssuePrint.cshtml"
                    Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h3>\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>日期：</td>\r\n                <td colspan=\"3\" class=\"tb_left\">\r\n                    ");
#nullable restore
#line 43 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssuePrint.cshtml"
                Write(Model.PrintDay);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>单号：</td>\r\n                <td colspan=\"3\" class=\"tb_left\">\r\n                    ");
#nullable restore
#line 47 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssuePrint.cshtml"
                Write(Model.PrintOrderNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>客户名称：</td>\r\n                <td colspan=\"3\" class=\"tb_left\">\r\n                    ");
#nullable restore
#line 53 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssuePrint.cshtml"
                Write(Model.CustName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>电话：</td>\r\n                <td colspan=\"3\" class=\"tb_left\">\r\n                    ");
#nullable restore
#line 57 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssuePrint.cshtml"
                Write(Model.LinkPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </td>
            </tr>
            <tr>
                <td>区域：</td>
                <td colspan=""3"" class=""tb_left"">
                </td>
                <td>传真：</td>
                <td colspan=""3"" class=""tb_left"">
                </td>
            </tr>
            <tr>
                <td>联系人：</td>
                <td colspan=""3"" class=""tb_left"">
                    ");
#nullable restore
#line 71 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssuePrint.cshtml"
                Write(Model.LinkName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </td>
                <td>邮箱：</td>
                <td colspan=""3"" class=""tb_left"">
                </td>
            </tr>
            <tr>
                <td>收货地址：</td>
                <td colspan=""7"" class=""tb_left"">
                    ");
#nullable restore
#line 80 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssuePrint.cshtml"
                Write(Model.ReciveAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </td>
            </tr>
            <tr>
                <td>序号</td>
                <td>产品名称</td>
                <td>产品型号</td>
                <td>规格描述</td>
                <td>单价(RMB)</td>
                <td>数量</td>
                <td>单位</td>
                <td>合计(RMB)</td>
            </tr>
            <!---循环打印产品-->
");
#nullable restore
#line 94 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssuePrint.cshtml"
               
                int i = 0;
                string saleMan = "";
                string sentMan = "";
                string expressCompany = "";
                string expressNumber = "";
             

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 102 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssuePrint.cshtml"
             foreach (var obj in Model.ListProduct)
            {
                i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 106 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssuePrint.cshtml"
                    Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 107 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssuePrint.cshtml"
                    Write(obj.MaterielTxt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 108 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssuePrint.cshtml"
                    Write(obj.MaterielType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 109 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssuePrint.cshtml"
                    Write(obj.MaterielDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 110 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssuePrint.cshtml"
                   Write(string.Format("{0:0.00}", obj.SalePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 111 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssuePrint.cshtml"
                    Write(obj.SaleNum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 112 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssuePrint.cshtml"
                    Write(obj.MaterielUnite);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 113 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssuePrint.cshtml"
                   Write(string.Format("{0:0.00}", obj.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 115 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssuePrint.cshtml"

                saleMan=obj.SaleTxt;
                sentMan=obj.SentManTxt;
                expressCompany = obj.ExpressCompany;
                expressNumber = obj.ExpressNumber;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <tr>\r\n                <td rowspan=\"2\" colspan=\"6\" class=\"remark\">\r\n                    <span>备注:</span>\r\n                    <span>");
#nullable restore
#line 125 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssuePrint.cshtml"
                      Write(Model.Remark);

#line default
#line hidden
#nullable disable
            WriteLiteral("   （快递公司：");
#nullable restore
#line 125 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssuePrint.cshtml"
                                              Write(expressCompany);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ，快递单号：");
#nullable restore
#line 125 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssuePrint.cshtml"
                                                                      Write(expressNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("）</span>\r\n                </td>\r\n                <td>合计(RMB)</td>\r\n                <td>\r\n                    ");
#nullable restore
#line 129 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssuePrint.cshtml"
               Write(string.Format("{0:0.00}", Model.TotalMoney));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>已付(RMB)</td>\r\n                <td>\r\n                    ");
#nullable restore
#line 135 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssuePrint.cshtml"
               Write(string.Format("{0:0.00}", Model.FactMoney));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td rowspan=\"2\" colspan=\"6\" class=\"remark\">\r\n                    <div>开户银行:  ");
#nullable restore
#line 140 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssuePrint.cshtml"
                            Write(Model.SysIssueConfig.SysBankName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div>开户名称： ");
#nullable restore
#line 141 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssuePrint.cshtml"
                           Write(Model.SysIssueConfig.SysBankMan);

#line default
#line hidden
#nullable disable
            WriteLiteral(" 开户账号: ");
#nullable restore
#line 141 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssuePrint.cshtml"
                                                                    Write(Model.SysIssueConfig.SysBankCardNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </td>\r\n                <td>余款(RMB)</td>\r\n                <td>\r\n                    ");
#nullable restore
#line 145 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssuePrint.cshtml"
               Write(string.Format("{0:0.00}", Model.YuMoney));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </td>
            </tr>
            <tr>
                <td>打款方式</td>
                <td>对私账户</td>
            </tr>

            <tr>
                <td colspan=""2"">销售员</td>
                <td>审批</td>
                <td>财务审批</td>
                <td>生产人</td>
                <td colspan=""2"">发货人</td>
                <td>发货日期</td>
            </tr>
            <tr>
                <td colspan=""2"">");
#nullable restore
#line 162 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssuePrint.cshtml"
                            Write(saleMan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>&nbsp;</td>\r\n                <td>&nbsp;</td>\r\n                <td>&nbsp;</td>\r\n                <td colspan=\"2\">");
#nullable restore
#line 166 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssuePrint.cshtml"
                            Write(sentMan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 167 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssuePrint.cshtml"
                 Write(Model.PrintDay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n<script type=\"text/javascript\">\r\n\r\n    function saveForm(index) {\r\n        $(\"#tb_print\").printArea();\r\n        window.setTimeout(function () {\r\n\r\n            var printOrderNumber = \'");
#nullable restore
#line 180 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssuePrint.cshtml"
                               Write(Model.PrintOrderNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
            var ids = ys.request(""ids"");
            updatePrintOrderNumbe(index, ids, printOrderNumber);

        }, 1000 * 6);

    }
    function updatePrintOrderNumbe(index,ids, printOrderNumber) {
         //string ids, string printOrderNumber
        ys.ajax({
            url: '");
#nullable restore
#line 190 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssuePrint.cshtml"
             Write(Url.Content("~/OrderManage/OrderTerIssue/UpdatePrintOrderNumbe"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n            type: \'post\',\r\n            data: {\r\n                ids: ids,\r\n                printOrderNumber: printOrderNumber,\r\n                custName: \'");
#nullable restore
#line 195 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssuePrint.cshtml"
                      Write(Model.CustName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                linkName: \'");
#nullable restore
#line 196 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssuePrint.cshtml"
                      Write(Model.LinkName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                printDay: \'");
#nullable restore
#line 197 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssuePrint.cshtml"
                      Write(Model.PrintDay);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                linkPhone: \'");
#nullable restore
#line 198 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssuePrint.cshtml"
                       Write(Model.LinkPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            },
            success: function (obj) {
                if (obj.Tag == 1) {
                    ys.msgSuccess(obj.Message);
                    parent.layer.close(index);
                }
                else {
                    ys.msgError(obj.Message);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<YiSha.Model.Result.OrderManage.Response_OrderPrintIssue> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\TerManage\Views\TerTransferRecord\TerTransferRecordIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99a4a64cad8b43108de5b10925b970c67b311bc7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_TerManage_Views_TerTransferRecord_TerTransferRecordIndex), @"mvc.1.0.view", @"/Areas/TerManage/Views/TerTransferRecord/TerTransferRecordIndex.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99a4a64cad8b43108de5b10925b970c67b311bc7", @"/Areas/TerManage/Views/TerTransferRecord/TerTransferRecordIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fff452d81302d3bae40575f5c9db46ed73b4e31f", @"/Areas/TerManage/_ViewImports.cshtml")]
    public class Areas_TerManage_Views_TerTransferRecord_TerTransferRecordIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\TerManage\Views\TerTransferRecord\TerTransferRecordIndex.cshtml"
  
    Layout = "~/Views/Shared/_FormGray.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row animated fadeInRight"">
    <div class=""ibox float-e-margins"">
        <div id=""ibox-content"">
            <div id=""vertical-timeline"" class=""vertical-container light-timeline"">

              
            </div>
        </div>
    </div>
    <script>
        var id = ys.request(""id"");
        $(function () {
            LoadData();

        });

        function LoadData() {
            ys.ajax({
                url: '");
#nullable restore
#line 23 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\TerManage\Views\TerTransferRecord\TerTransferRecordIndex.cshtml"
                 Write(Url.Content("~/TerManage/TerTransferRecord/GetListData"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                type: 'get',
                data: { terid:id},
                success: function (obj) {
                    if (obj.Tag == 1) {
                        var data = obj.Data;
                        CreateHtml(data);
                    }
                    else {
                        ys.msgError(obj.Message);
                    }
                }
            });
        }
        function CreateHtml(data_array) {
            var html = [];
            for (var i = 0; i < data_array.length; i++) {
                var obj = data_array[i];
                html.push("" "");
                html.push("" <div class=\""vertical - timeline - block\""> "");
                html.push(""     <div class=\""vertical - timeline - icon navy - bg\""> "");
                html.push(""         <i class=\""fa fa - briefcase\""></i> "");
                html.push(""     </div> "");

                html.push(""     <div class=\""vertical - timeline - content\""> "");
                html.push(""    ");
            WriteLiteral(@"     <h2>"" + SendTxt + ""转让信息</h2> "");
                html.push(""        <p> "");
                html.push(""         "" + SendTxt + ""把设备【"" + TerNumber+""】转让给 "" + ReceiverTxt+"" "");
                html.push(""        </p> "");
                html.push(""       <span class=\""vertical - date\""> "");
                html.push(""           日期 <br> "");
                html.push(""               <small>"" + ys.formatDate(obj.BaseCreateTime, ""yyyy-MM-dd HH:mm:ss"")+""</small> "");
                html.push(""      </span> "");
                html.push(""  </div> "");
                html.push(""   </div> "");
            }
            $(""#vertical-timeline"").html(html.join("" ""));
        }
    </script>
</div>");
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

#pragma checksum "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\Area\AreaIndexSelect.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "361419c90719dd1e012679f1006a9e1109e0a608"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SystemManage_Views_Area_AreaIndexSelect), @"mvc.1.0.view", @"/Areas/SystemManage/Views/Area/AreaIndexSelect.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"361419c90719dd1e012679f1006a9e1109e0a608", @"/Areas/SystemManage/Views/Area/AreaIndexSelect.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fff452d81302d3bae40575f5c9db46ed73b4e31f", @"/Areas/SystemManage/_ViewImports.cshtml")]
    public class Areas_SystemManage_Views_Area_AreaIndexSelect : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\Area\AreaIndexSelect.cshtml"
  
    Layout = "~/Views/Shared/_FormWhite.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"wrapper animated fadeInRight\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "361419c90719dd1e012679f1006a9e1109e0a6085496", async() => {
                WriteLiteral(@"
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">省份</label>
            <div class=""col-sm-4"">
                <div id=""provoice"" col=""Provoice""></div>
            </div>
            <label class=""col-sm-2 control-label "">城市</label>
            <div class=""col-sm-4"">
                <div  id=""city"" col=""City""></div>
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">县区</label>
            <div class=""col-sm-4"">
                <div id=""xian"" col=""Xian""></div>
            </div>
            <label class=""col-sm-2 control-label "">操作</label>
            <div class=""col-sm-4"">
                <button type=""button"" class=""btn btn-w-m btn-info"" onclick=""SetValues()"">确定追加</button>
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">设置代理区域</label>
            <div class=""col-sm-10"">
                <textarea id=""delegetZoneTxt""");
                WriteLiteral(" col=\"DelegetZoneTxt\" class=\"form-control\" style=\"height:90px\"></textarea>\r\n                <input type=\"hidden\" id=\"delegetZoneId\"  col=\"DelegetZoneId\"/>\r\n            </div>\r\n        </div>\r\n\r\n    ");
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
            WriteLiteral(@"
</div>
<script type=""text/javascript"">
    var curUserId = ""0"";
    $(function () {
        if (QuerryString(""curUserId"") != null && QuerryString(""curUserId"") != """") {
            curUserId = QuerryString(""curUserId"");
        }
        //AreaCode,ParentAreaCode,AreaName,AreaLevel
        $(""#provoice"").ysComboBox({
            url: '");
#nullable restore
#line 47 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\Area\AreaIndexSelect.cshtml"
             Write(Url.Content("~/SystemManage/Area/GetAreaList"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + ""?parentCode=0&curUserId="" + curUserId,
            key: ""areacode"",
            class: ""form-control"",
            value: ""areaname"",
            onChange: function (val) {
                ChangeCity(this.value);
            }
        });

    });

    function ChangeCity(code) {
        $(""#city"").ysComboBox({
            url: '");
#nullable restore
#line 60 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\Area\AreaIndexSelect.cshtml"
             Write(Url.Content("~/SystemManage/Area/GetAreaList"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + ""?parentCode="" + code + ""&curUserId="" + curUserId,
            key: ""areacode"",
            class: ""form-control"",
            value: ""areaname"",
            onChange: function (val) {
                ChangeXian(this.value);
            }
        });
    }
    function ChangeXian(code) {
        $(""#xian"").ysComboBox({
            url: '");
#nullable restore
#line 71 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\Area\AreaIndexSelect.cshtml"
             Write(Url.Content("~/SystemManage/Area/GetAreaList"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + ""?parentCode="" + code + ""&curUserId="" + curUserId,
            key: ""areacode"",
            class: ""form-control"",
            value: ""areaname"",

        });
    }

    function SetValues() {
        //delegetZone  getValue getText
        var zone_txt = [];
        var zone_id =[];
        //provoice_select
        if ($(""#provoice"").ysComboBox('getValue') != """") {
            zone_id.push($(""#provoice"").ysComboBox('getValue'));

            zone_txt.push($(""#provoice_select option:selected"").text());
        }
        if ($(""#city"").ysComboBox('getValue') != """") {
            zone_id.push($(""#city"").ysComboBox('getValue'));
            zone_txt.push($(""#city_select option:selected"").text());
        }
        if ($(""#xian"").ysComboBox('getValue') != """") {
            zone_id.push($(""#xian"").ysComboBox('getValue'));
            zone_txt.push($(""#xian_select option:selected"").text());
        }
        var delegetZoneTxt = $(""#delegetZoneTxt"").val();
        var delegetZoneId =");
            WriteLiteral(@" $(""#delegetZoneId"").val();

        if (delegetZoneId != """") {
            //设置代理区域
            if (delegetZoneId.indexOf(zone_id.join(""-"")) < 0) {
                delegetZoneTxt = delegetZoneTxt + "","";
                delegetZoneId = delegetZoneId + "","";

                delegetZoneId += zone_id.join(""-"");
                delegetZoneTxt += zone_txt.join(""-"");
            }
        }
        else {
            delegetZoneId += zone_id.join(""-"");
            delegetZoneTxt += zone_txt.join(""-"");
        }
       
        $(""#delegetZoneTxt"").val(delegetZoneTxt);
        $(""#delegetZoneId"").val(delegetZoneId);
    }

    var select_data = {txts:"""",ids:""""};
    function getSelectZone() {
        select_data.txts = $(""#delegetZoneTxt"").val();
        select_data.ids = $(""#delegetZoneId"").val();

        return select_data;
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

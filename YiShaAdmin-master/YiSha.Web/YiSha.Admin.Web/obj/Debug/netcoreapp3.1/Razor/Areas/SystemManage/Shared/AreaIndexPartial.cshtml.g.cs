#pragma checksum "E:\资料\私人项目\2020_08\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Shared\AreaIndexPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3da42794e595af7109b0bb9c45c8c256a71c71f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SystemManage_Shared_AreaIndexPartial), @"mvc.1.0.view", @"/Areas/SystemManage/Shared/AreaIndexPartial.cshtml")]
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
#line 2 "E:\资料\私人项目\2020_08\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\资料\私人项目\2020_08\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\_ViewImports.cshtml"
using YiSha.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\资料\私人项目\2020_08\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\_ViewImports.cshtml"
using YiSha.Util.Extension;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\资料\私人项目\2020_08\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\_ViewImports.cshtml"
using YiSha.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\资料\私人项目\2020_08\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\_ViewImports.cshtml"
using YiSha.Enum.OrganizationManage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\资料\私人项目\2020_08\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\_ViewImports.cshtml"
using YiSha.Enum.SystemManage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\资料\私人项目\2020_08\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\_ViewImports.cshtml"
using YiSha.Web.Code;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3da42794e595af7109b0bb9c45c8c256a71c71f8", @"/Areas/SystemManage/Shared/AreaIndexPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55137d24460cba143bd99b9d65bcd6525d8e46e8", @"/Areas/SystemManage/_ViewImports.cshtml")]
    public class Areas_SystemManage_Shared_AreaIndexPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<li>\n    所在区域：<div id=\"areaId\" col=\"AreaId\" style=\"display:inline-block\"></div>\n</li>\n\n<script type=\"text/javascript\">\n    $(function () {\n        $(\'#areaId\').ysComboBoxTree({ url: \'");
#nullable restore
#line 8 "E:\资料\私人项目\2020_08\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Shared\AreaIndexPartial.cshtml"
                                       Write(Url.Content("~/SystemManage/Area/GetZtreeAreaListJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\' });\n    });\n</script>");
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

#pragma checksum "E:\资料\私人项目\2020_08\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\Views\Form\Upload.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a87ffc696268cdda0289da47c599661feb9e5230"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_DemoManage_Views_Form_Upload), @"mvc.1.0.view", @"/Areas/DemoManage/Views/Form/Upload.cshtml")]
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
#line 3 "E:\资料\私人项目\2020_08\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\资料\私人项目\2020_08\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\_ViewImports.cshtml"
using YiSha.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\资料\私人项目\2020_08\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\_ViewImports.cshtml"
using YiSha.Util.Extension;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\资料\私人项目\2020_08\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\_ViewImports.cshtml"
using YiSha.Util.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\资料\私人项目\2020_08\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\_ViewImports.cshtml"
using YiSha.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\资料\私人项目\2020_08\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\_ViewImports.cshtml"
using YiSha.Web.Code;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a87ffc696268cdda0289da47c599661feb9e5230", @"/Areas/DemoManage/Views/Form/Upload.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3e0c61825795b9df37303585f2d2cfa2e121bde", @"/Areas/DemoManage/_ViewImports.cshtml")]
    public class Areas_DemoManage_Views_Form_Upload : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\资料\私人项目\2020_08\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\Views\Form\Upload.cshtml"
  
    Layout = "~/Views/Shared/_FormGray.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            DefineSection("header", async() => {
                WriteLiteral("\n    ");
#nullable restore
#line 7 "E:\资料\私人项目\2020_08\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\Views\Form\Upload.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/fileinput/5.0.3/css/fileinput.min.css")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    ");
#nullable restore
#line 8 "E:\资料\私人项目\2020_08\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\Views\Form\Upload.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/fileinput/5.0.3/js/fileinput.min.js")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
            }
            );
            WriteLiteral(@"
<div class=""wrapper wrapper-content animated fadeInRight"">
    <div class=""row"">
        <div class=""col-sm-12"">
            <div class=""ibox float-e-margins"">
                <div class=""ibox-title"">
                    <h5>文件上传控件 <small>https://github.com/kartik-v/bootstrap-fileinput</small></h5>
                </div>
                <div class=""ibox-content"">
                    <div class=""form-group"">
                        <label class=""font-noraml"">简单示例</label>
                        <div class=""file-loading"">
                            <input id=""fileinput-demo-1"" type=""file"">
                        </div>
                    </div>

                    <div class=""form-group"">
                        <label class=""font-noraml"">多文件上传</label>
                        <div class=""file-loading"">
                            <input id=""fileinput-demo-2"" type=""file"" multiple>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</");
            WriteLiteral("div>\n\n<script type=\"text/javascript\">\n    $(document).ready(function () {\n        $(\"#fileinput-demo-1\").fileinput({\n            language: \'zh\',\n            \'uploadUrl\': \'");
#nullable restore
#line 42 "E:\资料\私人项目\2020_08\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\Views\Form\Upload.cshtml"
                     Write(GlobalContext.SystemConfig.ApiSite);

#line default
#line hidden
#nullable disable
            WriteLiteral("\' + \'/File/UploadFile?fileModule=");
#nullable restore
#line 42 "E:\资料\私人项目\2020_08\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\Views\Form\Upload.cshtml"
                                                                                         Write(UploadFileType.News.ParseToInt());

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\n            showPreview: false\n        });\n\n        $(\"#fileinput-demo-2\").fileinput({\n            language: \'zh\',\n            \'uploadUrl\': \'");
#nullable restore
#line 48 "E:\资料\私人项目\2020_08\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\Views\Form\Upload.cshtml"
                     Write(GlobalContext.SystemConfig.ApiSite);

#line default
#line hidden
#nullable disable
            WriteLiteral("\' + \'/File/UploadFile?fileModule=");
#nullable restore
#line 48 "E:\资料\私人项目\2020_08\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\Views\Form\Upload.cshtml"
                                                                                         Write(UploadFileType.News.ParseToInt());

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\n            overwriteInitial: false,\n            initialPreviewAsData: true,\n            initialPreview: [\'");
#nullable restore
#line 51 "E:\资料\私人项目\2020_08\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\Views\Form\Upload.cshtml"
                         Write(Url.Content("~/image/portrait.png"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\']\n        });\n    });\n</script>");
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
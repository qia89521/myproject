#pragma checksum "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssueForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9770ce4a65bdc4499b9fdde079b230a9e18fe626"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_OrderManage_Views_OrderTerIssue_OrderTerIssueForm), @"mvc.1.0.view", @"/Areas/OrderManage/Views/OrderTerIssue/OrderTerIssueForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9770ce4a65bdc4499b9fdde079b230a9e18fe626", @"/Areas/OrderManage/Views/OrderTerIssue/OrderTerIssueForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e45dbd51f3d139278b58e1807e343bf3fa8e8229", @"/Areas/OrderManage/_ViewImports.cshtml")]
    public class Areas_OrderManage_Views_OrderTerIssue_OrderTerIssueForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssueForm.cshtml"
  
    Layout = "~/Views/Shared/_FormWhite.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("header", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 6 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssueForm.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/fileinput/5.0.3/css/fileinput.min.css")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 7 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssueForm.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/fileinput/5.0.3/js/fileinput.min.js")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("<div class=\"wrapper animated fadeInRight\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9770ce4a65bdc4499b9fdde079b230a9e18fe6266407", async() => {
                WriteLiteral(@"
        <div class=""tabs-container"">
            <div class=""tabs-container"">
                <ul class=""nav nav-tabs"">
                    <li class=""active"">
                        <a data-toggle=""tab"" href=""#tab-1"">基本信息</a>
                    </li>
                    <li>
                        <a data-toggle=""tab"" href=""#tab-2"">收件人信息</a>
                    </li>
                    <li");
                BeginWriteAttribute("class", " class=\"", 897, "\"", 905, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <a data-toggle=\"tab\" href=\"#tab-3\">审核信息</a>\r\n                    </li>\r\n                    <li");
                BeginWriteAttribute("class", " class=\"", 1028, "\"", 1036, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        <a data-toggle=""tab"" href=""#tab-4"">物流状态</a>
                    </li>
                </ul>
                <div class=""tab-content "">
                    <div id=""tab-1"" class=""tab-pane active"">
                        <div class=""panel-body"">
                            <div class=""form-group"">
                                <label class=""col-sm-2 control-label "">物料<font class=""red""> *</font></label>
                                <div class=""col-sm-8"">
                                    <input id=""materielTxt"" col=""MaterielTxt"" onfocus=""this.blur()"" type=""text"" class=""form-control"" />
                                    <input type=""hidden"" id=""materielId"" col=""MaterielId"" />
                                </div>
                                <div class=""col-sm-2 roleCode_op"">
                                    <button type=""button"" class=""btn btn-primary btn-sm"" onclick=""choosePage('MaterielTxt','materielId','materielTxt')"">选 择</button><br />
               ");
                WriteLiteral(@"                 </div>
                            </div>
                            <div class=""form-group"">
                                <label class=""col-sm-2 control-label "">销售人<font class=""red""> *</font></label>
                                <div class=""col-sm-8"">
                                    <input id=""saleTxt"" col=""SaleTxt"" type=""text"" onfocus=""this.blur()"" class=""form-control"" />
                                    <input type=""hidden"" id=""saleId"" col=""SaleId"" />
                                </div>
                                <div class=""col-sm-2 roleCode_op"">
                                    <button type=""button"" class=""btn btn-primary btn-sm"" onclick=""setParent()"">选 择</button><br />
                                </div>
                            </div>
                            <div class=""form-group"">
                                <label class=""col-sm-2 control-label "">出货量<font class=""red""> *</font></label>
                                <div class=""col");
                WriteLiteral(@"-sm-8 roleCode_op"">
                                    <input id=""saleNum"" col=""SaleNum"" type=""text"" onkeyup=""this.value=CheckIsFormatNumber(this.value, 0)"" class=""form-control"" />
                                </div>
                            </div>
                            <div class=""form-group"">
                                <label class=""col-sm-2 control-label "">销售价<font class=""red""> *</font></label>
                                <div class=""col-sm-8 roleCode_op"">
                                    <input id=""salePrice"" col=""SalePrice"" onkeyup=""this.value=CheckIsFormatNumber(this.value, 2)"" type=""text"" class=""form-control"" />
                                </div>
                            </div>
                            <div class=""form-group"">
                                <label class=""col-sm-2 control-label"">拿货价<font class=""red""> *</font></label>
                                <div class=""col-sm-8 roleCode_op"">
                                    <input id=""srcPrice""");
                WriteLiteral(@" col=""SrcPrice"" onkeyup=""this.value=CheckIsFormatNumber(this.value, 2)"" type=""text"" class=""form-control"" />
                                </div>
                            </div>
                            <div class=""form-group"">
                                <label class=""col-sm-2 control-label"">实收款<font class=""red""> *</font></label>
                                <div class=""col-sm-8 roleCode_op"">
                                    <input id=""factMoney"" col=""FactMoney"" onkeyup=""this.value=CheckIsFormatNumber(this.value, 2)"" type=""text"" class=""form-control"" />
                                </div>
                            </div>
                            
                            <div class=""form-group"">
                                <label class=""col-sm-2 control-label "">售卖区域<font class=""red""> *</font></label>
                                <div class=""col-sm-8"">
                                    <textarea id=""zone"" col=""Zone"" onfocus=""this.blur()"" class=""form-control"" st");
                WriteLiteral(@"yle=""height:60px""></textarea>
                                </div>
                                <div class=""col-sm-2 roleCode_op"">
                                    <button type=""button"" class=""btn btn-primary btn-sm roleCode_op"" onclick=""setZone()"">设 置</button><br />
                                    <button type=""button"" class=""btn btn-default btn-sm roleCode_op"" onclick=""clearZone()"">清 空</button>
                                </div>
                            </div>

                        </div>
                    </div>

                    <div id=""tab-2"" class=""tab-pane"">
                        <div class=""panel-body"">
                            <div class=""form-group"">
                                <label class=""col-sm-2 control-label "">姓名<font class=""red""> *</font></label>
                                <div class=""col-sm-8 roleCode_op"">
                                    <input id=""reciveName"" col=""ReciveName"" type=""text"" class=""form-control"" />
                 ");
                WriteLiteral(@"               </div>
                            </div>
                            <div class=""form-group"">
                                <label class=""col-sm-2 control-label "">手机号<font class=""red""> *</font></label>
                                <div class=""col-sm-8 roleCode_op"">
                                    <input id=""recivePhone"" col=""RecivePhone"" onkeyup=""this.value=CheckIsFormatNumber(this.value, 0)"" type=""text"" class=""form-control"" />
                                </div>
                            </div>
                            <div class=""form-group"">
                                <label class=""col-sm-2 control-label "">收件地址<font class=""red""> *</font></label>
                                <div class=""col-sm-8 roleCode_op"">
                                    <input id=""reciveAddress"" col=""ReciveAddress"" type=""text"" class=""form-control"" />
                                </div>
                                <div class=""col-sm-2 roleCode_op"">
                        ");
                WriteLiteral(@"            <button type=""button"" class=""btn btn-primary btn-sm"" onclick=""setAddress()"">选 择</button><br />
                                </div>
                            </div>
                        </div>
                    </div>
                    <div id=""tab-3"" class=""tab-pane"">
                        <div class=""panel-body"">
                            <div class=""form-group"">
                                <label class=""col-sm-2 control-label "">审核人<font class=""red""> *</font></label>
                                <div class=""col-sm-8 roleCode_2"">
                                    <div id=""shenHeManId"" col=""ShenHeManId""></div>
                                </div>
                            </div>
                            <div class=""form-group"">
                                <label class=""col-sm-2 control-label "">凭据上传</label>
                                <div class=""col-sm-8 roleCode_2"">
                                    <input id=""fileinput_PayMoneyImg"" type=""f");
                WriteLiteral(@"ile"">
                                    <input type=""hidden"" id=""payMoneyImg"" col=""PayMoneyImg""/>
                                </div>
                            </div>
                            <div class=""form-group"">
                                <label class=""col-sm-2 control-label "">审核操作<font class=""red""> *</font></label>
                                <div class=""col-sm-8 roleCode_2"" id=""shenHeStatus"" col=""ShenHeStatus""></div>
                            </div>
                            <div class=""form-group"">
                                <label class=""col-sm-2 control-label "">审核消息</label>
                                <div class=""col-sm-8 roleCode_2"">
                                    <textarea id=""shenHeMsg"" col=""ShenHeMsg"" class=""form-control"" style=""height:60px""></textarea>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div id=""tab-4"" class=""tab-pane"">
      ");
                WriteLiteral(@"                  <div class=""panel-body"">
                            <div class=""form-group"">
                                <label class=""col-sm-2 control-label "">发货人<font class=""red""> *</font></label>
                                <div class=""col-sm-8 roleCode_3"">
                                    <div id=""sentManId"" col=""SentManId""></div>
                                </div>
                               
                            </div>
                            <div class=""form-group"">
                                <label class=""col-sm-2 control-label "">物流公司<font class=""red""> *</font></label>
                                <div class=""col-sm-8 roleCode_3"">
                                    <input id=""expressCompany"" col=""ExpressCompany"" type=""text"" class=""form-control"" />
                                </div>
                            </div>
                            <div class=""form-group"">
                                <label class=""col-sm-2 control-label "">快递单号");
                WriteLiteral(@"<font class=""red""> *</font></label>
                                <div class=""col-sm-8 roleCode_3"""">
                                    <input id=""expressNumber"" col=""ExpressNumber"" type=""text"" class=""form-control"" />
                                </div>
                            </div>
                            <div class=""form-group"">
                                <label class=""col-sm-2 control-label "">发货备注</label>
                                <div class=""col-sm-8 roleCode_3"""">
                                    <textarea id=""remark"" col=""Remark"" class=""form-control"" style=""height:60px""></textarea>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    ");
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
            WriteLiteral("\r\n</div>\r\n\r\n<script type=\"text/javascript\">\r\n    var id = ys.request(\"id\");\r\n    var loginId = \"");
#nullable restore
#line 179 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssueForm.cshtml"
              Write(ViewBag.OperatorInfo.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n    var roldeCodes = \"");
#nullable restore
#line 180 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssueForm.cshtml"
                 Write(ViewBag.OperatorInfo.RoleCodes);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n    $(function () {\r\n        $(\"#shenHeStatus\").ysRadioBox({ data: ys.getJson(");
#nullable restore
#line 182 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssueForm.cshtml"
                                                    Write(Html.Raw(typeof(ShenHeStatusEnum).EnumToDictionaryString()));

#line default
#line hidden
#nullable disable
            WriteLiteral(@") });

        LoadShenHeMan();
        LoadSentMan();

        getForm();
        //表单校验
        $('#form').validate({
            rules: {
                materielTxt: { required: true },
                saleTxt: { required: true },
                saleNum: { required: true },
                salePrice: { required: true },
                srcPrice: { required: true },
                factMoney: { required: true },
                
                zone: { required: true },

                reciveName: { required: true },
                recivePhone: { required: true },
                reciveAddress: { required: true },

                sentManId: { required: true },
                sentManId: { required: true },
            }
        });
        //上传图片成功回掉函数
        $('#fileinput_PayMoneyImg').on('fileuploaded', function (event, data, previewId, index) {
            if (data.filescount > 0) {
                $(""#payMoneyImg"").val(data.response.Data);
            }
        });
");
            WriteLiteral("\r\n\r\n    });\r\n\r\n    //加载审核人\r\n    function LoadShenHeMan() {\r\n        $(\"#shenHeManId\").ysComboBox({\r\n            url: \'");
#nullable restore
#line 221 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssueForm.cshtml"
             Write(Url.Content("~/OrganizationManage/User/GetListByRoleCode"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\' +\"?roleCode=2\",\r\n            key: \"Id\",\r\n            value: \"RealName\",\r\n            class: \"form-control\",\r\n         });\r\n    }\r\n    //加载发货人 sentManId\r\n    function LoadSentMan() {\r\n          $(\"#sentManId\").ysComboBox({\r\n            url: \'");
#nullable restore
#line 230 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssueForm.cshtml"
             Write(Url.Content("~/OrganizationManage/User/GetListByRoleCode"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\' +\"?roleCode=3\",\r\n            key: \"Id\",\r\n            value: \"RealName\",\r\n            class: \"form-control\",\r\n         });\r\n    }\r\n\r\n    /**设置上级 */\r\n    function setParent() {\r\n        ys.openDialog({\r\n            title:  \"设置上级\",\r\n            content: \'");
#nullable restore
#line 241 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssueForm.cshtml"
                 Write(Url.Content("~/OrganizationManage/User/UserIndexSelect"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            width: ""868px"",
            height: ""470px"",
             callback: function (index, layero) {
                var iframeWin = window[layero.find('iframe')[0]['name']];
                 var select_data = iframeWin.chooseUserOK();
                 if (IsNullEmpty(select_data.ids)) {
                    ys.alertError('请先选择用户,再操作');
                }
                else {
                    //设置 操作人 saleId
                     $(""#saleId"").val(select_data.ids);
                     $(""#saleTxt"").val(select_data.txts);
                     layer.close(index);

                }
            }
        });

    }

    /**设置地址 */
    function setAddress() {
        ys.openDialog({
            title:  ""设置地址"",
            content: '");
#nullable restore
#line 266 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssueForm.cshtml"
                 Write(Url.Content("~/SystemManage/Area/AreaAddressSelect"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + ""?curUserId="" + $(""#saleId"").val(),
            width: ""868px"",
            height: ""430px"",
             callback: function (index, layero) {
                 var iframeWin = window[layero.find('iframe')[0]['name']];
                 var select_data = iframeWin.getSelectZone();
                 $(""#reciveAddress"").val(select_data.txts);
                 //getSelectZone
                 layer.close(index);
            }
        });

    }

    /**设置代理区域 */
    function setZone() {
        ys.openDialog({
            title:  ""设置代理区域"",
            content: '");
#nullable restore
#line 284 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssueForm.cshtml"
                 Write(Url.Content("~/SystemManage/Area/AreaIndexSelect"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + ""?curUserId="" + $(""#saleId"").val(),
            width: ""868px"",
            height: ""430px"",
             callback: function (index, layero) {
                 var iframeWin = window[layero.find('iframe')[0]['name']];
                 var select_data = iframeWin.getSelectZone();
                 $(""#zone"").val(select_data.txts);
                 //getSelectZone
                 layer.close(index);
            }
        });

    }


    function getForm() {
        if (id > 0) {
            ys.ajax({
                url: '");
#nullable restore
#line 302 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssueForm.cshtml"
                 Write(Url.Content("~/OrderManage/OrderTerIssue/GetFormJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '?id=' + id,
                type: 'get',
                success: function (obj) {
                    if (obj.Tag == 1) {
                        $('#form').setWebControls(obj.Data);
                        InitImg(obj.Data.PayMoneyImg);

                        SetOperatePannel(roldeCodes, ""2"", $(""#shenHeManId"").ysComboBox('getValue'));
                        SetOperatePannel(roldeCodes, ""3"", $(""#sentManId"").ysComboBox('getValue'));
                        SetOpElmentIsEnable(loginId,obj.Data.BaseCreatorId);
                    }
                }
            });
        }
        else {
            var defaultData = {};
            $('#form').setWebControls(defaultData);
            InitImg("""");
            SetOperatePannel(roldeCodes, ""2"","""");
            SetOperatePannel(roldeCodes, ""3"","""");
        }
    }

   

    function saveForm(index) {
        if ($('#form').validate().form()) {
            var postData = $('#form').getWebControls({ Id: id });
            ys.ajax");
            WriteLiteral("({\r\n                url: \'");
#nullable restore
#line 331 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssueForm.cshtml"
                 Write(Url.Content("~/OrderManage/OrderTerIssue/SaveFormJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                type: 'post',
                data: postData,
                success: function (obj) {
                    if (obj.Tag == 1) {
                        ys.msgSuccess(obj.Message);
                        parent.searchGrid();
                        parent.layer.close(index);
                    }
                    else {
                        ys.msgError(obj.Message);
                    }
                }
            });
        }
    }


    function choosePage(filed,hideId,txtId) {
        var url = """";
        var title = """";
        if (filed == ""MaterielTxt"") {
            url = '");
#nullable restore
#line 353 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssueForm.cshtml"
              Write(Url.Content("~/OrderManage/OrderMateriel/OrderMaterielIndexSelect"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
            title = ""选择物料"";
        }
        ys.openDialog({
            title: title,
            content: url,
            width: ""868px"",
            height: ""470px"",
             callback: function (index, layero) {
                var iframeWin = window[layero.find('iframe')[0]['name']];
                 var select_data = iframeWin.chooseUserOK();
                 if (IsNullEmpty(select_data.ids)) {
                    ys.alertError('请先选择用户,再操作');
                }
                else {
                    //设置 操作人
                     $(""#"" + hideId).val(select_data.ids);
                     $(""#"" + txtId).val(select_data.txts);
                     layer.close(index);

                }
            }
        });
    }

    /**
     * 初始化数据
     * param img
     */
    function InitImg(img) {
        var img_es = [];
        if (!IsNullEmpty(img)) {
            img = '");
#nullable restore
#line 385 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssueForm.cshtml"
              Write(GlobalContext.SystemConfig.ApiSite);

#line default
#line hidden
#nullable disable
            WriteLiteral("\' + img;\r\n            img_es.push(img);\r\n        }\r\n        $(\"#fileinput_PayMoneyImg\").fileinput({\r\n            language: \'zh\',\r\n          //  allowedFileTypes: [\'jpg\', \'jpeg\', \'png\'],\r\n            \'uploadUrl\': \'");
#nullable restore
#line 391 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssueForm.cshtml"
                     Write(GlobalContext.SystemConfig.ApiSite);

#line default
#line hidden
#nullable disable
            WriteLiteral("\' + \'/File/UploadFile?fileModule=");
#nullable restore
#line 391 "E:\资料\私人项目\2020_08\code\YiShaAdmin-master\YiSha.Web\YiSha.Admin.Web\Areas\OrderManage\Views\OrderTerIssue\OrderTerIssueForm.cshtml"
                                                                                         Write(UploadFileType.Money.ParseToInt());

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n            overwriteInitial: false,\r\n            initialPreviewAsData: true,\r\n            initialPreview: img_es\r\n         });\r\n\r\n    }\r\n</script>\r\n\r\n");
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

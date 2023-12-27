#pragma checksum "D:\Belgeler\source\repos\RealEstate\RealEstate\Areas\Writer\Views\Shared\Components\DashboardMessagee\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "158ab58f917229c25ba31925e70ba8d6fe0499c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_Shared_Components_DashboardMessagee_Default), @"mvc.1.0.view", @"/Areas/Writer/Views/Shared/Components/DashboardMessagee/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Belgeler\source\repos\RealEstate\RealEstate\Areas\Writer\Views\_ViewImports.cshtml"
using RealEstate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Belgeler\source\repos\RealEstate\RealEstate\Areas\Writer\Views\_ViewImports.cshtml"
using RealEstate.Areas.Writer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Belgeler\source\repos\RealEstate\RealEstate\Areas\Writer\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"158ab58f917229c25ba31925e70ba8d6fe0499c7", @"/Areas/Writer/Views/Shared/Components/DashboardMessagee/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f12901d0defef9088af739d82bf4eaf05a58fec5", @"/Areas/Writer/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Writer_Views_Shared_Components_DashboardMessagee_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:50px;height:50px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""col-md-5 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Son Mesajlar</h4>
            <div class=""table-responsive"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th> # </th>
                            <th> Gönderen </th>
                            <th> Tarih </th>
                            <th> Detaylar </th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 19 "D:\Belgeler\source\repos\RealEstate\RealEstate\Areas\Writer\Views\Shared\Components\DashboardMessagee\Default.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td> ");
#nullable restore
#line 22 "D:\Belgeler\source\repos\RealEstate\RealEstate\Areas\Writer\Views\Shared\Components\DashboardMessagee\Default.cshtml"
                                Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "158ab58f917229c25ba31925e70ba8d6fe0499c75642", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 818, "~/UserImage/", 818, 12, true);
#nullable restore
#line 23 "D:\Belgeler\source\repos\RealEstate\RealEstate\Areas\Writer\Views\Shared\Components\DashboardMessagee\Default.cshtml"
AddHtmlAttributeValue("", 830, item.SenderUser.Image, 830, 22, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" ");
#nullable restore
#line 23 "D:\Belgeler\source\repos\RealEstate\RealEstate\Areas\Writer\Views\Shared\Components\DashboardMessagee\Default.cshtml"
                                                                                                                                     Write(item.SenderUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 23 "D:\Belgeler\source\repos\RealEstate\RealEstate\Areas\Writer\Views\Shared\Components\DashboardMessagee\Default.cshtml"
                                                                                                                                                           Write(item.SenderUser.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                <td> ");
#nullable restore
#line 24 "D:\Belgeler\source\repos\RealEstate\RealEstate\Areas\Writer\Views\Shared\Components\DashboardMessagee\Default.cshtml"
                                Write(item.Date.ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                <td>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1119, "\"", 1165, 2);
            WriteAttributeValue("", 1126, "/Writer/Message/MessageDetails/", 1126, 31, true);
#nullable restore
#line 26 "D:\Belgeler\source\repos\RealEstate\RealEstate\Areas\Writer\Views\Shared\Components\DashboardMessagee\Default.cshtml"
WriteAttributeValue("", 1157, item.ID, 1157, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-secondary\">Detaylarını Gör</a>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 29 "D:\Belgeler\source\repos\RealEstate\RealEstate\Areas\Writer\Views\Shared\Components\DashboardMessagee\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Message>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

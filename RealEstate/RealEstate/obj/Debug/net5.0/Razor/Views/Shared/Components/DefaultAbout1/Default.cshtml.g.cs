#pragma checksum "D:\Belgeler\source\repos\RealEstate\RealEstate\Views\Shared\Components\DefaultAbout1\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ca1a95eb151d1590e9463ecdfe85360d8ecaf59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_DefaultAbout1_Default), @"mvc.1.0.view", @"/Views/Shared/Components/DefaultAbout1/Default.cshtml")]
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
#line 1 "D:\Belgeler\source\repos\RealEstate\RealEstate\Views\_ViewImports.cshtml"
using RealEstate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Belgeler\source\repos\RealEstate\RealEstate\Views\_ViewImports.cshtml"
using RealEstate.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ca1a95eb151d1590e9463ecdfe85360d8ecaf59", @"/Views/Shared/Components/DefaultAbout1/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f04be1918b5591cf4e086545c1506bd292093f29", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_DefaultAbout1_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EntityLayer.Concrete.About1>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Belgeler\source\repos\RealEstate\RealEstate\Views\Shared\Components\DefaultAbout1\Default.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-xxl py-5\">\r\n    <div class=\"container\">\r\n");
#nullable restore
#line 10 "D:\Belgeler\source\repos\RealEstate\RealEstate\Views\Shared\Components\DefaultAbout1\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row g-5 align-items-center\">\r\n                <div class=\"col-lg-6 wow fadeIn\" data-wow-delay=\"0.1s\">\r\n                    <div class=\"about-img position-relative overflow-hidden p-5 pe-0\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9ca1a95eb151d1590e9463ecdfe85360d8ecaf594497", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 7, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 460, "~/Makaan", 460, 8, true);
            AddHtmlAttributeValue(" ", 468, "Free", 469, 5, true);
            AddHtmlAttributeValue(" ", 473, "Website", 474, 8, true);
            AddHtmlAttributeValue(" ", 481, "Template", 482, 9, true);
            AddHtmlAttributeValue(" ", 490, "-", 491, 2, true);
            AddHtmlAttributeValue(" ", 492, "Free-CSS.com/real-estate-html-template/img/", 493, 44, true);
#nullable restore
#line 15 "D:\Belgeler\source\repos\RealEstate\RealEstate\Views\Shared\Components\DefaultAbout1\Default.cshtml"
AddHtmlAttributeValue("", 536, item.Image, 536, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-6 wow fadeIn\" data-wow-delay=\"0.5s\">\r\n\r\n                    <h1 class=\"mb-4\">");
#nullable restore
#line 20 "D:\Belgeler\source\repos\RealEstate\RealEstate\Views\Shared\Components\DefaultAbout1\Default.cshtml"
                                Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    <p class=\"mb-4\">");
#nullable restore
#line 21 "D:\Belgeler\source\repos\RealEstate\RealEstate\Views\Shared\Components\DefaultAbout1\Default.cshtml"
                               Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p><i class=\"fa fa-check text-primary me-3\"></i>");
#nullable restore
#line 22 "D:\Belgeler\source\repos\RealEstate\RealEstate\Views\Shared\Components\DefaultAbout1\Default.cshtml"
                                                               Write(item.Article1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p><i class=\"fa fa-check text-primary me-3\"></i>");
#nullable restore
#line 23 "D:\Belgeler\source\repos\RealEstate\RealEstate\Views\Shared\Components\DefaultAbout1\Default.cshtml"
                                                               Write(item.Article2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p><i class=\"fa fa-check text-primary me-3\"></i>");
#nullable restore
#line 24 "D:\Belgeler\source\repos\RealEstate\RealEstate\Views\Shared\Components\DefaultAbout1\Default.cshtml"
                                                               Write(item.Article3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 29 "D:\Belgeler\source\repos\RealEstate\RealEstate\Views\Shared\Components\DefaultAbout1\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EntityLayer.Concrete.About1>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
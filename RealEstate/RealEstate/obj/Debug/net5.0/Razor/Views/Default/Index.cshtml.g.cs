#pragma checksum "D:\Belgeler\source\repos\RealEstate\RealEstate\Views\Default\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4f81407e5b8cc7445903ada3798c6dcb4be3dc0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_Index), @"mvc.1.0.view", @"/Views/Default/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4f81407e5b8cc7445903ada3798c6dcb4be3dc0", @"/Views/Default/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f04be1918b5591cf4e086545c1506bd292093f29", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Default_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Belgeler\source\repos\RealEstate\RealEstate\Views\Default\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\Belgeler\source\repos\RealEstate\RealEstate\Views\Default\Index.cshtml"
Write(await Component.InvokeAsync("DefaultFeature"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "D:\Belgeler\source\repos\RealEstate\RealEstate\Views\Default\Index.cshtml"
Write(await Component.InvokeAsync("DefaultPropertyType"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!-- Category End -->\r\n<!-- About Start -->\r\n");
#nullable restore
#line 12 "D:\Belgeler\source\repos\RealEstate\RealEstate\Views\Default\Index.cshtml"
Write(await Component.InvokeAsync("DefaultAbout1"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- About End -->\r\n<!-- Property List Start -->\r\n");
#nullable restore
#line 15 "D:\Belgeler\source\repos\RealEstate\RealEstate\Views\Default\Index.cshtml"
Write(await Component.InvokeAsync("DefaultProperty"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Property List End -->\r\n<!-- Call to Action Start -->\r\n");
#nullable restore
#line 18 "D:\Belgeler\source\repos\RealEstate\RealEstate\Views\Default\Index.cshtml"
Write(await Component.InvokeAsync("DefaultAbout2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Call to Action End -->\r\n<!-- Team Start -->\r\n");
#nullable restore
#line 21 "D:\Belgeler\source\repos\RealEstate\RealEstate\Views\Default\Index.cshtml"
Write(await Component.InvokeAsync("DefaultEmployee"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!-- Team End -->\r\n<!-- Testimonial Start -->\r\n\r\n\r\n<a href=\"#\" class=\"btn btn-lg btn-primary btn-lg-square back-to-top\"><i class=\"bi bi-arrow-up\"></i></a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

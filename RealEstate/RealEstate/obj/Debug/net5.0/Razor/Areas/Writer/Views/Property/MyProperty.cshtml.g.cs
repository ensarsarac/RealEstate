#pragma checksum "D:\Belgeler\source\repos\RealEstate\RealEstate\Areas\Writer\Views\Property\MyProperty.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff91a767d26883005021395c4f1f14a33eda4e4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_Property_MyProperty), @"mvc.1.0.view", @"/Areas/Writer/Views/Property/MyProperty.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff91a767d26883005021395c4f1f14a33eda4e4b", @"/Areas/Writer/Views/Property/MyProperty.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f12901d0defef9088af739d82bf4eaf05a58fec5", @"/Areas/Writer/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Writer_Views_Property_MyProperty : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EntityLayer.Concrete.Property>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Belgeler\source\repos\RealEstate\RealEstate\Areas\Writer\Views\Property\MyProperty.cshtml"
  
    ViewData["Title"] = "MyProperty";
    Layout = "~/Views/Shared/_WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>İlanlarım</h1>
<hr />
<table class=""table table-bordered"">

    <tr>
        <th>#</th>
        <th>Başlık</th>
        <th>Fiyat</th>
        <th>Durum</th>
        <th>Tür</th>
        <th>Tarih</th>
        <th>Sil</th>
        <th>Düzenle</th>
        <th>Detaylar</th>
    </tr>

");
#nullable restore
#line 25 "D:\Belgeler\source\repos\RealEstate\RealEstate\Areas\Writer\Views\Property\MyProperty.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 28 "D:\Belgeler\source\repos\RealEstate\RealEstate\Areas\Writer\Views\Property\MyProperty.cshtml"
           Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "D:\Belgeler\source\repos\RealEstate\RealEstate\Areas\Writer\Views\Property\MyProperty.cshtml"
           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "D:\Belgeler\source\repos\RealEstate\RealEstate\Areas\Writer\Views\Property\MyProperty.cshtml"
           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "D:\Belgeler\source\repos\RealEstate\RealEstate\Areas\Writer\Views\Property\MyProperty.cshtml"
           Write(item.PropertyStatus.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "D:\Belgeler\source\repos\RealEstate\RealEstate\Areas\Writer\Views\Property\MyProperty.cshtml"
           Write(item.PropertyType.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "D:\Belgeler\source\repos\RealEstate\RealEstate\Areas\Writer\Views\Property\MyProperty.cshtml"
           Write(item.Date.ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 777, "\"", 825, 3);
            WriteAttributeValue("", 784, "/Writer/Property/RemoveProperty/", 784, 32, true);
#nullable restore
#line 34 "D:\Belgeler\source\repos\RealEstate\RealEstate\Areas\Writer\Views\Property\MyProperty.cshtml"
WriteAttributeValue("", 816, item.ID, 816, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 824, "/", 824, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 882, "\"", 930, 3);
            WriteAttributeValue("", 889, "/Writer/Property/UpdateProperty/", 889, 32, true);
#nullable restore
#line 35 "D:\Belgeler\source\repos\RealEstate\RealEstate\Areas\Writer\Views\Property\MyProperty.cshtml"
WriteAttributeValue("", 921, item.ID, 921, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 929, "/", 929, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\" id=\"delete\">Düzenle</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1004, "\"", 1045, 3);
            WriteAttributeValue("", 1011, "/Default/PropertyDetails/", 1011, 25, true);
#nullable restore
#line 36 "D:\Belgeler\source\repos\RealEstate\RealEstate\Areas\Writer\Views\Property\MyProperty.cshtml"
WriteAttributeValue("", 1036, item.ID, 1036, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1044, "/", 1044, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-secondary\">Detaylar</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 38 "D:\Belgeler\source\repos\RealEstate\RealEstate\Areas\Writer\Views\Property\MyProperty.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n\r\n<a href=\"/Writer/Property/AddProperty/\" class=\"btn btn-primary\">Yeni İlan Oluştur</a>\r\n");
            DefineSection("Script", async() => {
                WriteLiteral("\r\n\r\n   \r\n    <script src=\"https://unpkg.com/sweetalert/dist/sweetalert.min.js\"></script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EntityLayer.Concrete.Property>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
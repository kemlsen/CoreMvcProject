#pragma checksum "C:\Users\Kemal\Desktop\mvcprojeler\ProjeCore - Kopya\ProjeCore\Views\Default\BirimDetay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9a8f8bb3e6555d96fcbea4e20680049667f6072"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_BirimDetay), @"mvc.1.0.view", @"/Views/Default/BirimDetay.cshtml")]
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
#line 1 "C:\Users\Kemal\Desktop\mvcprojeler\ProjeCore - Kopya\ProjeCore\Views\_ViewImports.cshtml"
using ProjeCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Kemal\Desktop\mvcprojeler\ProjeCore - Kopya\ProjeCore\Views\Default\BirimDetay.cshtml"
using ProjeCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9a8f8bb3e6555d96fcbea4e20680049667f6072", @"/Views/Default/BirimDetay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f6887fc2a081498e457a98abd035f4ecf5faaf7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Default_BirimDetay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Personel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Kemal\Desktop\mvcprojeler\ProjeCore - Kopya\ProjeCore\Views\Default\BirimDetay.cshtml"
  
    ViewData["Title"] = "BirimDetay";
    Layout = "~/Views/Shared/_TestLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br /> \r\n<h2>");
#nullable restore
#line 9 "C:\Users\Kemal\Desktop\mvcprojeler\ProjeCore - Kopya\ProjeCore\Views\Default\BirimDetay.cshtml"
Write(ViewBag.brm);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Departmanı</h2><br />\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Ad</th>\r\n        <th>Soyad</th>\r\n        <th>Şehir</th>\r\n    </tr>\r\n");
#nullable restore
#line 17 "C:\Users\Kemal\Desktop\mvcprojeler\ProjeCore - Kopya\ProjeCore\Views\Default\BirimDetay.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\Kemal\Desktop\mvcprojeler\ProjeCore - Kopya\ProjeCore\Views\Default\BirimDetay.cshtml"
           Write(x.PersonelID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\Kemal\Desktop\mvcprojeler\ProjeCore - Kopya\ProjeCore\Views\Default\BirimDetay.cshtml"
           Write(x.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\Kemal\Desktop\mvcprojeler\ProjeCore - Kopya\ProjeCore\Views\Default\BirimDetay.cshtml"
           Write(x.Soyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\Kemal\Desktop\mvcprojeler\ProjeCore - Kopya\ProjeCore\Views\Default\BirimDetay.cshtml"
           Write(x.Sehir);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>            \r\n        </tr>\r\n");
#nullable restore
#line 25 "C:\Users\Kemal\Desktop\mvcprojeler\ProjeCore - Kopya\ProjeCore\Views\Default\BirimDetay.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Personel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "D:\Visual\projects\WebApp4\WebApp4\Views\Controls\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2dc8e27f57ffa6b66cceff40782e88184e15fba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Controls_Result), @"mvc.1.0.view", @"/Views/Controls/Result.cshtml")]
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
#line 1 "D:\Visual\projects\WebApp4\WebApp4\Views\_ViewImports.cshtml"
using WebApp4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Visual\projects\WebApp4\WebApp4\Views\_ViewImports.cshtml"
using WebApp4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2dc8e27f57ffa6b66cceff40782e88184e15fba", @"/Views/Controls/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca459b8411586a3dae35165809f6c0e7d64aef8d", @"/Views/_ViewImports.cshtml")]
    public class Views_Controls_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>");
#nullable restore
#line 1 "D:\Visual\projects\WebApp4\WebApp4\Views\Controls\Result.cshtml"
Write(ViewBag.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div style=\"display: flex\" ;>\r\n    <b class=\"m-2\">");
#nullable restore
#line 4 "D:\Visual\projects\WebApp4\WebApp4\Views\Controls\Result.cshtml"
              Write(ViewBag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b>\r\n");
#nullable restore
#line 5 "D:\Visual\projects\WebApp4\WebApp4\Views\Controls\Result.cshtml"
     for (int i = 0; i < ViewBag.MyArray.Length; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<pre class=\"m-2\" style=\"font-family:Arial; font-size:16px;\">");
#nullable restore
#line 6 "D:\Visual\projects\WebApp4\WebApp4\Views\Controls\Result.cshtml"
                                                            Write(ViewBag.MyArray[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre> <br />");
#nullable restore
#line 6 "D:\Visual\projects\WebApp4\WebApp4\Views\Controls\Result.cshtml"
                                                                                                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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

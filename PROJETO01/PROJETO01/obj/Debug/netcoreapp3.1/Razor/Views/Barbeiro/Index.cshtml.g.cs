#pragma checksum "D:\github\PROJETO01\PROJETO01\PROJETO01\Views\Barbeiro\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e5c3fa4c1551aecf327179f9283f0a260b07b3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Barbeiro_Index), @"mvc.1.0.view", @"/Views/Barbeiro/Index.cshtml")]
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
#line 1 "D:\github\PROJETO01\PROJETO01\PROJETO01\Views\_ViewImports.cshtml"
using PROJETO01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\github\PROJETO01\PROJETO01\PROJETO01\Views\_ViewImports.cshtml"
using PROJETO01.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e5c3fa4c1551aecf327179f9283f0a260b07b3b", @"/Views/Barbeiro/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93a24eea2b15d20d16798ed9e4b0c9c93903b076", @"/Views/_ViewImports.cshtml")]
    public class Views_Barbeiro_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PROJETO01.Modelos.Barbeiro>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>\r\n    ");
#nullable restore
#line 4 "D:\github\PROJETO01\PROJETO01\PROJETO01\Views\Barbeiro\Index.cshtml"
Write(Model.IdBarbeiro);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</h1>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PROJETO01.Modelos.Barbeiro> Html { get; private set; }
    }
}
#pragma warning restore 1591

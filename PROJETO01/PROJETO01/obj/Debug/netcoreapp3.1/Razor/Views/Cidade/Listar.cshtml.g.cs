#pragma checksum "C:\repositorios\PROJETO01\PROJETO01\PROJETO01\Views\Cidade\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ee04309c21a9b3364d50670a06daec46ff2489a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cidade_Listar), @"mvc.1.0.view", @"/Views/Cidade/Listar.cshtml")]
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
#line 1 "C:\repositorios\PROJETO01\PROJETO01\PROJETO01\Views\_ViewImports.cshtml"
using PROJETO01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\repositorios\PROJETO01\PROJETO01\PROJETO01\Views\_ViewImports.cshtml"
using PROJETO01.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ee04309c21a9b3364d50670a06daec46ff2489a", @"/Views/Cidade/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93a24eea2b15d20d16798ed9e4b0c9c93903b076", @"/Views/_ViewImports.cshtml")]
    public class Views_Cidade_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PROJETO01.Modelos.Cidade>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h3>
    CADASTRO DE CIDADES
    <a class=""btn btn-sm btn-primary float-right"" href=""/Cidade/Adicionar"">
        + ADICIONAR
    </a>
</h3>

<table class=""table table-hover "">
    <thead>
        <tr>
            <th>IdCidade</th>
            <th>UF</th>
            <th>Nome</th>
            <th>Ações</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 20 "C:\repositorios\PROJETO01\PROJETO01\PROJETO01\Views\Cidade\Listar.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 23 "C:\repositorios\PROJETO01\PROJETO01\PROJETO01\Views\Cidade\Listar.cshtml"
               Write(item.IdCidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\repositorios\PROJETO01\PROJETO01\PROJETO01\Views\Cidade\Listar.cshtml"
               Write(item.UF);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\repositorios\PROJETO01\PROJETO01\PROJETO01\Views\Cidade\Listar.cshtml"
               Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 629, "\"", 674, 2);
            WriteAttributeValue("", 636, "/Cidade/Editar?IdCidade=", 636, 24, true);
#nullable restore
#line 27 "C:\repositorios\PROJETO01\PROJETO01\PROJETO01\Views\Cidade\Listar.cshtml"
WriteAttributeValue("", 660, item.IdCidade, 660, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-warning\">\r\n                        Editar\r\n                    </a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 789, "\"", 835, 2);
            WriteAttributeValue("", 796, "/Cidade/Excluir?IdCidade=", 796, 25, true);
#nullable restore
#line 30 "C:\repositorios\PROJETO01\PROJETO01\PROJETO01\Views\Cidade\Listar.cshtml"
WriteAttributeValue("", 821, item.IdCidade, 821, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-danger\">\r\n                        Excluir\r\n                    </a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 35 "C:\repositorios\PROJETO01\PROJETO01\PROJETO01\Views\Cidade\Listar.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PROJETO01.Modelos.Cidade>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "D:\github\PROJETO01\PROJETO01\PROJETO01\Views\Barbeiro\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa03374a7cda472685365e725b483c37e3a451a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Barbeiro_Listar), @"mvc.1.0.view", @"/Views/Barbeiro/Listar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa03374a7cda472685365e725b483c37e3a451a4", @"/Views/Barbeiro/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93a24eea2b15d20d16798ed9e4b0c9c93903b076", @"/Views/_ViewImports.cshtml")]
    public class Views_Barbeiro_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PROJETO01.Modelos.Barbeiro>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <h3>
    CADASTRO DE BARBEIROS 
    <a class=""btn btn-sm btn-primary float-right"" href=""/Barbeiro/Adicionar"">
        + ADICIONAR
    </a>
</h3>

<table class=""table table-hover "">
         <thead>
              <tr>
                <th>IdBarbeiro</th>
                <th>Nome</th>
                <th>cpf</th>
                <th>Telefone</th>
                <th>IdEspecialidade</th>
                <th>PrecoCorte</th>
                <th>Ações</th>
              </tr>
        </thead>
    <tbody>
");
#nullable restore
#line 23 "D:\github\PROJETO01\PROJETO01\PROJETO01\Views\Barbeiro\Listar.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 26 "D:\github\PROJETO01\PROJETO01\PROJETO01\Views\Barbeiro\Listar.cshtml"
               Write(item.IdBarbeiro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "D:\github\PROJETO01\PROJETO01\PROJETO01\Views\Barbeiro\Listar.cshtml"
               Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "D:\github\PROJETO01\PROJETO01\PROJETO01\Views\Barbeiro\Listar.cshtml"
               Write(item.cpf);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "D:\github\PROJETO01\PROJETO01\PROJETO01\Views\Barbeiro\Listar.cshtml"
               Write(item.Telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "D:\github\PROJETO01\PROJETO01\PROJETO01\Views\Barbeiro\Listar.cshtml"
               Write(item.IdEspecialidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "D:\github\PROJETO01\PROJETO01\PROJETO01\Views\Barbeiro\Listar.cshtml"
               Write(item.PrecoCorte);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 931, "\"", 982, 2);
            WriteAttributeValue("", 938, "/Barbeiro/Editar?IdBarbeiro=", 938, 28, true);
#nullable restore
#line 34 "D:\github\PROJETO01\PROJETO01\PROJETO01\Views\Barbeiro\Listar.cshtml"
WriteAttributeValue("", 966, item.IdBarbeiro, 966, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-warning\">\r\n                        Editar\r\n                    </a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1097, "\"", 1149, 2);
            WriteAttributeValue("", 1104, "/Barbeiro/Excluir?IdBarbeiro=", 1104, 29, true);
#nullable restore
#line 37 "D:\github\PROJETO01\PROJETO01\PROJETO01\Views\Barbeiro\Listar.cshtml"
WriteAttributeValue("", 1133, item.IdBarbeiro, 1133, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-danger\">\r\n                        Excluir\r\n                    </a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 42 "D:\github\PROJETO01\PROJETO01\PROJETO01\Views\Barbeiro\Listar.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PROJETO01.Modelos.Barbeiro>> Html { get; private set; }
    }
}
#pragma warning restore 1591

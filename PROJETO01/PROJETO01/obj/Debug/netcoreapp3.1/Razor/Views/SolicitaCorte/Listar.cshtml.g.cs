#pragma checksum "C:\Users\040684\Desktop\ProjetoFinal\PROJETO01\PROJETO01\PROJETO01\Views\SolicitaCorte\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67db8f18bd70efbd782baf72ce52f2f7e6ae90bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SolicitaCorte_Listar), @"mvc.1.0.view", @"/Views/SolicitaCorte/Listar.cshtml")]
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
#line 1 "C:\Users\040684\Desktop\ProjetoFinal\PROJETO01\PROJETO01\PROJETO01\Views\_ViewImports.cshtml"
using PROJETO01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\040684\Desktop\ProjetoFinal\PROJETO01\PROJETO01\PROJETO01\Views\_ViewImports.cshtml"
using PROJETO01.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67db8f18bd70efbd782baf72ce52f2f7e6ae90bd", @"/Views/SolicitaCorte/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93a24eea2b15d20d16798ed9e4b0c9c93903b076", @"/Views/_ViewImports.cshtml")]
    public class Views_SolicitaCorte_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PROJETO01.Modelos.SolicitarCorte>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

    <h3 class=""mt-3"">
        CADASTRO DE CORTES
        <a class=""btn btn-sm btn-primary float-right"" href=""/SolicitaCorte/Adicionar"">
            + ADICIONAR
        </a>
    </h3>

    <table class=""table table-hover "">
        <thead id=""theadPosition"">
            <tr id=""size"">
                <th>IdSolicitacao</th>
                <th>Cliente</th>
                <th>Barbeiro</th>
                <th>Cidade</th>
                <th>Preço corte</th>
                <th>Logradouro</th>
                <th>Bairro</th>
                <th>Complemento</th>
                <th>Numero</th>
            </tr>
        </thead>

        <tbody>
");
#nullable restore
#line 27 "C:\Users\040684\Desktop\ProjetoFinal\PROJETO01\PROJETO01\PROJETO01\Views\SolicitaCorte\Listar.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 30 "C:\Users\040684\Desktop\ProjetoFinal\PROJETO01\PROJETO01\PROJETO01\Views\SolicitaCorte\Listar.cshtml"
                   Write(item.IdSolicitacao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "C:\Users\040684\Desktop\ProjetoFinal\PROJETO01\PROJETO01\PROJETO01\Views\SolicitaCorte\Listar.cshtml"
                   Write(item.IdCliente);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "C:\Users\040684\Desktop\ProjetoFinal\PROJETO01\PROJETO01\PROJETO01\Views\SolicitaCorte\Listar.cshtml"
                   Write(item.IdBarbeiro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "C:\Users\040684\Desktop\ProjetoFinal\PROJETO01\PROJETO01\PROJETO01\Views\SolicitaCorte\Listar.cshtml"
                   Write(item.IdCidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 34 "C:\Users\040684\Desktop\ProjetoFinal\PROJETO01\PROJETO01\PROJETO01\Views\SolicitaCorte\Listar.cshtml"
                   Write(item.PrecoCorte);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 35 "C:\Users\040684\Desktop\ProjetoFinal\PROJETO01\PROJETO01\PROJETO01\Views\SolicitaCorte\Listar.cshtml"
                   Write(item.Logradouro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 36 "C:\Users\040684\Desktop\ProjetoFinal\PROJETO01\PROJETO01\PROJETO01\Views\SolicitaCorte\Listar.cshtml"
                   Write(item.Bairro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 37 "C:\Users\040684\Desktop\ProjetoFinal\PROJETO01\PROJETO01\PROJETO01\Views\SolicitaCorte\Listar.cshtml"
                   Write(item.Complemento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 38 "C:\Users\040684\Desktop\ProjetoFinal\PROJETO01\PROJETO01\PROJETO01\Views\SolicitaCorte\Listar.cshtml"
                   Write(item.Numero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1272, "\"", 1334, 2);
            WriteAttributeValue("", 1279, "/SolicitaCorte/Editar?IdSolicitacao=", 1279, 36, true);
#nullable restore
#line 41 "C:\Users\040684\Desktop\ProjetoFinal\PROJETO01\PROJETO01\PROJETO01\Views\SolicitaCorte\Listar.cshtml"
WriteAttributeValue("", 1315, item.IdSolicitacao, 1315, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-warning\">\r\n                            Editar\r\n                        </a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1461, "\"", 1524, 2);
            WriteAttributeValue("", 1468, "/SolicitaCorte/Excluir?IdSolicitacao=", 1468, 37, true);
#nullable restore
#line 44 "C:\Users\040684\Desktop\ProjetoFinal\PROJETO01\PROJETO01\PROJETO01\Views\SolicitaCorte\Listar.cshtml"
WriteAttributeValue("", 1505, item.IdSolicitacao, 1505, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-danger\">\r\n                            Excluir  \r\n                        </a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 49 "C:\Users\040684\Desktop\ProjetoFinal\PROJETO01\PROJETO01\PROJETO01\Views\SolicitaCorte\Listar.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PROJETO01.Modelos.SolicitarCorte>> Html { get; private set; }
    }
}
#pragma warning restore 1591

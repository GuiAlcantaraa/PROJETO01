#pragma checksum "C:\GITHUB\PROJETO01\PROJETO01\PROJETO01\Views\Barbeiro\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2718cefd431555de32df143512dbd5f2cc593545"
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
#line 1 "C:\GITHUB\PROJETO01\PROJETO01\PROJETO01\Views\_ViewImports.cshtml"
using PROJETO01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\GITHUB\PROJETO01\PROJETO01\PROJETO01\Views\_ViewImports.cshtml"
using PROJETO01.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2718cefd431555de32df143512dbd5f2cc593545", @"/Views/Barbeiro/Listar.cshtml")]
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
                <th>Especialidade</th>
                <th>PrecoCorte</th>
                <th>Ações</th>
              </tr>
        </thead>
    <tbody>
");
#nullable restore
#line 23 "C:\GITHUB\PROJETO01\PROJETO01\PROJETO01\Views\Barbeiro\Listar.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 26 "C:\GITHUB\PROJETO01\PROJETO01\PROJETO01\Views\Barbeiro\Listar.cshtml"
               Write(item.IdBarbeiro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\GITHUB\PROJETO01\PROJETO01\PROJETO01\Views\Barbeiro\Listar.cshtml"
               Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\GITHUB\PROJETO01\PROJETO01\PROJETO01\Views\Barbeiro\Listar.cshtml"
               Write(Convert.ToInt64(item.cpf).ToString(@"000\.000\.000\-00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\GITHUB\PROJETO01\PROJETO01\PROJETO01\Views\Barbeiro\Listar.cshtml"
               Write(item.Telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\GITHUB\PROJETO01\PROJETO01\PROJETO01\Views\Barbeiro\Listar.cshtml"
               Write(item.EspecialidadeB.Especialidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\GITHUB\PROJETO01\PROJETO01\PROJETO01\Views\Barbeiro\Listar.cshtml"
               Write(string.Format("{0:c2}", item.PrecoCorte));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1011, "\"", 1062, 2);
            WriteAttributeValue("", 1018, "/Barbeiro/Editar?IdBarbeiro=", 1018, 28, true);
#nullable restore
#line 34 "C:\GITHUB\PROJETO01\PROJETO01\PROJETO01\Views\Barbeiro\Listar.cshtml"
WriteAttributeValue("", 1046, item.IdBarbeiro, 1046, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-warning\">\r\n                        Editar\r\n                    </a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1177, "\"", 1229, 2);
            WriteAttributeValue("", 1184, "/Barbeiro/Excluir?IdBarbeiro=", 1184, 29, true);
#nullable restore
#line 37 "C:\GITHUB\PROJETO01\PROJETO01\PROJETO01\Views\Barbeiro\Listar.cshtml"
WriteAttributeValue("", 1213, item.IdBarbeiro, 1213, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-danger\">\r\n                        Excluir\r\n                    </a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 42 "C:\GITHUB\PROJETO01\PROJETO01\PROJETO01\Views\Barbeiro\Listar.cshtml"
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

#pragma checksum "C:\Users\040684\Desktop\ProjetoFinal\PROJETO01\PROJETO01\PROJETO01\Views\Especialidade\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3c80b49fe9ccba2af37d5ae2ab145604006f837"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Especialidade_Listar), @"mvc.1.0.view", @"/Views/Especialidade/Listar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3c80b49fe9ccba2af37d5ae2ab145604006f837", @"/Views/Especialidade/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93a24eea2b15d20d16798ed9e4b0c9c93903b076", @"/Views/_ViewImports.cshtml")]
    public class Views_Especialidade_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PROJETO01.Modelos.EspecialidadeB>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h3 class =""mt-3"">
    CADASTRO DE ESPECIALIDADES
    <a class=""btn btn-sm btn-primary float-right"" href=""/Especialidade/Adicionar"">
        + ADICIONAR
    </a>
</h3>


<table class=""table table-hover "">
    <thead id=""theadPosition"">
        <tr id=""size"">
            <th>IdEspecialidade</th>
            <th>Especialidade</th>
            <th>Ações</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 20 "C:\Users\040684\Desktop\ProjetoFinal\PROJETO01\PROJETO01\PROJETO01\Views\Especialidade\Listar.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\040684\Desktop\ProjetoFinal\PROJETO01\PROJETO01\PROJETO01\Views\Especialidade\Listar.cshtml"
               Write(item.IdEspecialidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\040684\Desktop\ProjetoFinal\PROJETO01\PROJETO01\PROJETO01\Views\Especialidade\Listar.cshtml"
               Write(item.Especialidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 668, "\"", 734, 2);
            WriteAttributeValue("", 675, "/Especialidade/Editar?IdEspecialidade=", 675, 38, true);
#nullable restore
#line 26 "C:\Users\040684\Desktop\ProjetoFinal\PROJETO01\PROJETO01\PROJETO01\Views\Especialidade\Listar.cshtml"
WriteAttributeValue("", 713, item.IdEspecialidade, 713, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-warning\">\r\n                        Editar\r\n                    </a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 849, "\"", 916, 2);
            WriteAttributeValue("", 856, "/Especialidade/Excluir?IdEspecialidade=", 856, 39, true);
#nullable restore
#line 29 "C:\Users\040684\Desktop\ProjetoFinal\PROJETO01\PROJETO01\PROJETO01\Views\Especialidade\Listar.cshtml"
WriteAttributeValue("", 895, item.IdEspecialidade, 895, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-danger\">\r\n                        Excluir\r\n                    </a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 34 "C:\Users\040684\Desktop\ProjetoFinal\PROJETO01\PROJETO01\PROJETO01\Views\Especialidade\Listar.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<style>\r\n    \r\n    body{\r\n        background: #e6e6e6;\r\n    }\r\n\r\n     #theadPosition{\r\n      \r\n        background: #cccccc;\r\n    }\r\n  \r\n</style>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PROJETO01.Modelos.EspecialidadeB>> Html { get; private set; }
    }
}
#pragma warning restore 1591

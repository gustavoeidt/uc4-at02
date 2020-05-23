#pragma checksum "C:\xampp\htdocs\UC-4\at02\Views\Pacote\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7706ad647ac034e58ed50f850c7856ee1f240ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pacote_index), @"mvc.1.0.view", @"/Views/Pacote/index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7706ad647ac034e58ed50f850c7856ee1f240ea", @"/Views/Pacote/index.cshtml")]
    public class Views_Pacote_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<at02.Models.Pacote>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\xampp\htdocs\UC-4\at02\Views\Pacote\index.cshtml"
  
    ViewData["Title"] = "Listagem de Pacotes";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <table class=""table"">
        <thead>
            <tr>
                <th>Nome</th>
                <th>Origem</th>
                <th>Destino</th>
                <th>Saida</th>
                <th>Retorno</th>
                <th>Autor</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 20 "C:\xampp\htdocs\UC-4\at02\Views\Pacote\index.cshtml"
         foreach (at02.Models.Pacote item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 560, "\"", 592, 2);
            WriteAttributeValue("", 567, "/pacote/atualiza/", 567, 17, true);
#nullable restore
#line 23 "C:\xampp\htdocs\UC-4\at02\Views\Pacote\index.cshtml"
WriteAttributeValue("", 584, item.id, 584, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" >");
#nullable restore
#line 23 "C:\xampp\htdocs\UC-4\at02\Views\Pacote\index.cshtml"
                                                    Write(item.nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                <td>");
#nullable restore
#line 24 "C:\xampp\htdocs\UC-4\at02\Views\Pacote\index.cshtml"
               Write(item.origem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\xampp\htdocs\UC-4\at02\Views\Pacote\index.cshtml"
               Write(item.destino);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\xampp\htdocs\UC-4\at02\Views\Pacote\index.cshtml"
                Write(item.saida.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\xampp\htdocs\UC-4\at02\Views\Pacote\index.cshtml"
                Write(item.retorno.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\xampp\htdocs\UC-4\at02\Views\Pacote\index.cshtml"
               Write(item.autor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 883, "\"", 912, 2);
            WriteAttributeValue("", 890, "/pacote/apaga/", 890, 14, true);
#nullable restore
#line 29 "C:\xampp\htdocs\UC-4\at02\Views\Pacote\index.cshtml"
WriteAttributeValue("", 904, item.id, 904, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Apagar</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 31 "C:\xampp\htdocs\UC-4\at02\Views\Pacote\index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<at02.Models.Pacote>> Html { get; private set; }
    }
}
#pragma warning restore 1591
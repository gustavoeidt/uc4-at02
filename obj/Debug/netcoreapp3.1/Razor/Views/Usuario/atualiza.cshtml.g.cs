#pragma checksum "C:\xampp\htdocs\UC-4\at02\Views\Usuario\atualiza.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "873086d5c20ed34a0c6b20818893df62a1a2a7b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_atualiza), @"mvc.1.0.view", @"/Views/Usuario/atualiza.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"873086d5c20ed34a0c6b20818893df62a1a2a7b5", @"/Views/Usuario/atualiza.cshtml")]
    public class Views_Usuario_atualiza : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<at02.Models.Usuario>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\xampp\htdocs\UC-4\at02\Views\Usuario\atualiza.cshtml"
  
    ViewData["Title"] = ViewBag.usuario.nome;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 4 "C:\xampp\htdocs\UC-4\at02\Views\Usuario\atualiza.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\xampp\htdocs\UC-4\at02\Views\Usuario\atualiza.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\xampp\htdocs\UC-4\at02\Views\Usuario\atualiza.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\xampp\htdocs\UC-4\at02\Views\Usuario\atualiza.cshtml"
Write(Html.EditorForModel());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p style=\"margin-top: 20px; text-align: right\";>\r\n        <input type=\"submit\" value=\"Atualizar\" class=\"btn btn-primary\"/>\r\n    </p>\r\n");
#nullable restore
#line 16 "C:\xampp\htdocs\UC-4\at02\Views\Usuario\atualiza.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<at02.Models.Usuario> Html { get; private set; }
    }
}
#pragma warning restore 1591

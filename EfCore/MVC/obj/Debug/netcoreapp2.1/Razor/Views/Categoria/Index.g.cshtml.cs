#pragma checksum "/home/yuri/public_html/AspNetCoreCurso/EfCore/MVC/Views/Categoria/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d2d2a40b8ccd10e0d9724a959747c2ed8a89420"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categoria_Index), @"mvc.1.0.view", @"/Views/Categoria/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Categoria/Index.cshtml", typeof(AspNetCore.Views_Categoria_Index))]
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
#line 1 "/home/yuri/public_html/AspNetCoreCurso/EfCore/MVC/Views/_ViewImports.cshtml"
using MVC;

#line default
#line hidden
#line 2 "/home/yuri/public_html/AspNetCoreCurso/EfCore/MVC/Views/_ViewImports.cshtml"
using MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d2d2a40b8ccd10e0d9724a959747c2ed8a89420", @"/Views/Categoria/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d7a8f56340c239c091cff637a00cc2fdf252300", @"/Views/_ViewImports.cshtml")]
    public class Views_Categoria_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Dominio.Entidades.Categoria>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 456, true);
            WriteLiteral(@"
<h2>Categorias</h2>

<div class=""container"">
    <div class=""row"">
        <a href=""/Categoria/Salvar"" class=""btn btn-primary"">Nova Categoria</a>
    </div>    
</div>

<div class=""container"">
    <div class=""row"">
        <div class=""col-md-12"">
            <table class=""table table-hover"">
                <thead>
                    <tr>
                        <th>Nome</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 21 "/home/yuri/public_html/AspNetCoreCurso/EfCore/MVC/Views/Categoria/Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(575, 61, true);
            WriteLiteral("                        <tr>\n                            <td>");
            EndContext();
            BeginContext(637, 9, false);
#line 24 "/home/yuri/public_html/AspNetCoreCurso/EfCore/MVC/Views/Categoria/Index.cshtml"
                           Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(646, 73, true);
            WriteLiteral("</td>\n                            <td>\n                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 719, "\"", 752, 2);
            WriteAttributeValue("", 726, "/Categoria/Editar/", 726, 18, true);
#line 26 "/home/yuri/public_html/AspNetCoreCurso/EfCore/MVC/Views/Categoria/Index.cshtml"
WriteAttributeValue("", 744, item.Id, 744, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(753, 137, true);
            WriteLiteral(" class=\"btn btn-primary\">Editar</a>\n                            </td>\n                            <td>\n                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 890, "\"", 924, 2);
            WriteAttributeValue("", 897, "/Categoria/Excluir/", 897, 19, true);
#line 29 "/home/yuri/public_html/AspNetCoreCurso/EfCore/MVC/Views/Categoria/Index.cshtml"
WriteAttributeValue("", 916, item.Id, 916, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(925, 100, true);
            WriteLiteral(" class=\"btn btn-danger\">Excluir</a>\n                            </td>\n                        </tr>\n");
            EndContext();
#line 32 "/home/yuri/public_html/AspNetCoreCurso/EfCore/MVC/Views/Categoria/Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1047, 78, true);
            WriteLiteral("                </tbody>\n            </table>\n        </div>\n    </div>\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Dominio.Entidades.Categoria>> Html { get; private set; }
    }
}
#pragma warning restore 1591
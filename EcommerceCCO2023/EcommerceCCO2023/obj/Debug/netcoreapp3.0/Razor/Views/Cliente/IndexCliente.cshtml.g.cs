<<<<<<< HEAD
#pragma checksum "C:\Users\Miranda\Documents\Ecommerce\ecommerce-valeria\EcommerceCCO2023\EcommerceCCO2023\Views\Cliente\IndexCliente.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0db4ccb23bbb959190d30750c2384e94e9a9ec767256fc14407f69957a98fc3a"
=======
#pragma checksum "C:\Users\Lagoa\OneDrive\Área de Trabalho\EcommerceValeria\EcommerceCCO2023\EcommerceCCO2023\Views\Cliente\IndexCliente.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "daa79e00eaaaabfe74e39a2a93af607f780b85284dc3f174bc2d68643c7d471f"
>>>>>>> iago
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_IndexCliente), @"mvc.1.0.view", @"/Views/Cliente/IndexCliente.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Miranda\Documents\Ecommerce\ecommerce-valeria\EcommerceCCO2023\EcommerceCCO2023\Views\_ViewImports.cshtml"
using EcommerceCCO2023;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Miranda\Documents\Ecommerce\ecommerce-valeria\EcommerceCCO2023\EcommerceCCO2023\Views\_ViewImports.cshtml"
using EcommerceCCO2023.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"daa79e00eaaaabfe74e39a2a93af607f780b85284dc3f174bc2d68643c7d471f", @"/Views/Cliente/IndexCliente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d4cf9a087e6dcad1b435963ec34b4d4e953f6daf5173aab5e26dc8ecee89b3a1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cliente_IndexCliente : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Produto>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Miranda\Documents\Ecommerce\ecommerce-valeria\EcommerceCCO2023\EcommerceCCO2023\Views\Cliente\IndexCliente.cshtml"
  
    Layout = "_LayoutCliente";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table table-striped table-hover\">\r\n");
#nullable restore
#line 8 "C:\Users\Miranda\Documents\Ecommerce\ecommerce-valeria\EcommerceCCO2023\EcommerceCCO2023\Views\Cliente\IndexCliente.cshtml"
     if (Model != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>Código</th>\r\n            <th>Produto</th>\r\n            <th>Descrição</th>\r\n            <th>Preço</th>\r\n            <th>Categoria</th>\r\n            <th></th>\r\n        </tr>\r\n");
#nullable restore
#line 19 "C:\Users\Miranda\Documents\Ecommerce\ecommerce-valeria\EcommerceCCO2023\EcommerceCCO2023\Views\Cliente\IndexCliente.cshtml"
         foreach (var p in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"product-row\">\r\n                <td>");
#nullable restore
#line 22 "C:\Users\Miranda\Documents\Ecommerce\ecommerce-valeria\EcommerceCCO2023\EcommerceCCO2023\Views\Cliente\IndexCliente.cshtml"
               Write(p.IdProduto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\Miranda\Documents\Ecommerce\ecommerce-valeria\EcommerceCCO2023\EcommerceCCO2023\Views\Cliente\IndexCliente.cshtml"
               Write(p.NomeProd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\Miranda\Documents\Ecommerce\ecommerce-valeria\EcommerceCCO2023\EcommerceCCO2023\Views\Cliente\IndexCliente.cshtml"
               Write(p.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\Miranda\Documents\Ecommerce\ecommerce-valeria\EcommerceCCO2023\EcommerceCCO2023\Views\Cliente\IndexCliente.cshtml"
               Write(p.Valor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\Miranda\Documents\Ecommerce\ecommerce-valeria\EcommerceCCO2023\EcommerceCCO2023\Views\Cliente\IndexCliente.cshtml"
               Write(p.Categoria.NomeCategoria);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a class=\"btn btn-sm btn-success\"");
            BeginWriteAttribute("href", " href=\"", 722, "\"", 757, 2);
            WriteAttributeValue("", 729, "/Produto/Update/", 729, 16, true);
#nullable restore
#line 28 "C:\Users\Miranda\Documents\Ecommerce\ecommerce-valeria\EcommerceCCO2023\EcommerceCCO2023\Views\Cliente\IndexCliente.cshtml"
WriteAttributeValue("", 745, p.IdProduto, 745, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a>\r\n                    <a class=\"btn btn-sm btn-warning\"");
            BeginWriteAttribute("href", " href=\"", 824, "\"", 859, 2);
            WriteAttributeValue("", 831, "/Produto/Delete/", 831, 16, true);
#nullable restore
#line 29 "C:\Users\Miranda\Documents\Ecommerce\ecommerce-valeria\EcommerceCCO2023\EcommerceCCO2023\Views\Cliente\IndexCliente.cshtml"
WriteAttributeValue("", 847, p.IdProduto, 847, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Apagar</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 32 "C:\Users\Miranda\Documents\Ecommerce\ecommerce-valeria\EcommerceCCO2023\EcommerceCCO2023\Views\Cliente\IndexCliente.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\Miranda\Documents\Ecommerce\ecommerce-valeria\EcommerceCCO2023\EcommerceCCO2023\Views\Cliente\IndexCliente.cshtml"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td> VOLTOU NULL </td>\r\n    </tr>\r\n");
#nullable restore
#line 39 "C:\Users\Miranda\Documents\Ecommerce\ecommerce-valeria\EcommerceCCO2023\EcommerceCCO2023\Views\Cliente\IndexCliente.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n\r\n<a class=\"btn btn-primary\" href=\"/Produto/Create\">Adicionar</a>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Produto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\Pages\AgregarNuevaPlanta.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eae9f20ac0acc42d9082909eed9462f228c1961a"
// <auto-generated/>
#pragma warning disable 1591
namespace Tu_Jardin_App.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\_Imports.razor"
using Tu_Jardin_App.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\_Imports.razor"
using Tu_Jardin_App.Client.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/plantas/agregarnueva")]
    public partial class AgregarNuevaPlanta : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"/css/plantas.css\" rel=\"stylesheet\">\n<link href=\"/css/plantasusuario.css\" rel=\"stylesheet\">\n\n");
            __builder.AddMarkupContent(1, @"<div class=""page-background-class""><div class=""usuariocard""><h4> Añadir </h4>

        <form action=""/plantas""><table><tr><td><p class=""info"" style=""text-align: right; margin-right: 1vw;"">Nombre de la Planta: </p></td>
                    <td><input type=""text"" placeholder=""Nombre"" style=""width: 100%;""></td></tr>
                <tr><td><input class=""boton"" style=""width: 10vw;"" type=""submit"" value=""Crear""></td>

                    <td><a href=""/plantas""><input class=""boton"" style=""width: 10vw;"" type=""button"" value=""Salir""></a></td></tr></table></form></div></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

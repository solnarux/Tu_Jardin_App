#pragma checksum "C:\Users\solna\source\repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\Pages\Plantas\NuevaPlanta.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66afc67e044913049530d7d1b68b74623dadd3a6"
// <auto-generated/>
#pragma warning disable 1591
namespace Tu_Jardin_App.Client.Pages.Plantas
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\solna\source\repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\solna\source\repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\solna\source\repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\solna\source\repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\solna\source\repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\solna\source\repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\solna\source\repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\solna\source\repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\solna\source\repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\_Imports.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\solna\source\repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\_Imports.razor"
using Microsoft.Extensions.Primitives;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\solna\source\repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\solna\source\repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\_Imports.razor"
using Tu_Jardin_App.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\solna\source\repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\_Imports.razor"
using Tu_Jardin_App.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\solna\source\repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\_Imports.razor"
using Tu_Jardin_App.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\solna\source\repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\_Imports.razor"
using Tu_Jardin_App.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\solna\source\repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\_Imports.razor"
using Tu_Jardin_App.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/plantas/nueva")]
    public partial class NuevaPlanta : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"/css/plantas.css\" rel=\"stylesheet\">\r\n<link href=\"/css/plantasusuario.css\" rel=\"stylesheet\">\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "page-background-class");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "usuariocard");
            __builder.AddMarkupContent(5, "<h4> Añadir Plantas </h4>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Users\solna\source\repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\Pages\Plantas\NuevaPlanta.razor"
                         plant

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Users\solna\source\repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\Pages\Plantas\NuevaPlanta.razor"
                                          HandleSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(10, "table");
                __builder2.OpenElement(11, "tr");
                __builder2.AddMarkupContent(12, "<td><p class=\"info\" style=\"text-align: right; margin-right: 1vw;\">Nombre: </p></td>\r\n                    ");
                __builder2.OpenElement(13, "td");
                __builder2.OpenElement(14, "input");
                __builder2.AddAttribute(15, "type", "text");
                __builder2.AddAttribute(16, "placeholder", 
#nullable restore
#line 16 "C:\Users\solna\source\repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\Pages\Plantas\NuevaPlanta.razor"
                                                         plant.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(17, "style", "width: 100%;");
                __builder2.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\solna\source\repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\Pages\Plantas\NuevaPlanta.razor"
                                                                                                        plant.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => plant.Name = __value, plant.Name));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n                ");
                __builder2.OpenElement(21, "tr");
                __builder2.AddMarkupContent(22, "<td><p class=\"info\" style=\"text-align: right; margin-right: 1vw;\">Sembrada en: </p></td>\r\n                    ");
                __builder2.OpenElement(23, "td");
                __builder2.OpenElement(24, "input");
                __builder2.AddAttribute(25, "type", "date");
                __builder2.AddAttribute(26, "placeholder", 
#nullable restore
#line 20 "C:\Users\solna\source\repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\Pages\Plantas\NuevaPlanta.razor"
                                                         DateTime.Now

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(27, "style", "width: 100%;");
                __builder2.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\solna\source\repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\Pages\Plantas\NuevaPlanta.razor"
                                                                                                          plant.Seeddate

#line default
#line hidden
#nullable disable
                , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => plant.Seeddate = __value, plant.Seeddate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                ");
                __builder2.AddMarkupContent(31, "<tr><td><input class=\"btn btn-success\" style=\"width: 10vw;\" type=\"submit\" value=\"Crear\"></td>\r\n\r\n                    <td><a href=\"/plantas\" class=\"btn btn-success\" style=\"width: 10vw\"> Cancelar </a></td></tr>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\solna\source\repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\Pages\Plantas\NuevaPlanta.razor"
       

    [CascadingParameter]
    private Task<AuthenticationState> _authState { get; set; }

    private AuthenticationState authState;

    public Plant plant = new Plant();


    public string Type { get; set; }

    public string Img { get; set; }

    protected override async Task OnInitializedAsync()
    {


        authState = await _authState;

        plant.Seeddate = DateTime.Now;

        StringValues Tipo;
        StringValues Imagen;
        var uri = NavigationManager.ToAbsoluteUri(NavigationManager.Uri);

        if (QueryHelpers.ParseQuery(uri.Query).TryGetValue("Tipo", out Tipo))
        {
            Type = Tipo;

        }

        if (QueryHelpers.ParseQuery(uri.Query).TryGetValue("Img", out Imagen))
        {
            Img = Imagen;

        }

        plant.Type = Type;
        plant.Img = Img;

        

    }

    async void HandleSubmit()
    {

        User user = await PlantService.GetUser(authState.User.Identity.Name);

        user.Plants += 1;

        Achieve achieve = new Achieve();

        plant.Owner = user.UserName;

        plant.Email = user.Email;

        plant.Achievements = achieve;

        await PlantService.CreatePlant(plant);

        await PlantService.UpdateUser(user, user.Email);

        NavigationManager.NavigateTo("/plantas");



    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPlantService PlantService { get; set; }
    }
}
#pragma warning restore 1591

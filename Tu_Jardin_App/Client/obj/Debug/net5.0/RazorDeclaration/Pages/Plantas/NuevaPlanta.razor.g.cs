// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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

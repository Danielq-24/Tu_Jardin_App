#pragma checksum "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\Pages\Prueba2.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e19f6c47165a6172c2d18914523646dd4b1dabf"
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
#nullable restore
#line 12 "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\_Imports.razor"
using Tu_Jardin_App.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\_Imports.razor"
using Tu_Jardin_App.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/prueba/{id:int}")]
    public partial class Prueba2 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Planta</h3>\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, 
#nullable restore
#line 5 "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\Pages\Prueba2.razor"
     planta.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenElement(4, "p");
            __builder.AddContent(5, 
#nullable restore
#line 6 "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\Pages\Prueba2.razor"
     planta.Type

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.OpenElement(7, "p");
            __builder.AddContent(8, 
#nullable restore
#line 7 "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\Pages\Prueba2.razor"
     planta.Seeddate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.OpenElement(10, "img");
            __builder.AddAttribute(11, "src", 
#nullable restore
#line 8 "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\Pages\Prueba2.razor"
           planta.Img

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.OpenElement(13, "p");
            __builder.AddContent(14, 
#nullable restore
#line 9 "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\Pages\Prueba2.razor"
     planta.Owner

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\Pages\Prueba2.razor"
       

    [Parameter]
    public int id { get; set; }

    Plant planta = new Plant();

    protected override async Task OnInitializedAsync()
    {
        planta = await PlantService.GetPlant(id);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPlantService PlantService { get; set; }
    }
}
#pragma warning restore 1591
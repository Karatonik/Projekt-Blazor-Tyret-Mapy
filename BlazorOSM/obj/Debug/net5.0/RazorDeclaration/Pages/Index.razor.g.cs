// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorOSM.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\projekty\C\c#\Sulima projekt\Api\BlazorOSM\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\projekty\C\c#\Sulima projekt\Api\BlazorOSM\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\projekty\C\c#\Sulima projekt\Api\BlazorOSM\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\projekty\C\c#\Sulima projekt\Api\BlazorOSM\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\projekty\C\c#\Sulima projekt\Api\BlazorOSM\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\projekty\C\c#\Sulima projekt\Api\BlazorOSM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\projekty\C\c#\Sulima projekt\Api\BlazorOSM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\projekty\C\c#\Sulima projekt\Api\BlazorOSM\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\projekty\C\c#\Sulima projekt\Api\BlazorOSM\_Imports.razor"
using BlazorOSM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\projekty\C\c#\Sulima projekt\Api\BlazorOSM\_Imports.razor"
using BlazorOSM.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\projekty\C\c#\Sulima projekt\Api\BlazorOSM\Pages\Index.razor"
using BlazorOSM.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\projekty\C\c#\Sulima projekt\Api\BlazorOSM\Pages\Index.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\projekty\C\c#\Sulima projekt\Api\BlazorOSM\Pages\Index.razor"
using BlazorOSM.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "E:\projekty\C\c#\Sulima projekt\Api\BlazorOSM\Pages\Index.razor"
  
    DataRequest dataRequest = new DataRequest();

    String address = "";
    String xy;
    String cityAndStreet;
    IJSObjectReference mapModule;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            mapModule = await JsRuntime.InvokeAsync<IJSObjectReference>(
                "import", "./OSM.js");

        }
    }

    Task setMap() =>
        mapModule.InvokeVoidAsync("onButtonGet").AsTask();


    async Task GetData()
    {
        
        address = "Proszę czekać...";
        cityAndStreet = await http.GetJsonAsync<String>("https://localhost:5001/api/GetStreet");
        address = cityAndStreet;
        Console.WriteLine(cityAndStreet);
    }

    async Task GetGeo()
    {
        await mapModule.InvokeVoidAsync("onButtonGet").AsTask();
    }


    async Task SendCord()
    {
        dataRequest.City = cityAndStreet.Split(",")[0];//todo
        dataRequest.StreetName = cityAndStreet.Split(",")[1];//todo
        dataRequest.StreetCordX = await mapModule.InvokeAsync<float>("getX");
        dataRequest.StreetCordY = await mapModule.InvokeAsync<float>("getY");

        Console.WriteLine(dataRequest.StreetCordX + " " + dataRequest.StreetCordY);

        await http.PostJsonAsync<Boolean>("https://localhost:5001/api/SaveToDatabase", dataRequest);

    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
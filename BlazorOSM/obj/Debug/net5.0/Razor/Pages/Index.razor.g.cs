#pragma checksum "E:\projekty\C\c#\Sulima projekt\Api\BlazorOSM\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cc0d77e36d4a9912cc9e8a3130ee7592c592d6d"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddMarkupContent(2, "<h1>Mateusz Kalksztejn , Filip Nowicki</h1>\r\n    ");
            __builder.AddMarkupContent(3, "<h2 class=\"text-muted\">Programowanie w środowisku Windows Projekt</h2>\r\n    <div id=\"map\"></div>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "type", "button");
            __builder.AddAttribute(7, "class", "btn btn-primary");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "E:\projekty\C\c#\Sulima projekt\Api\BlazorOSM\Pages\Index.razor"
                                                                GetData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(9, "Pobierz ulice");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "type", "button");
            __builder.AddAttribute(13, "class", "btn btn-primary");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "E:\projekty\C\c#\Sulima projekt\Api\BlazorOSM\Pages\Index.razor"
                                                                GetGeo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(15, "Załaduj mapę");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "type", "button");
            __builder.AddAttribute(19, "class", "btn btn-primary");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "E:\projekty\C\c#\Sulima projekt\Api\BlazorOSM\Pages\Index.razor"
                                                                SendCord

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(21, "Wyślij");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.OpenElement(23, "label");
            __builder.AddAttribute(24, "id", "address");
            __builder.AddContent(25, 
#nullable restore
#line 16 "E:\projekty\C\c#\Sulima projekt\Api\BlazorOSM\Pages\Index.razor"
                         address

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.AddMarkupContent(27, "<div><label id=\"xy\"></label></div>");
            __builder.CloseElement();
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
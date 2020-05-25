#pragma checksum "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\People\CreatePerson.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63a684a303fc3a674d0dcac964b88ebd24dd1404"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMovie.Pages.People
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\_Imports.razor"
using BlazorMovie;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\_Imports.razor"
using BlazorMovie.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\_Imports.razor"
using BlazorMovie.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\_Imports.razor"
using BlazorMovie.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\_Imports.razor"
using BlazorMovie.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\_Imports.razor"
using BlazorMovie.Repository;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/People/CreatePerson")]
    public partial class CreatePerson : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>CreatePerson</h3>\r\n");
            __builder.OpenComponent<BlazorMovie.Pages.People.PersonForm>(1);
            __builder.AddAttribute(2, "Person", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorMovie.Shared.Entities.Person>(
#nullable restore
#line 5 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\People\CreatePerson.razor"
                    Person

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSumbit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 5 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\People\CreatePerson.razor"
                                           Create

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\People\CreatePerson.razor"
       
    Person Person = new Person();
    private async Task Create()
    {
        try
        {
            Console.WriteLine("Creating Person......");
            await personRepo.CreatePerson(Person);
            navmanager.NavigateTo("People");
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navmanager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPersonRepository personRepo { get; set; }
    }
}
#pragma warning restore 1591

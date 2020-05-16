#pragma checksum "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\MovieForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f776aa9be4a3c9a0044ee35fedd45aed2b04e8c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorMovie.Pages.Movies
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
    public partial class MovieForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\MovieForm.razor"
       
    [Parameter] public Movie Movie { get; set; }
    [Parameter] public EventCallback OnValidSubmit { get; set; }
    [Parameter] public List<Genre> SelectedGenre { get; set; } = new List<Genre>();
    [Parameter] public List<Genre> NotSelectedGenre { get; set; } = new List<Genre>();
    [Parameter] public List<Person> SelectedActor { get; set; } = new List<Person>();

    private List<MultipleSelectorModel> Selected { get; set; }
    private List<MultipleSelectorModel> NoSelected { get; set; }

    private string imageURl;

    protected override void OnInitialized()
    {
        Selected = SelectedGenre.Select(x => new MultipleSelectorModel { Key = x.Id.ToString(), Value = x.Name }).ToList();
        NoSelected = NotSelectedGenre.Select(x => new MultipleSelectorModel { Key = x.Id.ToString(), Value = x.Name }).ToList();

        imageURl = Movie.Poster;
        Movie.Poster = null;
    }
    void OnSelectedImage(string imageBase64)
    {
        Movie.Poster = imageBase64;
        imageURl = null;
    }
    private async Task<IEnumerable<Person>> SearchMethod(string searchText)
    {
        await Task.Delay(2000);

        return new List<Person>() { new Person { Id=1, Name="Mariah", BioGraphy="hahhaha", DateOfBirth=DateTime.Parse("1991-06-04"), Picture="https://scontent.fuln8-1.fna.fbcdn.net/v/t1.0-9/s960x960/81639706_10157900365092766_5021815628093194240_o.jpg?_nc_cat=104&_nc_sid=dd9801&_nc_ohc=5VTezNNUB6MAX9hZFoY&_nc_ht=scontent.fuln8-1.fna&_nc_tp=7&oh=96416a7c3319c3d88fbb83b38cc4d728&oe=5EDF0307" },
                                    new Person { Id=2, Name="Caray", BioGraphy="Muuhaha", DateOfBirth=DateTime.Parse("1992-05-09"), Picture="https://bloximages.chicago2.vip.townnews.com/santamariatimes.com/content/tncms/assets/v3/editorial/0/25/025939fd-11e8-534c-86ad-37ebf6fb3ef8/5dfc964c54ac5.image.jpg"}};
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

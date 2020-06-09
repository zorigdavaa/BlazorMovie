#pragma checksum "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\DetailsMovie.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae1d5a65e5b443836be97e0791a97431c7e07489"
// <auto-generated/>
#pragma warning disable 1591
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
#nullable restore
#line 14 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\_Imports.razor"
using BlazorMovie.Shared.DTO_s;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\_Imports.razor"
using BlazorMovie.Pages.Movies;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/movie/{MovieId:int}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/movie/{MovieId:int}/{MovieName}")]
    public partial class DetailsMovie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>DetailsMovie</h3>\r\n");
#nullable restore
#line 5 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\DetailsMovie.razor"
 if (model == null)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "Loading... ");
#nullable restore
#line 7 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\DetailsMovie.razor"
                            
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.OpenElement(3, "h2");
            __builder.AddContent(4, 
#nullable restore
#line 11 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\DetailsMovie.razor"
         model.Movie.Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(5, " (");
            __builder.AddContent(6, 
#nullable restore
#line 11 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\DetailsMovie.razor"
                             model.Movie.ReleaseDate.Value.ToString("yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(7, ") ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 12 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\DetailsMovie.razor"
    for (int i = 0; i < model.Genres.Count; i++)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\DetailsMovie.razor"
         if (i < model.Genres.Count - 1)
        {
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, 
#nullable restore
#line 16 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\DetailsMovie.razor"
             LinkGenre(model.Genres[i])

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(10, ", ");
#nullable restore
#line 16 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\DetailsMovie.razor"
                                                      ;
        }
        else
        {
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, 
#nullable restore
#line 20 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\DetailsMovie.razor"
             LinkGenre(model.Genres[i])

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 20 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\DetailsMovie.razor"
                                       
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\DetailsMovie.razor"
         
    }
    

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(12, " |  ");
            __builder.OpenElement(13, "span");
            __builder.AddContent(14, 
#nullable restore
#line 23 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\DetailsMovie.razor"
                            model.Movie.ReleaseDate.Value.ToString("dd MMM yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.AddContent(16, "    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "style", "display:flex;");
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenElement(20, "span");
            __builder.AddAttribute(21, "style", "@*display:inline-block;*@ margin-right:5px");
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "img");
            __builder.AddAttribute(24, "src", 
#nullable restore
#line 27 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\DetailsMovie.razor"
                       model.Movie.Poster

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(25, "style", "width:225px; height:315px");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenElement(28, "iframe");
            __builder.AddAttribute(29, "width", "560");
            __builder.AddAttribute(30, "height", "315");
            __builder.AddAttribute(31, "src", "https://www.youtube.com/embed/" + (
#nullable restore
#line 29 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\DetailsMovie.razor"
                                                                             model.Movie.Trailer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "frameborder", "0");
            __builder.AddAttribute(33, "allow", "accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture");
            __builder.AddAttribute(34, "allowfullscreen", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n    ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "style", "margin-top:10px;");
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.AddMarkupContent(40, "<h3>Summary</h3>\r\n        ");
            __builder.OpenElement(41, "div");
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.OpenComponent<BlazorMovie.Shared.RenderMarkDown>(43);
            __builder.AddAttribute(44, "MarkdownContent", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\DetailsMovie.razor"
                                              model.Movie.Summary

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n    ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "style", "margin-top:10px");
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.AddMarkupContent(51, "<h3>Actors</h3>\r\n        ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "style", "display:flex; flex-direction:column");
            __builder.AddMarkupContent(54, "\r\n");
#nullable restore
#line 41 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\DetailsMovie.razor"
             foreach (var actor in model.Actors)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(55, "                ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "style", "margin-bottom:2px;");
            __builder.AddMarkupContent(58, "\r\n                    ");
            __builder.OpenElement(59, "img");
            __builder.AddAttribute(60, "style", "width:50px");
            __builder.AddAttribute(61, "src", 
#nullable restore
#line 44 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\DetailsMovie.razor"
                                                  actor.Picture

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                    ");
            __builder.OpenElement(63, "span");
            __builder.AddAttribute(64, "style", "display:inline-block; width:200px");
            __builder.OpenElement(65, "a");
            __builder.AddAttribute(66, "href", "/person/" + (
#nullable restore
#line 45 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\DetailsMovie.razor"
                                                                                      actor.Id

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 45 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\DetailsMovie.razor"
                                                                                                actor.Name.Replace(" ","-")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(67, 
#nullable restore
#line 45 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\DetailsMovie.razor"
                                                                                                                              actor.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                    ");
            __builder.AddMarkupContent(69, "<span style=\"display:inline-block; width:45px;\">...</span>\r\n                    ");
            __builder.OpenElement(70, "span");
            __builder.AddContent(71, 
#nullable restore
#line 47 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\DetailsMovie.razor"
                           actor.Character

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n");
#nullable restore
#line 49 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\DetailsMovie.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(74, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n");
#nullable restore
#line 52 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\DetailsMovie.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\DetailsMovie.razor"
       
    [Parameter] public int MovieId { get; set; }
    [Parameter] public string MovieName { get; set; }
    private RenderFragment<Genre> LinkGenre = (genre) =>

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenElement(77, "a");
            __builder2.AddAttribute(78, "href", "movies/search?genreId=" + (
#nullable restore
#line 58 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\DetailsMovie.razor"
                                                                                         genre.Id

#line default
#line hidden
#nullable disable
            ));
            __builder2.AddContent(79, 
#nullable restore
#line 58 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\DetailsMovie.razor"
                                                                                                    genre.Name

#line default
#line hidden
#nullable disable
            );
            __builder2.CloseElement();
        }
#nullable restore
#line 58 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\DetailsMovie.razor"
                                                                                                                  ;
DetailsMovieDTO model;

protected async override Task OnInitializedAsync()
{
model = await movieRepo.GetDetailsMovieDto(MovieId);

}


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMovieRepository movieRepo { get; set; }
    }
}
#pragma warning restore 1591

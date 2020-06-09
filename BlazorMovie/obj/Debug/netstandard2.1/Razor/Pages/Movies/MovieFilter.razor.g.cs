#pragma checksum "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\MovieFilter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "879587c903e30baf5bfd90571dec8a2ee8cda646"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/movies/search")]
    public partial class MovieFilter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Search Movie</h3>\r\n\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\MovieFilter.razor"
                 filterMovieDTO

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "form-inline");
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "form-group mb-2");
                __builder2.AddMarkupContent(10, "\r\n\r\n        ");
                __builder2.OpenElement(11, "input");
                __builder2.AddAttribute(12, "type", "text");
                __builder2.AddAttribute(13, "class", "form-control");
                __builder2.AddAttribute(14, "id", "title");
                __builder2.AddAttribute(15, "placeholder", "Search");
                __builder2.AddAttribute(16, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 13 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\MovieFilter.razor"
                                                                                             (KeyboardEventArgs e)=>TitleKeyPress(e)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\MovieFilter.razor"
                            filterMovieDTO.TItle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => filterMovieDTO.TItle = __value, filterMovieDTO.TItle));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n\r\n    ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "form-group mb-2");
                __builder2.AddMarkupContent(23, "\r\n        ");
                __builder2.OpenElement(24, "select");
                __builder2.AddAttribute(25, "class", "form-control");
                __builder2.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\MovieFilter.razor"
                       filterMovieDTO.GenreId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => filterMovieDTO.GenreId = __value, filterMovieDTO.GenreId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(28, "\r\n            ");
                __builder2.OpenElement(29, "option");
                __builder2.AddAttribute(30, "value", "0");
                __builder2.AddContent(31, "--Select something");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n");
#nullable restore
#line 19 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\MovieFilter.razor"
             foreach (var genre in Genres)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(33, "                ");
                __builder2.OpenElement(34, "option");
                __builder2.AddAttribute(35, "value", 
#nullable restore
#line 21 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\MovieFilter.razor"
                                genre.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(36, 
#nullable restore
#line 21 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\MovieFilter.razor"
                                           genre.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n");
#nullable restore
#line 22 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\MovieFilter.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(38, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n    ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-group mx-sm-3 mb-2");
                __builder2.AddMarkupContent(43, "\r\n        ");
                __builder2.OpenElement(44, "input");
                __builder2.AddAttribute(45, "type", "checkbox");
                __builder2.AddAttribute(46, "class", "form-check-input");
                __builder2.AddAttribute(47, "id", "upcomingRelease");
                __builder2.AddAttribute(48, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\MovieFilter.razor"
                                                                                    filterMovieDTO.UpcomingReleases

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => filterMovieDTO.UpcomingReleases = __value, filterMovieDTO.UpcomingReleases));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n        ");
                __builder2.AddMarkupContent(51, "<label for=\"upcomingRelease\" class=\"form-check-label\">UpComing Releases</label>\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n    ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "form-group mx-sm-3 mb-2");
                __builder2.AddMarkupContent(55, "\r\n        ");
                __builder2.OpenElement(56, "input");
                __builder2.AddAttribute(57, "type", "checkbox");
                __builder2.AddAttribute(58, "class", "form-check-input");
                __builder2.AddAttribute(59, "id", "InTheather");
                __builder2.AddAttribute(60, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\MovieFilter.razor"
                                                                               filterMovieDTO.InTheaters

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(61, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => filterMovieDTO.InTheaters = __value, filterMovieDTO.InTheaters));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n        ");
                __builder2.AddMarkupContent(63, "<label for=\"InTheather\" class=\"form-check-label\">In Theather</label>\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n    ");
                __builder2.OpenElement(65, "button");
                __builder2.AddAttribute(66, "type", "button");
                __builder2.AddAttribute(67, "class", "btn btn-primary mb-2 mx-sm-3");
                __builder2.AddAttribute(68, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\MovieFilter.razor"
                                                                         SearchForMovies

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(69, "Filter");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n    ");
                __builder2.OpenElement(71, "button");
                __builder2.AddAttribute(72, "type", "button");
                __builder2.AddAttribute(73, "class", "btn btn-primary mb-2  ");
                __builder2.AddAttribute(74, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\MovieFilter.razor"
                                                                   Clear

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(75, "Clear");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(78, "\r\n\r\n");
            __builder.OpenComponent<BlazorMovie.Shared.MoviesList>(79);
            __builder.AddAttribute(80, "Movies", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazorMovie.Shared.Entities.Movie>>(
#nullable restore
#line 40 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\MovieFilter.razor"
                    Movies

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(81, "\r\n");
            __builder.OpenComponent<BlazorMovie.Shared.Pagination>(82);
            __builder.AddAttribute(83, "CurrentPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 42 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\MovieFilter.razor"
                         filterMovieDTO.Page

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(84, "TotalAmountPages", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 42 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\MovieFilter.razor"
                                                                totalAmountPages

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(85, "SelectedPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 42 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\MovieFilter.razor"
                                                                                                SelectedPage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Movies\MovieFilter.razor"
       
    #region Properties
    List<Movie> Movies;
    List<Genre> Genres = new List<Genre>();
    FilterMovieDTO filterMovieDTO = new FilterMovieDTO();
    int totalAmountPages;
    #endregion

    protected async Task SelectedPage(int page)
    {
        filterMovieDTO.Page = page;
        await LoadMovies();
    }

    protected async Task SearchForMovies()
    {
        await LoadMovies();
    }

    protected async Task Clear()
    {
        filterMovieDTO.TItle = "";
        filterMovieDTO.GenreId = 0;
        filterMovieDTO.UpcomingReleases = false;
        filterMovieDTO.InTheaters = false;
        await LoadMovies();

    }
    private async Task TitleKeyPress(KeyboardEventArgs e)
    {
        if (e.Key == "Enter")
        {
            await LoadMovies();
        }

    }

    private void FillFilterWithQueryStrings(Dictionary<string, string> queryString)
    {
        if (queryString.ContainsKey("genreId"))
        {
            filterMovieDTO.GenreId = int.Parse(queryString["genreId"]);
        }
        if (queryString.ContainsKey("title"))
        {
            filterMovieDTO.TItle = queryString["title"];
        }
        if (queryString.ContainsKey("genreId"))
        {
            filterMovieDTO.GenreId = int.Parse(queryString["genreId"]);
        }
        if (queryString.ContainsKey("intheaters"))
        {
            filterMovieDTO.UpcomingReleases = bool.Parse(queryString["intheaters"]);
        }
        if (queryString.ContainsKey("upcomingReleases"))
        {
            filterMovieDTO.UpcomingReleases = bool.Parse(queryString["upcomingReleases"]);
        }
        if (queryString.ContainsKey("page"))
        {
            filterMovieDTO.GenreId = int.Parse(queryString["page"]);
        }
    }

    protected override async Task OnInitializedAsync()
    {
        var queryStrings = navMan.GetQueryStrings(navMan.Uri);
        Genres = await genreRepo.GetGenres();
        if (queryStrings!=null)
        {
            FillFilterWithQueryStrings(queryStrings);
        }
            await LoadMovies();
    }

    protected async Task LoadMovies()
    {
        var queryString = GenerateQueryString();
        if (!string.IsNullOrWhiteSpace(queryString))
        {
            queryString = $"?{queryString}";
            navMan.NavigateTo("/movies/search" + queryString);
        }

        var paginatedResponse = await movieRepo.GetMoviesFiltered(filterMovieDTO);
        Movies = paginatedResponse.Response;
        totalAmountPages = paginatedResponse.TotalAmountPages;
    }
    private string GenerateQueryString()
    {
        var queryStringsDict = new Dictionary<string, string>();
        queryStringsDict["genreId"] = filterMovieDTO.GenreId.ToString();
        queryStringsDict["title"] = filterMovieDTO.TItle ?? "";
        queryStringsDict["intheaters"] = filterMovieDTO.InTheaters.ToString();
        queryStringsDict["upcomingReleases"] = filterMovieDTO.UpcomingReleases.ToString();
        queryStringsDict["page"] = filterMovieDTO.Page.ToString();

        //genreid=4&title=spider

        var defaultValue = new List<string> { "false", "", "0" };
        return string.Join("&", queryStringsDict
            .Where(x => !defaultValue.Contains(x.Value.ToLowerInvariant()))
            .Select(x=>$"{x.Key}={System.Web.HttpUtility.UrlEncode( x.Value)}"));
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navMan { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGenreRepository genreRepo { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMovieRepository movieRepo { get; set; }
    }
}
#pragma warning restore 1591

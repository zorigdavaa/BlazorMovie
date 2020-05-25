#pragma checksum "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae838ba3f4034a37621f42689da64ba0e32dbbbe"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMovie.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\r\n        ");
            __builder.AddMarkupContent(2, "<h3>Movie</h3>\r\n        ");
            __builder.OpenComponent<BlazorMovie.Shared.MoviesList>(3);
            __builder.AddAttribute(4, "Movies", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazorMovie.Shared.Entities.Movie>>(
#nullable restore
#line 6 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Index.razor"
                            movies

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __Blazor.BlazorMovie.Pages.Index.TypeInference.CreateCustomTypeAhead_0(__builder, 7, 8, 
#nullable restore
#line 11 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Index.razor"
                               SearchMethod

#line default
#line hidden
#nullable disable
            , 9, "Haih yumaa bichwel bich", 10, (context) => (__builder2) => {
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.AddContent(12, 
#nullable restore
#line 13 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Index.razor"
         context

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(13, "\r\n    ");
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Index.razor"
       
    protected List<Movie> movies;
    protected override void OnInitialized()
    {
        movies = Repository.GetMovies();
    }
    private async Task<IEnumerable<string>> SearchMethod(string searchText)
    {
        await Task.Delay(2000);
        if (searchText=="test")
        {
            return Enumerable.Empty<string>();
        }
        return new List<string>() { "Zorigoo", "Khongoroo" };
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepository Repository { get; set; }
    }
}
namespace __Blazor.BlazorMovie.Pages.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCustomTypeAhead_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Func<global::System.String, global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<TItem>>> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg2)
        {
        __builder.OpenComponent<global::BlazorMovie.Shared.CustomTypeAhead<TItem>>(seq);
        __builder.AddAttribute(__seq0, "SearchMethod", __arg0);
        __builder.AddAttribute(__seq1, "Placeholder", __arg1);
        __builder.AddAttribute(__seq2, "ResultTemplate", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

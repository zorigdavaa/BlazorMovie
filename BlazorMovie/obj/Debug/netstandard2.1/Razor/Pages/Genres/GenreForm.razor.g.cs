#pragma checksum "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Genres\GenreForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45befe685ac4edb0060f8eed0d092634d5e77197"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMovie.Pages.Genres
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
    public partial class GenreForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 3 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Genres\GenreForm.razor"
                 Genre

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 3 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Genres\GenreForm.razor"
                                       OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "form-group");
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.AddMarkupContent(12, "<label>Name:</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(13);
                __builder2.AddAttribute(14, "class", "form-control");
                __builder2.AddAttribute(15, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 8 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Genres\GenreForm.razor"
                                                     Genre.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Genre.Name = __value, Genre.Name))));
                __builder2.AddAttribute(17, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Genre.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n        ");
                __Blazor.BlazorMovie.Pages.Genres.GenreForm.TypeInference.CreateValidationMessage_0(__builder2, 19, 20, 
#nullable restore
#line 9 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Genres\GenreForm.razor"
                                  ()=>Genre.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(21, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n    ");
                __builder2.AddMarkupContent(23, "<button type=\"submit\" class=\"btn btn-primary\">Save Changes</button>\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Pages\Genres\GenreForm.razor"
       
    [Parameter] public Genre Genre { get; set; }
    [Parameter] public EventCallback OnValidSubmit { get; set; }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorMovie.Pages.Genres.GenreForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
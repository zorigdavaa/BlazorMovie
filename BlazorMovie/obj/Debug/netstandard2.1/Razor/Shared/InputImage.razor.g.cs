#pragma checksum "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Shared\InputImage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc60bfb1b6cad4bde82d8b23d9e1e9574d8b8d66"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMovie.Shared
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
#nullable restore
#line 16 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Shared\InputImage.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Shared\InputImage.razor"
using Blazor.FileReader;

#line default
#line hidden
#nullable disable
    public partial class InputImage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenElement(2, "label");
            __builder.AddContent(3, 
#nullable restore
#line 6 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Shared\InputImage.razor"
            Label

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "file");
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 8 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Shared\InputImage.razor"
                                                          ImageFileSelected

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "accept", ".jpg,.jpeg,.png");
            __builder.AddElementReferenceCapture(11, (__value) => {
#nullable restore
#line 8 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Shared\InputImage.razor"
                                 inputElement = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.OpenElement(15, "div");
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 12 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Shared\InputImage.razor"
     if (imageBase64 != null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "        ");
            __builder.OpenElement(18, "div");
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "style", "margin:10px;");
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "img");
            __builder.AddAttribute(24, "src", "data:image/jpeg;base64," + " " + (
#nullable restore
#line 16 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Shared\InputImage.razor"
                                                   imageBase64

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "style", "width:400px");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
#nullable restore
#line 19 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Shared\InputImage.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Shared\InputImage.razor"
     if (imageURL != null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(29, "        ");
            __builder.OpenElement(30, "div");
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "style", "margin:10px;");
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenElement(35, "img");
            __builder.AddAttribute(36, "src", 
#nullable restore
#line 24 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Shared\InputImage.razor"
                           imageURL

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(37, "style", "width:400px");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 27 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Shared\InputImage.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(41, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Shared\InputImage.razor"
       
    [Parameter] public string Label { get; set; }
    [Parameter] public string imageURL { get; set; }
    [Parameter] public EventCallback<string> OnSelectedImage { get; set; }
    private string imageBase64;
    ElementReference inputElement;

    async Task ImageFileSelected()
    {
        foreach (var file in await FileReaderService.CreateReference(inputElement).EnumerateFilesAsync())
        {
            await using (MemoryStream memoryStream = await file.CreateMemoryStreamAsync(4*1024))
            {
                byte[] imageBytes = new byte[memoryStream.Length];
                memoryStream.Read(imageBytes, 0, (int)memoryStream.Length);
                imageBase64 = Convert.ToBase64String(imageBytes);
                await OnSelectedImage.InvokeAsync(imageBase64);
                imageURL = null;
                StateHasChanged();
                
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileReaderService FileReaderService { get; set; }
    }
}
#pragma warning restore 1591

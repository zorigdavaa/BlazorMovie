#pragma checksum "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Shared\CustomTypeAhead.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13407bfae1c5f66df5f051319a1b5c171d93e82f"
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
#line 1 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Shared\CustomTypeAhead.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
    public partial class CustomTypeAhead<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "blazor-typeahead");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "blazored-typeahead__controls");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "type", "text");
            __builder.AddAttribute(8, "class", "blazored-typeahead__input");
            __builder.AddAttribute(9, "autocomplete", "off");
            __builder.AddAttribute(10, "placeholder", 
#nullable restore
#line 9 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Shared\CustomTypeAhead.razor"
                             Placeholder

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Shared\CustomTypeAhead.razor"
                         ShowSuggestions

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onfocusout", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 13 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Shared\CustomTypeAhead.razor"
                            onfocusout

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Shared\CustomTypeAhead.razor"
                            SearchText

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchText = __value, SearchText));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 15 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Shared\CustomTypeAhead.razor"
     if (IsSearching)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "        ");
            __builder.AddMarkupContent(18, "<div class=\"blazored-typeahead__results\">\r\n            <div class=\"blazored-typeahead__result\">\r\n                <span>Loading...</span>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 22 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Shared\CustomTypeAhead.razor"
    }
    else if (ShouldShowSuggestion())
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(19, "        ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "blazored-typeahead__results");
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 26 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Shared\CustomTypeAhead.razor"
             foreach (var item in Suggestions)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "                ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "blazored-typeahead__result");
            __builder.AddAttribute(26, "tabindex", "0");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Shared\CustomTypeAhead.razor"
                                 ()=>SelectSuggestion(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onmouseover", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Shared\CustomTypeAhead.razor"
                                   onmouseoversuggestion

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "onmouseout", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Shared\CustomTypeAhead.razor"
                                  onmouseoutsuggestion

#line default
#line hidden
#nullable disable
            ));
            __builder.SetKey(
#nullable restore
#line 28 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Shared\CustomTypeAhead.razor"
                           item

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.AddContent(31, 
#nullable restore
#line 32 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Shared\CustomTypeAhead.razor"
                     ResultTemplate(item)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 34 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Shared\CustomTypeAhead.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 36 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Shared\CustomTypeAhead.razor"
    }
    else if (ShowNotFound())
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, "        ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "blazored-typeahead__results");
            __builder.AddMarkupContent(39, "\r\n");
#nullable restore
#line 40 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Shared\CustomTypeAhead.razor"
             if (NotFoundTemplate != null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(40, "                ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "blazored-typeahead__notfound");
            __builder.AddMarkupContent(43, "\r\n                    ");
            __builder.AddContent(44, 
#nullable restore
#line 43 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Shared\CustomTypeAhead.razor"
                     NotFoundTemplate

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
#nullable restore
#line 45 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Shared\CustomTypeAhead.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(47, "                ");
            __builder.AddMarkupContent(48, "<div class=\"blazored-typeahead__notfound\">\r\n                    No Result Found\r\n                </div>\r\n");
#nullable restore
#line 51 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Shared\CustomTypeAhead.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(49, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n");
#nullable restore
#line 53 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Shared\CustomTypeAhead.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "E:\Visual studio repos\UdemyCourseRepo\Blazor Tutorial\BlazorMovie\BlazorMovie\Shared\CustomTypeAhead.razor"
       
    [Parameter] public string Placeholder { get; set; }
    [Parameter] public int MinimumLenght { get; set; } = 3;
    [Parameter] public int Debounce { get; set; } = 300;
    [Parameter] public Func<string, Task<IEnumerable<TItem>>> SearchMethod { get; set; }
    [Parameter] public RenderFragment<TItem> ResultTemplate { get; set; }
    [Parameter] public RenderFragment NotFoundTemplate { get; set; }
    [Parameter] public EventCallback<TItem> ValueChanged { get; set; }

    private bool IsSearching = false;
    private bool IsShowingSuggestions = false;
    private string _searchText = string.Empty;
    private Timer _debounceTimer;
    protected TItem[] Suggestions { get; set; } = new TItem[0];
    private bool IsMouseInSuggestion=false;

    protected override void OnInitialized()
    {
        _debounceTimer = new Timer();
        _debounceTimer.Interval = Debounce;
        _debounceTimer.AutoReset = false;
        _debounceTimer.Elapsed += Search;
        base.OnInitialized();
    }

    protected async void Search(Object source, ElapsedEventArgs e)
    {

        IsSearching = true;
        IsShowingSuggestions = false;
        await InvokeAsync(StateHasChanged);
        Suggestions = (await SearchMethod.Invoke(_searchText)).ToArray();
        IsSearching = false;
        IsShowingSuggestions = true;
        await InvokeAsync(StateHasChanged);
    }

    private string SearchText
    {
        get => _searchText;
        set
        {
            _searchText = value;
            if (value.Length == 0)
            {
                IsShowingSuggestions = false;
                _debounceTimer.Stop();
                Suggestions = new TItem[0];
            }
            else if (value.Length >= MinimumLenght)
            {
                _debounceTimer.Stop();
                _debounceTimer.Start();
            }
        }
    }
    private void ShowSuggestions()
    {
        if (Suggestions.Any())
        {
            IsShowingSuggestions = true;
        }
    }

    private bool ShouldShowSuggestion()
    {
        return IsShowingSuggestions && Suggestions.Any();
    }
    private async Task SelectSuggestion(TItem item)
    {
        SearchText = "";
        await ValueChanged.InvokeAsync(item);
    }
    private bool ShowNotFound()
    {
        return !Suggestions.Any() && IsShowingSuggestions;

    }
    private void onfocusout()
    {
        if (!IsMouseInSuggestion)
        {
            IsShowingSuggestions = false;
        }
    }
    void onmouseoversuggestion()
    {
        IsMouseInSuggestion = true;
    }
    void onmouseoutsuggestion()
    {
        IsMouseInSuggestion = false;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using BlazorMovie.Services;
using Blazor.FileReader;
using BlazorMovie.Helpers;
using BlazorMovie.Repository;
using Microsoft.AspNetCore.Components.Authorization;
using BlazorMovie.Auth;

namespace BlazorMovie
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddSingleton<IRepository, InMemoryRepository>();

            builder.Services.AddScoped<IHttpService, HttpService>();

            builder.Services.AddScoped<IGenreRepository, GenreRepository>();
            builder.Services.AddScoped<IPersonRepository, PersonRepository>();
            builder.Services.AddScoped<IMovieRepository, MovieRepository>();
            builder.Services.AddScoped<IAccountRepository, AccountRepository>();
            builder.Services.AddScoped<IRatingRepository, RatingRepository>();

            builder.Services.AddFileReaderService(options=>options.UseWasmSharedBuffer=true);

            builder.Services.AddAuthorizationCore();
            builder.Services.AddScoped<JWTAuthenticationStateProvider>();
            builder.Services.AddScoped<AuthenticationStateProvider, JWTAuthenticationStateProvider>(
                provider=>provider.GetRequiredService<JWTAuthenticationStateProvider>()
                );
            builder.Services.AddScoped<ILoginService, JWTAuthenticationStateProvider>(
                provider => provider.GetRequiredService<JWTAuthenticationStateProvider>()
                );


            await builder.Build().RunAsync();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Authorization;
namespace BlazorMovie.Auth
{
    public class DummyAuthStateProvider : AuthenticationStateProvider
    {
        public  override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var anonymous = new ClaimsIdentity( new List<Claim>() 
            {
                new Claim( ClaimTypes.Name, "Zorigoo"),
                new Claim(ClaimTypes.Role, "Admin")
            },"asd" );
            return Task.FromResult(new AuthenticationState(new ClaimsPrincipal(anonymous)));
        }
    }
}

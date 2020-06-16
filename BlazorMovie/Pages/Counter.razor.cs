using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovie.Pages
{
    public class CounterBase:ComponentBase
    {
        [CascadingParameter] private Task<AuthenticationState> AuthenticationState { get; set; }
        protected int currentCount = 0;

        protected async Task IncrementCount()
        {
            var authstate = await AuthenticationState;
            var user = authstate.User;
            if (user.Identity.IsAuthenticated)
            {
                currentCount++;
            }
            else
            {
                currentCount--;
            }

        }
    }
}

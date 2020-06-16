using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using BlazorMovie.Server.Context;
using BlazorMovie.Shared.Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorMovie.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class RatingController : ControllerBase
    {
        private readonly AppDbContext context;
        private readonly UserManager<IdentityUser> userManager;

        public RatingController(AppDbContext context, UserManager<IdentityUser> userManager)
        {
            this.context = context;
            this.userManager = userManager;
        }
        [HttpPost]
        public async Task<ActionResult> Rate(MovieRating movieRating)
        {
            var user = await userManager.FindByEmailAsync(HttpContext.User.Identity.Name);
            var userId = user.Id;

            var currentRating = await context.MovieRatings
                .FirstOrDefaultAsync(x => x.Id == movieRating.Id && x.UserId == userId);
            if (currentRating==null)
            {
                movieRating.UserId = userId;
                movieRating.RatingDate = DateTime.Today;
                context.MovieRatings.Add(movieRating);
                await context.SaveChangesAsync();
            }
            else
            {
                currentRating.Rate = movieRating.Rate;
                await context.SaveChangesAsync();
            }
            return NoContent();
        }

    }
}

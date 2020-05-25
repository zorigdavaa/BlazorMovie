using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorMovie.Server.Context;
using BlazorMovie.Server.Helpers;
using BlazorMovie.Shared.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorMovie.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly AppDbContext context;
        private readonly IFileStorageService fileStorageService;

        public MoviesController(AppDbContext context, IFileStorageService fileStorageService)
        {
            this.context = context;
            this.fileStorageService = fileStorageService;
        }
        [HttpGet]
        public async Task<IEnumerable<Movie>> Get()
        {
            return await context.Movies.ToListAsync();

        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Movie movie)
        {
            if (!string.IsNullOrEmpty(movie.Poster))
            {
                var moviePoster = Convert.FromBase64String(movie.Poster);
                movie.Poster = await fileStorageService.SaveFile(moviePoster, "jpg", "People");
            }
            await context.Movies.AddAsync(movie);
            await context.SaveChangesAsync();
            return movie.Id;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorMovie.Server.Context;
using BlazorMovie.Shared.Entities;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorMovie.Server.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly AppDbContext context;

        public GenresController(AppDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<IEnumerable<Genre>> Get()
        {
            return await context.Genres.ToListAsync();

        }

        [HttpPost]
        public async Task<ActionResult<int>> Post (Genre genre)
        {
            await context.Genres.AddAsync(genre);
            await context.SaveChangesAsync();
            return genre.Id;
        }
    }
}

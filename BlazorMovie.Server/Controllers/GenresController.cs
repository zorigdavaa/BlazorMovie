using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorMovie.Server.Context;
using BlazorMovie.Shared.Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorMovie.Server.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class GenresController : ControllerBase
    {
        private readonly AppDbContext context;

        public GenresController(AppDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<IEnumerable<Genre>> Get()
        {
            return await context.Genres.ToListAsync();

        }
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<Genre>> Get(int id)
        {
            var genre = await context.Genres.FindAsync(id);
            if (genre==null)
            {
                return NotFound();
            }
            return genre;
  

        }

        [HttpPost]
        public async Task<ActionResult<int>> Post (Genre genre)
        {
            await context.Genres.AddAsync(genre);
            await context.SaveChangesAsync();
            return genre.Id;
        }

        [HttpPut]
        public async Task<ActionResult> Put(Genre genre)
        {
            //context.Genres.Attach(genre).State = EntityState.Modified;
            //await context.SaveChangesAsync();
            //return NoContent();

            var genresTObeUpdated = await context.Genres.FindAsync(genre.Id);
            if (genresTObeUpdated==null)
            {
                return NotFound();
            }
            genresTObeUpdated.Name = genre.Name;
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            Genre genreTobeRemoved = await context.Genres.FindAsync(id);
            if (genreTobeRemoved==null)
            {
                return NotFound();
            }
            context.Genres.Remove(genreTobeRemoved);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}

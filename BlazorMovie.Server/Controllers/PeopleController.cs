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
    public class PeopleController : ControllerBase
    {
        private readonly AppDbContext context;
        public readonly IFileStorageService fileStorageService;

        public PeopleController(AppDbContext dbContext, IFileStorageService fileStorageService)
        {
            context = dbContext;
            this.fileStorageService = fileStorageService;
        }
        [HttpGet]
        public async Task<ActionResult<List<Person>>> GetPeople()
        {
            return await context.People.ToListAsync();
        }
        [HttpGet("search/{searchtext}")]
        public async Task<ActionResult<List<Person>>> FilterByName(string searchtext)
        {
            if (string.IsNullOrWhiteSpace(searchtext)) { return new List<Person>(); }
            
            return await context.People.Where(x=>x.Name.Contains(searchtext))
                .Take(5)
                .ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Person person)
        {
            if (!string.IsNullOrEmpty(person.Picture))
            {
                var personPicture = Convert.FromBase64String(person.Picture);
                person.Picture = await fileStorageService.SaveFile(personPicture, "jpg", "People");
            }
            context.Add(person);
            await context.SaveChangesAsync();
            return person.Id;
        }
    }
}

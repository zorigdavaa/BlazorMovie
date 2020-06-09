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
using AutoMapper;
using BlazorMovie.Shared.DTO_s;

namespace BlazorMovie.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly AppDbContext context;
        public readonly IFileStorageService fileStorageService;
        private readonly IMapper mapper;

        public PeopleController(AppDbContext dbContext, IFileStorageService fileStorageService, IMapper mapper)
        {
            context = dbContext;
            this.fileStorageService = fileStorageService;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<List<Person>>> GetPeople([FromQuery] PaginationDTO paginationDTO)
        {
            var queryAble = context.People.AsQueryable();
            await HttpContext.InsertPaginationParameterInResponse(queryAble, paginationDTO.RecordsPerPage);
            return await queryAble.Paginate(paginationDTO).ToListAsync();
            
        }
        [HttpGet("search/{searchtext}")]
        public async Task<ActionResult<List<Person>>> FilterByName(string searchtext)
        {
            if (string.IsNullOrWhiteSpace(searchtext)) { return new List<Person>(); }
            
            return await context.People.Where(x=>x.Name.Contains(searchtext))
                .Take(5)
                .ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Person>> GetPersonById(int id)
        {
            var personDB = await context.People.FindAsync(id);
            if (personDB == null){ return NotFound(); }
            return personDB;

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
        [HttpPut]
        public async Task<ActionResult> Put(Person person)
        {
            var personDb = await context.People.FindAsync(person.Id);
            if (personDb == null) { return NotFound(); }
            personDb = mapper.Map(person, personDb);
            if (!string.IsNullOrWhiteSpace(person.Picture))
            {
                var personPicture = Convert.FromBase64String(person.Picture);
                personDb.Picture = await fileStorageService.EditFile(personPicture, "jpg", "People", personDb.Picture);
            }
            await context.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            Person personToBeDeleted = await context.People.FindAsync(id);
            if (personToBeDeleted == null)
            {
                return NotFound();
            }
            context.People.Remove(personToBeDeleted);
            await context.SaveChangesAsync();
            return NoContent();
        }


    }
}

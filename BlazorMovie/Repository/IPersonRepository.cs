using BlazorMovie.Shared.DTO_s;
using BlazorMovie.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovie.Repository
{
    public interface IPersonRepository
    {
        Task CreatePerson(Person person);
        Task DeletePerson(int id);
        Task<PaginatedResponse<List<Person>>> GetPeople(PaginationDTO paginationDTO);

        //Task<List<Person>> GetPeople();/*Deprecated due to pagination*/
        Task<List<Person>> GetPeopleByName(string searchtext);
        Task<Person> GetPersonById(int id);
        Task UpdatePerson(Person person);
    }
}

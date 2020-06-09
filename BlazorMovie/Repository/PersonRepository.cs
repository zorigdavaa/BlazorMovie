using BlazorMovie.Helpers;
using BlazorMovie.Shared.DTO_s;
using BlazorMovie.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovie.Repository
{
    public class PersonRepository:IPersonRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/people";

        public PersonRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task CreatePerson(Person person)
        {
            var response = await httpService.Post(url, person);

            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
        public async Task<PaginatedResponse<List<Person>>> GetPeople(PaginationDTO paginationDTO)
        {
            return await httpService.GetHelper<List<Person>>(url, paginationDTO);
        }

        /*THIS ONE IS DEPRECATED DUE TO PAGINATION*/
        //public async Task<List<Person>> GetPeople()
        //{
        //    return await httpService.GetHelper<List<Person>>(url);
        //}


        public async Task<List<Person>> GetPeopleByName(string searchtext)
        {
            return await httpService.GetHelper<List<Person>>($"{url}/search/{searchtext}");
        }
        public async Task<Person> GetPersonById(int id)
        {
            return await httpService.GetHelper<Person>($"{url}/{id}");
        }

        public async Task UpdatePerson(Person person)
        {
            var response = await httpService.Put(url, person);

            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
        public async Task DeletePerson(int id)
        {
            var response = await httpService.Delete($"{url}/{id}");

            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}

using BlazorMovie.Helpers;
using BlazorMovie.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace BlazorMovie.Repository
{
    public class GenreRepository:IGenreRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/genres";

        public GenreRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }
        public async Task CreateGenre(Genre genre)
        {
            var response = await httpService.Post(url, genre);

            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
        public async Task<List<Genre>> GetGenres()
        {
            return await httpService.GetHelper<List<Genre>>(url);
        }
        public async Task<Genre> GetGenre(int id)
        {
            return await httpService.GetHelper<Genre>($"{url}/{id}");
        }

        public async Task UpdateGenre(Genre genre)
        {
            var response = await httpService.Put(url, genre);

            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteGenre(int id)
        {
            var response = await httpService.Delete($"{url}/{id}");

            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}

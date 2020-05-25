using BlazorMovie.Helpers;
using BlazorMovie.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovie.Repository
{
    public class MovieRepository:IMovieRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/movies";

        public MovieRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }
         public async Task<int> CreateMovie(Movie movie)
        {
            var response= await httpService.Post<Movie,int>(url, movie);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        
    }
}

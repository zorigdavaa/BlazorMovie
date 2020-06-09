using BlazorMovie.Helpers;
using BlazorMovie.Shared.DTO_s;
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

        public async Task<IndexPageDTO> GetIndexPageDto()
        {
            return await httpService.GetHelper<IndexPageDTO>(url);

        }
        public async Task<DetailsMovieDTO> GetDetailsMovieDto(int id)
        {
            return await httpService.GetHelper<DetailsMovieDTO>($"{url}/{id}");
        }
        public async Task<PaginatedResponse<List<Movie>>> GetMoviesFiltered(FilterMovieDTO filterMovieDTO)
        {
            var responseHttp = await httpService.Post<FilterMovieDTO, List<Movie>>($"{url}/filter", filterMovieDTO);
            var totalAmountPages = int.Parse(responseHttp.HttpResponseMessage.Headers.GetValues("totalAmountPages").FirstOrDefault());
            var paginatedResponse = new PaginatedResponse<List<Movie>>
            {
                Response = responseHttp.Response,
                TotalAmountPages = totalAmountPages
            };
            return paginatedResponse;
        }



        public async Task<MovieUpdateDTO> GetMovieForUpdate(int id)
        {
            return await httpService.GetHelper<MovieUpdateDTO>($"{url}/update/{id}");
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
        public async Task UpdateMovie(Movie movie)
        {
            var response = await httpService.Put(url, movie);

            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
        public async Task DeleteMovie(int id)
        {
            var response = await httpService.Delete($"{url}/{id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            
        }

    }
}

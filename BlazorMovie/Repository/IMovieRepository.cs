using BlazorMovie.Shared.DTO_s;
using BlazorMovie.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovie.Repository
{
    interface IMovieRepository
    {
        Task<int> CreateMovie(Movie movie);
        Task DeleteMovie(int id);

        //Task<T> Get<T>(string url);
        Task<DetailsMovieDTO> GetDetailsMovieDto(int id);
        Task<IndexPageDTO> GetIndexPageDto();
        Task<MovieUpdateDTO> GetMovieForUpdate(int id);
        Task<PaginatedResponse<List<Movie>>> GetMoviesFiltered(FilterMovieDTO filterMovieDTO);
        Task UpdateMovie(Movie movie);
    }
}

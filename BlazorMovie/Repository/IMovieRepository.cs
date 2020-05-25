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
    }
}

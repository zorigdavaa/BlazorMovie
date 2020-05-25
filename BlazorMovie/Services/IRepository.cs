using BlazorMovie.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovie.Services
{
    public interface IRepository
    {
        List<Movie> GetMovies();

    }
}

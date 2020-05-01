﻿using BlazorMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovie.Services
{
    public interface IMovieRepository
    {
        List<Movie> GetMovies();

    }
}

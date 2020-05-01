using BlazorMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovie.Services
{
    public class MovieInMemoryRepository : IMovieRepository
    {
        List<Movie> movies = new List<Movie>
        {
              new Movie { Title="SpiderMan", ReleaseDate=new DateTime(2009,12,03)},
              new Movie { Title="SuperMan", ReleaseDate=new DateTime(2010,01,04)},
              new Movie { Title="Batman", ReleaseDate=new DateTime(2011,02,05)}
        };
        public List<Movie> GetMovies()
        {
            return movies;
        }
    }
}

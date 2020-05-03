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
              new Movie { Title="SpiderMan", ReleaseDate=new DateTime(2009,12,03),
                  Poster="https://m.media-amazon.com/images/M/MV5BMGZlNTY1ZWUtYTMzNC00ZjUyLWE0MjQtMTMxN2E3ODYxMWVmXkEyXkFqcGdeQXVyMDM2NDM2MQ@@._V1_SY1000_CR0,0,674,1000_AL_.jpg"},
              new Movie { Title="SuperMan", ReleaseDate=new DateTime(2010,01,04),
              Poster="https://m.media-amazon.com/images/M/MV5BZTU1ZGFjNzEtZWYzZC00ZmI0LTg2NmMtN2YyNTY4YzhlODIyXkEyXkFqcGdeQXVyMjExMjk0ODk@._V1_SY1000_SX738_AL_.jpg"},
              new Movie { Title="Batman", ReleaseDate=new DateTime(2011,02,05),
              Poster="https://m.media-amazon.com/images/M/MV5BMTk4ODQzNDY3Ml5BMl5BanBnXkFtZTcwODA0NTM4Nw@@._V1_.jpg"}
        };
        public List<Movie> GetMovies()
        {
            return movies;
        }
    }
}

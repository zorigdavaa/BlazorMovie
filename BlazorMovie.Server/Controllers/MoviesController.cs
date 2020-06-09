﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using AutoMapper;
using BlazorMovie.Server.Context;
using BlazorMovie.Server.Helpers;
using BlazorMovie.Shared.DTO_s;
using BlazorMovie.Shared.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorMovie.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly AppDbContext context;
        private readonly IFileStorageService fileStorageService;
        private readonly IMapper mapper;
        private string containerName = "movies";

        public MoviesController(AppDbContext context, IFileStorageService fileStorageService, IMapper mapper)
        {
            this.context = context;
            this.fileStorageService = fileStorageService;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<IndexPageDTO>> Get()
        {
            var limit = 6;
            var moviesInTheaters = await context.Movies.Where(x => x.InTheaters)
                .Take(limit).OrderByDescending(x => x.ReleaseDate).ToListAsync();
            var todaysDate = DateTime.Today;
            var upcomingReleases = await context.Movies.Where(x => x.ReleaseDate > todaysDate)
                .OrderBy(x => x.ReleaseDate).Take(limit).ToListAsync();

            var response = new IndexPageDTO();
            response.InTheaters = moviesInTheaters;
            response.UpcomingReleases = upcomingReleases;
            return response;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<DetailsMovieDTO>> Get(int id)
        {
            var movie = await context.Movies.Where(x => x.Id == id)
                .Include(x => x.MovieGenres).ThenInclude(x => x.Genre)
                .Include(x => x.MoviesActors).ThenInclude(x => x.Person)
                .FirstOrDefaultAsync();
            if (movie == null) { return NotFound(); }
            movie.MoviesActors = movie.MoviesActors.OrderBy(x => x.Order).ToList();
            
            var model = new DetailsMovieDTO();
            model.Movie = movie;
            model.Genres = movie.MovieGenres.Select(x=>x.Genre).ToList();
            model.Actors = movie.MoviesActors.Select(x =>
                  new Person
                  {
                      Name = x.Person.Name,
                      Picture = x.Person.Picture,
                      Character = x.Character,
                      Id = x.PersonId, 
                  }).ToList();
            return model;
        }

        [HttpPost("filter")]
        public async Task<ActionResult<List<Movie>>> Filter(FilterMovieDTO filterMovieDTO)
        {
            var moviesQueryable = context.Movies.AsQueryable();
            if (!string.IsNullOrWhiteSpace( filterMovieDTO.TItle))
            {
                moviesQueryable = moviesQueryable.Where(x => x.Title.Contains(filterMovieDTO.TItle));
            }
            if (filterMovieDTO.InTheaters)
            {
                moviesQueryable = moviesQueryable.Where(x => x.InTheaters);

            }
            if (filterMovieDTO.UpcomingReleases)
            {
                var today = DateTime.Today;
                moviesQueryable = moviesQueryable.Where(x => x.ReleaseDate > today);
            }
            if (filterMovieDTO.GenreId !=0)
            {
                moviesQueryable = moviesQueryable.Where(x => x.MovieGenres.Select(y => y.GenreId).Contains(filterMovieDTO.GenreId));
            }
            await HttpContext.InsertPaginationParameterInResponse(moviesQueryable, filterMovieDTO.RecordsPerPage);

            var movies = await moviesQueryable.Paginate(filterMovieDTO.Pagination).ToListAsync();
            return movies;

        }


        [HttpGet("update/{id}")]
        public async Task<ActionResult<MovieUpdateDTO>> PutGet(int id)
        {
            var movieActionResult = await Get(id);
            if (movieActionResult.Result is NotFoundResult)
            {
                return NotFound();
            }
            var movieDetailDTO = movieActionResult.Value;
            var selectedGenresIds = movieDetailDTO.Genres.Select(x => x.Id).ToList();
            var notSelectedGenres = await context.Genres
                  .Where(x =>  !selectedGenresIds.Contains(x.Id)).ToListAsync();
            var model = new MovieUpdateDTO();
            model.Movie = movieDetailDTO.Movie;
            model.SelectedGenres = movieDetailDTO.Genres;
            model.NotSelectedGenres = notSelectedGenres;
            model.Actors = movieDetailDTO.Actors;
            return model;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Movie movie)
        {
            if (!string.IsNullOrEmpty(movie.Poster))
            {
                var moviePoster = Convert.FromBase64String(movie.Poster);
                movie.Poster = await fileStorageService.SaveFile(moviePoster, "jpg", containerName);
            }
            if (movie.MoviesActors!=null)
            {
                for (int i = 0; i < movie.MoviesActors.Count; i++)
                {
                    movie.MoviesActors[i].Order = i + 1;
                }
            }

            await context.Movies.AddAsync(movie);
            await context.SaveChangesAsync();
            return movie.Id;
        }
        [HttpPut]
        public async Task<ActionResult> Put(Movie movie)
        {
            var movieDB = await context.Movies.FindAsync(movie.Id);
            if (movieDB == null) { return NotFound(); }
            movieDB = mapper.Map(movie, movieDB);
            if (!string.IsNullOrWhiteSpace(movie.Poster))
            {
                var moviePoster = Convert.FromBase64String(movie.Poster);
                movieDB.Poster = await fileStorageService.EditFile(moviePoster, "jpg", containerName, movieDB.Poster);
            }
            await context.Database.ExecuteSqlInterpolatedAsync($"delete from MoviesActors where MovieId={movie.Id}; delete from MovieGenres where MovieId = {movie.Id}");
            if (movie.MoviesActors != null)
            {
                for (int i = 0; i < movie.MoviesActors.Count; i++)
                {
                    movie.MoviesActors[i].Order = i + 1;
                }
            }
            movieDB.MoviesActors = movie.MoviesActors;
            await context.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            Movie movieToBeDeleted = await context.Movies.FindAsync(id);
            if (movieToBeDeleted == null)
            {
                return NotFound();
            }
            context.Movies.Remove(movieToBeDeleted);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}

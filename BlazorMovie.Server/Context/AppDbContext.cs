using BlazorMovie.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace BlazorMovie.Server.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MoviesActors>().HasKey(x => new { x.MovieId, x.PersonId });
            modelBuilder.Entity<MovieGenres>().HasKey(x => new { x.MovieId, x.GenresId });
            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Genre> Genres { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieGenres> MovieGenres { get; set; }
        public DbSet<MoviesActors> MoviesActors { get; set; }
    }
}

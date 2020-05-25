using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Text;

namespace BlazorMovie.Shared.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Summary { get; set; }
        public bool InTheaters { get; set; }
        public string Trailer { get; set; }
        [Required]
        public DateTime? ReleaseDate { get; set; }
        public string Poster { get; set; }
        public List<MovieGenres> MovieGenres { get; set; } = new List<MovieGenres>();
        public List<MoviesActors> MoviesActors { get; set; }
        public string TitleBrief
        {
            get 
            {
                if (string.IsNullOrEmpty(Title))
                {
                    return null;
                }
                else if (Title.Length>60)
                {
                    return Title.Substring(0, 60) + "...";
                }
                else
                {
                    return Title;
                }
            }
        }

    }
}

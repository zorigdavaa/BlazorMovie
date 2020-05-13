using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorMovie.Shared.Entities
{
    class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Summary { get; set; }
        public bool InThearers { get; set; }
        public string Trailer { get; set; }
        [Required]
        public DateTime? ReleasedDate { get; set; }
        public string Poster { get; set; }
        public List<MovieGenres> MovieGenres { get; set; }
        public string TitleBrief
        {
            get { return Title; }
        }

    }
}

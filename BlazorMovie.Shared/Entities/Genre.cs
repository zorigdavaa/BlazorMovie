using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorMovie.Shared.Entities
{
    class Genre
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<MovieGenres> MoveGenres { get; set; } = new List<MovieGenres>();

    }
}

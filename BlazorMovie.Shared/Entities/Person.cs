using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BlazorMovie.Shared.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BioGraphy { get; set; }
        public string Picture { get; set; }
        [Required]
        public DateTime? DateOfBirth { get; set; }
        [NotMapped]
        public string Character { get; set; }
        public List<MoviesActors> MoviesActors { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BlazorMovie.Shared.Entities
{
    public class MoviesActors
    {
        public int MovieId { get; set; }
        public int PersonId { get; set; }
        public Movie Movie { get; set; }
        public Person Person { get; set; }
        public string Character { get; set; }
        public int Order { get; set; }
    }
}

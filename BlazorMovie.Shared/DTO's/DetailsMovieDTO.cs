﻿using BlazorMovie.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorMovie.Shared.DTO_s
{
    public class DetailsMovieDTO
    {
        public Movie Movie { get; set; }
        public List<Genre> Genres { get; set; }
        public List<Person> Actors { get; set; }
    }
}
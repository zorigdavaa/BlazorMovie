using BlazorMovie.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorMovie.Shared.DTO_s
{
    public class IndexPageDTO
    {
        public List<Movie> InTheaters { get; set; }
        public List<Movie> UpcomingReleases { get; set; }
    }
}

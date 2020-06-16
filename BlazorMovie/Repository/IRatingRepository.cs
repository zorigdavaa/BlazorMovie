using BlazorMovie.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovie.Repository
{
    public interface IRatingRepository
    {
        Task Vote(MovieRating movieRating);
    }
}

using BlazorMovie.Helpers;
using BlazorMovie.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovie.Repository
{
    public class RatingRepository:IRatingRepository
    {
        private readonly IHttpService httpService;
        private string urlBase = "api/Rating";

        public RatingRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }
        public async Task Vote(MovieRating movieRating)
        {
            var httpResponse = await httpService.Post(urlBase, movieRating);
            if (!httpResponse.Success)
            {
                throw new ApplicationException(await httpResponse.GetBody());
            }
        }
    }
}

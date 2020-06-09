using AutoMapper;
using BlazorMovie.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovie.Server.Helpers
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Person, Person>().ForMember(x => x.Picture, options => options.Ignore());
            CreateMap<Movie, Movie>().ForMember(x => x.Poster, options => options.Ignore());
        }
    }
}

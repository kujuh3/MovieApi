using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApi.DataTransferObjects.Outgoing
{
    public class GenreDto
    {
        public long Id { get; set; }

        public string GenreName { get; set; }

        public List<MovieDto> Movies { get; set; }
    }

    public class GenreDtoProfile : Profile
    {
        public GenreDtoProfile()
        {
            CreateMap<Models.Genre, GenreDto>().ReverseMap();
        }
    }
}

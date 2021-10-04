using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace MovieApi.DataTransferObjects.Outgoing
{
    public class DirectorDto
    {
        public long PersonId { get; set; }

        public List<CrewDto> Crews { get; set; }

    }

    public class DirectorDtoProfile : Profile
    {
        public DirectorDtoProfile()
        {
            CreateMap<Models.Director, DirectorDto>().ReverseMap();
        }
    }
}

using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApi.DataTransferObjects.Outgoing
{
    public class ActorDto
    {
        public long PersonId { get; set; }

        public List<CrewDto> Crews { get; set; }
    }

    public class ActorDtoProfile : Profile
    {
        public ActorDtoProfile()
        {
            CreateMap<Models.Actor, ActorDto>().ReverseMap();
        }
    }
}

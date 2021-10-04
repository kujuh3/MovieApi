using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApi.DataTransferObjects.Outgoing
{
    public class ProducingCompanyDto
    {
        public long Id { get; set; }

        public string CompanyName { get; set; }

        public List<MovieDto> Movies { get; set; }

    }

    public class ProducingCompanyDtoProfile : Profile
    {
        public ProducingCompanyDtoProfile()
        {
            CreateMap<Models.ProducingCompany, ProducingCompanyDto>().ReverseMap();
        }
    }
}

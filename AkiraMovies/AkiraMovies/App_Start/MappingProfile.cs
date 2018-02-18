using AkiraMovies.DataTransferObject;
using AkiraMovies.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AkiraMovies.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //var config = new MapperConfiguration(c => { c.CreateMap<CustomerModels, CustomerDTO>(); });
            //IMapper mapper = config.CreateMapper();

            //config = new MapperConfiguration(c => {
            //    c.CreateMap<CustomerDTO, CustomerModels>().ForMember(d => d.MembershipTypeId, opt => opt.Ignore());
            //});

            //mapper = config.CreateMapper();

            CreateMap<CustomerModels, CustomerDTO>();
            CreateMap<CustomerDTO, CustomerModels>().ForMember(c => c.Id, d => d.Ignore());


        }

    }
}
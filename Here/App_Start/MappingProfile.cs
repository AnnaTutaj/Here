using AutoMapper;
using Here.Dtos;
using Here.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Here.App_Start
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }

    }
}
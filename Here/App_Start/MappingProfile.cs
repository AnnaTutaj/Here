using AutoMapper;
using Here.Dtos;
using Here.Models;


namespace Here.App_Start
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {
            //From Domain to Dto
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Movie, MovieDto>();

            //From Dto to Domain
            Mapper.CreateMap<CustomerDto, Customer>().ForMember(c => c.Id, opt => opt.Ignore());
            Mapper.CreateMap<MovieDto, Movie>().ForMember(c => c.Id, opt => opt.Ignore());
        }

    }
}
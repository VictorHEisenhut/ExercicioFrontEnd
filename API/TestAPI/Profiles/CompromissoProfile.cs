using AutoMapper;
using TestAPI.Data.Dtos;
using TestAPI.Entities;

namespace TestAPI.Profiles
{
    public class CompromissoProfile : Profile
    {
        public CompromissoProfile()
        {
            CreateMap<Compromisso, CreateCompromissoDto>();
            CreateMap<CreateCompromissoDto, Compromisso>();



        }
    }
}

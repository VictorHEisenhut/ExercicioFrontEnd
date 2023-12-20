using AulaEntity.Models;
using AulaEntity.Models.ViewModels.Local;
using AutoMapper;

namespace AulaEntity.Profiles
{
    public class LocalProfile : Profile
    {
        public LocalProfile()
        {
            CreateMap<Local, CreateLocalVM>();
            CreateMap<CreateLocalVM, Local>();

            CreateMap<UpdateLocalVM, Local>();
            CreateMap<Local, UpdateLocalVM>();

        }
    }
}

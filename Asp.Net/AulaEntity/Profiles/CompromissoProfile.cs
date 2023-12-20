using AulaEntity.Models;
using AulaEntity.Models.ViewModels.Compromisso;
using AulaEntity.Models.ViewModels.Contato;
using AulaEntity.Models.ViewModels.Local;
using AutoMapper;

namespace AulaEntity.Profiles
{
    public class CompromissoProfile : Profile
    {
        public CompromissoProfile()
        {
            CreateMap<Compromisso, CreateCompromissoVM>();
            CreateMap<CreateCompromissoVM, Compromisso>();

            CreateMap<Compromisso, ReadCompromissoVM>()
                .ForMember(vm => vm.Contato, opt => opt.MapFrom(c => c.Contato))
                .ForMember(vm => vm.Local, opt => opt.MapFrom(l => l.Local));
            CreateMap<ReadCompromissoVM, Compromisso>()
                .ForMember(vm => vm.Contato, opt => opt.MapFrom(c => c.Contato))
                .ForMember(vm => vm.Local, opt => opt.MapFrom(l => l.Local));
            CreateMap<Contato, ReadContatoVM>();
            CreateMap<ReadContatoVM, Contato>();
            CreateMap<Local, ReadLocalVM>();
            CreateMap<ReadLocalVM, Local>();

            CreateMap<UpdateCompromissoVM, Compromisso>();
            CreateMap<Compromisso, UpdateCompromissoVM>();
        }
    }
}

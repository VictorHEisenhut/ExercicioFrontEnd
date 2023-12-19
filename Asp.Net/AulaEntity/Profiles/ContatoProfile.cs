using AulaEntity.Models;
using AulaEntity.Models.ViewModels;
using AutoMapper;
using System.Runtime.CompilerServices;

namespace AulaEntity.Profiles
{
    public class ContatoProfile : Profile
    {
        public ContatoProfile()
        {
            CreateMap<Contato, CreateContatoVM>();
            CreateMap<CreateContatoVM, Contato>();

            CreateMap<Contato, ReadContatoVM>();
            CreateMap<ReadContatoVM, Contato>();

            CreateMap<UpdateContatoVM, Contato>();
        }
    }
}

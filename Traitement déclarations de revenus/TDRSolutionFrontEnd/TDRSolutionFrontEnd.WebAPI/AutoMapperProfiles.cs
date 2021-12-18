using System.Linq;
using AutoMapper;
using TDRSolutionFrontEnd.Core.Entities;
using TDRSolutionFrontEnd.WebAPI.DTOs;

namespace TDRSolutionFrontEnd.WebAPI
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {

            CreateMap<UserForRegisterDto, Usager>();
            CreateMap<Usager, UserForDetailedDto>();
            CreateMap<Usager, UserForListDto>();
            CreateMap<DeclarationForCreateDto, DeclarationRevenus>();
            CreateMap<DeclarationForUpdateDto, DeclarationRevenus>();
            CreateMap<DeclarationRevenus, DeclarationsForListDto>();
            CreateMap<DeclarationRevenus, DeclarationForDetailedDto>();
            CreateMap<DeclarationRevenus, DemandeTraitement.DeclarationRevenus>()
                .ForMember(dest => dest.IdDeclaration, act => act.MapFrom(src => src.Id))
                .ForMember(dest => dest.RevenusEmploi, act => act.MapFrom(src => src.RevenusEmploi))
                .ForMember(dest => dest.RevenusAutre, act => act.MapFrom(src => src.RevenusAutre))
                .ForMember(dest => dest.Annee, act => act.MapFrom(src => src.Annee));
            CreateMap<DeclarationRevenus, DemandeTraitement.Contribuable>()
                .ForMember(dest => dest.IdContribuable, act => act.MapFrom(src => src.Usager.Id))
                .ForMember(dest => dest.Nom, act => act.MapFrom(src => src.Usager.LastName))
                .ForMember(dest => dest.Prenom, act => act.MapFrom(src => src.Usager.FirstName))
                .ForMember(dest => dest.NAS, act => act.MapFrom(src => src.Usager.NAS))
                .ForMember(dest => dest.Adresse, act => act.MapFrom(src => src.Usager.Adresse))
                .ForMember(dest => dest.Courriel, act => act.MapFrom(src => src.Usager.Email))
                .ForMember(dest => dest.TelephonePrincipal, act => act.MapFrom(src => src.Usager.TelephonePrincipal))
                .ForMember(dest => dest.TelephoneSecondaire, act => act.MapFrom(src => src.Usager.TelephoneSecondaire))
                .ForMember(dest => dest.Citoyennete, act => act.MapFrom(src => src.Usager.Citoyennete));
            CreateMap<DeclarationRevenus, DemandeTraitement>()
                .ForMember(dest => dest.declarationRevenus, input => input.MapFrom(s => s))
                .ForMember(dest => dest.contribuable, input => input.MapFrom(s => s));



        }
    }
}

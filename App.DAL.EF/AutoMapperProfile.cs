using AutoMapper;

namespace App.DAL.EF;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<App.Domain.AppUserInTournament, App.DAL.DTO.AppUserInTournament>().ReverseMap();
        CreateMap<App.Domain.Competition, App.DAL.DTO.Competition>().ReverseMap();
        CreateMap<App.Domain.Country, App.DAL.DTO.Country>().ReverseMap();
        CreateMap<App.Domain.Match, App.DAL.DTO.Match>().ReverseMap();
        CreateMap<App.Domain.Player, App.DAL.DTO.Player>().ReverseMap();
        CreateMap<App.Domain.Prediction, App.DAL.DTO.Prediction>().ReverseMap();
        CreateMap<App.Domain.Team, App.DAL.DTO.Team>().ReverseMap();
        CreateMap<App.Domain.TeamInCompetition, App.DAL.DTO.TeamInCompetition>().ReverseMap();
        CreateMap<App.Domain.TeamInMatch, App.DAL.DTO.TeamInMatch>().ReverseMap();
        CreateMap<App.Domain.Tournament, App.DAL.DTO.Tournament>().ReverseMap();
    }
}
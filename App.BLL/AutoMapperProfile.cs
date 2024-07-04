using AutoMapper;

namespace App.BLL;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<App.DAL.DTO.AppUserInTournament, App.BLL.DTO.AppUserInTournament>().ReverseMap();
        CreateMap<App.DAL.DTO.Competition, App.BLL.DTO.Competition>().ReverseMap();
        CreateMap<App.DAL.DTO.Country, App.BLL.DTO.Country>().ReverseMap();
        CreateMap<App.DAL.DTO.Match, App.BLL.DTO.Match>().ReverseMap();
        CreateMap<App.DAL.DTO.Player, App.BLL.DTO.Player>().ReverseMap();
        CreateMap<App.DAL.DTO.Prediction, App.BLL.DTO.Prediction>().ReverseMap();
        CreateMap<App.DAL.DTO.Team, App.BLL.DTO.Team>().ReverseMap();
        CreateMap<App.DAL.DTO.TeamInCompetition, App.BLL.DTO.TeamInCompetition>().ReverseMap();
        CreateMap<App.DAL.DTO.TeamInMatch, App.BLL.DTO.TeamInMatch>().ReverseMap();
        CreateMap<App.DAL.DTO.Tournament, App.BLL.DTO.Tournament>().ReverseMap();
    }
}
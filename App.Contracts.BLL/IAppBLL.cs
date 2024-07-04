using App.Contracts.BLL.Services;
using Base.Contracts.BLL;

namespace App.Contracts.BLL;

public interface IAppBLL : IBLL
{
    IAppUserInTournamentService AppUsersInTournament { get; }
    ICompetitionService Competitions { get; }
    ICountryService Countries { get; }
    IMatchService Matches { get; }
    IPlayerService Players { get; }
    IPredictionService Predictions { get; }
    ITeamInCompetitionService TeamsInCompetition { get; }
    ITeamInMatchService TeamsInMatch { get; }
    ITeamService Teams { get; }
    ITournamentService Tournaments { get; }
}
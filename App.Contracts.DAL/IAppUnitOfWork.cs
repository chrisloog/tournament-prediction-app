using App.Contracts.DAL.Repositories;
using App.Domain.Identity;
using Base.Contracts.DAL;

namespace App.Contracts.DAL;

public interface IAppUnitOfWork : IUnitOfWork
{
    IEntityRepository<AppUser> Users { get; }
    IAppUserInTournamentRepository AppUsersInTournament { get; }
    ICompetitionRepository Competitions { get; }
    ICountryRepository Countries { get; }
    IMatchRepository Matches { get; }
    IPlayerRepository Players { get; }
    IPredictionRepository Predictions { get; }
    ITeamInCompetitionRepository TeamsInCompetition { get; }
    ITeamInMatchRepository TeamsInMatch { get; }
    ITeamRepository Teams { get; }
    ITournamentRepository Tournaments { get; }
}
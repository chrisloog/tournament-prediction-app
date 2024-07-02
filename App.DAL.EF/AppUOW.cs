using App.Contracts.DAL;
using App.Contracts.DAL.Repositories;
using App.DAL.EF.Repositories;
using App.Domain.Identity;
using AutoMapper;
using Base.Contracts.DAL;
using Base.DAL.EF;

namespace App.DAL.EF;

public class AppUOW : BaseUnitOfWork<AppDbContext>, IAppUnitOfWork
{
    private readonly IMapper _mapper;
    public AppUOW(AppDbContext dbContext, IMapper mapper) : base(dbContext)
    {
        _mapper = mapper;
    }

    //====================================================================
    public IAppUserInTournamentRepository? _appUsersInTournament { get; }
    public IAppUserInTournamentRepository AppUsersInTournament =>
        _appUsersInTournament ?? new AppUserInTournamentRepository(UowDbContext, _mapper);
    
    //====================================================================
    public ICompetitionRepository? _competitions { get; }
    public ICompetitionRepository Competitions =>
        _competitions ?? new CompetitionRepository(UowDbContext, _mapper);
    
    //====================================================================
    public ICountryRepository? _countries { get; }
    public ICountryRepository Countries => 
        _countries ?? new CountryRepository(UowDbContext, _mapper);
    
    //====================================================================
    public IMatchRepository? _matches { get; }
    public IMatchRepository Matches => 
        _matches ?? new MatchRepository(UowDbContext, _mapper);
    
    //====================================================================
    public IPlayerRepository? _players { get; }
    public IPlayerRepository Players => _players ?? new PlayerRepository(UowDbContext, _mapper);
    
    //====================================================================
    public IPredictionRepository? _predictions { get; }
    public IPredictionRepository Predictions =>
        _predictions ?? new PredictionRepository(UowDbContext, _mapper);
    
    //====================================================================
    public ITeamInCompetitionRepository? _teamsInCompetition { get; }
    public ITeamInCompetitionRepository TeamsInCompetition =>
        _teamsInCompetition ?? new TeamInCompetitionRepository(UowDbContext, _mapper);
    
    //====================================================================
    public ITeamInMatchRepository? _teamsInMatch { get; }
    public ITeamInMatchRepository TeamsInMatch =>
        _teamsInMatch ?? new TeamInMatchRepository(UowDbContext, _mapper);
    
    //====================================================================
    public ITeamRepository? _teams { get; }
    public ITeamRepository Teams => _teams ?? new TeamRepository(UowDbContext, _mapper);
    
    //====================================================================
    public ITournamentRepository? _tournaments { get; }
    public ITournamentRepository Tournaments =>
        _tournaments ?? new TournamentRepository(UowDbContext, _mapper);
    
    //====================================================================
    private IEntityRepository<AppUser>? _users;
    public IEntityRepository<AppUser> Users => _users ??
                                               new BaseEntityRepository<AppUser, AppUser, AppDbContext>(UowDbContext,
                                                   new DalDomainMapper<AppUser, AppUser>(_mapper));
}
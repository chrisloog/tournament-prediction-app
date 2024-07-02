using App.Contracts.DAL.Repositories;
using AutoMapper;
using Base.DAL.EF;
using APPDomain = App.Domain;
using DALDTO = App.DAL.DTO;

namespace App.DAL.EF.Repositories;

public class TeamInCompetitionRepository : BaseEntityRepository<APPDomain.TeamInCompetition, DALDTO.TeamInCompetition, AppDbContext>, ITeamInCompetitionRepository
{
    public TeamInCompetitionRepository(AppDbContext dbContext, IMapper mapper) : 
        base(dbContext, new DalDomainMapper<APPDomain.TeamInCompetition, DALDTO.TeamInCompetition>(mapper))
    {
    }
}
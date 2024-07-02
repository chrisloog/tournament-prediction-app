using App.Contracts.DAL.Repositories;
using AutoMapper;
using Base.Contracts.DAL;
using Base.DAL.EF;
using APPDomain = App.Domain;
using DALDTO = App.DAL.DTO;

namespace App.DAL.EF.Repositories;

public class TeamInMatchRepository : BaseEntityRepository<APPDomain.TeamInMatch, DALDTO.TeamInMatch, AppDbContext>, ITeamInMatchRepository
{
    public TeamInMatchRepository(AppDbContext dbContext, IMapper mapper) : 
        base(dbContext, new DalDomainMapper<APPDomain.TeamInMatch, DALDTO.TeamInMatch>(mapper))
    {
    }
}
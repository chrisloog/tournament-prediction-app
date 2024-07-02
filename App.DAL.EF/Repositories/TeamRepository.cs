using App.Contracts.DAL.Repositories;
using AutoMapper;
using Base.Contracts.DAL;
using Base.DAL.EF;
using APPDomain = App.Domain;
using DALDTO = App.DAL.DTO;

namespace App.DAL.EF.Repositories;

public class TeamRepository : BaseEntityRepository<APPDomain.Team, DALDTO.Team, AppDbContext>, ITeamRepository
{
    public TeamRepository(AppDbContext dbContext, IMapper mapper) : 
        base(dbContext, new DalDomainMapper<APPDomain.Team, DALDTO.Team>(mapper))
    {
    }
}
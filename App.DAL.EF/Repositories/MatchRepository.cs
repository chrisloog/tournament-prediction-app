using App.Contracts.DAL.Repositories;
using AutoMapper;
using Base.Contracts.DAL;
using Base.DAL.EF;
using APPDomain = App.Domain;
using DALDTO = App.DAL.DTO;

namespace App.DAL.EF.Repositories;

public class MatchRepository : BaseEntityRepository<APPDomain.Match, DALDTO.Match, AppDbContext>, IMatchRepository
{
    public MatchRepository(AppDbContext dbContext, IMapper mapper) : 
        base(dbContext, new DalDomainMapper<APPDomain.Match, DALDTO.Match>(mapper))
    {
    }
}
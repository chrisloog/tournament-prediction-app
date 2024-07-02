using App.Contracts.DAL.Repositories;
using AutoMapper;
using Base.Contracts.DAL;
using Base.DAL.EF;
using APPDomain = App.Domain;
using DALDTO = App.DAL.DTO;

namespace App.DAL.EF.Repositories;

public class CompetitionRepository : BaseEntityRepository<APPDomain.Competition, DALDTO.Competition, AppDbContext>, ICompetitionRepository
{
    public CompetitionRepository(AppDbContext dbContext, IMapper mapper) : 
        base(dbContext, new DalDomainMapper<APPDomain.Competition, DALDTO.Competition>(mapper))
    {
    }
}
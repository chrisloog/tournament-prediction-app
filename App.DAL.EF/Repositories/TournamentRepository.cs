using App.Contracts.DAL.Repositories;
using AutoMapper;
using Base.Contracts.DAL;
using Base.DAL.EF;
using APPDomain = App.Domain;
using DALDTO = App.DAL.DTO;

namespace App.DAL.EF.Repositories;

public class TournamentRepository : BaseEntityRepository<APPDomain.Tournament, DALDTO.Tournament, AppDbContext>, ITournamentRepository
{
    public TournamentRepository(AppDbContext dbContext, IMapper mapper) : 
        base(dbContext, new DalDomainMapper<APPDomain.Tournament, DALDTO.Tournament>(mapper))
    {
    }
}
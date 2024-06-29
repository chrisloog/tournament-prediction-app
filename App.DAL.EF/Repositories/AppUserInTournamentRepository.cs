using App.Contracts.DAL.Repositories;
using AutoMapper;
using Base.DAL.EF;
using APPDomain = App.Domain;
using DALDTO = App.DAL.DTO;

namespace App.DAL.EF.Repositories;

public class AppUserInTournamentRepository : BaseEntityRepository<APPDomain.AppUserInTournament, DALDTO.AppUserInTournament, AppDbContext>, IAppUserInTournamentRepository
{
    public AppUserInTournamentRepository(AppDbContext dbContext, IMapper mapper) :
        base(dbContext, new DalDomainMapper<APPDomain.AppUserInTournament, DALDTO.AppUserInTournament>(mapper))
    {
    }
}
  
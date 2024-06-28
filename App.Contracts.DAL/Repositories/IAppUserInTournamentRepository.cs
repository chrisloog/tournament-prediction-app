using Base.Contracts.DAL;
using DALDTO = App.DAL.DTO;

namespace App.Contracts.DAL.Repositories;

public interface IAppUserInTournamentRepository : IEntityRepository<DALDTO.AppUserInTournament>, IAppUserInTournamentRepositoryCustom<DALDTO.AppUserInTournament>
{
    // define your DAL only custom methods here
}

public interface IAppUserInTournamentRepositoryCustom<TEntity>
{
    // bll & dal
}
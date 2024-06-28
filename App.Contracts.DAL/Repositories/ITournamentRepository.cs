using Base.Contracts.DAL;
using DALDTO = App.DAL.DTO;

namespace App.Contracts.DAL.Repositories;

public interface ITournamentRepository : IEntityRepository<DALDTO.Tournament>, ITournamentRepositoryCustom<DALDTO.Tournament>
{
    
}

public interface ITournamentRepositoryCustom<TEntity>
{
    
}
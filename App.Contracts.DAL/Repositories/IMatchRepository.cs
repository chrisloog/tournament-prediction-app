using Base.Contracts.DAL;
using DALDTO = App.DAL.DTO;

namespace App.Contracts.DAL.Repositories;

public interface IMatchRepository : IEntityRepository<DALDTO.Match>, IMatchRepositoryCustom<DALDTO.Match>
{
    
}

public interface IMatchRepositoryCustom<TEntity>
{
    
}
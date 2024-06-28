using Base.Contracts.DAL;
using DALDTO = App.DAL.DTO;

namespace App.Contracts.DAL.Repositories;

public interface IPlayerRepository : IEntityRepository<DALDTO.Player>, IPlayerRepositoryCustom<DALDTO.Player>
{
    
}

public interface IPlayerRepositoryCustom<TEntity>
{
    
}
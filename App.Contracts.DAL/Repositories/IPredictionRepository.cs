using Base.Contracts.DAL;
using DALDTO = App.DAL.DTO;

namespace App.Contracts.DAL.Repositories;

public interface IPredictionRepository : IEntityRepository<DALDTO.Prediction>, IPredictionRepositoryCustom<DALDTO.Prediction>
{
    
}

public interface IPredictionRepositoryCustom<TEntity>
{
    
}
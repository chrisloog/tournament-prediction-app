using App.BLL.DTO;
using App.Contracts.DAL.Repositories;
using Base.Contracts.DAL;

namespace App.Contracts.BLL.Services;

public interface IPredictionService : IEntityRepository<Prediction>, IPredictionRepositoryCustom<Prediction>
{
    
}
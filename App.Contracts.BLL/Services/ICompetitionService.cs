using App.Contracts.DAL.Repositories;
using Base.Contracts.DAL;

namespace App.Contracts.BLL.Services;

public interface ICompetitionService : IEntityRepository<App.BLL.DTO.Competition>, ICompetitionRepositoryCustom<App.BLL.DTO.Competition>
{
    
}
using Base.Contracts.DAL;
using DALDTO = App.DAL.DTO;

namespace App.Contracts.DAL.Repositories;

public interface ITeamRepository : IEntityRepository<DALDTO.Team>, ITeamRepositoryCustom<DALDTO.Team>
{
    
}

public interface ITeamRepositoryCustom<TEntity>
{
    
}
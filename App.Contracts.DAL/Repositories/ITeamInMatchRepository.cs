using Base.Contracts.DAL;
using DALDTO = App.DAL.DTO;

namespace App.Contracts.DAL.Repositories;

public interface ITeamInMatchRepository : IEntityRepository<DALDTO.TeamInMatch>, ITeamInMatchRepositoryCustom<DALDTO.TeamInMatch>
{
    
}

public interface ITeamInMatchRepositoryCustom<TEntity> 
{
    
}
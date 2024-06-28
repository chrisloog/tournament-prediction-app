using Base.Contracts.DAL;
using DALDTO = App.DAL.DTO;

namespace App.Contracts.DAL.Repositories;

public interface ITeamInCompetitionRepository : IEntityRepository<DALDTO.TeamInCompetition>, ITeamInCompetitionRepositoryCustom<DALDTO.TeamInCompetition>
{
    
}

public interface ITeamInCompetitionRepositoryCustom<TEntity>
{
    
}
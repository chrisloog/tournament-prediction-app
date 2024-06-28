using Base.Contracts.DAL;
namespace App.Contracts.DAL.Repositories;
using DALDTO = App.DAL.DTO;

public interface ICompetitionRepository : IEntityRepository<DALDTO.Competition>, ICompetitionRepositoryCustom<DALDTO.Competition>
{
    // define your DAL only custom methods here
}

public interface ICompetitionRepositoryCustom<TEntity>
{
    // bll & dal
}
using Base.Contracts.DAL;
using DALDTO = App.DAL.DTO;

namespace App.Contracts.DAL.Repositories;

public interface ICountryRepository : IEntityRepository<DALDTO.Country>, ICountryRepositoryCustom<DALDTO.Country>
{
    
}

public interface ICountryRepositoryCustom<TEntity>
{
    
}
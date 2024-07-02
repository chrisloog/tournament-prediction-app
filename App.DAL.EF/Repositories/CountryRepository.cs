using App.Contracts.DAL.Repositories;
using AutoMapper;
using Base.Contracts.DAL;
using Base.DAL.EF;
using APPDomain = App.Domain;
using DALDTO = App.DAL.DTO;

namespace App.DAL.EF.Repositories;

public class CountryRepository : BaseEntityRepository<APPDomain.Country, DALDTO.Country, AppDbContext>, ICountryRepository
{
    public CountryRepository(AppDbContext dbContext, IMapper mapper) : 
        base(dbContext, new DalDomainMapper<APPDomain.Country, DALDTO.Country>(mapper))
    {
    }
}
using App.Contracts.DAL.Repositories;
using AutoMapper;
using Base.Contracts.DAL;
using Base.DAL.EF;
using APPDomain = App.Domain;
using DALDTO = App.DAL.DTO;

namespace App.DAL.EF.Repositories;

public class PredictionRepository : BaseEntityRepository<APPDomain.Prediction, DALDTO.Prediction, AppDbContext>, IPredictionRepository
{
    public PredictionRepository(AppDbContext dbContext, IMapper mapper) : 
        base(dbContext, new DalDomainMapper<APPDomain.Prediction, DALDTO.Prediction>(mapper))
    {
    }
}
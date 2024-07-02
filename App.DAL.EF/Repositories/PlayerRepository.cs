using App.Contracts.DAL.Repositories;
using AutoMapper;
using Base.Contracts.DAL;
using Base.DAL.EF;
using APPDomain = App.Domain;
using DALDTO = App.DAL.DTO;

namespace App.DAL.EF.Repositories;

public class PlayerRepository : BaseEntityRepository<APPDomain.Player, DALDTO.Player, AppDbContext>, IPlayerRepository
{
    public PlayerRepository(AppDbContext dbContext, IMapper mapper) : 
        base(dbContext, new DalDomainMapper<APPDomain.Player, DALDTO.Player>(mapper))
    {
    }
}
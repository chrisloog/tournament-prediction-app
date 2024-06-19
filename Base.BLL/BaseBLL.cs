using Base.Contracts.BLL;
using Base.Contracts.DAL;
using Microsoft.EntityFrameworkCore;

namespace Base.BLL;

public abstract class BaseBLL<TAppDbContext> : IBLL
    where TAppDbContext : DbContext
{
    protected readonly IUnitOfWork Uow;

    protected BaseBLL(IUnitOfWork uow)
    {
        Uow = uow;
    }

    public async Task<int> SaveChangesAsync()
    {
        return await Uow.SaveChangesAsync();
    }
}

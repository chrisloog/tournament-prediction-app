using App.Domain;
using App.Domain.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace App.DAL.EF;

public class AppDbContext : IdentityDbContext<AppUser, AppRole, Guid, IdentityUserClaim<Guid>, AppUserRole,
    IdentityUserLogin<Guid>, IdentityRoleClaim<Guid>, IdentityUserToken<Guid>>
{
    public DbSet<Player> Players { get; set; } = default!;
    public DbSet<AppUserInTournament> AppUserInTournaments { get; set; } = default!;
    public DbSet<Competition> Competitions { get; set; } = default!;
    public DbSet<Country> Countries { get; set; } = default!;
    public DbSet<Match> Matches { get; set; } = default!;
    public DbSet<Prediction> Predictions { get; set; } = default!;
    public DbSet<Team> Teams { get; set; } = default!;
    public DbSet<TeamInCompetition> TeamInCompetitions { get; set; } = default!;
    public DbSet<TeamInMatch> TeamInMatches { get; set; } = default!;
    public DbSet<Tournament> Tournaments { get; set; } = default!;
    
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        foreach (var entity in ChangeTracker.Entries().Where(e => e.State != EntityState.Deleted))
        {
            foreach (var prop in entity
                         .Properties
                         .Where(x => x.Metadata.ClrType == typeof(DateTime)))
            {
                Console.WriteLine(prop);
                prop.CurrentValue = ((DateTime) prop.CurrentValue).ToUniversalTime();
            }
        }

        return base.SaveChangesAsync(cancellationToken);
    }
}
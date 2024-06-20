using App.Domain.Identity;
using Base.Contracts.Domain;
using Base.Domain;

namespace App.Domain;

public class AppUserInTournament : BaseEntityId, IDomainAppUser<AppUser>
{
    public int? Rank { get; set; }
    public int? Points { get; set; }
    public DateTime DateJoined { get; set; } = default!;
    
    public Guid AppUserId { get; set; }
    public AppUser? AppUser { get; set; }

    public Guid? TournamentId { get; set; }
    public Tournament? Tournament { get; set; }
}
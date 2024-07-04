using App.Domain.Identity;
using Base.Contracts.Domain;
using Tournament = App.BLL.DTO.Tournament;

namespace App.BLL.DTO;

public class AppUserInTournament : IDomainEntityId
{
    public Guid Id { get; set; }
    
    public int? Rank { get; set; }
    public int? Points { get; set; }
    public DateTime DateJoined { get; set; } = default!;
    
    public Guid AppUserId { get; set; }
    public AppUser? AppUser { get; set; }

    public Guid? TournamentId { get; set; }
    public Tournament? Tournament { get; set; }
}
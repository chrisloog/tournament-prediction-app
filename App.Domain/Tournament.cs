using System.ComponentModel.DataAnnotations;
using App.Domain.Identity;
using Base.Contracts.Domain;
using Base.Domain;

namespace App.Domain;

public class Tournament : BaseEntityId, IDomainAppUser<AppUser>
{
    [MinLength(1)]
    [MaxLength(128)]
    public string Name { get; set; } = default!;
    
    // Creator of the tournament
    public Guid AppUserId { get; set; }
    public AppUser? AppUser { get; set; }

    public Guid? CompetitionId { get; set; }
    public Competition? Competition { get; set; }
    
    public ICollection<Prediction>? Predictions { get; set; }
    public ICollection<AppUserInTournament>? AppUsersInTournament { get; set; }
}
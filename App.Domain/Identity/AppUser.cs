using System.ComponentModel.DataAnnotations;
using Base.Contracts.Domain;
using Microsoft.AspNetCore.Identity;

namespace App.Domain.Identity;


public class AppUser : IdentityUser<Guid>, IDomainEntityId
{
    public ICollection<AppUserInTournament>? AppUserInTournaments { get; set; }
    public ICollection<Tournament>? Tournaments { get; set; }
    public ICollection<Prediction>? Predictions { get; set; }
    public ICollection<AppRefreshToken>? RefreshTokens { get; set; }
}

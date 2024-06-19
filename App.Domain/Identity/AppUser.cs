using System.ComponentModel.DataAnnotations;
using Base.Contracts.Domain;
using Microsoft.AspNetCore.Identity;

namespace App.Domain.Identity;


public class AppUser : IdentityUser<Guid>, IDomainEntityId
{
    public ICollection<AppRefreshToken>? RefreshTokens { get; set; }
}

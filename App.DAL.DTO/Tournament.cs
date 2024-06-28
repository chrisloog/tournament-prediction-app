using System.ComponentModel.DataAnnotations;
using App.Domain.Identity;
using Base.Contracts.Domain;

namespace App.DAL.DTO;

public class Tournament : IDomainEntityId
{
    public Guid Id { get; set; }
    
    [MinLength(1)]
    [MaxLength(128)]
    public string Name { get; set; } = default!;
    
    // Creator of the tournament
    public Guid AppUserId { get; set; }
    public AppUser? AppUser { get; set; }

    public Guid? CompetitionId { get; set; }
    public DAL.DTO.Competition? Competition { get; set; }
    
    public ICollection<DAL.DTO.Prediction>? Predictions { get; set; }
    public ICollection<DAL.DTO.AppUserInTournament>? AppUsersInTournament { get; set; }
}
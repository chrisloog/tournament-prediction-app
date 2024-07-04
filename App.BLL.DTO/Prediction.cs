using System.ComponentModel.DataAnnotations;
using App.Domain.Identity;
using Base.Contracts.Domain;
using Helpers.Enums;
using Tournament = App.BLL.DTO.Tournament;

namespace App.BLL.DTO;

public class Prediction : IDomainEntityId
{
    public Guid Id { get; set; }
    
    [MinLength(1)]
    [MaxLength(128)]
    public string Value { get; set; } = default!;
    public EPredictionType PredictionType { get; set; } = default!;
    
    public Guid AppUserId { get; set; }
    public AppUser? AppUser { get; set; }
    
    public Guid? TournamentId { get; set; }
    public Tournament? Tournament { get; set; }

    public Guid? MatchId { get; set; }
    public Match? Match { get; set; }
}
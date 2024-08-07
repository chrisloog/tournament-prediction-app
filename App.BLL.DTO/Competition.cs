using System.ComponentModel.DataAnnotations;
using Base.Contracts.Domain;
using Match = App.BLL.DTO.Match;
using TeamInCompetition = App.BLL.DTO.TeamInCompetition;
using Tournament = App.BLL.DTO.Tournament;

namespace App.BLL.DTO;

public class Competition : IDomainEntityId
{
    public Guid Id { get; set; }
    
    [MinLength(1)]
    [MaxLength(128)]
    public string Name { get; set; } = default!;

    public DateTime Start { get; set; } = default!;
    public DateTime End { get; set; } = default!;

    public ICollection<Tournament>? Tournaments { get; set; }
    public ICollection<Match>? Matches { get; set; }
    public ICollection<TeamInCompetition>? TeamsInCompetition { get; set; }
}
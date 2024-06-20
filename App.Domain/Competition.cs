using System.ComponentModel.DataAnnotations;
using Base.Domain;

namespace App.Domain;

public class Competition : BaseEntityId
{
    [MinLength(1)]
    [MaxLength(128)]
    public string Name { get; set; } = default!;

    public DateTime Start { get; set; } = default!;
    public DateTime End { get; set; } = default!;

    public ICollection<Tournament>? Tournaments { get; set; }
    public ICollection<Match>? Matches { get; set; }
    public ICollection<TeamInCompetition>? TeamsInCompetition { get; set; }
}
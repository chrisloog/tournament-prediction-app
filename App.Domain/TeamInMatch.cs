using Base.Domain;

namespace App.Domain;

public class TeamInMatch : BaseEntityId
{
    public int? Goals { get; set; }
    public int? YellowCards { get; set; }
    public int? RedCards { get; set; }

    public Guid? MatchId { get; set; }
    public Match? Match { get; set; }

    public Guid? TeamId { get; set; }
    public Team? Team { get; set; }
}
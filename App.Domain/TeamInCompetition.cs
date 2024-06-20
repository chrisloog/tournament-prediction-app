using Base.Domain;

namespace App.Domain;

public class TeamInCompetition : BaseEntityId
{
    public int? Rank { get; set; }

    public Guid? TeamId { get; set; }
    public Team? Team { get; set; }

    public Guid? CompetitionId { get; set; }
    public Competition? Competition { get; set; }
}
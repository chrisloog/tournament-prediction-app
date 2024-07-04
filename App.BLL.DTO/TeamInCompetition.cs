using Base.Contracts.Domain;

namespace App.BLL.DTO;

public class TeamInCompetition : IDomainEntityId
{
    public Guid Id { get; set; }
    
    public int? Rank { get; set; }

    public Guid? TeamId { get; set; }
    public Team? Team { get; set; }

    public Guid? CompetitionId { get; set; }
    public Competition? Competition { get; set; }
}
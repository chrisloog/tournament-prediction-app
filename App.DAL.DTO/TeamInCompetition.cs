using Base.Contracts.Domain;
using Base.Domain;

namespace App.DAL.DTO;

public class TeamInCompetition : IDomainEntityId
{
    public Guid Id { get; set; }
    
    public int? Rank { get; set; }

    public Guid? TeamId { get; set; }
    public DAL.DTO.Team? Team { get; set; }

    public Guid? CompetitionId { get; set; }
    public DAL.DTO.Competition? Competition { get; set; }
}
using Base.Contracts.Domain;

namespace App.BLL.DTO;

public class TeamInMatch : IDomainEntityId
{
    public Guid Id { get; set; }
    
    public int? Goals { get; set; }
    public int? YellowCards { get; set; }
    public int? RedCards { get; set; }

    public Guid? MatchId { get; set; }
    public Match? Match { get; set; }

    public Guid? TeamId { get; set; }
    public Team? Team { get; set; }
}
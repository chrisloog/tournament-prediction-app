using Base.Contracts.Domain;
using Base.Domain;

namespace App.DAL.DTO;

public class TeamInMatch : IDomainEntityId
{
    public Guid Id { get; set; }
    
    public int? Goals { get; set; }
    public int? YellowCards { get; set; }
    public int? RedCards { get; set; }

    public Guid? MatchId { get; set; }
    public DAL.DTO.Match? Match { get; set; }

    public Guid? TeamId { get; set; }
    public DAL.DTO.Team? Team { get; set; }
}
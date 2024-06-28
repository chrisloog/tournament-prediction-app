using App.Domain;
using Base.Contracts.Domain;
using Base.Domain;

namespace App.DAL.DTO;

public class Match : IDomainEntityId
{
    public Guid Id { get; set; }
    
    public DateTime Start { get; set; } = default!;
    public string Location { get; set; } = default!;
    
    public Guid? CompetitionId { get; set; }
    public DAL.DTO.Competition? Competition { get; set; }
    
    public ICollection<TeamInMatch>? TeamInMatches { get; set; }
    public ICollection<Prediction>? Predictions { get; set; }
}
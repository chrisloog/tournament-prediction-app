using Base.Contracts.Domain;
using Prediction = App.BLL.DTO.Prediction;
using TeamInMatch = App.BLL.DTO.TeamInMatch;

namespace App.BLL.DTO;

public class Match : IDomainEntityId
{
    public Guid Id { get; set; }
    
    public DateTime Start { get; set; } = default!;
    public string Location { get; set; } = default!;
    
    public Guid? CompetitionId { get; set; }
    public Competition? Competition { get; set; }
    
    public ICollection<TeamInMatch>? TeamInMatches { get; set; }
    public ICollection<Prediction>? Predictions { get; set; }
}
using Base.Domain;

namespace App.Domain;

public class Match : BaseEntityId
{
    public DateTime Start { get; set; } = default!;
    public string Location { get; set; } = default!;
    
    public Guid? CompetitionId { get; set; }
    public Competition? Competition { get; set; }
    
    public ICollection<TeamInMatch>? TeamInMatches { get; set; }
    public ICollection<Prediction>? Predictions { get; set; }
}
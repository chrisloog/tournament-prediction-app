using System.ComponentModel.DataAnnotations;
using Base.Contracts.Domain;
using Helpers.Enums;
using TeamInCompetition = App.BLL.DTO.TeamInCompetition;
using TeamInMatch = App.BLL.DTO.TeamInMatch;

namespace App.BLL.DTO;

public class Team : IDomainEntityId
{
    public Guid Id { get; set; }
    
    [MinLength(1)]
    [MaxLength(64)]
    public string Name { get; set; } = default!;
    
    [MinLength(1)]
    [MaxLength(3)]
    public string ShortName { get; set; } = default!;
    
    public ELeague League { get; set; } = default!;

    public Guid? CountryId { get; set; }
    public Country? Country { get; set; }
    
    public ICollection<Player>? Players { get; set; }
    public ICollection<TeamInCompetition>? TeamInCompetitions { get; set; }
    public ICollection<TeamInMatch>? TeamInMatches { get; set; }
}
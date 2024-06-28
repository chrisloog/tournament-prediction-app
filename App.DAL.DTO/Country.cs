using System.ComponentModel.DataAnnotations;
using App.Domain;
using Base.Contracts.Domain;

namespace App.DAL.DTO;

public class Country : IDomainEntityId
{
    public Guid Id { get; set; }
    
    [MinLength(1)]
    [MaxLength(64)]
    public string Name { get; set; } = default!;
    
    [MinLength(1)]
    [MaxLength(3)]
    public string ShortName { get; set; } = default!;
    
    public ICollection<Team>? Teams { get; set; }
    public ICollection<Player>? Players { get; set; }
}
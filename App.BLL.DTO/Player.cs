using System.ComponentModel.DataAnnotations;
using Base.Contracts.Domain;
using Team = App.BLL.DTO.Team;

namespace App.BLL.DTO;

public class Player : IDomainEntityId
{
    public Guid Id { get; set; }
    
    [MinLength(1)]
    [MaxLength(128)]
    public string Name { get; set; } = default!;

    public Guid? CountryId { get; set; }
    public Country? Country { get; set; }

    public Guid? TeamId { get; set; }
    public Team? Team { get; set; }
}
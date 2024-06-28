using System.ComponentModel.DataAnnotations;
using App.Domain;
using Base.Contracts.Domain;
using Base.Domain;

namespace App.DAL.DTO;

public class Player : IDomainEntityId
{
    public Guid Id { get; set; }
    
    [MinLength(1)]
    [MaxLength(128)]
    public string Name { get; set; } = default!;

    public Guid? CountryId { get; set; }
    public DAL.DTO.Country? Country { get; set; }

    public Guid? TeamId { get; set; }
    public Team? Team { get; set; }
}
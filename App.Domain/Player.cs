using System.ComponentModel.DataAnnotations;
using Base.Domain;

namespace App.Domain;

public class Player : BaseEntityId
{
    [MinLength(1)]
    [MaxLength(128)]
    public string Name { get; set; } = default!;

    public Guid? CountryId { get; set; }
    public Country? Country { get; set; }

    public Guid? TeamId { get; set; }
    public Team? Team { get; set; }
}
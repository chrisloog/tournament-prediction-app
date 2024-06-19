using System.ComponentModel.DataAnnotations;
using Base.Domain;
using Helpers.Enums;

namespace App.Domain;

public class Team : BaseEntityId
{
    [MinLength(1)]
    [MaxLength(64)]
    public string Name { get; set; } = default!;
    
    [MinLength(1)]
    [MaxLength(3)]
    public string ShortName { get; set; } = default!;
    
    public ELeague League { get; set; } = default!;

    public Guid? CountryId { get; set; }
    public Country? Country { get; set; }
    
    // TODO: ICollections
}
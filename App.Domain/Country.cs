using System.ComponentModel.DataAnnotations;
using Base.Domain;

namespace App.Domain;

public class Country : BaseEntityId
{
    [MinLength(1)]
    [MaxLength(64)]
    public string Name { get; set; } = default!;
    
    [MinLength(1)]
    [MaxLength(3)]
    public string ShortName { get; set; } = default!;
    
    // TODO: ICollections
}
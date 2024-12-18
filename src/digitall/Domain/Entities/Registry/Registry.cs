using System.ComponentModel.DataAnnotations;
using Domain.Common;
using Domain.Enums.Registry;

namespace Domain.Entities.Registry;

public class Registry : BaseEntity
{
    [Required] [MaxLength(length: 16)] public string? ImeI_1 { get; set; }
    [MaxLength(length: 16)] public string? ImeI_2 { get; set; }
    
    [Required] public bool AcceptTheRules { get; set; } = true;
    
    [MaxLength(length: 500)] public string? Summery { get; set; } = "";

    [MaxLength(length: 50)] public string? ForWho { get; set; }

    public RegistryStatus Status { get; set; } = RegistryStatus.AwaitingSupportReview;
    
    [Required]
    [MaxLength(11)] public string? Phone { get; set; }
}
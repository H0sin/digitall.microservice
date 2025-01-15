using System.ComponentModel.DataAnnotations;

namespace Domain.DTOs.Registry;

public class AddRegistryDto
{
    [Required] [MaxLength(length: 16)] public string? ImeI_1 { get; set; }
    [MaxLength(length: 16)] public string? ImeI_2 { get; set; }
    [Required] public bool AcceptTheRules { get; set; } = true;
    
    [MaxLength(length: 500)] public string? Summery { get; set; } = "";

    [MaxLength(length: 50)] public string? ForWho { get; set; }
    [MaxLength(length: 11)] [Required] public string Phone { get; set; }
}
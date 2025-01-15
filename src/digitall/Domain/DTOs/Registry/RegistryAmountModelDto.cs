using System.ComponentModel.DataAnnotations;

namespace Domain.DTOs.Registry;

public class RegistryAmountModelDto
{
    public long Id { get; set; }
    [MaxLength(50)] public string? Model { get; set; }
    public long? Price { get; set; }
}
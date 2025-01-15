using System.ComponentModel.DataAnnotations;
using Domain.Common;

namespace Domain.Entities.Registry;

public class RegistrationOptions : BaseEntity
{
    public long PassportPrice { get; set; }
    public int AgentShareFraction { get; set; } = 10;
    
    public string? CardNumber { get; set; }
    
    public ulong? Shaba { get; set; }

    [MaxLength(16)]
    public string? CardHolderName { get; set; }
}
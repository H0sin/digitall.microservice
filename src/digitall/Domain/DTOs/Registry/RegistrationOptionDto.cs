using System.Text.RegularExpressions;
using Domain.Entities.Registry;
using Microsoft.Win32;

namespace Domain.DTOs.Registry;

public class RegistrationOptionDto
{
    public long Id { get; set; }
    public long PassportPrice { get; set; }
    public int AgentShareFraction { get; set; } = 10;
    public string? CardNumber { get; set; }
    public ulong? Shaba { get; set; }
    public string? CardHolderName { get; set; }

    public RegistrationOptionDto()
    {
    }

    public RegistrationOptionDto(RegistrationOptions? option)
    {
        Id = option.Id;
        PassportPrice = option.PassportPrice;
        AgentShareFraction = option.AgentShareFraction;
        CardNumber = option.CardNumber;
        Shaba = option.Shaba;
        CardHolderName = option.CardHolderName;
    }
}
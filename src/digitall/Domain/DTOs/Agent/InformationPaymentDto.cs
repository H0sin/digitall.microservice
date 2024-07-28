using System.ComponentModel.DataAnnotations;

namespace Domain.DTOs.Agent;

public class InformationPaymentDto
{
    public string CardNumber { get; set; }
    public int MaximumAmount { get; set; }
    public int MinimalAmount { get; set; }
    public string? CardHolderName { get; set; }
}
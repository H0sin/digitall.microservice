using Domain.Entities.Agent;
using Microsoft.Extensions.Logging;

namespace Domain.DTOs.Agent;

public class AgentRequestDto
{
    public DateTime CreateDate { get; set; }
    public long UserId { get; set; }
    public string? UserName { get; set; }
    public string? BrandName { get; set; }
    public string? PersianBrandName { get; set; }
    public string? BrandAddress { get; set; }
    public long AgentPercent { get; set; } = 0;
    public long UserPercent { get; set; } = 0;
    public string? Description { get; set; }
    public int MaximumAmount { get; set; } = 2000000;
    public int MinimalAmount { get; set; } = 0;
    public string? CardNumber { get; set; } = "";
    public string? CardHolderName { get; set; } = "";
    public string? PaymentDescription { get; set; }
    public string? AgentRequestStatus { get; set; } = "wating";
    public long Id { get; set; }
    public AgentRequestDto(AgentRequest agentRequest)
    {
        CreateDate = agentRequest.CreateDate;
        UserName = agentRequest.User.FirstName + " " + agentRequest.User.LastName;
        BrandName = agentRequest.BrandName;
        PersianBrandName = agentRequest.PersianBrandName;
        BrandAddress = agentRequest.BrandAddress;
        AgentPercent = agentRequest.AgentPercent ?? 0;
        UserPercent = agentRequest.UserPercent ?? 0;
        Description = agentRequest.Description;
        MaximumAmount = agentRequest.MaximumAmount;
        MinimalAmount = agentRequest.MinimalAmount;
        CardNumber = agentRequest.CardNumber;
        CardHolderName = agentRequest.CardHolderName;
        PaymentDescription = agentRequest.PaymentDescription;
        AgentRequestStatus = agentRequest.AgentRequestStatus;
        Id = agentRequest.Id;
    }
}
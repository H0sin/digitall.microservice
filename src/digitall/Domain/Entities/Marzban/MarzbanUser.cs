using System.ComponentModel.DataAnnotations;
using Domain.Enums.Marzban;
using Domain.Common;
using Domain.Entities.Order;
using Newtonsoft.Json;

namespace Domain.Entities.Marzban;

public class MarzbanUser : BaseEntity
{
    public long MarzbanServerId { get; set; }
    public long MarzbanVpnId { get; set; }

    [MaxLength(500, ErrorMessage = "username")]
    public string Username { get; set; }

    [MaxLength(500, ErrorMessage = "username")]
    public long? Expire { get; set; }
    public long? Data_Limit { get; set; }
    public long UserId { get; set; }
    public long OrderDetailId { get; set; }
    public OrderDetail OrderDetail { get; set; }
    public DateTime? Sub_Updated_At { get; set; }
    public string? Sub_Last_User_Agent { get; set; }
    public DateTime? Online_At { get; set; }
    public string? Subscription_Url { get; set; } = "";
    public long? OnHoldExpireDuration { get; set; }
    public string? OnHoldTimeout { get; set; }
    public string? Status { get; set; } 
    public long? Used_Traffic { get; set; }
    public long? Lifetime_Used_Traffic { get; set; }
    public DateTime? Created_At { get; set; }
    public List<string?> Links { get; set; } = new();
}
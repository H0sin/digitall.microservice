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
    public string Username { get; set; }
    public string? Expire { get; set; }
    public long? Data_Limit { get; set; }
    public long UserId { get; set; }
    public long OrderDetailId { get; set; }
    public OrderDetail OrderDetail { get; set; }
    
    // [JsonProperty("proxies")] public object? Proxies { get; set; }

    // [JsonProperty("data_limit")] public long? Data_Limit { get; set; } = 0;
    //
    // [JsonProperty("data_limit_reset_strategy")]
    // public DataLimitResetStrategy? Data_Limit_Reset_Strategy { get; set; } = DataLimitResetStrategy.No_Reset;
    //
    // [JsonProperty("inbounds")] public Inbounds Inbounds { get; set; }
    // [JsonProperty("note")] public string? Note { get; set; }
    // [JsonProperty("sub_updated_at")] public string? Sub_Updated_At { get; set; }
    // [JsonProperty("sub_last_user_agent")] public string? Sub_Last_User_Agent { get; set; }
    // [JsonProperty("online_at")] public string? Online_At { get; set; }
    //
    // [JsonProperty("on_hold_expire_duration")]
    // public string? On_Hold_Expire_Duration { get; set; }
    //
    // [JsonProperty("on_hold_timeout")] public string? On_Hold_Timeout { get; set; }
    // [JsonProperty("username")] public string? Username { get; set; }
    // [JsonProperty("status")] public string? Status { get; set; }
    // [JsonProperty("used_traffic")] public string? Used_traffic { get; set; }
    //
    // [JsonProperty("lifetime_used_traffic")]
    // public string? Lifetime_Used_Traffic { get; set; }
    //
    // [JsonProperty("created_at")] public string? Created_At { get; set; }
    // [JsonProperty("links")] public string? Links { get; set; }
    // [JsonProperty("subscription_url")] public string? Subscription_Url { get; set; }
    // [JsonProperty("excluded_inbounds")] public string? Excluded_Inbounds { get; set; }
}

// public class Inbounds
// {
//     [JsonProperty("vmess")] public List<string>? Vmess { get; set; } = new();
//     [JsonProperty("vless")] public List<string>? Vless { get; set; } = new();
//     [JsonProperty("shadowsocks")] public List<string>? Shadowsocks { get; set; } = new();
//     [JsonProperty("trojan")] public List<string>? Trojan { get; set; } = new();
// }
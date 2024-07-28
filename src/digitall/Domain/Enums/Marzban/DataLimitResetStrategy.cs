using Newtonsoft.Json;

namespace Domain.Enums.Marzban;

[Flags]
public enum DataLimitResetStrategy : byte
{
    [JsonProperty("no_reset")] No_Reset,
    [JsonProperty("day")] Day,
    [JsonProperty("week")] Week,
    [JsonProperty("month")] Month,
    [JsonProperty("year")] Year
}
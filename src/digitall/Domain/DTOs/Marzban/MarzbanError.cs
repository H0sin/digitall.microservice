using System.Collections;
using Newtonsoft.Json;

namespace Domain.DTOs.Marzban;

public class MarzbanValidationError
{
    [JsonProperty("detail")] public List<MarzbanDetail> Details { get; set; }
}

public partial class MarzbanDetail
{
    [JsonProperty("loc")] public IList Loc { get; set; }

    [JsonProperty("msg")] public string Msg { get; set; }

    [JsonProperty("type")] public string Type { get; set; }
}
using Domain.DTOs.Paging;

namespace Domain.DTOs.Server;

public class FilterServerDto : BasePaging<ServerDto>
{
    public string? ServerAddress { get; set; }
    public string? ServerName { get; set; }
}
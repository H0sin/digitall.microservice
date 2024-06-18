using Domain.Entities.Marzban;

namespace Domain.DTOs.Marzban;

public class GetMarzbanServerOptionDto
{
    public GetMarzbanServerOptionDto()
    {
    }

    public GetMarzbanServerOptionDto(MarzbanServer? server)
    {
        Id = server!.Id;
        ServerName = server!.ServerName;
    }

    public long Id { get; set; }
    public string? ServerName { get; set; }
    public long UserPrice { get; set; }
}
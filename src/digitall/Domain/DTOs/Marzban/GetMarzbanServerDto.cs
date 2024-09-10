using System.ComponentModel.DataAnnotations;
using Domain.Entities.Marzban;

namespace Domain.DTOs.Marzban;

public class GetMarzbanServerDto
{
    public string? ServerName { get; set; }
    public string? ServerIp { get; set; }
    public string? ServerPort { get; set; }
    public bool Ssl { get; set; } = false;
    public string? Path { get; set; }
    public string? UserName { get; set; }
    public string? Password { get; set; }
    public long Users { get; set; }
    public List<string>? HolderInbound { get; set; } = null;
    public string? TypeHolderInbound { get; set; } = null;
    public long Id { get; set; }

    public GetMarzbanServerDto()
    {
    }

    public GetMarzbanServerDto(MarzbanServer server)
    {
        ServerName = server.ServerName;
        ServerIp = server.ServerIp;
        ServerPort = server.ServerPort;
        Ssl = server.Ssl;
        Path = server.Path;
        UserName = server.UserName;
        Password = server.Password;
        Users = server.Users;
        HolderInbound = server.HolderInbound;
        TypeHolderInbound = server.TypeHolderInbound;
        Id = server.Id;
    }
}
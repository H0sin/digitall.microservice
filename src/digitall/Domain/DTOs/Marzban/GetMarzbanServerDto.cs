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

    public GetMarzbanServerDto()
    {

    }

    public GetMarzbanServerDto(MarzbanServer marzban)
    {
        ServerName = marzban.ServerName;
        ServerIp = marzban.ServerIp;
        ServerPort = marzban.ServerPort;
        Ssl = marzban.Ssl;
        Path = marzban.Path;
        UserName = marzban.UserName;
        Password = marzban.Password;
        Users = marzban.Users;
    }
}
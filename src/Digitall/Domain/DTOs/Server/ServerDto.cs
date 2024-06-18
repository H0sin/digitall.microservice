using Domain.Enums.Server;

namespace Domain.DTOs.Server;

public class ServerDto
{
    public ServerDto(Entities.Server.Server server)
    {
        SubPath = server.SubPath;
        CountryId = server.CountryId;
        SubDomain = server.SubDomain;
        SubPort = server.SubPort;
        Id = server.Id;
        ServerAddress = server.ServerAddress;
        ServerName = server.ServerName;
        Port = server.Port;
        UserName = server.UserName;
        Password = server.Password;
        ServerStatus = server.ServerStatus;
    }

    public ServerDto()
    {
    }

    public long Id { get; set; }
    public string ServerName { get; set; }
    public string ServerAddress { get; set; }
    public string UserName { get; set; }
    public string Port { get; set; }
    public string Password { get; set; }
    public long CountryId { get; set; }
    public string SubPath { get; set; }
    public string SubDomain { get; set; }
    public string SubPort { get; set; }

    public ServerStatus ServerStatus { get; set; }

    public string _GetFullPath()
    {
        return ServerAddress + ':' + Port + "/";
    }
}
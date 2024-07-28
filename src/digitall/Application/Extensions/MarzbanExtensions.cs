

using Domain.Entities.Marzban;

namespace Application.Extensions;

public static class MarzbanExtensions
{
    public static string GetFullIpAddress(this MarzbanServer marzbanServer) =>
        "http" +
        (marzbanServer.Ssl ? "s" : "") +
        "://" +
        marzbanServer.ServerIp +
        ":" +
        marzbanServer.ServerPort;

    public static Dictionary<string, string> ToKeyValuePairs(this object obj)
    {
        return obj.GetType().GetProperties()
            .ToDictionary(prop => prop.Name, prop => prop.GetValue(obj)?.ToString());
    }
}
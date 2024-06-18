using Domain.DTOs.Server;

namespace Application.Static;

public static class PathUri
{
    public static string Login = "/login";

    public static string Inbounds = "/panel/api/inbounds";

    public static string InboundsList = Inbounds + "/list";

    public static string AddClient = Inbounds + "/addClient";

    public static string AddInbound = Inbounds + "/add";

    public static string UpdateInbound = Inbounds + "/update";

    public static string DeleteInbound = Inbounds + "/del";
}
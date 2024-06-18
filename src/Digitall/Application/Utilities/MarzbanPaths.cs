using Application.Extensions;

using Domain.Entities.Server;

namespace Application.Utilities;

public static class MarzbanPaths
{
    public static string Login = "/api/admin/token";

    // core
    public static string CoreRestart = "/api/core/restart";
    public static string CoreConfig = "/api/core/config";


    // node
    public static string NodeSettings = "/api/node/settings";
    public static string NodeCreate = "/api/node";
    public static string NodeGet = "/api/node";
    public static string NodeUpdate = "/api/node";
    public static string NodeDelete = "/api/node";

    // user
    public static string UserCreate = "/api/user";

    public static string UserGet = "/api/user";

    // inbound
    public static string InboundGet = "/api/inbounds";

}
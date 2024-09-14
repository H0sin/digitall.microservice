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
    public static string UserUpdate = "/api/user";
    public static string UserDelete = "/api/user";
    public static string UsersExpire = "/api/users/expired";
    public static string UsersReset(string username) => $"/api/user/{username}/reset";

    public static string UserDeleteExpire(string? before = null, string? after = null)
    {
        string query = "/api/users/expired";
        if (before != null)
            query += $"?expired_before={before}";

        if (before != null & after != null)
        {
            query += $"&expired_after={after}";
        }

        if (after != null)
        {
            query += $"?expired_after={after}";
        }

        return query;
    }


    // inbound
    public static string InboundGet = "/api/inbounds";
}
using Microsoft.AspNetCore.Hosting;

namespace Application.Utilities
{
    public static class PathExtension
    {
        public static string DefaultAvatar = "/images/faces/face7.jpg";

        public static string UserAvatarOrigin = "/images/UserAvatar/origin/";
        // public static string UserAvatarOriginServer = "/app/wwwroot/images/UserAvatar/origin/";

        public static string UserAvatarThumb = "/images/UserAvatar/thumb/";
        // public static string UserAvatarThumbServer = "/app/wwwroot/images/UserAvatar/thumb/";

        public static string ProductAvatarOrigin = "/images/ProductAvatar/origin/";
        // public static string ProductAvatarOriginServer = "/app/wwwroot/images/ProductAvatar/origin/";

        public static string ProductAvatarThumb = "/images/ProductAvatar/thumb/";
        // public static string ProductAvatarThumbServer = "/app/wwwroot/images/ProductAvatar/thumb/";

        public static string TransactionAvatarOrigin = "/images/TransactionAvatar/origin/";
        // public static string TransactionAvatarOriginServer = "/app/wwwroot/images/TransactionAvatar/origin/";

        public static string TransactionAvatarThumb = "/images/TransactionAvatar/thumb/";
        // public static string TransactionAvatarThumbServer = "/app/wwwroot/images/TransactionAvatar/thumb/";

        public static string FileOrigin = "/files/Origin/";
        // public static string FileOriginServer = "/app/wwwroot/files/Origin/";
        
        public static string GetServerPath(string relativePath, IWebHostEnvironment env)
        {
            return Path.Combine(env.WebRootPath, relativePath.TrimStart('/'));
        }

        public static string UserAvatarOriginServer(IWebHostEnvironment env) => GetServerPath(UserAvatarOrigin, env);
        public static string UserAvatarThumbServer(IWebHostEnvironment env) => GetServerPath(UserAvatarThumb, env);

        public static string ProductAvatarOriginServer(IWebHostEnvironment env) => GetServerPath(ProductAvatarOrigin, env);
        public static string ProductAvatarThumbServer(IWebHostEnvironment env) => GetServerPath(ProductAvatarThumb, env);

        public static string TransactionAvatarOriginServer(IWebHostEnvironment env) => GetServerPath(TransactionAvatarOrigin, env);
        public static string TransactionAvatarThumbServer(IWebHostEnvironment env) => GetServerPath(TransactionAvatarThumb, env);

        public static string FileOriginServer(IWebHostEnvironment env) => GetServerPath(FileOrigin, env);
    }
}
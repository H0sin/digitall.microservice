namespace Application.Utilities
{
    public static class PathExtension
    {
        #region default images

        public static string DefaultAvatar = "/images/faces/face7.jpg";

        #endregion

        #region user avatar

        public static string UserAvatarOrigin = "/Content/Images/UserAvatar/origin/";

        public static string UserAvatarOriginServer =
            Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Content/Images/UserAvatar/origin/");

        public static string UserAvatarThumb = "/Content/Images/UserAvatar/thumb/";

        public static string UserAvatarThumbServer =
            Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Content/Images/UserAvatar/thumb/");

        #endregion

        #region product

        public static string ProductAvatarOrigin = "/Content/Images/ProductAvatar/origin/";

        public static string ProductAvatarOriginServer = Path.Combine(Directory.GetCurrentDirectory(),
            "wwwroot/Content/Images/ProductAvatar/origin/");

        public static string ProductAvatarThumb = "/Content/Images/ProductAvatar/thumb/";

        public static string ProductAvatarThumbServer = Path.Combine(Directory.GetCurrentDirectory(),
            "wwwroot/Content/Images/ProductAvatar/thumb/");

        #endregion

        #region transaction

        public static string TransactionAvatarOrigin = "/Content/Images/TransactionAvatar/origin/";

        public static string TransactionAvatarOriginServer = Path.Combine(Directory.GetCurrentDirectory(),
            "wwwroot/Content/Images/TransactionAvatar/origin/");

        public static string TransactionAvatarThumb = "/Content/Images/TransactionAvatar/thumb/";

        public static string TransactionAvatarThumbServer = Path.Combine(Directory.GetCurrentDirectory(),
            "wwwroot/Content/Images/TransactionAvatar/thumb/");

        #endregion

        #region file

        public static string FileOrigin = "wwwroot/Content/Files/Origin/";

        public static string FileOriginOriginServer = Path.Combine(Directory.GetCurrentDirectory(),
            "wwwroot/Content/Files/Origin/");

        #endregion
    }
}
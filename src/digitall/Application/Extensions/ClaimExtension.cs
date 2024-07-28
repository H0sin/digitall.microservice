using System.Security.Claims;

namespace Application.Extensions
{
    public static class ClaimExtension
    {
        public static bool IsUserSupperAdmin(this ClaimsPrincipal principal)
        {
            var claim = principal.Claims.SingleOrDefault(s => s.Type == "UserSupperAdmin");
            if (claim != null)
            {
                bool userAdmin = Convert.ToBoolean(claim.Value);
                return userAdmin;
            }

            return default;
        }

        public static long GetId(this ClaimsPrincipal principal)
        {
            var claim = principal.Claims.SingleOrDefault(s => s.Type == ClaimTypes.NameIdentifier);
            if (claim != null)
            {
                var userId = Convert.ToInt64(claim.Value);
                if (userId != 0) return userId;
            }
            return default;
        }

        public static List<long> GetRolseId(this ClaimsPrincipal principal)
        {
            var claim = principal.Claims.SingleOrDefault(s => s.Type == ClaimTypes.Role);
            if (claim != null)
            {

                List<long> roleIdLong = new List<long>();
                string[] roleId = claim.Value.Split(",");
                foreach (var id in roleId)
                {
                    try
                    {
                        roleIdLong.Add(Convert.ToInt64(id));
                    }
                    catch (Exception e)
                    {

                    }
                }

                if (roleIdLong.Count > 0)
                    return roleIdLong;
            }
            return default;
        }
    }
}

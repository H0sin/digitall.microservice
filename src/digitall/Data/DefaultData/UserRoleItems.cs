using Domain.Entities.Authorization;

namespace Data.DefaultData;

public class UserRoleItems
{
    public static List<UserRole> UserRoles = new()
    {
        new UserRole()
        {
            Id = 1,
            RoleId = 1,
            UserId = 1,
            CreateBy = 1,
            CreateDate = DateTime.Now,
            ModifiedDate = DateTime.Now,
            ModifyBy = 1
        },
        new UserRole()
        {
            Id = 2,
            RoleId = 4,
            UserId = 1,
            CreateBy = 1,
            CreateDate = DateTime.Now,
            ModifiedDate = DateTime.Now,
            ModifyBy = 1
        }
    };
}
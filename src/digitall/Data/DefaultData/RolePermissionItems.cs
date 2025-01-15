using Domain.Entities.Authorization;

namespace Data.DefaultData;

public class RolePermissionItems
{
    public static List<RolePermission> RolePermissions = new()
    {
        new()
        {
            Id = 1,
            RoleId = 1,
            PermissionId = 1,
            CreateBy = 1,
            CreateDate = DateTime.Now,
            IsDelete = false,
            ModifyBy = 1,
            ModifiedDate = DateTime.Now
        },
        new RolePermission()
        {
            Id = 17,
            RoleId = 1,
            PermissionId = 17,
            CreateBy = 1,
            CreateDate = DateTime.Now,
            IsDelete = false,
            ModifyBy = 1,
            ModifiedDate = DateTime.Now
        },
        new RolePermission()
        {
            Id = 18,
            RoleId = 1,
            PermissionId = 18,
            CreateBy = 1,
            CreateDate = DateTime.Now,
            IsDelete = false,
            ModifyBy = 1,
            ModifiedDate = DateTime.Now
        }
    };
}
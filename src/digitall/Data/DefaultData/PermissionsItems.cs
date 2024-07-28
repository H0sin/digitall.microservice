using Domain.Entities.Authorization;

namespace Data.DefaultData;

public class PermissionsItems
{
    public static List<Permission> Permissions = new List<Permission>()
    {
        new Permission
        {
            Id = 1,
            ModifyBy = 1,
            CreateBy = 1,
            CreateDate = DateTime.Now,
            ModifiedDate = DateTime.Now,
            IsDelete = false,
            Title = "لیست کاربران",
            SystemName = "FilterUsers"
        }
    };
}
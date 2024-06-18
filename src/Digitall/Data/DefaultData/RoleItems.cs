using Domain.Entities.Authorization;

namespace Data.DefaultData;

public class RoleItems
{
    public static List<Role> Roles = new List<Role>()
    {
        new Role()
        {
            Id = 1,
            Title = "مدیر",
            CreateBy = 1,
            CreateDate = DateTime.Now,
            ModifiedDate = DateTime.Now,
            ModifyBy = 1,
        },
        new Role()
        {
            Id = 2,
            Title = "همکار",
            CreateBy = 1,
            CreateDate = DateTime.Now,
            ModifiedDate = DateTime.Now,
            ModifyBy = 1,
        },
        new Role()
        {
            Id = 3,
            Title = "کاربر",
            CreateBy = 1,
            CreateDate = DateTime.Now,
            ModifiedDate = DateTime.Now,
            ModifyBy = 1,
        }
    };
}
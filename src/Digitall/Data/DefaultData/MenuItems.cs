using Domain.Entities;
using Domain.Entities.Menu;

namespace Data.DefaultData;

public class MenuItems
{
    public static List<Menu> Menu = new List<Menu>()
    {
        #region doshboard

        new Menu()
        {
            Id = 1,
            CreateBy = 1,
            ModifyBy = 1,
            Active = true,
            ModifiedDate = DateTime.Now,
            CreateDate = DateTime.Now,
            Sorted = 1,
            Title = "اصلی",
        },
        new Menu()
        {
            Id = 2,
            CreateBy = 1,
            ModifyBy = 1,
            Active = true,
            ModifiedDate = DateTime.Now,
            CreateDate = DateTime.Now,
            Sorted = 2,
            Link = "/",
            Title = "داشبورد",
            Icon = "box",
            ParentId = 1,
            Area = "",
            Controller = "Home",
            Action = "Index",
        },

        #endregion

        #region users

        new Menu()
        {
            Id = 3,
            CreateBy = 1,
            ModifyBy = 1,
            Active = true,
            ModifiedDate = DateTime.Now,
            CreateDate = DateTime.Now,
            Sorted = 3,
            Title = "عملیات",
        },

        new Menu()
        {
            Id = 4,
            CreateBy = 1,
            ModifyBy = 1,
            Active = true,
            ModifiedDate = DateTime.Now,
            CreateDate = DateTime.Now,
            Sorted = 4,
            Title = "کاربران",
            Icon = "list",
            ParentId = 3
        },


        new Menu()
        {
            Id = 5,
            CreateBy = 1,
            ModifyBy = 1,
            Active = true,
            ModifiedDate = DateTime.Now,
            CreateDate = DateTime.Now,
            Sorted = 5,
            Title = "لیست کاربران",
            ParentId = 4,
            Link = "Account/Users",
            Area = "",
            Controller = "Account",
            Action = "Users",
        },

        new Menu()
        {
            Id = 6,
            CreateBy = 1,
            ModifyBy = 1,
            Active = true,
            ModifiedDate = DateTime.Now,
            CreateDate = DateTime.Now,
            Sorted = 6,
            Title = "لیست همه کاربران",
            ParentId = 4,
            Link = "Account/AllUsers",
            Area = "",
            Controller = "Account",
            Action = "AllUsers",
        },

        #endregion
    };
}
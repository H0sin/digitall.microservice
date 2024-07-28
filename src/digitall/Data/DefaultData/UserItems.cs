using Domain.Entities.Account;

namespace Data.DefaultData;

public class UserItems
{
    public static List<User> Users = new List<User>()
    {
        new User
        {
            Id = 1,
            Mobile = "09913737962",
            Avatar = "",
            FirstName = "حسین",
            LastName = "فرجی",
            CreateBy = 1,
            ModifyBy = 1,
            CreateDate = DateTime.Now,
            ModifiedDate = DateTime.Now,
            Password = "FC-EA-92-0F-74-12-B5-DA-7B-E0-CF-42-B8-C9-37-59",
            IsBlocked = false,
            AgentId = 100001,
            MobileActiveCode = new Random().Next(10000, 999999).ToString(),
            IsMobileActive = true,
            Email = "h.faraji8079@gmail.com",
            IsEmailActive = true,
            EmailActiveCode = Guid.NewGuid().ToString("N"),
        }
    };
}
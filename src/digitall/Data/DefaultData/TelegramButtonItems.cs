using Domain.Entities.Telegram;

namespace Data.DefaultData;

public class TelegramButtonItems
{
    public static List<TelegramButtons> TelegramButtons = new()
    {
        new()
        {
            CreateDate = DateTime.Now,
            Name = "master_digitall_vpn_bot",
            Link = "https://t.me/master_digitall_vpn_bot",
            IsDelete = false,
            CreateBy = 1,
            Id = 1,
            ModifiedDate = DateTime.Now,
            ModifyBy = 1,
            Title = "شروع ربات",
            IsLike = true,
        }
    };
}
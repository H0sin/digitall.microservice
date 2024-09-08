using Domain.Entities.Telegram;

namespace Data.DefaultData;

public static class TelegramBotItems
{ 
    public static List<TelegramBot> TelegramBots = new()
    {
        new()
        {
            Description = "ربات مستر ما",
            AgentId = 100001,
            CreateDate = DateTime.Now,
            Id = 1,
            BotId = 7419690675,
            Name = "master_digitall_vpn_bot",
            Link = "https://t.me/master_digitall_vpn_bot",
            Route = "/7332050396:AAHvkWaF4MhUb3U8yfvSlD1y81i_jF2tCN0",
            HostAddress = "https://364c-80-240-30-200.ngrok-free.app",
            Token = "7332050396:AAHvkWaF4MhUb3U8yfvSlD1y81i_jF2tCN0",
            PersionName = "ربات اصلی مستر",
            IsDelete = false,
            CreateBy = 1,
            SecretToken = "",
            ModifiedDate = DateTime.Now,
            ModifyBy = 1, 
        }
    };
}
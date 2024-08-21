using Domain.DTOs.Notification;
using Domain.DTOs.Telegram;
using Domain.Enums.Notification;

namespace Application.Static.Template;

public static class NotificationTemplate
{
    public static AddNotificationDto Welcome(long? userId = 0, string message = "خوش آمدید")
    {
        return new AddNotificationDto()
        {
            Expire = DateTime.Now.AddHours(2),
            Message = message,
            NotificationType = NotificationType.Success,
            UserId = userId,
            ForAllMember = false
        };
    }

    public static AddNotificationDto NewRequestForAgent(long userId, string userName, string description,
        string? telegramUsername = null,
        List<ButtonJsonDto>? buttonJson = null)
    {
        string message = $@"
        📣 یک کاربر درخواست نمایندگی ثبت کرده لطفا اطلاعات را بررسی و وضعیت را مشخص کنید.

        آیدی عددی : {userId}
        نام کاربری : {userName}
         شناسه تلگرام:{telegramUsername ?? ""}
        توضیحات : {description}";

        return new AddNotificationDto()
        {
            Expire = DateTime.Now.AddHours(24),
            Message = message,
            NotificationType = NotificationType.Warning,
            UserId = userId,
            ForAllMember = false,
            Buttons = buttonJson
        };
    }

    public static AddNotificationDto ChangeRequestAgent(long userId, string status)
    {
        return new AddNotificationDto()
        {
            Expire = DateTime.Now.AddHours(24),
            Message = $"درخواست نمایندگی شما {status}  شد",
            NotificationType = NotificationType.Warning,
            UserId = userId,
            ForAllMember = false
        };
    }

    public static AddNotificationDto StartedBotNotification(long userId, string? name, long chatId)
    {
        return new AddNotificationDto()
        {
            Expire = DateTime.Now.AddHours(24),
            Message = $"""
                       کاربری با ایدی
                       @{name}
                       و شناسه
                       {chatId}
                       ربات را استارت کرد
                       """,
            NotificationType = NotificationType.Warning,
            UserId = userId,
            ForAllMember = false
        };
    }
}
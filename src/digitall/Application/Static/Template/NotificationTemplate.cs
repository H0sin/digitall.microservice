using Application.Helper;
using Domain.DTOs.Account;
using Domain.DTOs.Notification;
using Domain.DTOs.Telegram;
using Domain.Entities.Transaction;
using Domain.Enums.Notification;
using Domain.Enums.Transaction;

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

    public static AddNotificationDto NewRequestForAgent(long userId, string userName, string phone, string description,
        string? telegramUsername = null,
        List<ButtonJsonDto>? buttonJson = null)
    {
        string message = $@"
        📣 یک کاربر درخواست نمایندگی ثبت کرده لطفا اطلاعات را بررسی و وضعیت را مشخص کنید.

        آیدی عددی : {userId}
        نام کاربری : {userName}
         شماره تماس :{phone}
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

    public static AddNotificationDto StartedBotNotification(long userId, string? name, bool cartToCard, long chatId)
    {
        List<ButtonJsonDto> buttons = new();

        if (!cartToCard)
            buttons.Add(new("فعال سازی کارت به کارت", $"action_card?id={chatId}&action={!cartToCard}"));
        else
            buttons.Add(new("غیر فعال سازی کارت به کارت", $"action_card?id={chatId}&action={!cartToCard}"));

        buttons.Add(new("مدیریت کاربر", $"user_management?id={chatId}"));

        return new AddNotificationDto()
        {
            Expire = DateTime.Now.AddHours(24),
            Message = $"""
                       کاربری با ایدی
                       @{name}
                       و شناسه
                       `\{chatId}`\
                       ربات را استارت کرد
                       """,
            NotificationType = NotificationType.Warning,
            UserId = userId,
            ForAllMember = false,
            Buttons = buttons
        };
    }

    public static AddNotificationDto TransactionStatusAsync(long userId, Transaction transaction)
    {
        string status = transaction.TransactionStatus == TransactionStatus.Accepted
            ? $"""
                   ✅ تراکنش شما با کد {transaction.TransactionCode}با موفقیت پذیرفته شد!
                   💰 مبلغ {transaction.Price:N0} تومان به موجودی حساب شما افزوده شد.
               """
            : $"""
                   ❌ متأسفانه تراکنش شما با کد  {transaction.TransactionCode}رد شده است.
                   لطفاً مجدداً تلاش کنید یا با پشتیبانی تماس بگیرید.
               """;

        return new AddNotificationDto()
        {
            Message = status,
            NotificationType = NotificationType.Alter,
            UserId = userId,
            ForAllMember = false,
        };
    }

    public static AddNotificationDto ErrorForAddTransactionNotification(long userId, string userName, long chatId,
        long price, bool notSeeCardToCard = false)
    {
        string message = notSeeCardToCard
            ? $"""
                ⚠️ خطا در پرداخت
               کاربری با شناسه چت : `\{chatId}`\
                نام کاربری : @{userName}
               قصد داشت تراکنشی با مبلغ {price:N0} تومان انجام دهد، اما به دلیل عدم فعال بودن درگاه کارت به کارت برای این کاربر،
               تراکنش انجام نشد
               """
            : $"""
                ⚠️ خطا در پرداخت
               کاربری با شناسه چت : `\{chatId}`\
                نام کاربری : @{userName}
               قصد داشت تراکنشی با مبلغ {price:N0} تومان انجام دهد، اما به دلیل عدم وجود شماره کارت، تراکنش انجام نشد.
               لطفا شماره کارت خود را از پنل مدیریت نمایندگی تنظیم کنید
               """;


        return new AddNotificationDto()
        {
            Message = message,
            NotificationType = NotificationType.Alter,
            UserId = userId,
            ForAllMember = false,
        };
    }

    public static AddNotificationDto AddTransactionNotification(long userId, long chatId, Transaction transaction,
        string newTransactionAvatarTransaction, string fileCaption, string? userName = null)
    {
        List<ButtonJsonDto> buttons = new()
        {
            new("رد پرداخت \u274c", $"update_trans?status=NotAccepted&id={transaction.Id}"),
            new("تایید پرداخت \u2705", $"update_trans?status=Accepted&id={transaction.Id}"),
            new("بلاک کردن کاربر \u2b55\ufe0f", $"blocked_user?id={chatId}"),
            new("افزایش دستی موجودی \u2b55\ufe0f", $"increase_by_agent?id={chatId}")
        };

        userName = userName == null ? "ندارد" : "@" + userName;
        return new AddNotificationDto()
        {
            Message = $"""
                       ⭕️ یک پرداخت جدید انجام شده است .
                       افزایش موجودی
                       👤 شناسه کاربر:`\{chatId}`\
                       🛒 کد پیگیری پرداخت: {transaction.TransactionCode}
                       ⚜️ نام کاربری: {userName}
                       💸 مبلغ پرداختی: {transaction.Price:N0} تومان
                       توضیحات:
                       ✍️ در صورت درست بودن رسید پرداخت را تایید نمایی
                       """,
            NotificationType = NotificationType.Alter,
            UserId = userId,
            ForAllMember = false,
            FileAddress = newTransactionAvatarTransaction,
            FileCaption = fileCaption,
            Buttons = buttons
        };
    }

    public static List<AddNotificationDto> IncomeFromPaymentAsync(List<CalculatorUserIncome> incomes,
        string? userName,
        long chatId,
        long price,
        DateTime createServiceTime)
    {
        List<AddNotificationDto> notifications = new();
        string persianTime = PersianDateTimeHelper.GetPersianDateTime(createServiceTime);
        foreach (var income in incomes)
        {
            string? price_No = $"{price:N0}";
            string? balance_No = $"{income.Balance:NO}";
            string message = $"""
                              🛍 خرید جدید
                              کاربری با شناسه :`\{chatId}`\
                              نام کاربری :@{userName}
                              سفارسی ثبت کرد
                              سود شما از خرید:{balance_No} تومان
                              مبلغ کسر شده از موجودی کاربر:{price_No} تومان
                              تاریخ خرید سرویس:{persianTime}
                              """;

            notifications.Add(new AddNotificationDto()
            {
                Message = message,
                NotificationType = NotificationType.Alter,
                UserId = income.UserId,
                ForAllMember = false,
            });
        }

        return notifications;
    }
}
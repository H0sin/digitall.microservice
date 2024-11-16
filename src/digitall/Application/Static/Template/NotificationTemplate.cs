using Application.Helper;
using Data.Migrations;
using Domain.DTOs.Account;
using Domain.DTOs.Notification;
using Domain.DTOs.Telegram;
using Domain.DTOs.Transaction;
using Domain.Entities.Apple;
using Domain.Entities.Marzban;
using Domain.Entities.Notification;
using Domain.Entities.Order;
using Domain.Entities.Transaction;
using Domain.Enums.Notification;
using Domain.Enums.Transaction;
using Telegram.Bot.Types;
using User = Domain.Entities.Account.User;

namespace Application.Static.Template;

public static class NotificationTemplate
{
    public static AddNotificationDto WarrantyNotificationForSupports(AppleId appleId)
        => new()
        {
            Message = $"""
                       🚨🚨 درخواست جدید گارانتی اپل آیدی! 🚨🚨
                       
                       🆘📣 توجه، پشتیبان عزیز! 📣🆘
                       🔔 یک درخواست گارانتی اپل آیدی از طرف مشتری ثبت شده است.
                       
                       🤔 شما انجام می‌دهید؟ 🤔
                       ⚠️ توجه: فقط یک پشتیبان می‌تواند این درخواست را قبول کند اگر شما این درخواست را تایید کنید، سایر پشتیبان‌ها قادر به قبول آن نخواهند بود!
                       
                       📍 لطفاً هرچه سریع‌تر تصمیم بگیرید تا فرآیند رسیدگی به درخواست مشتری آغاز شود ⏳
                       
                       با کلیک روی دکمه زیر، شما مسئول رسیدگی به این درخواست می‌شوید و سایر پشتیبان‌ها دسترسی به این درخواست نخواهند داشت
                       """,
            NotificationType = NotificationType.Alter,
            UserId = 0,
            Buttons = new()
            {
                new("من انجام میدهم ✅", $"assign_appleId_tome?id={appleId.Id}"),
            }
        };


    public static AddNotificationDto SetBrandName(long userId)
        => new()
        {
            Message = """
                      🚨 شما هنوز نام نمایندگی‌تان را ست نکرده‌اید! 🚨

                      📢🔥 نام نمایندگی خودت را ست کن! 🔥📢

                      ✨ چرا مهمه؟
                      با ست کردن نام نمایندگی، اشتراک‌هایی که شما و زیرمجموعه‌تان خرید می‌کنید، با برند خودتان ساخته می‌شود. این یعنی تبلیغ رایگان برای شما و امکان مدیریت آسان‌تر اشتراک‌های مشتریان برای تمدید و پشتیبانی بهتر. 😉

                      🛠 چطور نام نمایندگی را ثبت کنیم؟
                      ۱. وارد مدیریت پنل نمایندگی شوید. ✏️
                      ۲. گزینه ثبت | تغییر نام نمایندگی را انتخاب کنید. 🔘

                      ⬇️👇 دکمه زیر را بزنید تا تنظیماتتان را تکمیل کنید 👇⬇️
                      """,
            NotificationType = NotificationType.Alter,
            UserId = userId,
            Buttons = new() { new ButtonJsonDto("تغییر نام نماینگی ✏️", "set_branding_name") }
        };

    public static AddNotificationDto DecreaseForDeleteService(long userId, string srvicename, long profit) =>
        new()
        {
            Message = $"""
                       🛑 سرویس {srvicename} با موفقیت حذف شد.
                       🔻 مبلغ سود شما از فروش سرویس کسر گردید.
                       💸 مبلغ کسر شده: {profit:N0} تومان.
                       """,
            UserId = userId,
            Expire = DateTime.Now.AddHours(2),
            NotificationType = NotificationType.DeletedReports
        };


    public static AddNotificationDto
        SendDeleteMarzbanUserNotificationForAgent(long userId, string message, long serviceId) =>
        new()
        {
            Message = message,
            UserId = userId,
            Buttons = new()
            {
                new("عدم تایید حذف سرویس 🚫", $"not_deleted_service?id={serviceId}"),
                new("حذف سرویس 🗑", $"deleted_service?id={serviceId}")
            },
            Expire = DateTime.Now.AddHours(2),
            NotificationType = NotificationType.DeletedReports
        };


    public static AddNotificationDto SendDeleteWireguardAccountNotificationForAgent(long userId, string message,
        long peerId) =>
        new()
        {
            Message = message,
            UserId = userId,
            Buttons = new()
            {
                new("عدم تایید حذف سرویس 🚫", $"not_deleted_wg_service?id={peerId}"),
                new("حذف سرویس 🗑", $"deleted_wg_service?id={peerId}")
            },
            Expire = DateTime.Now.AddHours(2),
            NotificationType = NotificationType.DeletedReports
        };

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

    public static AddNotificationDto NewRequestForAgent(long userId, long chatId, string userName, string phone,
        string description,
        string? telegramUsername = null,
        List<ButtonJsonDto>? buttonJson = null)
    {
        string name = userName != null ? "@" + userName : "@NOT_USERNAME";
        string message = $"""
                          📣 یک کاربر درخواست نمایندگی ثبت کرده است. لطفاً اطلاعات زیر را بررسی و وضعیت را مشخص کنید:
                          آیدی عددی:`\{chatId}`\
                          نام کاربری: {name}
                          شماره تماس: {phone}
                          توضیحات: {description}
                          """;

        return new AddNotificationDto()
        {
            Expire = DateTime.Now.AddHours(24),
            Message = message,
            NotificationType = NotificationType.AgentRequestReports,
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
            NotificationType = NotificationType.AgentRequestReports,
            UserId = userId,
            ForAllMember = false
        };
    }

    public static AddNotificationDto StartedBotNotification(long userId, string? name, bool cartToCard, long id,
        long chatId)
    {
        List<ButtonJsonDto> buttons = new();

        if (!cartToCard)
            buttons.Add(new("فعال سازی کارت به کارت", $"action_card?id={id}&action={!cartToCard}"));
        else
            buttons.Add(new("غیر فعال سازی کارت به کارت", $"action_card?id={id}&action={!cartToCard}"));

        buttons.Add(new("مدیریت کاربر", $"user_management?id={id}"));


        string username = name != null ? "@" + name : "@NOT_USERNAME";

        return new AddNotificationDto()
        {
            Expire = DateTime.Now.AddHours(24),
            Message = $"""
                       🌟 نماینده محترم: 🌟
                       نام کاربری: {username}
                       شناسه: `\{chatId}`\
                       ربات را آغاز کرد. 🎉
                       """,
            NotificationType = NotificationType.StartReports,
            UserId = userId,
            ForAllMember = false,
            Buttons = buttons
        };
    }

    public static AddNotificationDto TransactionStatusAsync(long userId, Transaction transaction)
    {
        string status = transaction.TransactionStatus == TransactionStatus.Accepted
            ? $"""
               ✅ تراکنش شما با کد
               {transaction.TransactionCode}
               با موفقیت پذیرفته شد! 🎉
               💰 مبلغ {transaction.Price:N0} تومان به موجودی حساب شما افزوده شد.
               """
            : $"""
               ❌ متأسفانه تراکنش شما با کد
               {transaction.TransactionCode}
               رد شده است. 😔
               لطفاً مجدداً تلاش کنید یا با پشتیبانی تماس بگیرید. 📞
               """;

        return new AddNotificationDto()
        {
            Message = status,
            NotificationType = NotificationType.FinancialReports,
            UserId = userId,
            ForAllMember = false,
        };
    }

    public static AddNotificationDto ErrorForAddTransactionNotification(long userId, string userName, long chatId,
        long price, bool notSeeCardToCard = false, long? childUserId = null)
    {
        List<ButtonJsonDto> buttons = new()
        {
            new ButtonJsonDto("فعال کردن شماره کارت 🟢", $"action_card?id={childUserId ?? 0}&action={true}")
        };

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
            Buttons = notSeeCardToCard ? buttons : null
        };
    }

    public static AddNotificationDto AddTransactionNotification(long userId, long chatId, Transaction transaction,
        string newTransactionAvatarTransaction, string fileCaption, string? userName = null)
    {
        List<ButtonJsonDto> buttons = new()
        {
            new("رد پرداخت \u274c", $"update_trans?status=NotAccepted&id={transaction.Id}"),
            new("تایید پرداخت \u2705", $"update_trans?status=Accepted&id={transaction.Id}"),
            new("بلاک کردن کاربر \u2b55\ufe0f", $"blocked_user?id={transaction.CreateBy}"),
            new("افزایش دستی موجودی \u2b55\ufe0f", $"increase_by_agent?id={transaction.CreateBy}")
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
            NotificationType = NotificationType.FinancialReports,
            UserId = userId,
            ForAllMember = false,
            FileAddress = newTransactionAvatarTransaction,
            FileCaption = fileCaption,
            Buttons = buttons,
            Expire = DateTime.Now.AddHours(2),
        };
    }

    public static AddNotificationDto IncomeFromPaymentAsync(CalculatorUserIncome income,
        string? userName,
        long chatId,
        long price,
        long userbalance,
        DateTime createServiceTime,
        bool renewal = false,
        string marzbanVpnName = "",
        string marzbanUsername = null,
        bool isLargestAgent = false)
    {
        string persianTime = PersianDateTimeHelper.GetPersianDateTime(createServiceTime);
        string message = "";
        if (renewal)
        {
            if (isLargestAgent)
            {
                message = $"""
                           🔄🛍 **تمدید جدید**
                           👤 کاربری با شناسه : `\{chatId}`
                           📦 نوع سرویس : {marzbanVpnName}
                           📧 نام کاربری : @{userName}
                           ✨ سرویسی را تمدید کرد
                           📋 نام سرویس : {marzbanUsername}
                           💰 سود شما از تمدید : {income.Balance:N0} تومان
                           💼 موجودی شما قبل از تمدید : {income.BalanceBeforPayment:N0} تومان
                           📈 موجودی شما بعد از تمدید : {(income.Balance + income.BalanceBeforPayment):N0} تومان
                           📉 مبلغ کسر شده از موجودی کاربر : {price:N0} تومان
                           💳 موجودی فعلی کاربر : {userbalance:N0} تومان
                           🕰️ موجودی کاربر قبل از تمدید : {(userbalance + price):N0} تومان
                           🗓️ تاریخ تمدید سرویس : {persianTime}
                           """;
            }
            else
            {
                message = $"""
                           🔄🛍 **تمدید جدید**
                           👥 زیر مجموعه نماینده شما سرویسی را تمدید کرد
                           🆔 شناسه نماینده : `\{income.chatId}`
                           📦 نوع سرویس : {marzbanVpnName}
                           💰 سود شما از تمدید : {income.Balance:N0} تومان
                           💼 موجودی شما قبل از تمدید : {income.BalanceBeforPayment:N0} تومان
                           📈 موجودی شما بعد از تمدید : {(income.Balance + income.BalanceBeforPayment):N0} تومان
                           📉 مبلغ کسر شده از موجودی کاربر : {price:N0} تومان
                           💳 موجودی فعلی کاربر : {userbalance:N0} تومان
                           🕰️ موجودی کاربر قبل از تمدید : {(userbalance + price):N0} تومان
                           🗓️ تاریخ تمدید سرویس : {persianTime}
                           """;
            }
        }
        else
        {
            if (isLargestAgent)
            {
                message = $"""
                           🛍🆕 **خرید جدید**
                           👤 کاربری با شناسه : `\{chatId}`
                           📦 نوع سرویس : {marzbanVpnName}
                           📧 نام کاربری : @{userName}
                           📝 سفارسی ثبت کرد
                           📋 نام سرویس : {marzbanUsername}
                           💰 سود شما از خرید : {income.Balance:N0} تومان
                           💼 موجودی شما قبل از خرید : {income.BalanceBeforPayment:N0} تومان
                           📈 موجودی شما بعد از خرید : {(income.Balance + income.BalanceBeforPayment):N0} تومان
                           📉 مبلغ کسر شده از موجودی کاربر : {price:N0} تومان
                           💳 موجودی فعلی کاربر : {userbalance:N0} تومان
                           🕰️ موجودی کاربر قبل از خرید : {(userbalance + price):N0} تومان
                           🗓️ تاریخ خرید سرویس : {persianTime}
                           """;
            }
            else
            {
                message = $"""
                           🛍🆕 **خرید جدید **
                           👥زیر مجموعه نماینده شما سرویسی را خرید کرد
                           🆔 شناسه نماینده : `\{income.chatId}`
                           📦 نوع سرویس : {marzbanVpnName}
                           📋 نام سرویس : {marzbanUsername}
                           💰 سود شما از تمدید : {income.Balance:N0} تومان
                           💼 موجودی شما قبل از تمدید : {income.BalanceBeforPayment:N0} تومان
                           📈 موجودی شما بعد از تمدید : {(income.Balance + income.BalanceBeforPayment):N0} تومان
                           📉 مبلغ کسر شده از موجودی کاربر : {price:N0} تومان
                           💳 موجودی فعلی کاربر : {userbalance:N0} تومان
                           🕰️ موجودی کاربر قبل از تمدید : {(userbalance + price):N0} تومان
                           🗓️ تاریخ خرید سرویس : {persianTime}
                           """;
            }
        }

        return new()
        {
            Message = message,
            UserId = income.UserId,
            ForAllMember = false,
            Expire = DateTime.Now.AddHours(2),
            NotificationType = renewal ? NotificationType.RenewReports : NotificationType.BuyReports
        };
    }

    public static List<AddNotificationDto> IncomeFromPaymentAsync(List<CalculatorUserIncome> incomes,
        string? userName,
        long chatId,
        long price,
        long userbalance,
        DateTime createServiceTime,
        bool renewal = false,
        string marzbanVpnName = "",
        string marzbanUsername = null)
    {
        List<AddNotificationDto> notifications = new();
        string persianTime = PersianDateTimeHelper.GetPersianDateTime(createServiceTime);

        IOrderedEnumerable<CalculatorUserIncome> newIncomes = incomes.OrderByDescending(x => x.AgentId);

        var largestAgentIncome = newIncomes.First();

        foreach (var income in newIncomes)
        {
            string message = "";

            bool isLargestAgent = income == largestAgentIncome;

            if (renewal)
            {
                if (isLargestAgent)
                {
                    message = $"""
                               🔄🛍 **تمدید جدید**
                               👤 کاربری با شناسه : `\{chatId}`
                               📦 نوع سرویس : {marzbanVpnName}
                               📧 نام کاربری : @{userName}
                               ✨ سرویسی را تمدید کرد
                               📋 نام سرویس : {marzbanUsername}
                               💰 سود شما از تمدید : {income.Balance:N0} تومان
                               💼 موجودی شما قبل از تمدید : {income.BalanceBeforPayment:N0} تومان
                               📈 موجودی شما بعد از تمدید : {(income.Balance + income.BalanceBeforPayment):N0} تومان
                               📉 مبلغ کسر شده از موجودی کاربر : {price:N0} تومان
                               💳 موجودی فعلی کاربر : {userbalance:N0} تومان
                               🕰️ موجودی کاربر قبل از تمدید : {(userbalance + price):N0} تومان
                               🗓️ تاریخ تمدید سرویس : {persianTime}
                               """;
                }
                else
                {
                    message = $"""
                               🔄🛍 **تمدید جدید - زیر مجموعه نماینده شما**
                               👥 سرویسی را تمدید کرد
                               🆔 شناسه نماینده : `\{income.chatId}`
                               📦 نوع سرویس : {marzbanVpnName}
                               💰 سود شما از تمدید : {income.Balance:N0} تومان
                               💼 موجودی شما قبل از تمدید : {income.BalanceBeforPayment:N0} تومان
                               📈 موجودی شما بعد از تمدید : {(income.Balance + income.BalanceBeforPayment):N0} تومان
                               📉 مبلغ کسر شده از موجودی کاربر : {price:N0} تومان
                               💳 موجودی فعلی کاربر : {userbalance:N0} تومان
                               🕰️ موجودی کاربر قبل از تمدید : {(userbalance + price):N0} تومان
                               🗓️ تاریخ تمدید سرویس : {persianTime}
                               """;
                }
            }
            else
            {
                if (isLargestAgent)
                {
                    message = $"""
                               🛍🆕 **خرید جدید**
                               👤 کاربری با شناسه : `\{chatId}`
                               📦 نوع سرویس : {marzbanVpnName}
                               📧 نام کاربری : @{userName}
                               📝 سفارسی ثبت کرد
                               📋 نام سرویس : {marzbanUsername}
                               💰 سود شما از خرید : {income.Balance:N0} تومان
                               💼 موجودی شما قبل از خرید : {income.BalanceBeforPayment:N0} تومان
                               📈 موجودی شما بعد از خرید : {(income.Balance + income.BalanceBeforPayment):N0} تومان
                               📉 مبلغ کسر شده از موجودی کاربر : {price:N0} تومان
                               💳 موجودی فعلی کاربر : {userbalance:N0} تومان
                               🕰️ موجودی کاربر قبل از خرید : {(userbalance + price):N0} تومان
                               🗓️ تاریخ خرید سرویس : {persianTime}
                               """;
                }
                else
                {
                    message = $"""
                               🛍🆕 **خرید جدید - زیر مجموعه نماینده شما**
                               👥 سرویسی را خرید کرد
                               🆔 شناسه نماینده : `\{income.chatId}`
                               📦 نوع سرویس : {marzbanVpnName}
                               📋 نام سرویس : {marzbanUsername}
                               💰 سود شما از تمدید : {income.Balance:N0} تومان
                               💼 موجودی شما قبل از تمدید : {income.BalanceBeforPayment:N0} تومان
                               📈 موجودی شما بعد از تمدید : {(income.Balance + income.BalanceBeforPayment):N0} تومان
                               📉 مبلغ کسر شده از موجودی کاربر : {price:N0} تومان
                               💳 موجودی فعلی کاربر : {userbalance:N0} تومان
                               🕰️ موجودی کاربر قبل از تمدید : {(userbalance + price):N0} تومان
                               🗓️ تاریخ خرید سرویس : {persianTime}
                               """;
                }
            }

            notifications.Add(new AddNotificationDto()
            {
                Message = message,
                NotificationType = NotificationType.Alter,
                UserId = income.UserId,
                ForAllMember = false,
                Expire = DateTime.Now.AddHours(2),
            });
        }

        return notifications;
    }

    public static AddNotificationDto SendTicketForAgentAsync(long userId, string message, long chatId, long childUserId,
        string username,
        DateTime dateTime, string? filaAddress = null)
    {
        List<ButtonJsonDto> buttons = new()
        {
            new("مدیریت کاربر", $"user_management?id={childUserId}"),
            new("ارسال پیام", $"send_message_user?id={childUserId}"),
        };

        return new()
        {
            Message = $"""
                       ✉️ نماینده عزیز یک پیام از سمت کاربر برای شما ارسال گردید
                       زمان ارسال:{PersianDateTimeHelper.GetPersianDateTime(dateTime)}
                       آیدی عددی کاربر `\{chatId}`\
                       نام کاربری: @{username}
                       متن پیغام : {message}
                       """,
            UserId = userId,
            ForAllMember = false,
            FileAddress = filaAddress,
            Buttons = buttons,
            Expire = DateTime.Now.AddHours(2),
        };
    }

    public static AddNotificationDto SendTicketForUserAsync(long userId, long chatId, string message,
        DateTime dateTime, string? filaAddress = null)
    {
        return new()
        {
            Message = $"""
                       ✉️ کاربر عزیز یک پیام از سمت نماینده برای شما ارسال گردید
                       زمان ارسال:{PersianDateTimeHelper.GetPersianDateTime(dateTime)}
                       متن پیغام : {message}
                       """,
            UserId = userId,
            ForAllMember = false,
            FileAddress = filaAddress,
        };
    }

    public static AddNotificationDto SendTransactionNotification(AddTransactionDto transaction, long userId)
    {
        string message = transaction.TransactionType == TransactionType.ManualIncrease
            ? $"""
               مبلغ {transaction.Price:N0}
                به صورت دستی توسط نماینده به
                موجودی شما اضافه شد
                توضیحات {transaction.Description}
               """
            : $"""
               مبلغ {transaction.Price:N0}
               به صورت دستی توسط نماینده از
               موجودی شما کم شد
               توضیحات {transaction.Description}
               """;
        return new()
        {
            Message = message,
            UserId = userId,
            ForAllMember = false,
        };
    }

    public static List<AddNotificationDto> SendMessageForUsers(
        List<long> userIds,
        DateTime createServiceTime,
        string text,
        string? fileAddress = null,
        ButtonJsonDto? button = null)
    {
        List<AddNotificationDto> notifications = new();
        string persianTime = PersianDateTimeHelper.GetPersianDateTime(createServiceTime);
        foreach (var userId in userIds)
        {
            string message = $"""
                              📩 پیام ارسالی از پشتیبانی:
                              📝 متن پیام:
                              {text}
                              ⏰ ساعت ارسال:
                              {persianTime}
                              """;

            notifications.Add(new AddNotificationDto()
            {
                Message = message,
                NotificationType = NotificationType.Alter,
                UserId = userId,
                ForAllMember = false,
                Expire = DateTime.Now.AddHours(2),
                FileAddress = null,
                Buttons = button != null
                    ? new()
                    {
                        button
                    }
                    : null
            });
        }

        return notifications;
    }

    public static List<AddNotificationDto> ForwardMessageForUsers(List<long> userIds,
        DateTime createServiceTime,
        int? messageId,
        long? forwardChatId)
    {
        List<AddNotificationDto> notifications = new();
        foreach (var userId in userIds)
        {
            notifications.Add(new AddNotificationDto()
            {
                NotificationType = NotificationType.Alter,
                UserId = userId,
                ForAllMember = false,
                Expire = DateTime.Now.AddHours(24),
                FileAddress = null,
                Forward = true,
                ForwardChatId = forwardChatId,
                MessageId = messageId
            });
        }

        return notifications;
    }

    public static AddNotificationDto AlterForDisabledAccounts(DateTime disabledTime, long userId)
        => new(
        )
        {
            Message = $"""
                       🌟 نماینده محترم،

                       با سلام و احترام 😊

                       به اطلاع می‌رسانیم که سقف اعتباری شما به پایان رسیده است. ما ارزش فراوانی برای همکاری شما قائل هستیم و قدردان اعتماد و همراهی شما هستیم. 💖

                       لطفاً در صورت امکان طی {(disabledTime - DateTime.Now).Hours} ساعت آینده نسبت به تسویه حساب خود اقدام فرمایید تا بتوانیم بدون وقفه به ارائه خدمات به شما ادامه دهیم. 🙏 در غیر این صورت، متأسفانه اشتراک‌های شما به صورت موقت غیرفعال خواهند شد. 😔

                       امیدواریم با تسویه به‌موقع، همکاری مؤثر ما همچنان ادامه یابد. در صورت نیاز به هرگونه اطلاعات یا کمک، لطفاً با ما در تماس باشید. 📞

                       با آرزوی موفقیت و سربلندی برای شما 🌺 تیم پشتیبانی 🎉
                       """,
            UserId = userId,
            NotificationType = NotificationType.Alter,
            Buttons = new()
            {
                new("تسویه حساب 🏦", "inventory_increase")
            },
        };
}
using System.Globalization;

namespace Domain.Entities.Wireguard;

public class PeerInformationDto
{
    public string? Name { get; set; }
    public long TotalReceivedVolume { get; set; }
    public long DownloadVolume { get; set; }
    public long UploadVolume { get; set; }
    public long StartTime { get; set; }
    public long ExpireTime { get; set; }
    public long? TotalVolume { get; set; }
    public string? Status { get; set; }
    public long? TotalDay { get; set; }
    public long Id { get; set; }
    public long VpnId { get; set; }

    public PeerInformationDto(long totalVolume, long totalDay)
    {
        TotalVolume = totalVolume;
        TotalDay = totalDay;
    }

    public PeerInformationDto()
    {
    }

    public string GetPersianDate(DateTime? dateTime)
    {
        if (dateTime is null)
            return "";

        PersianCalendar pc = new PersianCalendar();
        return $"{pc.GetYear(dateTime.Value)}/{pc.GetMonth(dateTime.Value):00}/{pc.GetDayOfMonth(dateTime.Value):00}";
    }

    public string GetPersianDateFromUnix(long? timestamp)
    {
        if (timestamp is null)
            return "شروع نشده";

        DateTime dt = DateTimeOffset.FromUnixTimeMilliseconds(timestamp.Value).DateTime;

        PersianCalendar pc = new PersianCalendar();

        int remainingDays = (dt.Date - DateTime.Now.Date).Days;

        string persianDate = $"{pc.GetYear(dt)}/{pc.GetMonth(dt):00}/{pc.GetDayOfMonth(dt):00}";
        string daysLeft = remainingDays > 0
            ? $" (باقی‌مانده: {remainingDays} روز)"
            : $" (گذشته: {-remainingDays} روز)";

        return persianDate + daysLeft;
    }

    private string FormatVolume(long? volume)
    {
        if (volume == null)
        {
            return "اطلاعات موجود نیست";
        }

        if (volume.Value < 1024 * 1024 * 1024)
        {
            return $"{volume.Value / (1024 * 1024)} مگابایت";
        }
        else
        {
            double volumeInGB = Math.Ceiling(volume.Value / (1024.0 * 1024.0 * 1024.0));
            return $"{volumeInGB} گیگابایت" +
                   " " +
                   $"({volume.Value / (1024 * 1024)}مگابایت)";
        }
    }

    public string GetInfo()
    {
        var status = this.Status switch
        {
            "active" => "فعال \u2705",
            "disabled" => "غیر فعال \u274c",
            "limited" => "اتمام حجم \ud83e\udeab",
            "onhold" => "شروع نشده \u267b\ufe0f",
            "expired" => "اتمام زمان \u23f0",
            _ => "نامشخص \u274c"
        };

        var startTime = StartTime == 0 ? "شروع نشده" : GetPersianDateFromUnix(StartTime);
        string activeUntilDate = ExpireTime == 0 ? "نامحدود (نامحدود)" : GetPersianDateFromUnix(ExpireTime);

        return $"📛 نام: {Name}\n" +
               $"📊 وضعیت: {status}\n" +
               $"💾 حجم کل: {FormatVolume(TotalVolume)}\n" +
               $"⬇️ حجم دانلود: {FormatVolume(DownloadVolume)}\n" +
               $"⬆️ حجم آپلود: {FormatVolume(UploadVolume)}\n" +
               $"🕒 زمان شروع: {startTime}\n" +
               $"⏳ زمان انقضا: {activeUntilDate}\n";
    }

    public string GenerateServiceDeletionRequestMessage(string telegramUsername, long chatId, string message)
    {
        string lastConnection = StartTime == 0 ? "متصل نشده" : "متصل شده";
        string formattedTotalVolume = FormatVolume(TotalVolume);
        string formattedUsedVolume = FormatVolume(UploadVolume + DownloadVolume);
        string formattedRemainingVolume = FormatVolume(TotalVolume - (UploadVolume + DownloadVolume));
        string activeUntilDate = ExpireTime == 0 ? "نامحدود (نامحدود)" : GetPersianDateFromUnix(ExpireTime);

        return $"سلام ادمین 👋\n" +
               $"📌 یک درخواست حذف سرویس توسط کاربر برای شما ارسال شده است. لطفا بررسی کرده و در صورت درست بودن و موافقت تایید کنید.\n\n" +
               $"📊 اطلاعات سرویس کاربر:\n" +
               $"آیدی عددی کاربر : {chatId}\n" +
               $"نام کاربری کاربر : @{telegramUsername}\n" +
               $"نام کاربری کانفیگ : {Name}\n" +
               $"وضعیت سرویس : {Status}\n" +
               $"🟢  اتصال شما : {lastConnection}\n\n" +
               $"📥 حجم مصرفی : {formattedUsedVolume}\n" +
               $"♾ حجم سرویس : {formattedTotalVolume}\n" +
               $"🪫 حجم باقی مانده : {formattedRemainingVolume}\n" +
               $"📅 فعال تا تاریخ : {activeUntilDate}\n\n" +
               $"دلیل حذف سرویس : {message}";
    }
}
using System.Globalization;
using Domain.DTOs.Marzban;
using Domain.Entities.Marzban;
using Newtonsoft.Json;

namespace Domain.DTOs.Telegram;

public class SubescribeStatus
{
    public class ServiceStatus
    {
        [JsonProperty("status")] public string Status { get; set; }

        [JsonProperty("username")] public string Username { get; set; }

        [JsonProperty("location")] public string Location { get; set; }

        [JsonProperty("service_code")] public string ServiceCode { get; set; }

        [JsonProperty("total_volume")] public long? TotalVolume { get; set; }

        [JsonProperty("used_volume")] public long? UsedVolume { get; set; }

        [JsonProperty("remaining_volume")] public long? RemainingVolume { get; set; }

        [JsonProperty("active_until")] public long? ActiveUntil { get; set; }

        [JsonProperty("last_connection")] public DateTime? LastConnection { get; set; }

        [JsonProperty("last_link_generation")] public DateTime? LastLinkGeneration { get; set; }

        public long MarzbanUserId { get; set; }
        public long VpnId { get; set; }
        public string VpnName { get; set; }

        public string GetPersianDate(DateTime? dateTime)
        {
            if (dateTime is null)
                return "";

            PersianCalendar pc = new PersianCalendar();
            return
                $"{pc.GetYear(dateTime.Value)}/{pc.GetMonth(dateTime.Value):00}/{pc.GetDayOfMonth(dateTime.Value):00}";
        }

        public string GetPersianDateFromUnix(long? timestamp)
        {
            if (timestamp is null)
                return "شروع نشده";

            DateTime dt = DateTimeOffset.FromUnixTimeSeconds(timestamp.Value).DateTime;
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
            return $"وضعیت سرویس: {Status}\n" +
                   $"👤 نام سرویس: {Username}\n" +
                   $"🌍 نوع سرویس: {VpnName}\n" +
                   $"🖇 کد سرویس: {ServiceCode}\n" +
                   $"🔋 حجم سرویس: {FormatVolume(TotalVolume)} \n" +
                   $"📥 حجم مصرفی: {FormatVolume(UsedVolume)} \n" +
                   $"💢 حجم باقی مانده: {FormatVolume(RemainingVolume)} \n" +
                   $"📅 فعال تا تاریخ: {GetPersianDateFromUnix(ActiveUntil)}\n" +
                   $"📶 آخرین زمان اتصال: {GetPersianDate(LastConnection)}\n" +
                   $"آخرین زمان تغییر لینک: {GetPersianDate(LastLinkGeneration)}";
        }

        public ServiceStatus(MarzbanUserDto? marzbanUser)
        {
            Status = marzbanUser.Status switch
            {
                "active" => "فعال \u2705",
                "disabled" => "غیر فعال \u274c",
                "limited" => "اتمام حجم \ud83e\udeab",
                "on_hold" => "شروع نشده \u267b\ufe0f",
                "expired" => "اتمام زمان \u23f0",
                _ => "نامشخص \u274c"
            };

            Username = marzbanUser.Username;
            TotalVolume = marzbanUser.Data_Limit;
            UsedVolume = marzbanUser.Used_Traffic;
            RemainingVolume = TotalVolume - UsedVolume;
            ActiveUntil = marzbanUser.Expire;
            LastConnection = marzbanUser.Sub_Updated_At;
            LastLinkGeneration = marzbanUser.Sub_Updated_At;
            MarzbanUserId = marzbanUser.Id;
            VpnId = marzbanUser.MarzbanVpnId ?? 0;
            VpnName = marzbanUser.MarzbanVpnName ?? "در دست رس نیست";
        }

        public ServiceStatus(MarzbanUser? marzbanUser)
        {
            Status = marzbanUser.Status switch
            {
                "active" => "فعال \u2705",
                "disabled" => "غیر فعال \u274c",
                "limited" => "اتمام حجم \ud83e\udeab",
                "on_hold" => "شروع نشده \u267b\ufe0f",
                "expired" => "اتمام زمان \u23f0",
                _ => "نامشخص \u274c"
            };

            Username = marzbanUser.Username;
            TotalVolume = marzbanUser.Data_Limit;
            UsedVolume = marzbanUser.Used_Traffic;
            RemainingVolume = TotalVolume - UsedVolume;
            ActiveUntil = marzbanUser.Expire;
            LastConnection = marzbanUser.Sub_Updated_At;
            LastLinkGeneration = marzbanUser.Sub_Updated_At;
            MarzbanUserId = marzbanUser.Id;
            VpnId = marzbanUser.MarzbanVpnId;
        }

        public string GenerateServiceDeletionRequestMessage(string telegramUsername, long chatId, string message)
        {
            string lastConnection = LastConnection == null ? "متصل نشده" : GetPersianDate(LastConnection);
            string formattedTotalVolume = FormatVolume(TotalVolume);
            string formattedUsedVolume = FormatVolume(UsedVolume);
            string formattedRemainingVolume = FormatVolume(RemainingVolume);
            string activeUntilDate = ActiveUntil == null ? "نامحدود (نامحدود)" : GetPersianDateFromUnix(ActiveUntil);

            return $"سلام ادمین 👋\n" +
                   $"📌 یک درخواست حذف سرویس توسط کاربر برای شما ارسال شده است. لطفا بررسی کرده و در صورت درست بودن و موافقت تایید کنید.\n\n" +
                   $"📊 اطلاعات سرویس کاربر:\n" +
                   $"آیدی عددی کاربر : {chatId}\n" +
                   $"نام کاربری کاربر : @{telegramUsername}\n" +
                   $"نام کاربری کانفیگ : {Username}\n" +
                   $"وضعیت سرویس : {Status}\n" +
                   $"لوکیشن : {Location}\n" +
                   $"کد سرویس : {ServiceCode}\n\n" +
                   $"🟢 آخرین زمان اتصال شما : {lastConnection}\n\n" +
                   $"📥 حجم مصرفی : {formattedUsedVolume}\n" +
                   $"♾ حجم سرویس : {formattedTotalVolume}\n" +
                   $"🪫 حجم باقی مانده : {formattedRemainingVolume}\n" +
                   $"📅 فعال تا تاریخ : {activeUntilDate}\n\n" +
                   $"دلیل حذف سرویس : {message}";
        }


        public ServiceStatus()
        {
        }
    }
}
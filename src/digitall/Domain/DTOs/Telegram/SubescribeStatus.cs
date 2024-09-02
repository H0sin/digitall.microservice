using System.Globalization;
using Domain.DTOs.Marzban;
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

            DateTime dt = DateTimeOffset.FromUnixTimeSeconds(timestamp.Value).DateTime;
            PersianCalendar pc = new PersianCalendar();
            
            int remainingDays = (dt.Date - DateTime.Now.Date).Days;
            
            string persianDate = $"{pc.GetYear(dt)}/{pc.GetMonth(dt):00}/{pc.GetDayOfMonth(dt):00}";
            string daysLeft = remainingDays > 0 ? $" (باقی‌مانده: {remainingDays} روز)" : $" (گذشته: {-remainingDays} روز)";

            return persianDate + daysLeft;
        }

        private string FormatVolume(long? volume)
        {
            if (volume == null)
            {
                return "اطلاعات موجود نیست";
            }
        
            // مقدار کمتر از یک گیگابایت را به مگابایت تبدیل می‌کند
            if (volume.Value < 1024 * 1024 * 1024)
            {
                return $"{volume.Value / (1024 * 1024)} مگابایت";
            }
            // مقدار برابر یا بیشتر از یک گیگابایت را به گیگابایت تبدیل می‌کند
            else
            {
                return $"{volume.Value / (1024 * 1024 * 1024)} گیگابایت";
            }
        }
        
        public string GetInfo()
        {
            return $"وضعیت سرویس: {Status}\n" +
                   $"👤 نام سرویس: {Username}\n" +
                   $"🌍 لوکیشن سرویس: {Location}\n" +
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
                "disabled"  => "غیر فعال \u274c",
                "limited" => "اتمام حجم \ud83e\udeab",
                "on_hold" => "شروع نشده \u267b\ufe0f",
                "expired" => "اتمام زمان \u23f0",
                _=> "نامشخص \u274c"
            };
            
            Username = marzbanUser.Username;
            TotalVolume = marzbanUser.Data_Limit;
            UsedVolume = marzbanUser.Used_Traffic;
            RemainingVolume = TotalVolume - UsedVolume;
            ActiveUntil = marzbanUser.Expire;
            LastConnection = marzbanUser.Sub_Updated_At;
            LastLinkGeneration = marzbanUser.Sub_Updated_At;
            MarzbanUserId = marzbanUser.Id ;
            VpnId = marzbanUser.MarzbanVpnId;
        }

        public ServiceStatus()
        {
            
        }
    }
}
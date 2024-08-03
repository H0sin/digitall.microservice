namespace Domain.DTOs.Telegram;

public class SubscribeFactorBotDto
{
    public string? Title { get; set; }
    public int Days { get; set; }
    public long Price { get; set; }
    public int Gb { get; set; }
    public string? Description { get; set; }
    public long Balance { get; set; }
    public long Count { get; set; }

    public string GetInfo()
    {
        return $"📇 پیش فاکتور شما: \n" +
               $"👤 نام سرویس: {Title}\n" +
               $"📆 مدت اعتبار: {Days + "روز"}\n" +
               $"📆 قیمت: {Price + "تومان"}\n" +
               $"👥 حجم اکانت:  {(Gb > 200 ? "نامحدود" : Gb + "گیگ")}\n" +
               $"🗒 یادداشت محصول: {Description}\n" +
               $"💵 موجودی کیف پول شما: {Balance}\n" +
               $"💰 سفارش شما آماده پرداخت است\n";
    }

    public string GetRenewalInfo()
    {
        return $"📜 فاکتور تمدید شما برای نام کاربری {Title} ایجاد شد.\n" +
               $"🛍 نام محصول: {Gb} گیگ {Price} تومان\n" +
               $"💸 مبلغ تمدید: {Price}\n" +
               $"⏱ مدت زمان تمدید: {Days} روز\n" +
               $"🔋 حجم تمدید: {Gb} گیگ\n" +
               "✅ برای تایید و تمدید سرویس روی دکمه زیر کلیک کنید";
    }
}
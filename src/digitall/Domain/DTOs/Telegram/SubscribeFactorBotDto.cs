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
               $"👥 حجم اکانت:  {Gb + "گیگ"}\n" +
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

    public string GetAppendGbInfo()
    {
        return
            $"\ud83d\udcdc فاکتور خرید حجم اضافه برای شما ایجاد شد.\n\n" +
            $"\ud83d\udccc تعرفه هر گیگابایت حجم اضافه : {Price} تومان\n" +
            $"\ud83d\udd0b حجم اضافه درخواستی : {Gb} گیگابایت\n" +
            $"\ud83d\udcb0 مبلغ فاکتور شما : {Gb * Price} تومان\n\n" +
            "\u2705 جهت پرداخت و اضافه شدن حجم، روی دکمه زیر کلیک کنید";
    }

    public string GetAppendDayInfo()
    {
        return
            $"\ud83d\udcdc فاکتور خرید روز اضافه برای شما ایجاد شد.\n\n" +
            $"\ud83d\udccc تعرفه هر روز اضافه : {Price} تومان\n" +
            $"\ud83d\udd0b  اضافه درخواستی : {Days} روز \n" +
            $"\ud83d\udcb0 مبلغ فاکتور شما : {Days * Price} تومان\n\n" +
            "\u2705 جهت پرداخت و اضافه شدن روز، روی دکمه زیر کلیک کنید";
    }
}
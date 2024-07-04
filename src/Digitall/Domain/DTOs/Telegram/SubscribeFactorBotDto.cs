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
}
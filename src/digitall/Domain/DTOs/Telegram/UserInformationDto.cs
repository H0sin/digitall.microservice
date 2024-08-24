namespace Domain.DTOs.Telegram;

public class UserInformationDto
{
    public long SumPayment { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Mobile { get; set; }
    public string? Email { get; set; }
    public int CountMarzbanUser { get; set; }
    public long? ChatId { get; set; }
    public string? TelegramUserName { get; set; }
    public bool UserStatus { get; set; }
    public long UserId { get; set; }
    public string? RegistrationDate { get; set; }
    public int TestAccountLimit { get; set; }
    public long Balance { get; set; }
    public int TotalPurchaseCount { get; set; }
    public long TotalPaymentAmount { get; set; }
    public long TotalPurchaseAmount { get; set; }
    public int ReferralCount { get; set; }
    public bool CardNumberVisibility { get; set; }
    
    public  string GetInformation()
    {
        string userState = UserStatus ? "بلاک شده" : "فعال";
        string cardNumberVisibility = CardNumberVisibility ? "فعال" : "غیر فعال";
        return $@"
        👀 اطلاعات کاربر:
        ⭕️ وضعیت کاربر : {userState}
        ⭕️ نام کاربری کاربر : {TelegramUserName}
        ⭕️ آیدی عددی کاربر : {ChatId}
        ⭕️ زمان عضویت کاربر : {RegistrationDate}
        ⭕️ محدودیت اکانت تست : {TestAccountLimit}
        ⭕️ شماره موبایل : {Mobile ?? "ندارد"}
        ⭕️ موجودی کاربر : {Balance:N0}
        ⭕️ تعداد خرید کل کاربر : {TotalPurchaseCount}
        ⭕️ مبلغ کل پرداختی : {TotalPaymentAmount:N0}
        ⭕️ جمع کل خرید : {TotalPurchaseAmount:N0}
        ⭕️ تعداد زیرمجموعه کاربر : {ReferralCount}
        ⭕️ نمایش شماره کارت : {cardNumberVisibility}
        ";
    }
}
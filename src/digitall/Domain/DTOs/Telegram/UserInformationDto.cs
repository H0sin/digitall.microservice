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
    public bool IsBlocked { get; set; }
    public bool IsAgent { get; set; }
    public long? SpecialPercent { get; set; }
    public long SumAgentIncomes { get; set; } = 0;
    
    public long AmountNegative { get; set; }
    
    public string GetInformation()
    {
        string userState = IsBlocked ? "بلاک شده" : "فعال";
        string cardNumberVisibility = CardNumberVisibility ? "فعال" : "غیر فعال";
        string agentDescription = IsAgent ? "کاربر نماینده است" : "کاربر نماینده نیست";
        string specialPercent = IsAgent ? $"\u2b55\ufe0f در صد سود دریافتی : {SpecialPercent}" : "";
        return $@"
         👀 اطلاعات کاربر:
        ⭕️ وضعیت کاربر : {userState}
         ⭕️ تعداد سرویس های خریداری شده :{CountMarzbanUser}
        ⭕️ نام کاربری کاربر : @{TelegramUserName}
        ⭕️ آیدی عددی کاربر : {ChatId}
        ⭕️ زمان عضویت کاربر : {RegistrationDate}
        ⭕️ محدودیت اکانت تست : {TestAccountLimit}
        ⭕️ شماره موبایل : {Mobile ?? "ندارد"}
        ⭕️ موجودی کاربر : {Balance:N0}
         ⭕️ کل سود فروش :{SumAgentIncomes:N0}
        ⭕️ تعداد خرید کل کاربر : {TotalPurchaseCount}
        ⭕️ مبلغ کل پرداختی : {TotalPaymentAmount:N0}
        ⭕️ جمع کل خرید : {TotalPurchaseAmount:N0}
        ⭕️ تعداد زیرمجموعه کاربر : {ReferralCount}
        ⭕️ نمایش شماره کارت : {cardNumberVisibility}
         ⭕️ سقف خرید منفی:{AmountNegative:N0}
         {specialPercent}
         ⭕️{agentDescription} 
        ";
    }
}
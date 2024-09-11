namespace Domain.DTOs.Account;

public class CalculatorUserIncome
{
    public CalculatorUserIncome(long userId, long balance,long agentId,int percent,string? brandName)
    {
        UserId = userId;
        Balance = balance;
        AgentId = agentId;
        Percent = percent;
        BrandName = brandName;
    }

    public long UserId { get; set; }
    public long Balance { get; set; }
    public long AgentId { get; set; }
    public int Percent { get; set; }
    public string? BrandName { get; set; }
    public string? TelegramUserName { get; set; }
    public long? chatId { get; set; }
    public long BalanceBeforPayment { get; set; }
}
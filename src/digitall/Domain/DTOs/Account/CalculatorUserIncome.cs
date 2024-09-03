namespace Domain.DTOs.Account;

public class CalculatorUserIncome
{
    public CalculatorUserIncome(long userId, long balance,long agentId,int percent)
    {
        UserId = userId;
        Balance = balance;
        AgentId = agentId;
        Percent = percent;
    }

    public long UserId { get; set; }
    public long Balance { get; set; }
    public long AgentId { get; set; }
    public int Percent { get; set; }
}
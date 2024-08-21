namespace Domain.DTOs.Account;

public class CalculatorUserIncome
{
    public CalculatorUserIncome(long userId, long balance,long agentId)
    {
        UserId = userId;
        Balance = balance;
        AgentId = agentId;
    }

    public long UserId { get; set; }
    public long Balance { get; set; }
    public long AgentId { get; set; }
}
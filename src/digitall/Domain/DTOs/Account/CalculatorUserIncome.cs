namespace Domain.DTOs.Account;

public class CalculatorUserIncome
{
    public CalculatorUserIncome(long userId, long balance)
    {
        UserId = userId;
        Balance = balance;
    }

    public long UserId { get; set; }
    public long Balance { get; set; }
}
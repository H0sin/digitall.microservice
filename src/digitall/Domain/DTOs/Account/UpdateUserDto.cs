namespace Domain.DTOs.Account;

public class UpdateUserDto
{
    public long Id { get; set; }
    public bool IsBlocked { get; set; }
    public bool CardToCardPayment { get; set; }
}
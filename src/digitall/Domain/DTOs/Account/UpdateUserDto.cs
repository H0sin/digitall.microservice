using System.ComponentModel.DataAnnotations;

namespace Domain.DTOs.Account;

public class UpdateUserDto
{
    public long Id { get; set; }
    public bool IsBlocked { get; set; }
    public bool CardToCardPayment { get; set; }

    [MaxLength(3000)]
    public string? Description { get; set; }
    public int SpecialPercent { get; set; } = 0;
}
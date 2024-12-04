using System.ComponentModel.DataAnnotations;

namespace Domain.Enums.Transaction;

public enum TransactionType
{
    [Display(Name = "کاهش")] Decrease,

    [Display(Name = "افزایش")] Increase,
    
    [Display(Name = "افزایش دستی")] ManualIncrease,
    
    [Display(Name = "کاهش دستی")] ManualDecrease,
}
using System.ComponentModel.DataAnnotations;
using Domain.Entities.Account;

namespace Domain.DTOs.Account;

public class IncreaseBalanceDto
{
    #region releation

    public User User { get; set; }

    #endregion

    #region properties

    public long UserId { get; set; }

    [Display(Name = "مبلغ")] public long Amount { get; set; }

    [Display(Name = "توضیحات")] public string? Description { get; set; }

    #endregion
}
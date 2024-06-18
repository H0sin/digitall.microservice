using System.ComponentModel.DataAnnotations;
using Domain.Common;
using Domain.Entities.Account;
using Domain.Enums.Transaction;

namespace Domain.Entities.Transaction;

public class Transaction : BaseEntity
{
    #region releation

    public User User { get; set; }

    #endregion

    #region properties

    [Display(Name = "عنوان تراکنش")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string? Title { get; set; }

    [Display(Name = "مبلغ تراکش")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    public long Price { get; set; }

    [Display(Name = "توضیحات تراکنش")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(2000, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string? Description { get; set; }


    [Display(Name = "نام صاحب حساب")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string AccountName { get; set; }

    [Display(Name = "زمان تراکنش")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    public DateTime TransactionTime { get; set; }

    [Display(Name = "شماره کارت")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public long CardNumber { get; set; }

    [Display(Name = "نام بانک")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string? BankName { get; set; }

    [Display(Name = "عکس تراکنش")] public string? AvatarTransaction { get; set; }

    [Display(Name = "نوع تراکنش")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    public TransactionType TransactionType { get; set; }

    [Display(Name = "وضعیت تراکنش")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    public TransactionStatus TransactionStatus { get; set; }

    public long UserId { get; set; }

    #endregion
}
using System.ComponentModel.DataAnnotations;
using Domain.Enums.Transaction;
using Microsoft.AspNetCore.Http;

namespace Domain.DTOs.Transaction;

public class AddTransactionDto
{
    [Display(Name = "عنوان تراکنش")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string? Title { get; set; }

    [Display(Name = "مبلغ تراکش")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    public long Price { get; set; }

    [Display(Name = "توضیحات تراکنش")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string? Description { get; set; }

    [Display(Name = "نوع تراکنش")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    public TransactionType TransactionType { get; set; }

    [Display(Name = "نام صاحب حساب")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string AccountName { get; set; }

    [Display(Name = "زمان تراکنش")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    public DateTime TransactionTime { get; set; }

    [Display(Name = "شماره کارت")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    public string CardNumber { get; set; }

    [Display(Name = "نام بانک")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string? BankName { get; set; }

    [Display(Name = "عکس تراکنش")] public IFormFile? AvatarTransaction { get; set; }

    public long TransactionDetailId { get; set; }
}
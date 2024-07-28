using System.ComponentModel.DataAnnotations;

namespace Domain.DTOs.Order;

public class OrderDto
{
    public long UserId { get; set; }
    [Display(Name = "نام کاربر")] public string? UserName { get; set; }

    [Display(Name = "شماره تماس")] public string? Mobile { get; set; }
    public DateTime? PaymentDate { get; set; }
    public bool IsPaid { get; set; }

    [Display(Name = "کد پیگیری")]
    [MaxLength(300, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public long TracingCode { get; set; }

    [Display(Name = "توضیحات")] public string? Description { get; set; }
    public List<OrderDetailDto>? OrderDetail { get; set; }
}
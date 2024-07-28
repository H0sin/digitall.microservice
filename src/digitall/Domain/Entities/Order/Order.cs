using System.ComponentModel.DataAnnotations;
using Domain.Common;

namespace Domain.Entities.Order;

public class Order : BaseEntity
{
    #region relations

    public ICollection<OrderDetail> OrderDetails { get; set; }

    #endregion

    #region properties

    public long UserId { get; set; }

    public DateTime? PaymentDate { get; set; }

    public bool IsPaid { get; set; }

    [Display(Name = "کد پیگیری")]
    [MaxLength(300, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public long TracingCode { get; set; } = new Random().NextInt64(1000000000000, 9999999999999);

    [Display(Name = "توضیحات")] public string? Description { get; set; }

    #endregion
}
using System.ComponentModel.DataAnnotations;
using Domain.Common;
using Domain.Entities.Order;

namespace Domain.Entities.Sanaei;

public class Client : BaseEntity
{
    public bool Enable { get; set; }
    [MaxLength(200)] public string? Email { get; set; }
    public long Up { get; set; }
    public long Down { get; set; }
    public long ExpiryTime { get; set; }
    public long TotalGb { get; set; }
    public long Reset { get; set; }
    public long InboundId { get; set; }
    public Inbound? Inbound { get; set; }
    public long ServerId { get; set; }
    public long CountryId { get; set; }

    [MaxLength(50, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string? SanaeiClientId { get; set; }

    [MaxLength(50, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string SubId { get; set; }

    [MaxLength(50, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string Password { get; set; }

    [Display(Name = "نام")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(50, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string? Name { get; set; }

    public long? OrderDetailId { get; set; }
    public OrderDetail? OrderDetail { get; set; }
}
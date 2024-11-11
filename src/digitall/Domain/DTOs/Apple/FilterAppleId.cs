using Domain.DTOs.Paging;
using Domain.Entities.Apple;

namespace Domain.DTOs.Apple;

public class FilterAppleId : BasePaging<AppleIdDto>
{
    public string? Email { get; set; }
    public long? UserId { get; set; }
}
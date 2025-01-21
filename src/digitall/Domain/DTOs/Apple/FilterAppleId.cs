using Domain.DTOs.Paging;
using Domain.Entities.Apple;
using Domain.Enums.Apple;

namespace Domain.DTOs.Apple;

public class FilterAppleId : BasePaging<AppleIdDto>
{
    public string? Email { get; set; }
    public long? UserId { get; set; }

    public AppleIdStatus? Status { get; set; }

    public long? Type { get; set; }
}
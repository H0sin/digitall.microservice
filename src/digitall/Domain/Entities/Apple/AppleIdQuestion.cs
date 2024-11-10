using Domain.Common;

namespace Domain.Entities.Apple;

public class AppleIdQuestion : BaseEntity
{
    public ICollection<AppleIdQuestionAppleId>? AppleIdQuestionAppleIds { get; set; }
    public string? Question { get; set; }
    public string? Answer { get; set; }
}
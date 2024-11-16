using Domain.Common;
using Domain.Enums.Apple;

namespace Domain.Entities.Apple;

public class AppleId : BaseEntity
{
    public long AppleIdTypeId { get; set; }
    public AppleIdType AppleIdType { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? Password { get; set; }
    public DateTime? BirthDay { get; set; }
    public string? Question1 { get; set; }
    public string? Answer1 { get; set; }
    public string? Question2 { get; set; }
    public string? Answer2 { get; set; }
    public string? Question3 { get; set; }
    public string? Answer3 { get; set; }
    public long? UserId { get; set; }
    public long? OrderId { get; set; }
    public long? AssignSupporterUserId { get; set; }
    public bool SendToWarranty { get; set; } = false;
    public AppleIdStatus? Status { get; set; }
}
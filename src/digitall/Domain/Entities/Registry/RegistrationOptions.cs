using Domain.Common;

namespace Domain.Entities.Registry;

public class RegistrationOptions : BaseEntity
{
    public long PassportPrice { get; set; }
    public int AgentShareFraction { get; set; } = 10;
}
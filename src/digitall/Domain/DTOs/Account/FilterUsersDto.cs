using Domain.DTOs.Paging;

namespace Domain.DTOs.Account;

public class FilterUsersDto : BasePaging<UserDto>
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Mobile { get; set; }
    public long AgentId { get; set; }
}
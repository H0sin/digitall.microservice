using Domain.DTOs.Paging;

namespace Domain.DTOs.Account;

public class FilterUsersDto : BasePaging<UserDto>
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Mobile { get; set; }
    
    public long AgentId { get; set; }

    /// <summary>
    /// search in chatId - firstname - lastname - telegramUsername
    /// </summary>
    public string? Username { get; set; }
    
    /// <summary>
    /// 0 get all user
    /// 1 get user
    /// 2 get agent
    /// </summary>
    public int IsAgent { get; set; } = 0;
}
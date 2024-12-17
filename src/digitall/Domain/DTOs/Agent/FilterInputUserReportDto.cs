using Domain.DTOs.Paging;

namespace Domain.DTOs.Agent;

public class FilterInputUserReportDto : BasePaging<InputUserReportDto>
{
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; } = DateTime.Now;
    public long AgentId { get; set; }
    public long UserId { get; set; }
}
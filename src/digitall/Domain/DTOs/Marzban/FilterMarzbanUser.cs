using Domain.DTOs.Paging;
using Domain.Entities.Marzban;

namespace Domain.DTOs.Marzban;

public class FilterMarzbanUser : BasePaging<MarzbanUserDto>
{
    public long? UserId { get; set; }
}
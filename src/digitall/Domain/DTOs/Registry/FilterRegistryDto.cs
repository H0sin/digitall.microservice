using Domain.DTOs.Paging;
using Domain.Enums.Registry;

namespace Domain.DTOs.Registry;

public class FilterRegistryDto : BasePaging<RegistryDto>
{
    public string? Imei { get; set; }
    public RegistryStatus? Status { get; set; }
}

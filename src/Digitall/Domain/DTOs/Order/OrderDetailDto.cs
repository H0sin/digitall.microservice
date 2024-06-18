using Domain.DTOs.Marzban;
using Domain.DTOs.Product;
using Domain.DTOs.Sanaei.Client;
using Domain.Enums.Order;

namespace Domain.DTOs.Order;

public class OrderDetailDto
{
    public long Id { get; set; }
    public int Count { get; set; }
    public long ProductPrice { get; set; }
    public string? ProductName { get; set; }
    public ProductDto? Product { get; set; }
    public ICollection<ClientInOrder>? Clients { get; set; }
    public ICollection<MarzbanUserDto> MarzbanUsers { get; set; }
    public OrderDeatilType OrderDeatilType { get; set; }
}
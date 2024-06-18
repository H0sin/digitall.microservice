namespace Domain.DTOs.Order;

public class AddProductToOrderDto
{
    public long ProductId { get; set; }
    public int Count { get; set; }
}
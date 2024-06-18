namespace Domain.DTOs.Order;

public class UserOpenOrderDto
{
    public long UserId { get; set; }

    public string Description { get; set; }

    public List<UserOpenOrderDetailItemDto> Details { get; set; }

    public int GetTotalPrice()
    {
        return Details.Sum(s => (s.ProductPrice + s.ProductColorPrice) * s.Count);
    }

    public int GetTotalDiscounts()
    {
        return Details.Sum(s => s.GetOrderDetailWithDiscountPriceAmount());
    }
}
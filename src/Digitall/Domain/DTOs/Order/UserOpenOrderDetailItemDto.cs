namespace Domain.DTOs.Order;

public class UserOpenOrderDetailItemDto
{
    public long DetailId { get; set; }

    public long ProductId { get; set; }

    public string ProductTitle { get; set; }

    public string ProductImageName { get; set; }

    public long? ProductColorId { get; set; }

    public int Count { get; set; }

    public int ProductPrice { get; set; }

    public int ProductColorPrice { get; set; }

    public string ColorName { get; set; }

    public int? DiscountPercentage { get; set; }

    public int GetOrderDetailWithDiscountPriceAmount()
    {
        if (DiscountPercentage != null)
            return (ProductPrice + ProductColorPrice) * DiscountPercentage.Value / 100 * Count;

        return 0;
    }

    public int GetTotalAmountByDiscount()
    {
        return (ProductPrice + ProductColorPrice) * Count - GetOrderDetailWithDiscountPriceAmount();
    }


    public string GetOrderDetailWithDiscountPrice()
    {
        if (DiscountPercentage != null) return GetOrderDetailWithDiscountPriceAmount().ToString("#,0 تومان");

        return "------";
    }
}
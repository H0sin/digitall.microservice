using Domain.Entities.Apple;

namespace Domain.DTOs.Apple;

public class GetAppleIdTypeDto
{
    public long Id { get; set; }
    public string? Title { get; set; }
    public long Price { get; set; }

    public GetAppleIdTypeDto()
    {
        
    }

    public GetAppleIdTypeDto(AppleIdType appleIdType)
    {
        Id = appleIdType.Id; 
        Title = appleIdType.Title;
        Price = appleIdType.Price;
    }
}
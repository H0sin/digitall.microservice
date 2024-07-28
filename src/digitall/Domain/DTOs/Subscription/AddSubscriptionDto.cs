namespace Domain.DTOs.Subscription;

public class AddSubscriptionDto
{
    public AddSubscriptionDto()
    {
    }

    public AddSubscriptionDto(string? Name)
    {
    }

    public string Name { get; set; }

    public Entities.Subscription.Subscription Sub(string? Name)
    {
        return new Entities.Subscription.Subscription
        {
            Name = Name
        };
    }
}
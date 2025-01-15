using Domain.Enums.Registry;

namespace Domain.DTOs.Registry;

public class RegistryDto
{
    public long Id { get; set; }
    public string? ImeI_1 { get; set; }
    public string? ImeI_2 { get; set; }
    public string? Summery { get; set; }
    public string? ForWho { get; set; }
    public RegistryStatus Status { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    public long? CreateBy { get; set; }
    public string? Phone { get; set; }

    public string? Model { get; set; }
    
    public long? Price { get; set; }

    public RegistryDto()
    {
    }

    public RegistryDto(Entities.Registry.Registry registry)
    {
        ImeI_1 = registry.ImeI_1;
        ImeI_2 = registry.ImeI_2;
        Summery = registry.Summery;
        ForWho = registry.ForWho;
        Status = registry.Status;
        CreateDate = registry.CreateDate;
        ModifiedDate = registry.ModifiedDate;
        CreateBy = registry.CreateBy;
        Id = registry.Id;
        Phone = registry.Phone;
        Model = registry.Model;
        Price = registry.Price;
    }
}
using Microsoft.AspNetCore.Http;

namespace Domain.DTOs.Registry;

public class UploadRegistryTransactionImagesDto
{
    public long Id { get; set; }
    public IFormFileCollection? Images { get; set; }
}
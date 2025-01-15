using Domain.DTOs.Registry;

namespace Application.Services.Interface.Registry;

public interface IRegistryService
{
    /// <summary>
    /// add registry
    /// </summary>
    /// <param name="registry"></param>
    /// <param name="userId"></param>
    /// <returns></returns>
    Task AddRegistryAsync(AddRegistryDto registry, long userId);

    /// <summary>
    /// filter registry
    /// </summary>
    /// <param name="filter"></param>
    /// <param name="userId"></param>
    /// <returns></returns>
    Task<FilterRegistryDto> FilterRegistryAsync(FilterRegistryDto filter, long userId);
    
    /// <summary>
    /// filter registry
    /// </summary>
    /// <param name="filter"></param>
    /// <returns></returns>
    Task<FilterRegistryDto> FilterRegistryAsync(FilterRegistryDto filter);

    /// <summary>
    /// update modal and registry price
    /// </summary>
    /// <param name="amountModel"></param>
    /// <param name="userId"></param>
    /// <returns></returns>
    Task UpdateRegistryAmountModel(RegistryAmountModelDto amountModel,long userId);

    /// <summary>
    /// upload transaction images
    /// </summary>
    /// <param name="registry"></param>
    /// <param name="userId"></param>
    /// <returns></returns>
    Task UploadRegistryTransactionImagesAsync(UploadRegistryTransactionImagesDto registry,long userId);

    /// <summary>
    /// send registry options async
    /// </summary>
    /// <returns></returns>
    Task<RegistrationOptionDto?> GetRegistryOptionAsync();
}
using Application.Services.Interface.Registry;
using Domain.DTOs.Registry;
using Domain.Exceptions;
using Domain.IRepositories.Registry;
using Microsoft.EntityFrameworkCore;

namespace Application.Services.Implementation.Registry;

public class RegistryService(IRegistryRepository registryRepository) : IRegistryService
{
    public async Task AddRegistryAsync(AddRegistryDto registry, long userId)
    {
        if (await registryRepository
                .GetQuery()
                .AnyAsync(x => 
                    x.ImeI_1 == registry.ImeI_1 || 
                    (!string.IsNullOrEmpty(registry.ImeI_2) && x.ImeI_2 == registry.ImeI_2)))
            throw new ExistsException("این دستگاه قبلا ثبت شده است");

        if (!registry.AcceptTheRules) throw new AppException("تا شرایط را نپذیرید امکان ثبت ندارید");

        var newRegistry = new Domain.Entities.Registry.Registry
        {
            ImeI_1 = registry.ImeI_1,
            ImeI_2 = registry.ImeI_2,
            Summery = registry.Summery,
            ForWho = registry.ForWho,
            Phone = registry.Phone
        };

        await registryRepository.AddEntity(newRegistry);
        await registryRepository.SaveChanges(userId);
    }

    public async Task<FilterRegistryDto> FilterRegistryAsync(FilterRegistryDto filter, long userId)
    {
        var query = registryRepository.GetQuery().Where(x => x.CreateBy == userId);

        if (!string.IsNullOrEmpty(filter.Imei))
            query = query.Where(r =>
                EF.Functions.Like(r.ImeI_1, $"%{filter.Imei}%") ||
                EF.Functions.Like(r.ImeI_2, $"%{filter.Imei}%"));

        if (filter.Status is not null)
            query = query
                .Where(x => x.Status == filter.Status);

        var registry = query.Select(x => new RegistryDto(x));

        await filter.Paging(registry);

        return filter;
    }

    public async Task<FilterRegistryDto> FilterRegistryAsync(FilterRegistryDto filter)
    {
        var query = registryRepository.GetQuery();

        if (!string.IsNullOrEmpty(filter.Imei))
            query = query.Where(r =>
                EF.Functions.Like(r.ImeI_1, $"%{filter.Imei}%") ||
                EF.Functions.Like(r.ImeI_2, $"%{filter.Imei}%"));

        if (filter.Status is not null)
            query = query
                .Where(x => x.Status == filter.Status);

        var registry = query.Select(x => new RegistryDto(x));

        await filter.Paging(registry);

        return filter;
    }
}
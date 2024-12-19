using Application.Services.Implementation.Agent;
using Application.Services.Interface.Agent;
using Application.Services.Interface.Registry;
using Data.Repositories.Agent;
using Domain.DTOs.Registry;
using Domain.Enums.Registry;
using Domain.Exceptions;
using Domain.IRepositories.Account;
using Domain.IRepositories.Registry;
using Microsoft.EntityFrameworkCore;

namespace Application.Services.Implementation.Registry;

public class RegistryService(
    IRegistryRepository registryRepository,
    IRegistrationOptionsRepository registrationOptionsRepository,
    IUserRepository userRepository,
    IAgentService agentService) : IRegistryService
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

    public async Task UpdateRegistryAmountModel(RegistryAmountModelDto amountModel,long userId)
    {
        var registry = await registryRepository.GetEntityById(amountModel.Id);
        var registryOptions = await registrationOptionsRepository.GetQuery().FirstOrDefaultAsync();
        
        if (registry is null) throw new ExistsException($"ریجستری با شناسه{amountModel.Id} پیدا نشد");

        var user = await userRepository.GetEntityById(registry.CreateBy);
        var agent = await agentService.GetAgentByIdAsync(user.AgentId);
        // var agentUser = await userRepository.GetEntityById(agent.AgentAdminId);
        
        var totalPercent = (user.IsAgent ? agent?.AgentPercent : agent?.UserPercent) ?? 1;
        var totalDecimalPercent = totalPercent / 100.0;
        
        var agentShareFraction = (registryOptions.AgentShareFraction / 100.0); 
        var agentAdjustedPercent = totalDecimalPercent * agentShareFraction;
        var price = (amountModel.Price ?? 0) + (registryOptions.PassportPrice);
        
        registry.Price = (long)Math.Round(price * agentAdjustedPercent);
        registry.Model = amountModel.Model;
        registry.Status = RegistryStatus.AwaitingForAcceptAmountModel;
        // var agentShare = (long)Math.Round((registry.Price ?? 0) * agentAdjustedPercent);
        // agentUser.Balance += agentShare;

        await registryRepository.UpdateEntity(registry);
        await registryRepository.SaveChanges(userId);
    }
}
using Application.Exceptions;
using Application.Helper;
using Application.Services.Interface.Account;
using Application.Services.Interface.Agent;
using Application.Services.Interface.Telegram;
using Data.DefaultData;
using Domain.DTOs.Account;
using Domain.DTOs.Agent;
using Domain.DTOs.Telegram;
using Domain.Entities.Account;
using Domain.Entities.Telegram;
using Domain.IRepositories.Account;
using Domain.IRepositories.Telegram;
using Microsoft.EntityFrameworkCore;
using System;
using Application.Services.Interface.Marzban;
using Application.Services.Interface.Transaction;
using Domain.DTOs.Marzban;
using Domain.DTOs.Transaction;
using Domain.Entities.Marzban;

namespace Application.Services.Implementation.Telegram;

public class TelegramService(
    ITelegramBotRepository telegramBotRepository,
    IUserRepository userRepository,
    IAgentService agentService,
    IMarzbanService marzbanService,
    ITransactionService transactionService) : ITelegramService
{
    public async Task<AddTelegramBotDto> AddTelegramBotAsync(AddTelegramBotDto bot, long userId)
    {
        TelegramBot telegramBot = bot._GenerateTelegramBot();

        if (await telegramBotRepository.GetQuery().AnyAsync(x => x.Token == bot.Token))
            throw new ExistsException("این بات از قبل ثبت شده است");

        await telegramBotRepository.AddEntity(telegramBot);
        await telegramBotRepository.SaveChanges(1);
        return bot;
    }

    public async Task<List<TelegramBotDto>?> GetAllTelegramBotAsync()
    {
        return await telegramBotRepository
            .GetQuery()
            .Select(x => new TelegramBotDto(x))
            .ToListAsync();
    }

    public async Task<string?> GetTelegramBotAsyncByName(string name)
    {
        TelegramBot? bot = await telegramBotRepository.GetQuery().SingleOrDefaultAsync(x => x.Name == name);

        return bot?.Token ?? null;
    }

    public async Task<User?> GetUserByChatIdAsync(long chatId)
    {
        return await userRepository.GetQuery().SingleOrDefaultAsync(x => x.ChatId == chatId);
    }

    public async Task<List<MarzbanVpnTestDto>> GetListMarzbanVpnTestAsync()
    {
        return await marzbanService.GetListMarzbanVpnsTest();
    }

    public async Task<List<MarzbanVpnBotDto>> GetMarzbanVpnsAsync()
    {
        return await marzbanService.GetListMarzbanVpns();
    }

    public async Task<MarzbanUserInformationDto> GetMarzbanTestVpnsAsync(long vpnId, long chatId)
    {
        User? user = await GetUserByChatIdAsync(chatId);
        MarzbanUser marzbanUser = await marzbanService.BuyMarzbanTestVpnAsync(vpnId, user.Id);
        return await marzbanService.GetMarzbanUserInformationAsync(marzbanUser.Username);
    }

    public async Task<GetMarzbanVpnDto?> GetMarzbanVpnInformationByIdAsync(long vpnId)
    {
        return await marzbanService.GetMarzbanVpnByIdAsync(vpnId);
    }

    public async Task<List<MarzbanVpnTemplateDto>> GetMarzbanVpnTemplatesByVpnIdAsync(long vpnId, long chatId)
    {
        User? user = await GetUserByChatIdAsync(chatId);
        return await marzbanService.GetMarzbanVpnTemplateByVpnIdAsync(vpnId, user!.Id);
    }

    public async Task<List<MarzbanUser>> BuySubscribeAsync(BuyMarzbanVpnDto buy, long chatId)
    {
        User? user = await GetUserByChatIdAsync(chatId);
        return await marzbanService.BuyMarzbanVpnAsync(buy, user.Id);
    }

    public async Task<SubscribeFactorBotDto> SendFactorSubscribeAsync(BuyMarzbanVpnDto buy, long chatId)
    {
        User? user = await GetUserByChatIdAsync(chatId);

        var agentIds = await agentService.GetAgentRoot(user.AgentId);

        using Percent percent = new(agentService);

        SubscribeFactorBotDto factor = new();

        factor.Title = buy.Title ?? "خرید سرویس کاهش پینگ";
        factor.Balance = user?.Balance ?? 0;

        if ((buy.MarzbanVpnTemplateId ?? 0) == 0)
        {
            GetMarzbanVpnDto? vpn = await GetMarzbanVpnInformationByIdAsync(buy.MarzbanVpnId);
            factor.Count = buy.Count == 0 ? 1 : buy.Count;
            // factor.Description = buy. todo
            factor.Price = ((buy.TotalGb * vpn.GbPrice) + (buy.TotalDay * vpn.DayPrice)) * buy.Count;
            factor.Days = buy.TotalDay;
            factor.Gb = buy.TotalGb;
            factor.Price = await percent.Calculate(agentIds, factor.Price);
            return factor;
        }

        MarzbanVpnTemplateDto? template =
            await marzbanService.GetMarzbanVpnTemplateByIdAsync(buy.MarzbanVpnTemplateId ?? 0);
        factor.Days = template.Days;
        factor.Gb = template.Gb;
        factor.Price = (await percent.Calculate(agentIds, template.Price)) * buy.Count;
        factor.Count = buy.Count;

        return factor;
    }

    public async Task<MarzbanVpnTemplateDto?> GetMarzbanTemplateByIdAsync(long id)
        => await marzbanService.GetMarzbanVpnTemplateByIdAsync(id);

    public async Task<FilterMarzbanUser> FilterMarzbanUsersList(FilterMarzbanUser filter)
        => await marzbanService.FilterMarzbanUsersAsync(filter);

    public async Task<SubescribeStatus.ServiceStatus?> GetMarzbanUserByChatIdAsync(long id, long chatId)
    {
        User user = await GetUserByChatIdAsync(chatId);
        MarzbanUserDto? marzbanUser = await marzbanService.GetMarzbanUserByUserIdAsync(id, user.Id);
        SubescribeStatus.ServiceStatus subescribeStatus = new SubescribeStatus.ServiceStatus(marzbanUser);
        return subescribeStatus;
    }

    public async Task<List<string>> GetMarzbanSubscibtionLiknsAsync(long id, long chatId)
    {
        User user = await GetUserByChatIdAsync(chatId);
        MarzbanUserDto? marzbanUser = await marzbanService.GetMarzbanUserByUserIdAsync(id, user.Id);
        return marzbanUser.Links;
    }

    public async Task<string> GetSubscibetionAsync(long id, long chatId)
    {
        User user = await GetUserByChatIdAsync(chatId);
        MarzbanUserDto? marzbanUser = await marzbanService.GetMarzbanUserByUserIdAsync(id, user.Id);
        return marzbanUser.Subscription_Url;
    }

    public async Task<List<TransactionDetailDto>> GetTransactionDetailAsync()
    {
        return await transactionService.GetTransactionDetailsAsync();
    }


    public async Task<string> ResetUserPasswordAsync(long chatId, int charter = 6)
    {
        User? user = await GetUserByChatIdAsync(chatId);
        if (DateTime.UtcNow - user.ModifiedDate >= TimeSpan.FromMinutes(3))
        {
            string password = new Random().Next(100000, 999999).ToString();
            user.Password = password;
            await userRepository.UpdateEntity(user);
            await userRepository.SaveChanges(user.Id);
            return password;
        }
        else
        {
            throw new AppException("لطفا چند دقیقه دیگر تلاش کنید");
        }

        return "";
    }

    public async Task UpdateMarzbanUserAsync(MarzbanUserDto user, long serverId)
    {
        throw new NotImplementedException();
    }

    public async Task AddTransactionAsync(AddTransactionDto transaction, long chatId)
    {
        User? user = await GetUserByChatIdAsync(chatId);
        await transactionService.AddTransactionAsync(transaction, user!.Id);
    }

    public async Task StartTelegramBot(StartTelegramBotDto start)
    {
        AgentDto? agent = await agentService.GetAgentByCode(start.AgentCode ?? 0);

        if (agent == null)
            agent = await agentService.GetAgentByIdAsync(AgentItems.Agents.First().Id);

        User? user = await GetUserByChatIdAsync(start.ChatId);

        if (user is null)
        {
            await userRepository.AddEntity(new User()
            {
                Balance = 0,
                AgentId = agent!.Id,
                FirstName = start.FirstName,
                LastName = start.LastName,
                Password = PasswordHelper.EncodePasswordMd5(start.ChatId.ToString()),
                EmailActiveCode = Guid.NewGuid().ToString("N"),
                ChatId = start.ChatId
            });

            await userRepository.SaveChanges(1);
        }
    }

    public async ValueTask DisposeAsync()
    {
        await agentService.DisposeAsync();
        await userRepository.DisposeAsync();
        await telegramBotRepository.DisposeAsync();
        GC.SuppressFinalize(agentService);
    }
}
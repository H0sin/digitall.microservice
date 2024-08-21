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
using Application.Extensions;
using Application.Services.Interface.Marzban;
using Application.Services.Interface.Notification;
using Application.Services.Interface.Transaction;
using Application.Sessions;
using Application.Static.Template;
using Domain.DTOs.Marzban;
using Domain.DTOs.Transaction;
using Domain.Entities.Agent;
using Domain.Entities.Marzban;
using Domain.Enums.Marzban;
using Domain.Exceptions;

namespace Application.Services.Implementation.Telegram;

public class TelegramService(
    ITelegramBotRepository telegramBotRepository,
    IUserRepository userRepository,
    IAgentService agentService,
    IMarzbanService marzbanService,
    ITransactionService transactionService,
    INotificationService notificationService) : ITelegramService
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

    public async Task<AgentDto?> GetAgentByTelegramToken(string token)
    {
        TelegramBot? telegramBot = await telegramBotRepository.GetQuery().Include(z => z.Agent)
            .SingleOrDefaultAsync(x => x.Token == token);

        AgentDto? agent = await agentService.GetAgentByIdAsync(telegramBot.AgentId);

        return agent;
    }

    public async Task<User?> GetUserByChatIdAsync(long chatId)
    {
        return await userRepository.GetQuery()
            .SingleOrDefaultAsync(x => x.ChatId == chatId);
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

    public async Task<MarzbanVpnDto?> GetMarzbanVpnInformationByIdAsync(long vpnId, long chatId)
    {
        User? user = await GetUserByChatIdAsync(chatId);
        return await marzbanService.GetMarzbanVpnByIdAsync(vpnId, user.Id);
    }

    public async Task<List<MarzbanVpnTemplateDto>> GetMarzbanVpnTemplatesByVpnIdAsync(long vpnId, long chatId)
    {
        User? user = await GetUserByChatIdAsync(chatId);
        return await marzbanService.GetMarzbanVpnTemplateByVpnIdAsync(vpnId, user!.Id);
    }

    public async Task<List<MarzbanUser>> BuySubscribeAsync(BuyMarzbanVpnDto buy, long chatId)
    {
        User? user = await GetUserByChatIdAsync(chatId);

        if (buy.MarzbanUserId != null && buy.MarzbanUserId != 0)
        {
            await marzbanService.RenewalMarzbanVpnAsync(buy, user?.Id ?? 0);
            return new List<MarzbanUser>();
        }
        else return await marzbanService.BuyMarzbanVpnAsync(buy, user?.Id ?? 0);
    }

    public async Task<SubscribeFactorBotDto> SendFactorSubscribeAsync(BuyMarzbanVpnDto buy, long chatId)
    {
        User? user = await GetUserByChatIdAsync(chatId);

        var agentIds = await agentService.GetAgentRoot(user.AgentId);

        SubscribeFactorBotDto factor = new();

        factor.Title = buy.Title ?? "خرید سرویس کاهش پینگ";
        factor.Balance = user.Balance;
        CountingVpnPrice countingVpnPrice = new();

        if ((buy.MarzbanVpnTemplateId ?? 0) == 0)
        {
            factor.Count = buy.Count == 0 ? 1 : buy.Count;
            MarzbanVpnDto? marzbanVpn = await marzbanService.GetMarzbanVpnByIdAsync(buy.MarzbanVpnId);

            long daysPrice = (factor.Days *
                              await countingVpnPrice.CalculateFinalPrice(agentService, user.Id, marzbanVpn.DayPrice)) *
                             factor.Count;

            long gbsPrice = (factor.Gb *
                             await countingVpnPrice.CalculateFinalPrice(agentService, user.Id, marzbanVpn.GbPrice)) *
                            factor.Count;

            marzbanVpn.DayPrice = gbsPrice;
            marzbanVpn.GbPrice = gbsPrice;

            factor.Price = buy.CountingPrice(marzbanVpn);
            factor.Days = buy.TotalDay;
            factor.Gb = buy.TotalGb;

            return factor;
        }

        MarzbanVpnTemplateDto? template =
            await marzbanService.GetMarzbanVpnTemplateByIdAsync(buy.MarzbanVpnTemplateId ?? 0);

        long templatePrice =
            await countingVpnPrice.CalculateFinalPrice(agentService, user.Id, template.Price);

        factor.Days = template.Days;
        factor.Gb = template.Gb;
        factor.Price = (templatePrice!) * buy.Count;
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

    public async Task<TransactionDetailDto?> GetTransactionDetailAsync(long chatId)
    {
        User? user = await GetUserByChatIdAsync(chatId);
        return await transactionService.GetTransactionDetailsAsync(user?.AgentId ?? 0);
    }


    public async Task<string> ResetUserPasswordAsync(long chatId, int charter = 6)
    {
        User? user = await GetUserByChatIdAsync(chatId);
        // if (DateTime.UtcNow - user.ModifiedDate >= TimeSpan.FromMinutes(3))
        // {
        string password = new Random().Next(100000, 999999).ToString();
        user.Password = PasswordHelper.EncodePasswordMd5(password);
        await userRepository.UpdateEntity(user);
        await userRepository.SaveChanges(user.Id);
        return password;
        // }
        // else
        // {
        //     throw new AppException("لطفا چند دقیقه دیگر تلاش کنید");
        // }

        // return "";
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

    public async Task<AgentOptionDto?> StartTelegramBotAsync(StartTelegramBotDto start)
    {
        User? user = await GetUserByChatIdAsync(start.ChatId);

        AgentDto? agent = await agentService.GetAgentByUserIdAsync(user?.Id ?? 0);
        User? newUser = null;

        if (user is null)
        {
            agent = await agentService.GetAgentByCode(start.AgentCode ?? 0);

            if (agent == null)
                agent = await agentService.GetAgentByIdAsync(AgentItems.Agents.First().Id);

            newUser = new User()
            {
                Balance = 0,
                AgentId = agent!.Id,
                FirstName = start.FirstName,
                LastName = start.LastName,
                Password = PasswordHelper.EncodePasswordMd5(start.ChatId.ToString()),
                EmailActiveCode = Guid.NewGuid().ToString("N"),
                ChatId = start.ChatId,
                BotId = start.BotId,
                TelegramUsername = start.TelegramUsername
            };

            await userRepository.AddEntity(newUser);
            await userRepository.SaveChanges(newUser.Id);
        }

        if ((newUser?.BotId ?? user!.BotId) != start.BotId)
            throw new ApplicationException("شما در ربات دیگری عضو شدید");

        await notificationService.AddNotificationAsync(
            NotificationTemplate.StartedBotNotification(agent!.AgentAdminId,
                start.TelegramUsername ?? (user?.UserFullName() ?? newUser?.UserFullName()), start.ChatId),
            user?.Id ?? newUser.Id);

        return await agentService.GetAgentOptionByAgentIdAsync(agent.Id);
    }

    public async Task ChangeMarzbanUserStatusAsync(MarzbanUserStatus status, long marzbanUserId, long chatId)
    {
        User user = await GetUserByChatIdAsync(chatId);
        await marzbanService.ChangeMarzbanUserStatusAsync(status, marzbanUserId, user.Id);
    }

    public async Task<bool> HaveRequestForAgentAsync(long chatId)
    {
        User? user = await GetUserByChatIdAsync(chatId);
        return await agentService.HaveRequestAgentAsync(user!.Id);
    }

    public async Task AddRequestAgentAsync(string description, long chatId)
    {
        User? user = await GetUserByChatIdAsync(chatId);

        AddRequestAgentDto request = new()
        {
            Description = description
        };

        await agentService.AddAgentRequestAsync(request, user!.Id);
    }

    public async Task DeleteMarzbanUserAsync(long marzbanUserId, long chatId)
    {
        User? user = await GetUserByChatIdAsync(chatId);
        await marzbanService.DeleteMarzbanUserAsync(marzbanUserId, user.Id);
    }

    public async Task<string> RevokeMarzbanUserAsync(long marzbanUserId, long chatId)
    {
        User? user = await GetUserByChatIdAsync(chatId);
        return await marzbanService.RevokeMarzbanUserAsync(marzbanUserId, user.Id);
    }

    public async Task<AgentDto?> GetAgentByChatIdAsync(long chatId)
    {
        User? user = await GetUserByChatIdAsync(chatId);
        return await agentService.GetAgentByUserIdAsync(user!.Id);
    }

    public async Task<bool> IsAgentAsyncByChatIdAsync(long chatId)
    {
        User? user = await GetUserByChatIdAsync(chatId);
        return await agentService.IsAgentAsync(user!.Id);
    }

    public async Task<string?> GetAgentBotLinkAsync(long chatId)
    {
        User? user = await GetUserByChatIdAsync(chatId);
        return await agentService.GetAgentTelegramLink(user!.Id);
    }

    public async Task<TelegramBotDto> GetTelegramBotByBotIdAsync(long botId)
    {
        return new TelegramBotDto(await telegramBotRepository
            .GetQuery()
            .SingleOrDefaultAsync(x => x.BotId == botId));
    }

    public async Task<bool> EditeAgentTransactionDetailAsync(long chatId, TelegramMarzbanVpnSession session)
    {
        User? user = await GetUserByChatIdAsync(chatId);

        AgentDto? agent = await agentService
            .GetAgentByAdminIdAsync(user?.Id);

        if (agent is null)
            return false;

        TransactionDetailDto transactionDetail = new()
        {
            CardNumber = session.CardNumber,
            CardHolderName = session.CardHolderName,
            Id = agent.TransactionDeatilId
        };

        return await transactionService.UpdateTransactionDetailsAsync(transactionDetail, user!.Id);
    }

    public async Task<TransactionDetailDto?> GetAgentTransactionDetailAsync(long chatId)
    {
        User? user = await GetUserByChatIdAsync(chatId);
        AgentDto? agent = await agentService.GetAgentByAdminIdAsync(user!.Id);
        TransactionDetailDto? transactionDetail = await transactionService.GetTransactionDetailsAsync(agent!.Id);
        return transactionDetail;
    }

    public async Task<AgentInformationDto> GetAgentInformationAsync(long chatId)
    {
        User? user = await GetUserByChatIdAsync(chatId);
        return await agentService.GetAgentInformationAsync(user.Id);
    }

    public async Task<bool> UpdateAgentPercentAsync(long chatId, long percent)
    {
        User? user = await GetUserByChatIdAsync(chatId);

        AgentDto agent = await agentService.GetAgentByAdminIdAsync(user.Id);

        if (agent is null)
            throw new ApplicationException("شما نماینده نیستید");

        agent.AgentPercent = percent;

        return await agentService.UpdateAgentAsync(agent, user.Id);
    }

    public async Task<bool> UpdateUserPercentAsync(long chatId, long percent)
    {
        User? user = await GetUserByChatIdAsync(chatId);

        AgentDto agent = await agentService.GetAgentByAdminIdAsync(user.Id);

        if (agent is null)
            throw new ApplicationException("شما نماینده نیستید");

        agent.UserPercent = percent;
        return await agentService.UpdateAgentAsync(agent, user.Id);
    }

    public async Task<bool> UpdateAgentBrandNames(long chatId, string? persionBrandName, string? englishBrandName)
    {
        User? user = await GetUserByChatIdAsync(chatId);
        AgentDto agent = await agentService.GetAgentByAdminIdAsync(user.Id);

        if (agent is null)
            throw new ApplicationException("شما نماینده نیستید");

        agent.PersianBrandName = persionBrandName;
        agent.BrandName = englishBrandName;

        return await agentService.UpdateAgentAsync(agent, user.Id);
    }
}
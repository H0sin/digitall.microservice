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

namespace Application.Services.Implementation.Telegram;

public class TelegramService(
    ITelegramBotRepository telegramBotRepository,
    IUserRepository userRepository,
    IAgentService agentService) : ITelegramService
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

    public async Task<List<TelegramBotDto>> GetAllTelegramBotAsync()
    {
        return await telegramBotRepository.GetQuery().Select(x => new TelegramBotDto(x)).ToListAsync();
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
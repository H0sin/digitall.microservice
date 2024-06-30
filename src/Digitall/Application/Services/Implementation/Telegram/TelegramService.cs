using Application.Helper;
using Application.Services.Interface.Account;
using Application.Services.Interface.Agent;
using Application.Services.Interface.Telegram;
using Data.DefaultData;
using Domain.DTOs.Account;
using Domain.DTOs.Agent;
using Domain.DTOs.Telegram;
using Domain.Entities.Account;
using Domain.IRepositories.Account;

namespace Application.Services.Implementation.Telegram;

public class TelegramService(IUserRepository userRepository,IAgentService agentService) : ITelegramService
{
    public async Task RegisterUserFromTelegram(AddUserFromTelegramDto user)
    {
        AgentDto? agent = await agentService.GetAgentByCode(user.AgentCode ?? 0);

        if (agent == null)
            agent = await agentService.GetAgentByIdAsync(AgentItems.Agents.First().Id);

        await userRepository.AddEntity(new User()
        {
            Balance = 0,
            AgentId = agent.Id,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Password = PasswordHelper.EncodePasswordMd5(user.ChatId.ToString()),
            EmailActiveCode = Guid.NewGuid().ToString("N")
        });

        await userRepository.SaveChanges(1);
    }
}
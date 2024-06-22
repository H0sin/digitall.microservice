using Application.Services.Interface.Account;
using Application.Services.Interface.Telegram;
using Domain.DTOs.Account;
using Domain.DTOs.Telegram;
using Domain.IRepositories.Account;

namespace Application.Services.Implementation.Telegram;

public class TelegramService(IUserRepository userRepository) : ITelegramService
{
    public async Task RegisterUserFromTelegram(AddUserFromTelegramDto user)
    {
        await userRepository.AddEntity(new()
        {
            FirstName = user.FirstName,
            LastName = user.LastName,
            ChatId = user.ChatId
        });
    }
}
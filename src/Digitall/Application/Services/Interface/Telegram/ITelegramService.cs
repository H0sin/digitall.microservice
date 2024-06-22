using Domain.DTOs.Telegram;

namespace Application.Services.Interface.Telegram;

public interface ITelegramService
{
    Task RegisterUserFromTelegram(AddUserFromTelegramDto user);
}
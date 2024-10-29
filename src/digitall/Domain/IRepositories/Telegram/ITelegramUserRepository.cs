using Domain.Entities.Telegram;

namespace Domain.IRepositories.Telegram;

public interface ITelegramUserRepository
{
    Task<TelegramUser> Update(TelegramUser user);
    Task<TelegramUser?> Get(long key);
}
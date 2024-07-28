using Data.Context;
using Data.Repositories.Base;
using Domain.Entities.Telegram;
using Domain.IRepositories.Telegram;

namespace Data.Repositories.Telegram;

public class TelegramBotRepository(DigitallDbContext context)
    : BaseRepository<TelegramBot>(context), ITelegramBotRepository;
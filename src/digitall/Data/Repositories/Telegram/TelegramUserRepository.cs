using Domain.Entities.Telegram;
using Domain.IRepositories.Telegram;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Data.Repositories.Telegram;

public class TelegramUserRepository : ITelegramUserRepository
{
    private readonly IDistributedCache _cache;
    
    public async Task<TelegramUser> Update(TelegramUser user)
    {
        var options = new DistributedCacheEntryOptions
        {
            AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(24)
        };

        var jsonData = JsonSerializer.Serialize(user);
        await _cache.SetStringAsync(user.UserChatId.ToString(), jsonData, options);

        return user;
    }

    public async Task<TelegramUser?> Get(long key)
    {
        var user = await _cache.GetStringAsync(key.ToString());
        
        if (string.IsNullOrEmpty(user))
            return null;
        
        return JsonConvert.DeserializeObject<TelegramUser>(user); 
    }
}
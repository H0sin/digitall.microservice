using Domain.Entities.Telegram;
using Domain.IRepositories.Telegram;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;

namespace Data.Repositories.Telegram;

public class TelegramUserRepository(IDistributedCache _cache) : ITelegramUserRepository
{
    public async Task<TelegramUser> Update(TelegramUser user)
    {
        var jsonData = JsonConvert.SerializeObject(user);

        await _cache.SetStringAsync(user.UserChatId.ToString(), jsonData);

        return user;
    }

    public async Task<TelegramUser?> Get(long key)
    {
        var user = await _cache.GetStringAsync(key.ToString());
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("----------------------------------------------------");

        Console.WriteLine(user);
        
        
        Console.WriteLine(user);
        Console.WriteLine(user);
        Console.WriteLine(user);
        Console.WriteLine(user);
        Console.WriteLine(user);
        Console.WriteLine(user);
        Console.WriteLine(user);
        
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("----------------------------------------------------");


        if (string.IsNullOrWhiteSpace(user) | string.IsNullOrEmpty(user))
            return null;

        return JsonConvert.DeserializeObject<TelegramUser>(user);
    }
}
using Domain.Entities.Marzban;

namespace Domain.DTOs.Marzban;

public class MarzbanUserDto
{
    public string Username { get; set; }
    public string? Expire { get; set; }
    public long? Data_Limit { get; set; } = 0;

    public MarzbanUserDto()
    {

    }

    public MarzbanUserDto(MarzbanUser marzbanUser)
    {
        Username = marzbanUser.Username;
        Expire = marzbanUser.Expire;
        Data_Limit = marzbanUser.Data_Limit;
    }
}
namespace Domain.DTOs.Wireguard;

public class BuyWireguardResponseDto
{
    public string Name { get; set; }
    public string Config { get; set; }
    public int Day { get; set; }
    public int Gb { get; set; }
    public string Title { get; set; }
    
    public BuyWireguardResponseDto(string title,string name, string config, int? day, int? gb)
    {
        Name = name;
        Config = config;
        Day = day ?? 0;
        Gb = gb ?? 0;
        Title = title;
    } 
}
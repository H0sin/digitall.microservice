namespace Domain.DTOs.Agent;

public class AgentInformationDto
{
    public string? BrandName { get; set; }
    public string? PersianBrandName { get; set; }
    public long AgentAdminId { get; set; }
    public long AgentCode { get; set; }
    public string? BrandAddress { get; set; }
    public long AgentPercent { get; set; }
    public long UserPercent { get; set; }
    public long? TelegramBotId { get; set; }
    public string? BotName { get; set; }
    public string? BotToken { get; set; }
    public long? BotId { get; set; }
    public string? AdminName { get; set; }
    public int CountUser { get; set; }
    public long Sale { get; set; }
    public long Profit { get; set; }
    public int? CountAgentLevel_1 { get; set; } = 0;
    public int? CountAgentLevel_2 { get; set; } = 0;

    public string Information_Text()
    {
         return $@"
            📱 اطلاعات نمایندگی
                
            🔖 نام برند: {BrandName}
            🏷️ نام برند فارسی: {PersianBrandName} 
             🔑 شناسه نمایندگی:{AgentCode}
            🏠 آدرس برند: {BrandAddress}
            📈 درصد نمایندگی: {AgentPercent}%
            👥 درصد کاربر: {UserPercent}%
            👤 نام مدیر: {AdminName}
            👥 تعداد کاربران: {CountUser}
            💰 فروش: {Sale} تومان
            💵 سود: {Profit} تومان
            👤 تعداد نمایندگان سطح 1: {CountAgentLevel_1 ?? 0}
            👤 تعداد نمایندگان سطح 2: {CountAgentLevel_2 ?? 0}
            ";
    }
}
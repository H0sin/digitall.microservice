using System.ComponentModel.DataAnnotations;
using Domain.DTOs.Transaction;
using Domain.Entities.Agent;
using Domain.Enums.Agent;

namespace Domain.DTOs.Agent;

public class AddRequestAgentDto
{
    [Display(Name = "نام برند")]
    [MaxLength(300, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public string? BrandName { get; set; } = "";

    [Display(Name = "نام فارسی برند")]
    [MaxLength(300, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public string? PersianBrandName { get; set; } = "";

    [Display(Name = "آدرس مغازه")] public string? BrandAddress { get; set; }

    [Display(Name = "درصد نماینده")] public long AgentPercent { get; set; } = 0;

    [Display(Name = "درصد کاربر")] public long UserPercent { get; set; } = 0;

    [Display(Name = "توضیحات")] public string? Description { get; set; }
    
    [Display(Name = "شماره تماس")] public string Phone { get; set; }
    
    public AddTransactionDetailDto? transactionDetial { get; set; } = new();

    public AgentRequest _GenerateAgentRequest(long userId,long agentId)
    {
        AgentRequest agentRequest =
            new()
            {
                BrandName = BrandName,
                PersianBrandName = PersianBrandName,
                BrandAddress = BrandAddress,
                AgentPercent = AgentPercent,
                UserPercent = UserPercent,
                Description = Description,
                CardHolderName = transactionDetial?.CardHolderName,
                CardNumber = transactionDetial?.CardNumber,
                UserId = userId,
                AgentId = agentId,
                Phone = Phone,
            };

        return agentRequest;
    }
}
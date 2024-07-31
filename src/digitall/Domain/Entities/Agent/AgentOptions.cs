using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Common;

namespace Domain.Entities.Agent;

[Table("AgentOption")]
public class AgentOptions : BaseEntity
{
    [Display(Name = "پیام خوش آمد گویی ")]
    [MaxLength(500, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string? WelcomeMessage { get; set; } = "خوش آمدید";

    public long AgentId { get; set; }
    public Agent? Agent { get; set; }
}
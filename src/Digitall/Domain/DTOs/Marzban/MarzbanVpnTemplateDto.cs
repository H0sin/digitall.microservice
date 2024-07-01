using System.ComponentModel.DataAnnotations;

namespace Domain.DTOs.Marzban;

public class MarzbanVpnTemplateDto
{
    public long Id { get; set; }
    public string? Title { get; set; }

    public long Price { get; set; }

    public int Days { get; set; }

    public int Gb { get; set; }

    public long MarzbanVpnId { get; set; }
}
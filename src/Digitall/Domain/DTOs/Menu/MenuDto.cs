using System.ComponentModel.DataAnnotations;

namespace Domain.DTOs.Menu;

public class MenuDto
{
    public long Id { get; set; }
    public string? Title { get; set; }
    public bool Active { get; set; } = true;
    public string? Icon { get; set; }
    public string? Link { get; set; }
    public string? Area { get; set; }
    public string? Controller { get; set; }
    public string? Action { get; set; }
    public int Sorted { get; set; }
    public List<MenuDto>? Menus { get; set; } = new List<MenuDto>();
}
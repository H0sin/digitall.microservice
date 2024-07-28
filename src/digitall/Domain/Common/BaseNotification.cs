namespace Domain.Common;

public class BaseNotification
{
    public string? Message { get; set; }
    public string? Subject { get; set; }
    public int Status { get; set; }
    public string? Receiver { get; set; }
    public string[]? Receivers { get; set; }
}
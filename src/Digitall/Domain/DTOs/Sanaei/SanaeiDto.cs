namespace Domain.DTOs.Sanaei;

public class SanaeiDto<T> where T : class
{
    public bool Success { get; set; }
    public string? Msg { get; set; }
    public T? Obj { get; set; }
}

public class SanaeiDto
{
    public bool Success { get; set; }
    public string? Msg { get; set; }
    public string? Obj { get; set; } = null;
}
namespace Application.Utilities;

public class JobSettings
{
    public string JobName { get; set; }
    public string JobGroup { get; set; }
    public string TriggerName { get; set; }
    public string TriggerGroup { get; set; }
    public string CronSchedule { get; set; }
    public string JobType { get; set; }
}
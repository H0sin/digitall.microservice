namespace Domain.Enums.Notification;

[Flags]
public enum NotificationType : byte
{
    Alter,
    Warning,
    Danger,
    Success
}
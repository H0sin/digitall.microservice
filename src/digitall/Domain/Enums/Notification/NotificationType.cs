namespace Domain.Enums.Notification;

[Flags]
public enum NotificationType : byte
{
    Alter,
    Warning,
    Danger,
    Success,
    StartReports,
    FinancialReports,
    BogsReports,
    BuyReports,
    RenewReports,
    PaymentReports,
    DeletedReports,
    AgentRequestReports,
} 
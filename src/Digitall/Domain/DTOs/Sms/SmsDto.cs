using Domain.Common;
using Domain.Enums.Notification;
using IPE.SmsIrClient.Models.Requests;

namespace Domain.DTOs.Sms;

public class SmsDto : BaseNotification
{
    public TypeSendSms TypeSendSms { get; set; }
    public VerifySendParameter[] Parameters { get; set; }
}
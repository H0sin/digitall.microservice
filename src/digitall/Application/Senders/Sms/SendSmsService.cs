using Application.Services.Interface.Notification;
using Application.Services.Interface.Account;
using Domain.Common;
using Domain.DTOs.Sms;
using Domain.Entities.Account;
using Domain.Enums.Notification;
using Domain.Exceptions;
using IPE.SmsIrClient;
using IPE.SmsIrClient.Models.Requests;
using IPE.SmsIrClient.Models.Results;
using Microsoft.Extensions.Configuration;

namespace Application.Senders.Sms;

public class SendSmsService<T> : ISendNotificationService<T> where T : SmsDto
{
    #region constructor

    private IConfigurationRoot _configuration;

    public SendSmsService()
    {
        _configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
    }

    #endregion

    public async Task<bool> SendNotificationAsync(T notification)
    {
        try
        {
            SmsIr smsIr = new SmsIr(_configuration.GetSection("SmsIrConfig:ApiKey").Value);
            switch (notification.TypeSendSms)
            {
                case TypeSendSms.SendPassword:
                    int templateId = Convert.ToInt32(_configuration.GetSection("SmsIrConfig:PasswordTemplateId").Value);
                    var response =
                        await smsIr.VerifySendAsync(notification.Receiver, templateId, notification.Parameters);
                    VerifySendResult sendResult = response.Data;
                    return true;
                case TypeSendSms.SendChangeMobile:
                    int templateIdChangePhone =
                        Convert.ToInt32(_configuration.GetSection("SmsIrConfig:ChangePhoneNumber").Value);
                    var responseChangePhone = await smsIr.VerifySendAsync(notification.Receiver, templateIdChangePhone,
                        notification.Parameters);
                    VerifySendResult changePhone = responseChangePhone.Data;
                    return true;
            }
        }
        catch (Exception e)
        {
            throw new AppException("خطایی در ارسال پیامک رخ داده است");
        }

        return false;
    }
}
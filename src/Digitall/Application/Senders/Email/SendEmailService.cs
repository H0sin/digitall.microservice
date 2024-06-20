using MailKit.Net.Smtp;
using Application.Services.Interface.Notification;
using Domain.DTOs.Email;
using MailKit.Security;
using Microsoft.Extensions.Configuration;
using MimeKit;

namespace Application.Senders.Email;

public class SendEmailService<T> : ISendNotificationService<T> where T : EmailDto
{
    private IConfigurationRoot _configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

    public async Task<bool> SendNotificationAsync(T notification)
    {
        var message = new MimeMessage();
        message.From.Add(new MailboxAddress("Digitall Vpn", "h.faraji8079@gmail.com"));
        message.To.Add(new MailboxAddress("Recipient Name", notification.Receiver));
        message.Subject = notification.Subject;
        message.Body = new TextPart("plain")
        {
            Text = notification.Message
        };

        using (var client = new SmtpClient())
        {
            try
            {
                await client.ConnectAsync("smtp.gmail.com", 587, SecureSocketOptions.StartTls);

                // Note: only needed if the SMTP server requires authentication
                client.Authenticate("h.faraji8079@gmail.com", "Hossein8916");
                client.Send(message);
                client.Disconnect(true);
                Console.WriteLine("Email sent successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        return true;
    }
}
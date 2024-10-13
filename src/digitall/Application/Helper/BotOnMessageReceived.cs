using System.Diagnostics;
using Application.Extensions;
using Application.Services.Interface.Notification;
using Application.Services.Interface.Telegram;
using Application.Sessions;
using Domain.DTOs.Agent;
using Domain.DTOs.Notification;
using Domain.Enums.Notification;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Telegram.Bot;
using Telegram.Bot.Types;
using User = Domain.Entities.Account.User;

namespace Application.Helper;

public static class BotOnMessageReceived
{
    public static async Task Action(Message message,
        ITelegramBotClient botClient,
        IMemoryCache memoryCache,
        ITelegramService telegramService,
        INotificationService notificationService,
        CancellationToken cancellationToken)
    {
        try
        {
            long chatId = message.Chat.Id;

            if (memoryCache.TryGetValue(message?.Chat.Id ?? 0, out TelegramUser? telegramUser))
            {
            }
            else
            {
                memoryCache.Set(message?.Chat.Id ?? 0, new TelegramUser(), TimeSpan.FromMinutes(10));
                telegramUser = memoryCache.Get(message?.Chat.Id ?? 0) as TelegramUser;
            }


            if (message.Photo is not { } photo & message.Text is not { } messageText)
                await botClient.SendTextMessageAsync(chatId, "فرمت ارسالی درست نیست",
                    cancellationToken: cancellationToken);

            User? user = await telegramService.GetUserByChatIdAsync(chatId);


            if (user != null && message.Text != TelegramHelper.BackToHomeButtonText &&
                message.Text != TelegramHelper.BackListTypeOfSendMessageButtonText)
                await TelegramHelper.MessageBasedOnStatus(botClient, telegramService, message, telegramUser, user,
                    cancellationToken);

            bool? started = message?.Text?.StartsWith("/start");

            Message? action = new Message();

            if (started != null & started == true)
            {
                action = message?.Text?.Split(" ")[0] switch
                {
                    "/start" => await telegramService.StartedTelegramBotAsync(botClient, message, cancellationToken,
                        telegramUser),
                };
            }

            if (user?.IsAgent ?? false)
            {
                Debug.Assert(telegramUser != null, nameof(telegramUser) + " != null");

                switch (message?.Text ?? "")
                {
                    case TelegramHelper.BackToHomeButtonText:
                        await telegramService.SendMainMenuAsync(
                            botClient,
                            new() { Message = message },
                            cancellationToken,
                            telegramUser);
                        break;
                    case TelegramHelper.ChangeBrandingNameButtonText:
                        await
                            telegramService.UpdateAgentBrandingNameAsync(
                                botClient, new() { Message = message }, cancellationToken, telegramUser);
                        break;

                    case TelegramHelper.ChangeCardNumberButtonText:
                        await
                            telegramService.SendTextForUpdateAgentCardDetailInformationAsync(
                                botClient, new() { Message = message }, cancellationToken, telegramUser);
                        break;

                    case TelegramHelper.ShowPaymentInformationeButtonText:
                        await
                            telegramService.SendAgentTransactionPaymentDetailAsync(
                                botClient, new() { Message = message }, cancellationToken, telegramUser);
                        break;

                    case TelegramHelper.ChangeAgentPercnteButtonText:
                        await
                            telegramService.SendTextUpdateAgentPercentAsync(
                                botClient, new() { Message = message }, cancellationToken, telegramUser);
                        break;

                    case TelegramHelper.ChangeUserPercenteButtonText:
                        await
                            telegramService.SendTextUpdateUserPercentAsync(
                                botClient, new() { Message = message }, cancellationToken, telegramUser);
                        break;

                    case TelegramHelper.UserPaymentButtonText:
                        await
                            telegramService.SendTextUpdatePaymentForUserOptionAsync(
                                botClient, new() { Message = message }, cancellationToken, telegramUser);
                        break;

                    case TelegramHelper.AgentPaymentButtonText:
                        await
                            telegramService.SendTextUpdatePaymentForAgentOptionAsync(
                                botClient, new() { Message = message }, cancellationToken, telegramUser);

                        break;

                    case TelegramHelper.RepresentationStatisticsButtonText:
                        await telegramService.SendAgentInformationAsync(
                            botClient, new() { Message = message }, cancellationToken);

                        break;

                    case TelegramHelper.SearchUserButtonText:
                        await telegramService.SendTextSearchUserByChatAsync(
                            botClient, new() { Message = message }, cancellationToken, telegramUser);

                        break;

                    case TelegramHelper.SendMessageButtonText:
                        await telegramService.SendMenuForSendMessageByAgentAsync(botClient, new() { Message = message },
                            cancellationToken);
                        break;

                    case TelegramHelper.BackToManagement:
                        await telegramService.SendMenuAgencyManagementAsync(botClient, new() { Message = message },
                            cancellationToken);

                        break;

                    case TelegramHelper.BackListTypeOfSendMessageButtonText:
                        await telegramService.SendMenuForSendMessageByAgentAsync(botClient, new() { Message = message },
                            cancellationToken);

                        break;

                    case TelegramHelper.ForwardMessageButtonText:
                        await telegramService.SendMenuForSelectedUserGroupingByAgentAsync(botClient,
                            new()
                            {
                                Data = "sned_message?type=forward",
                                Message = message
                            },
                            cancellationToken, telegramUser);
                        break;

                    case TelegramHelper.CustomMessageButtonText:
                        await telegramService.SendMenuForSelectedUserGroupingByAgentAsync(botClient,
                            new()
                            {
                                Data = "sned_message?type=custom",
                                Message = message
                            },
                            cancellationToken, telegramUser);
                        break;

                    case TelegramHelper.ForAllUserButtonText:
                        await telegramService.SubmitListingsButtonsAsync(botClient,
                            new()
                            {
                                Data = "user_categroy?group=all",
                                Message = message
                            },
                            cancellationToken, telegramUser);

                        break;

                    case TelegramHelper.ForAgentButtonText:
                        await telegramService.SubmitListingsButtonsAsync(botClient,
                            new()
                            {
                                Data = "user_categroy?group=agent",
                                Message = message
                            },
                            cancellationToken, telegramUser);

                        break;

                    case TelegramHelper.SendTransactionWaitingMessageButtonText:
                        await telegramService
                            .SendTransactionsWaitingQueAsync(
                                botClient, new()
                                {
                                    Data = "send_list_waiting_transaction",
                                    Message = message
                                }, cancellationToken);
                        break;
                    
                    case TelegramHelper.SendDeleteServiceWaitingMessageButtonText:
                        await telegramService
                            .SendDeletedServiceInQueAsync(
                                botClient, new()
                                {
                                    Data = "send_list_waiting_Deleted",
                                    Message = message
                                }, cancellationToken);
                        break;

                    default:
                        action = message?.Text switch
                        {
                            TelegramHelper.AgencyManagementButtonText => await telegramService.AgencyManagementAsync(
                                botClient, message, cancellationToken),
                            TelegramHelper.RepresentationStatisticsButtonText => await telegramService
                                .StartedTelegramBotAsync(
                                    botClient, message, cancellationToken, telegramUser),
                            TelegramHelper.SendMessageButtonText => await telegramService.StartedTelegramBotAsync(
                                botClient,
                                message, cancellationToken, telegramUser),
                            TelegramHelper.SearchUserButtonText => await telegramService.StartedTelegramBotAsync(
                                botClient,
                                message, cancellationToken, telegramUser),
                            TelegramHelper.BackToHomeButtonText => await telegramService.StartedTelegramBotAsync(
                                botClient,
                                message, cancellationToken, telegramUser),
                            TelegramHelper.ManagementAgentsButtonText => await telegramService.SendListAgentsAsync(
                                botClient, message, cancellationToken),
                            TelegramHelper.ChangeCardNumberButtonText => await telegramService.StartedTelegramBotAsync(
                                botClient, message, cancellationToken, telegramUser),
                            TelegramHelper.ShowPaymentInformationeButtonText => await telegramService
                                .StartedTelegramBotAsync(
                                    botClient, message, cancellationToken, telegramUser),
                            TelegramHelper.ChangeAgentPercnteButtonText => await
                                telegramService.StartedTelegramBotAsync(
                                    botClient, message, cancellationToken, telegramUser),
                            TelegramHelper.ChangeUserPercenteButtonText => await
                                telegramService.StartedTelegramBotAsync(
                                    botClient, message, cancellationToken, telegramUser),
                            TelegramHelper.UserPaymentButtonText => await telegramService.StartedTelegramBotAsync(
                                botClient,
                                message, cancellationToken, telegramUser),
                            _ => new Message()
                        };
                        break;
                }
            }

            Message sentMessage = action;
        }
        catch (Exception e)
        {
            User? curent_user = await telegramService.GetUserByChatIdAsync(message!.Chat.Id);

            bool containsEnglishCharacters = e.Message.Any(c => c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z');

            if (containsEnglishCharacters)
            {
                var errorDetails = $"""
                                    🛠️ گزارش باگ جدید
                                    ❌❌❌❌❌❌❌
                                    👤 کاربری که دچار خطا شده: {curent_user.UserFullName()}
                                    💬 شناسه کاربریش: {curent_user.ChatId}
                                    ❗ عنوان خطا: {e.Message}
                                    📜 جزیات خطا: {e.InnerException?.Message ?? "مشخص نیست"}
                                    📍 مکان خطا: {e.StackTrace ?? "مشخص نیست"}
                                    ❌❌❌❌❌❌❌
                                    """;


                await notificationService.AddNotificationAsync(new AddNotificationDto()
                {
                    Message = errorDetails,
                    NotificationType = NotificationType.BogsReports,
                    UserId = curent_user.Id,
                }, curent_user.Id);

                var userErrorMessage = $"""
                                        ⚠️ متاسفانه مشکلی در هنگام پردازش درخواست شما پیش آمده است.

                                        🚫 ما عمیقاً از این موضوع پوزش می‌طلبیم و به سرعت در حال بررسی این مشکل هستیم. لطفاً چند دقیقه صبر کنید و دوباره تلاش کنید.

                                        🔄 اگر این مشکل ادامه پیدا کرد، پیشنهاد می‌کنیم ربات را دوباره استارت کنید تا شاید مشکل برطرف شود.

                                        /start

                                        🔧 در صورتی که مشکل همچنان باقی ماند، لطفاً با پشتیبانی تماس بگیرید تا بتوانیم به شما کمک کنیم.

                                        🙏 با تشکر از شکیبایی و درک شما.
                                        """;

                await botClient.SendTextMessageAsync(
                    chatId: message.Chat.Id,
                    text: userErrorMessage,
                    cancellationToken: cancellationToken);
            }
            else
            {
                await botClient.SendTextMessageAsync(
                    chatId: message.Chat.Id,
                    text: e.Message,
                    cancellationToken: cancellationToken);
            }
        }
    }
}
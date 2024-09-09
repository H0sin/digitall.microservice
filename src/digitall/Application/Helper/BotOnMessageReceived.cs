using System.Diagnostics;
using Application.Services.Interface.Telegram;
using Application.Sessions;
using Domain.DTOs.Agent;
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


            if (user != null && message.Text != TelegramHelper.BackToHomeButtonText && message.Text != TelegramHelper.BackListTypeOfSendMessageButtonText)
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
                            cancellationToken,telegramUser);
                        break;
                    
                    case TelegramHelper.CustomMessageButtonText:
                        await telegramService.SendMenuForSelectedUserGroupingByAgentAsync(botClient,
                            new()
                            {
                                Data = "sned_message?type=custom",
                                Message = message
                            },
                            cancellationToken,telegramUser);
                        break;
                    
                    case TelegramHelper.ForAllUserButtonText:
                        await telegramService.SubmitListingsButtonsAsync(botClient,
                            new()
                            {
                                Data = "user_categroy?group=all",
                                Message = message
                            },
                            cancellationToken,telegramUser);
                        
                        break;
                    
                    case TelegramHelper.ForAgentButtonText:
                        await telegramService.SubmitListingsButtonsAsync(botClient,
                            new()
                            {
                                Data = "user_categroy?group=agent",
                                Message = message
                            },
                            cancellationToken,telegramUser);
                        
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
            await botClient!.SendTextMessageAsync(message.Chat.Id, e.Message, cancellationToken: cancellationToken);
        }
    }
}
using Application.Services.Interface.Telegram;
using Application.Sessions;
using Microsoft.Extensions.Caching.Memory;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;
using User = Domain.Entities.Account.User;

namespace Application.Helper;

public static class BotOnCallbackQueryReceived
{
    public static async Task Action(ITelegramService telegramService,
        TelegramBotClient botClient,
        CallbackQuery callbackQuery,
        IMemoryCache memoryCache,
        CancellationToken cancellationToken)
    {
        string data = callbackQuery.Data.Split('?')[0];

        if (memoryCache.TryGetValue(callbackQuery.Message?.Chat.Id ?? 0, out TelegramUser? telegramUser))
        {
        }
        else
        {
            memoryCache.Set(callbackQuery.Message?.Chat.Id ?? 0, new TelegramUser(), TimeSpan.FromMinutes(10));
            telegramUser = memoryCache.Get(callbackQuery.Message?.Chat.Id ?? 0) as TelegramUser;
        }

        try
        {
            switch (data)
            {
                case "start":
                    await telegramService.StartedTelegramBotAsync(botClient, callbackQuery.Message, cancellationToken, telegramUser!);
                    break;
                
                case "back_to_home":
                    await telegramService.SendMainMenuAsync(botClient, callbackQuery, cancellationToken, telegramUser);
                    break;

                case "test_free":
                    await telegramService.SendListVpnHaveTestAsync(botClient, callbackQuery, cancellationToken);
                    break;

                case "create_test_config":
                    await telegramService.SendSubscriptionTestAsync(botClient, callbackQuery, cancellationToken,
                        telegramUser);
                    break;

                case "list_vpn":
                    await telegramService.SendListVpnAsync(botClient, callbackQuery, cancellationToken);
                    break;

                case "list_vpn_template":
                    await telegramService.SendListVpnTemplateAsync(botClient, callbackQuery, cancellationToken);
                    break;

                case "sendpricetemplate":
                    await telegramService.SendVpnGbAndPriceAsync(botClient, callbackQuery, cancellationToken);
                    break;

                case "factor_subscribe":
                    await telegramService.SendFactorVpnAsync(botClient, callbackQuery, cancellationToken, telegramUser);
                    break;

                case "buy_subscribe":
                    await telegramService.SendSubscriptionAsync(botClient, callbackQuery, cancellationToken,
                        telegramUser);
                    break;

                case "my_services":
                    await telegramService.SendListServicesAsync(botClient, callbackQuery, cancellationToken);
                    break;

                case "subscribe_info":
                    await telegramService.SendSubscribeInformationAsync(botClient, callbackQuery, cancellationToken,
                        telegramUser);
                    break;

                case "subscription_link":
                    await telegramService.SendSubscriptionLinkAsync(botClient, callbackQuery, cancellationToken);
                    break;

                case "search_list_service":
                    await telegramService.GiveServiceNameForFilterAsync(botClient, callbackQuery, cancellationToken,
                        telegramUser);
                    break;

                case "revoke_subscription":
                    await telegramService.RevokesubscriptionAsync(botClient, callbackQuery, cancellationToken,
                        telegramUser!);
                    break;

                case "delete_service":
                    await telegramService.SendTextDeleteMarzbanUserAsync(botClient, callbackQuery, cancellationToken,
                        telegramUser!);
                    break;

                case "deleted_service":
                    await telegramService.DeletedMarzbanUserServiceByAgentAsync(botClient, callbackQuery,
                        cancellationToken);
                    break;

                case "not_deleted_service":
                    await telegramService.NotDeleteMarzbanUserServiceByAgentAsync(botClient, callbackQuery,
                        cancellationToken);
                    break;

                case "active_service":
                    await telegramService.ActiveMarzbanUserAsync(botClient, callbackQuery, cancellationToken,
                        telegramUser!);
                    break;

                case "disabled_service":
                    await telegramService.DisabledMarzbanUserAsync(botClient, callbackQuery, cancellationToken,
                        telegramUser!);
                    break;

                case "supporting":
                    await telegramService.SendSupportingMenuAsync(botClient, callbackQuery, cancellationToken);
                    break;

                case "default_question":
                    await telegramService.SendDefaultQuestionAsync(botClient, callbackQuery, cancellationToken);
                    break;

                case "send_text_supporting":
                    await telegramService.SendTextForSendMessageSupporting(botClient, callbackQuery, cancellationToken,
                        telegramUser!);
                    break;

                case "wallet":
                    await telegramService.SendUserInformationAsync(botClient, callbackQuery, cancellationToken);
                    break;

                case "inventory_increase":
                    await telegramService.SendTransactionDetailsAsync(botClient, callbackQuery, cancellationToken,
                        telegramUser!);
                    break;

                case "send_transaction_image":
                    await telegramService.GiveTransactionImageAsync(botClient, callbackQuery, cancellationToken,
                        telegramUser!);
                    break;

                case "update_trans":
                    await telegramService.UpdateTransactionStatusAsync(botClient, callbackQuery, cancellationToken);
                    break;

                case "agent_request":
                    await telegramService.SendTextAgentRequest(botClient, callbackQuery, cancellationToken,
                        telegramUser!);
                    break;

                case "accept_agent_request":
                    await telegramService.AcceptAgentRequestAsync(botClient, callbackQuery, cancellationToken,
                        telegramUser!);
                    break;

                case "reject_agent_request":
                    await telegramService.RejectAgentRequestAsync(botClient, callbackQuery, cancellationToken,
                        telegramUser!);
                    break;

                case "invitation_link":
                    await telegramService.SendTelegramInviteLinkAsync(botClient, callbackQuery, cancellationToken);
                    break;

                case "transactions":
                    await telegramService.SendTransactionsAsync(botClient, callbackQuery, cancellationToken,
                        telegramUser!);
                    break;

                case "user_transactions":
                    await telegramService.SendUserTransactionsAsync(botClient, callbackQuery, cancellationToken,
                        telegramUser!);
                    break;

                case "web_information":
                    await telegramService.SendUserForLoginToWebAsync(botClient, callbackQuery, cancellationToken);
                    break;

                case "agency_management":
                    await telegramService.SendMenuAgencyManagementAsync(botClient, callbackQuery, cancellationToken);
                    break;

                case "user_management":
                    await telegramService.ManagementUserAsync(botClient, callbackQuery, cancellationToken,
                        telegramUser!);
                    break;

                case "increase_by_agent":
                    await telegramService.IncreaseUserByAgentAsync(botClient, callbackQuery, cancellationToken,
                        telegramUser!);
                    break;

                case "decrease_by_agent":
                    await telegramService.DecreaseUserByAgentAsync(botClient, callbackQuery, cancellationToken,
                        telegramUser!);
                    break;

                case "blocked_user":
                    await telegramService.BlockUserAsync(botClient, callbackQuery, cancellationToken, telegramUser!);
                    break;

                case "on_blocked_user":
                    await telegramService.OnBlockUserAsync(botClient, callbackQuery, cancellationToken, telegramUser!);
                    break;

                case "send_message_user":
                    await telegramService.SendTextGiveMessageForUserByAgentAsync(botClient, callbackQuery,
                        cancellationToken, telegramUser!);
                    break;

                case "action_card":
                    await telegramService.ChangeStateCardToCardAsync(botClient, callbackQuery, cancellationToken,
                        telegramUser);
                    break;
                
                case "change_agent_percent":
                    await telegramService.SendTextForGiveSpecialPercent(botClient, callbackQuery, cancellationToken,
                        telegramUser);
                    break;
                
                case "added_agent":
                    await telegramService.AddAgentAsync(botClient, callbackQuery, cancellationToken,
                        telegramUser);
                        break;    
                
                case "button":
                    await telegramService.SendMessageAsync(botClient, callbackQuery, cancellationToken,
                        telegramUser);
                    break;
                
                default:
                    break;
            }
        }
        catch (Exception e)
        {
            User? curent_user = await telegramService.GetUserByChatIdAsync(callbackQuery!.Message.Chat.Id);

            switch (e.Message)
            {
                case "موجودی شما کافی نیست":
                    List<InlineKeyboardButton> increase = new()
                    {
                        InlineKeyboardButton.WithCallbackData("\ud83d\udcb0 افزایش موجودی", "inventory_increase")
                    };
                    telegramUser.State = TelegramMarzbanVpnSessionState.None;

                    await botClient.SendTextMessageAsync(
                        chatId: callbackQuery!.Message!.Chat.Id,
                        text: e.Message,
                        replyMarkup: new InlineKeyboardMarkup(increase),
                        cancellationToken: cancellationToken);
                    break;
                default:
                    await botClient.SendTextMessageAsync(callbackQuery!.Message!.Chat.Id, e.Message,
                        cancellationToken: cancellationToken);
                    break;
            }
        }
    }
}
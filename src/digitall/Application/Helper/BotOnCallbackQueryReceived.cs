using Application.Extensions;
using Application.Services.Interface.Notification;
using Application.Services.Interface.Telegram;
using Domain.DTOs.Notification;
using Domain.Entities.Telegram;
using Domain.Enums.Notification;
using Domain.IRepositories.Telegram;
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
        ITelegramUserRepository memoryCache,
        INotificationService notificationService,
        CancellationToken cancellationToken)
    {
        string data = callbackQuery.Data.Split('?')[0];

        var telegramUser = await memoryCache.Get(callbackQuery.Message?.Chat.Id ?? 0) ?? await memoryCache.Update(new TelegramUser()); 
        
        try
        {
            switch (data)
            {
                case "special_bot":
                    await telegramService.RequestForSpecialBotAsync(botClient, callbackQuery, cancellationToken,
                        telegramUser);
                    break;
                
                case "set_branding_name":
                    await telegramService.UpdateAgentBrandingNameAsync(
                        botClient, callbackQuery, cancellationToken, telegramUser);
                    break;

                case "active_wg_service":
                    await telegramService.ActiveWireguardAccountAsync(botClient, callbackQuery, cancellationToken);
                    break;

                case "disabled_wg_service":
                    await telegramService.DisabledWireguardAccountAsync(botClient, callbackQuery, cancellationToken);
                    break;

                case "delete_wg_service":
                    await telegramService.SendTextDeleteWireguardAccountAsync(botClient, callbackQuery,
                        cancellationToken,
                        telegramUser!);
                    break;

                case "peer_file":
                    await telegramService.SendPeerConfigFileAsync(botClient, callbackQuery, cancellationToken);
                    break;

                case "peer_link":
                    await telegramService.SendPeerQrAsync(botClient, callbackQuery, cancellationToken);
                    break;

                case "start":
                    await telegramService.StartedTelegramBotAsync(botClient, callbackQuery.Message, cancellationToken,
                        telegramUser);
                    break;

                case "peer_info":
                    await telegramService.ShowPeerInformation(botClient, callbackQuery, cancellationToken);
                    break;

                case "my_product":
                    await telegramService.SendListMyProductsAsync(botClient, callbackQuery, cancellationToken);
                    break;

                case "my_product_":
                    await telegramService.SendMyProductsAsync(botClient, callbackQuery, cancellationToken);
                    break;

                case "products":
                    await telegramService.SendProductListAsync(botClient, callbackQuery, cancellationToken);
                    break;

                case "product":
                    await telegramService.SendProductTemplatesAsync(botClient, callbackQuery, cancellationToken);
                    break;

                case "list_wireguard_template":
                    await telegramService.SendListWireguardVpnTemplateAsync(botClient, callbackQuery,
                        cancellationToken);
                    break;

                case "send_wireguard_price_template":
                    await telegramService.SendWireguardVpnGbAndPriceAsync(botClient, callbackQuery, cancellationToken);
                    break;

                case "create_test_wireguard":
                    await telegramService.SendWireguardAccountTest(botClient, callbackQuery, cancellationToken,
                        telegramUser!);
                    break;

                case "factor_wireguard_subscribe":
                    await telegramService.SendWireguardServiceFactorVpnAsync(botClient, callbackQuery,
                        cancellationToken, telegramUser!);
                    break;

                case "buy_wireguard_subscribe":
                    await telegramService.SendWireguardSubscriptionAsync(botClient, callbackQuery,
                        cancellationToken, telegramUser!);
                    break;

                case "product_test":
                    await telegramService.SendProductTemplatesHaveTestAsync(botClient, callbackQuery,
                        cancellationToken);
                    break;

                case "back_to_home":
                    await telegramService.SendMainMenuAsync(botClient, callbackQuery, cancellationToken, telegramUser);
                    break;

                case "test_free":
                    await telegramService.SendListProductHaveTestAsync(botClient, callbackQuery, cancellationToken);
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

                case "my_wireguard_services":
                    await telegramService.SendListWireguardServicesAsync(botClient, callbackQuery, cancellationToken);
                    break;

                case "search_list_service":
                    await telegramService.GiveServiceNameForFilterAsync(botClient, callbackQuery, cancellationToken,
                        telegramUser);
                    break;

                case "search_list_wg_service":
                    await telegramService.GiveWireguardServiceNameForFilterAsync(botClient, callbackQuery,
                        cancellationToken,
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

                case "deleted_wg_service":
                    await telegramService.MainDeleteWireguardAccountAsync(botClient, callbackQuery, cancellationToken);
                    break;

                case "not_deleted_wg_service":
                    await telegramService.NotDeleteWireguardAccountAsync(botClient, callbackQuery, cancellationToken);
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

            bool containsEnglishCharacters = e.Message.Any(c => c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z');

            if (e.Message.Trim() == TelegramHelper.SendTextGiveEngilishBrandName.Trim())
            {
                await botClient.SendTextMessageAsync(
                    chatId: callbackQuery!.Message!.Chat.Id,
                    text: e.Message,
                    cancellationToken: cancellationToken);
            }
            else
            {
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
                        telegramUser.State = TelegramMarzbanVpnSessionState.None;
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
                                chatId: callbackQuery!.Message!.Chat.Id,
                                text: userErrorMessage,
                                cancellationToken: cancellationToken);
                        }
                        else
                        {
                            await botClient.SendTextMessageAsync(
                                chatId: callbackQuery!.Message!.Chat.Id,
                                text: e.Message,
                                cancellationToken: cancellationToken);
                        }

                        break;
                }
            }
        }
    }
}
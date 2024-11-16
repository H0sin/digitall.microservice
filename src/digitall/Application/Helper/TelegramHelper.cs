using System.Text.RegularExpressions;
using Application.Extensions;
using Application.Services.Implementation.Telegram;
using Application.Services.Interface.Agent;
using Application.Services.Interface.Telegram;
using Domain.DTOs.Agent;
using Domain.DTOs.Apple;
using Domain.DTOs.Marzban;
using Domain.DTOs.Product;
using Domain.DTOs.Telegram;
using Domain.DTOs.Transaction;
using Domain.DTOs.Wireguard;
using Domain.Entities.Apple;
using Domain.Entities.Telegram;
using Domain.Entities.Transaction;
using Domain.Exceptions;
using SixLabors.ImageSharp.Formats.Qoi;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;
using User = Domain.Entities.Account.User;

namespace Application.Helper;

public class TelegramHelper
{
    #region buttons

    private static InlineKeyboardButton ViewLearnLink(string link) =>
        InlineKeyboardButton.WithUrl("مشاهده اموزش 📖",
            link.TrimEnd());

    public const string AgencyManagementButtonText = "مدیریت پنل نمایندگی ✏️";
    public const string RepresentationStatisticsButtonText = "آمار نمایندگی 📊";
    public const string BackToManagement = "بازگشت به منو قبل ⬅️";
    public const string SendMessageButtonText = "ارسال پیام ✍️";
    public const string SearchUserButtonText = "جستجو کاربر 🔍";
    public const string BackToHomeButtonText = "بازگشت به منو اصلی 🔙";
    public const string ManagementAgentsButtonText = "مدیریت نماینده ها 👥";
    public const string ChangeCardNumberButtonText = "ثبت | تغییر شماره کارت 💳";
    public const string ChangeBrandingNameButtonText = "ثبت | تغییر نام نمایندگی 🔘";
    public const string ShowPaymentInformationeButtonText = "مشاهده اطلاعات پرداخت 💰";
    public const string ChangeAgentPercnteButtonText = "تغییر درصد نماینده ها 💯";
    public const string ChangeUserPercenteButtonText = "تغییر درصد کاربران 💯";
    public const string UserPaymentButtonText = "پرداخت کاربری 💵";
    public const string AgentPaymentButtonText = "پرداخت نمایندگی 💵";
    public const string ForwardMessageButtonText = "فوروارد پیام 🛩";
    public const string CustomMessageButtonText = "ارسال پیام دلخواه 📝";
    public const string ForAgentButtonText = "برای نماینده ها 👤";
    public const string ForAllUserButtonText = "برای همه کاربران 👥";
    public const string BackListTypeOfSendMessageButtonText = "بازگشت به ارسال پیام 📝";
    public const string SendTransactionWaitingMessageButtonText = "تراکنش هایه برسی نشده 💵";
    public const string SendDeleteServiceWaitingMessageButtonText = "سرویس های در صف حذف ❌";

    private static readonly InlineKeyboardMarkup ButtonForMessage = new InlineKeyboardMarkup(new[]
    {
        new InlineKeyboardButton[]
        {
            InlineKeyboardButton.WithCallbackData("شروع ربات 💫", "button?query=start&text=شروع ربات 💫"),
        },
        new InlineKeyboardButton[]
        {
            InlineKeyboardButton.WithCallbackData("پیام بدون دکمه ارسال شود 📭", "button?query=null")
        }
    });

    private static readonly InlineKeyboardButton BackToHome =
        InlineKeyboardButton.WithCallbackData("بازگشت به منو اصلی 🏠", "back_to_home");

    private static readonly InlineKeyboardButton BuyAppleId =
        InlineKeyboardButton.WithCallbackData("خرید اپل آیدی | ارسال اطلاعات 🛒", "buy_appleId");

    private static readonly InlineKeyboardButton TestFree =
        InlineKeyboardButton.WithCallbackData("تست رایگان 😎", "test_free");

    private static readonly InlineKeyboardButton BuySubscribe =
        InlineKeyboardButton.WithCallbackData("خرید اشتراک 🔒", "list_vpn");

    private static readonly InlineKeyboardButton MyServices =
        InlineKeyboardButton.WithCallbackData("محصولات من🎁", "my_product");

    private static readonly InlineKeyboardButton RepresentationRequest =
        InlineKeyboardButton.WithCallbackData("در خواست نمایندگی ♻️", "agent_request");

    private static readonly InlineKeyboardButton Supports =
        InlineKeyboardButton.WithCallbackData("پشتیبانی 👤", "supporting");

    private static readonly InlineKeyboardButton Wallet =
        InlineKeyboardButton.WithCallbackData("کیف پول + شارژ 🏦", "wallet");

    private static readonly InlineKeyboardButton SiteInformation = InlineKeyboardButton.WithCallbackData(
        "کلمه عبور و نام کاربری سایت 🔒", "web_information");

    private static readonly InlineKeyboardButton BuyProduct =
        InlineKeyboardButton.WithCallbackData("خرید محصول 🛒", "products");

    private static readonly InlineKeyboardButton InviteLink =
        InlineKeyboardButton.WithCallbackData("زیر مجموعه گیری 🤝",
            "invitation_link");

    private static readonly InlineKeyboardButton ManagementAgent =
        InlineKeyboardButton.WithCallbackData("مدیریت پنل نمایندگی 🏢",
            "agency_management");

    private static readonly InlineKeyboardButton Transactions = InlineKeyboardButton.WithCallbackData(
        "لیست تراکنش ها 💸",
        $"transactions");

    private static readonly InlineKeyboardButton SpecialBot = InlineKeyboardButton.WithCallbackData(
        "دریافت ربات اختصاصی (رایگان)🤖",
        $"special_bot");

    #region buttons method

    public static InlineKeyboardMarkup TaskAppleIdComplaint()
    {
        IList<List<InlineKeyboardButton>> buttons = new List<List<InlineKeyboardButton>>();

        buttons.Add(CreateList1Button(InlineKeyboardButton.WithCallbackData("🔶برسی شد🔶", "barecy_2")));

        return new InlineKeyboardMarkup(buttons);
    }

    public static InlineKeyboardMarkup AppleIdProblems(long id)
    {
        IList<List<InlineKeyboardButton>> buttons = new List<List<InlineKeyboardButton>>();

        buttons.Add(CreateList2Button(
                InlineKeyboardButton.WithCallbackData("not active", $"accept_warranty?id={id}&p=not_active"),
                InlineKeyboardButton.WithCallbackData("disabled", $"accept_warranty?id={id}&p=disabled")));

        return new InlineKeyboardMarkup(buttons);
    }

    public static InlineKeyboardMarkup ActionSupporterForAppleId(AppleIdDto? appleId)
    {
        IList<List<InlineKeyboardButton>> buttons = new List<List<InlineKeyboardButton>>();

        buttons.Add(CreateList1Button(
            InlineKeyboardButton.WithCallbackData("✅ تایید درخواست", $"accept_warranty?id={appleId.Id}")));

        buttons.Add(CreateList1Button(InlineKeyboardButton.WithCallbackData("🚫 اپل آیدی سالم بود رد درخواست",
            $"reject_b_true?id={appleId.Id}")));

        buttons.Add(CreateList1Button(InlineKeyboardButton.WithCallbackData("🔗 مشخصات تغییر پیدا کرده رد درخواست",
            $"reject_b_change?id={appleId.Id}")));

        return new InlineKeyboardMarkup(buttons);
    }

    public static InlineKeyboardMarkup? AppleIdInformationButton(AppleId appleId, AppleIdType type)
    {
        IList<List<InlineKeyboardButton>> buttons = new List<List<InlineKeyboardButton>>();

        // buttons.Add(CreateList1Button(InlineKeyboardButton.WithCallbackData("مشخصات آپل آیدی اشتباه است 📛", 
        //     $"wrong_appleId_Information?Id={appleId.Id}")));

        if (type.Warranty)
            buttons.Add(CreateList1Button(InlineKeyboardButton.WithCallbackData("گزارش مشکلات - گارانتی",
                $"appleId_warranty?Id={appleId.Id}")));


        buttons.Add(
            CreateList1Button(InlineKeyboardButton.WithCallbackData("بازگشت به لیست اپل آیدی ها", $"list_my_appleId")));
        buttons.Add(CreateList1Button(BackToHome));

        return new InlineKeyboardMarkup(buttons);
    }

    public static InlineKeyboardMarkup CreateListVpnWiregardButton(List<WireguardVpnDto> vpns)
    {
        IList<List<InlineKeyboardButton>> buttons = new List<List<InlineKeyboardButton>>();

        foreach (WireguardVpnDto vpn in vpns)
        {
            buttons.Add(
                CreateList1Button(
                    InlineKeyboardButton.WithCallbackData(vpn?.Name, "create_test_wireguard?id=" + vpn.Id)));
        }

        buttons.Add(CreateList1Button(BackToHome));
        return new InlineKeyboardMarkup(buttons);
    }

    public static InlineKeyboardMarkup? SendListProductsHaveTest(List<ProductDto> products)
    {
        IList<List<InlineKeyboardButton>> buttons = new List<List<InlineKeyboardButton>>();

        foreach (var product in products)
        {
            buttons.Add(CreateList1Button(InlineKeyboardButton.WithCallbackData(product.ProductName,
                $"product_test?category={product.CategoryType}")));
        }

        buttons.Add(CreateList1Button(BackToHome));

        return new InlineKeyboardMarkup(buttons);
    }

    public static InlineKeyboardMarkup CreateWirguardFactorButton(long id, long vpnId, long peerId)
    {
        IList<List<InlineKeyboardButton>> buttons = new List<List<InlineKeyboardButton>>();

        if (peerId != 0)
        {
            buttons.Add(CreateList1Button(InlineKeyboardButton.WithCallbackData("پرداخت و تمدید سرویس 💰",
                $"buy_wireguard_subscribe" +
                $"?templateId={id}" +
                $"&vpnId={vpnId}" +
                $"&peerId={peerId}")));
        }
        else
        {
            buttons.Add(CreateList1Button(InlineKeyboardButton.WithCallbackData("پرداخت و دریافت سرویس 💰",
                $"buy_wireguard_subscribe" +
                $"?templateId={id}" +
                $"&vpnId={vpnId}" +
                $"&peerId={peerId}")));
        }

        buttons.Add(CreateList1Button(BackToHome));

        return new InlineKeyboardMarkup(buttons);
    }

    public static InlineKeyboardMarkup CreateListGbAndPriceButton(List<WireguardVpnTemplatesDto> templates, long days,
        long peerId = 0)
    {
        templates = templates.Where(x => x.Days == days).OrderBy(x => x.Gb).ToList();

        IList<List<InlineKeyboardButton>> buttons = new List<List<InlineKeyboardButton>>();

        foreach (var template in templates)
        {
            buttons.Add(CreateList1Button(InlineKeyboardButton.WithCallbackData(
                $"{template.Gb} گیگ {template.Price:N0} تومان",
                "factor_wireguard_subscribe?id=" + template.Id + "&vpnId=" + template.WireguardVpnId + "&peerId=" +
                peerId)));
        }

        buttons.Add(CreateList1Button(BackToHome));

        return new InlineKeyboardMarkup(buttons);
    }

    public static InlineKeyboardMarkup CreateListVpnButton(List<WireguardVpnDto> vpns)
    {
        IList<List<InlineKeyboardButton>> buttons = new List<List<InlineKeyboardButton>>();

        foreach (WireguardVpnDto vpn in vpns)
        {
            buttons.Add(
                CreateList1Button(
                    InlineKeyboardButton.WithCallbackData(vpn?.Name, "list_wireguard_template?id=" + vpn.Id)));
        }

        buttons.Add(CreateList1Button(BackToHome));
        return new InlineKeyboardMarkup(buttons);
    }

    public static InlineKeyboardMarkup? SendListMyProducts(List<ProductDto> products)
    {
        IList<List<InlineKeyboardButton>> buttons = new List<List<InlineKeyboardButton>>();

        foreach (var product in products)
        {
            buttons.Add(CreateList1Button(InlineKeyboardButton.WithCallbackData(product.ProductName,
                $"my_product_?category={product.CategoryType}")));
        }

        buttons.Add(CreateList1Button(BackToHome));

        return new InlineKeyboardMarkup(buttons);
    }

    public static InlineKeyboardMarkup? SendListProducts(List<ProductDto> products)
    {
        IList<List<InlineKeyboardButton>> buttons = new List<List<InlineKeyboardButton>>();

        foreach (var product in products)
        {
            buttons.Add(CreateList1Button(InlineKeyboardButton.WithCallbackData(product.ProductName,
                $"product?category={product.CategoryType}")));
        }

        buttons.Add(CreateList1Button(BackToHome));

        return new InlineKeyboardMarkup(buttons);
    }

    public static ReplyKeyboardMarkup? CreateListUserGroupingSendMessageButton()
        => new(new[]
        {
            new KeyboardButton[] { ForAgentButtonText, ForAllUserButtonText },
            new KeyboardButton[] { BackListTypeOfSendMessageButtonText },
        })
        {
            ResizeKeyboard = true,
            Selective = true,
            InputFieldPlaceholder = "نوع گروه کاربری را مشخص کنید"
        };

    public static ReplyKeyboardMarkup? CreateListTypeOfSendMessageButton()
        => new(new[]
        {
            new KeyboardButton[] { CustomMessageButtonText, ForwardMessageButtonText },
            new KeyboardButton[] { BackToManagement },
        })
        {
            ResizeKeyboard = true,
            Selective = true,
            InputFieldPlaceholder = "نوع ارسال پیام را مشخص کنید"
        };


    public static ReplyKeyboardMarkup CreateAgentManagementButton()
        => new ReplyKeyboardMarkup(new[]
        {
            new KeyboardButton[] { AgencyManagementButtonText, RepresentationStatisticsButtonText },
            new KeyboardButton[] { SendDeleteServiceWaitingMessageButtonText },
            new KeyboardButton[] { SearchUserButtonText, SendMessageButtonText },
            new KeyboardButton[] { SendTransactionWaitingMessageButtonText },
            new KeyboardButton[] { BackToHomeButtonText },
        })
        {
            ResizeKeyboard = true,
            Selective = true,
            InputFieldPlaceholder = "پنل نمایندگی"
        };

    public static ReplyKeyboardMarkup CreateAgentManagementSettingsButton()
        => new ReplyKeyboardMarkup(new[]
        {
            new KeyboardButton[] { ManagementAgentsButtonText },
            new KeyboardButton[] { ChangeCardNumberButtonText, ChangeBrandingNameButtonText },
            new KeyboardButton[] { ShowPaymentInformationeButtonText },
            new KeyboardButton[] { ChangeUserPercenteButtonText, ChangeAgentPercnteButtonText },
            new KeyboardButton[] { AgentPaymentButtonText, UserPaymentButtonText },
            new KeyboardButton[] { BackToManagement },
            new KeyboardButton[] { BackToHomeButtonText }
        })
        {
            ResizeKeyboard = true,
            InputFieldPlaceholder = "تنظیمات پنل نمایندگی"
        };

    public static InlineKeyboardMarkup ButtonBackToHome()
    {
        IList<List<InlineKeyboardButton>> buttons = new List<List<InlineKeyboardButton>>();
        buttons.Add(CreateList1Button(BackToHome));
        return new InlineKeyboardMarkup(buttons);
    }

    public static InlineKeyboardMarkup ButtonBuyAppleId(long type)
    {
        IList<List<InlineKeyboardButton>> buttons = new List<List<InlineKeyboardButton>>();
        buttons.Add(CreateList1Button(InlineKeyboardButton.WithCallbackData("خرید اپل آیدی | ارسال اطلاعات 🏠",
            $"buy_appleId?type={type}")));
        buttons.Add(CreateList1Button(BackToHome));
        return new InlineKeyboardMarkup(buttons);
    }

    public InlineKeyboardMarkup CreateSeeLearn(string url)
    {
        IList<List<InlineKeyboardButton>> buttons = new List<List<InlineKeyboardButton>>();

        buttons.Add(CreateList1Button(ViewLearnLink(url)));

        return new InlineKeyboardMarkup(buttons);
    }

    public static InlineKeyboardMarkup TransactionButtons(TransactionDto transaction)
    {
        IList<List<InlineKeyboardButton>> buttons = new List<List<InlineKeyboardButton>>();

        buttons.Add(CreateList2Button(
            InlineKeyboardButton.WithCallbackData("رد پرداخت ❌",
                $"update_trans?status=NotAccepted&id={transaction.Id}"),
            InlineKeyboardButton.WithCallbackData("تایید پرداخت ✅",
                $"update_trans?status=Accepted&id={transaction.Id}")));

        return new InlineKeyboardMarkup(buttons);
    }

    public static InlineKeyboardMarkup RepresentationRequestButtons()
    {
        IList<List<InlineKeyboardButton>> buttons = new List<List<InlineKeyboardButton>>();

        buttons.Add(CreateList1Button(RepresentationRequest));

        return new InlineKeyboardMarkup(buttons);
    }

    public static InlineKeyboardMarkup CreateStartMenu(User? user, bool has_bot = false)
    {
        IList<List<InlineKeyboardButton>> buttons = new List<List<InlineKeyboardButton>>();

        buttons.Add(CreateList2Button(TestFree, BuyProduct));
        buttons.Add(CreateList2Button(MyServices, Supports));

        buttons.Add(CreateList1Button(SiteInformation));

        if (user is { IsAgent: true })
        {
            buttons.Add(CreateList2Button(InviteLink, Transactions));
            buttons.Add(CreateList2Button(ManagementAgent, Wallet));
        }
        else
        {
            buttons.Add(CreateList2Button(RepresentationRequest, Wallet));
            buttons.Add(CreateList1Button(Transactions));
        }

        if (!has_bot) buttons.Add(CreateList1Button(SpecialBot));

        return new InlineKeyboardMarkup(buttons);
    }

    public static InlineKeyboardMarkup CreateMainMenu(User user, bool has_bot = false)
    {
        IList<List<InlineKeyboardButton>> buttons = new List<List<InlineKeyboardButton>>();

        buttons.Add(CreateList2Button(TestFree, BuyProduct));
        buttons.Add(CreateList2Button(MyServices, Supports));

        buttons.Add(CreateList1Button(SiteInformation));

        if (user is { IsAgent: true })
        {
            buttons.Add(CreateList2Button(InviteLink, Transactions));
            buttons.Add(CreateList2Button(ManagementAgent, Wallet));
        }
        else
        {
            buttons.Add(CreateList2Button(RepresentationRequest, Wallet));
            buttons.Add(CreateList1Button(Transactions));
        }

        if (!has_bot) buttons.Add(CreateList1Button(SpecialBot));

        return new InlineKeyboardMarkup(buttons);
    }

    public static InlineKeyboardMarkup CreateListButtonsForSendMessage()
        => ButtonForMessage;

    public InlineKeyboardMarkup CreateListVpnButton(List<MarzbanVpnTestDto> vpns)
    {
        IList<List<InlineKeyboardButton>> buttons = new List<List<InlineKeyboardButton>>();

        foreach (MarzbanVpnTestDto vpn in vpns)
        {
            buttons.Add(
                CreateList1Button(
                    InlineKeyboardButton.WithCallbackData(vpn?.Title, "create_test_config?id=" + vpn.Id)));
        }

        buttons.Add(CreateList1Button(BackToHome));
        return new InlineKeyboardMarkup(buttons);
    }

    public InlineKeyboardMarkup CreateListVpnButton(List<MarzbanVpnBotDto> vpns)
    {
        IList<List<InlineKeyboardButton>> buttons = new List<List<InlineKeyboardButton>>();

        foreach (MarzbanVpnBotDto vpn in vpns)
        {
            buttons.Add(
                CreateList1Button(
                    InlineKeyboardButton.WithCallbackData(vpn?.Title, "list_vpn_template?id=" + vpn.Id)));
        }

        buttons.Add(CreateList1Button(BackToHome));
        return new InlineKeyboardMarkup(buttons);
    }

    public static InlineKeyboardMarkup CreateListAppleIdTypeTemplateButton(ICollection<AppleIdType> appleIdTypes)
    {
        IList<List<InlineKeyboardButton>> buttons = new List<List<InlineKeyboardButton>>();
        foreach (var type in appleIdTypes)
        {
            buttons.Add(
                CreateList1Button(InlineKeyboardButton.WithCallbackData($"{type.Title} قیمت {type.Price:N0}",
                    $"factor_appleId?type={type.Id}")));
        }

        buttons.Add(CreateList1Button(BackToHome));

        return new InlineKeyboardMarkup(buttons);
    }

    public static InlineKeyboardMarkup CreateListVpnTemplateButton(List<WireguardVpnTemplatesDto> templates,
        long peerId = 0)
    {
        var groupedTemplates = templates.GroupBy(x => x.Days);

        IList<List<InlineKeyboardButton>> buttons = new List<List<InlineKeyboardButton>>();

        foreach (var group in groupedTemplates)
        {
            var firstTemplate = group.First();

            string text = group.Key switch
            {
                31 => "یک ماه",
                61 => "دو ماه",
                91 => "سه ماه",
                121 => "چهار ماه",
                151 => "پنج ماه",
                181 => "شش ماه",
                211 => "هفت ماه",
                241 => "هشت ماه",
                271 => "نه ماه",
                301 => "ده ماه",
                331 => "یازده ماه",
                361 => "یک سال",
                _ => firstTemplate.Days + " روزه "
            };


            buttons.Add(
                CreateList1Button(
                    InlineKeyboardButton.WithCallbackData(text,
                        $"send_wireguard_price_template" +
                        $"?id={firstTemplate.Id}" +
                        $"&vpnId={firstTemplate.WireguardVpnId}" +
                        $"&peerId={peerId}" +
                        $"&days={firstTemplate.Days}")));
        }

        buttons.Add(CreateList1Button(BackToHome));

        return new InlineKeyboardMarkup(buttons);
    }


    public InlineKeyboardMarkup CreateListVpnTemplateButton(List<MarzbanVpnTemplateDto> templates, long subscribeId = 0)
    {
        var groupedTemplates = templates.GroupBy(x => x.Days);

        IList<List<InlineKeyboardButton>> buttons = new List<List<InlineKeyboardButton>>();

        foreach (var group in groupedTemplates)
        {
            var firstTemplate = group.First();

            string text = group.Key switch
            {
                31 => "یک ماه",
                61 => "دو ماه",
                91 => "سه ماه",
                121 => "چهار ماه",
                151 => "پنج ماه",
                181 => "شش ماه",
                211 => "هفت ماه",
                241 => "هشت ماه",
                271 => "نه ماه",
                301 => "ده ماه",
                331 => "یازده ماه",
                361 => "یک سال",
                _ => firstTemplate.Days + " روزه "
            };


            buttons.Add(
                CreateList1Button(
                    InlineKeyboardButton.WithCallbackData(text,
                        $"sendpricetemplate" +
                        $"?id={firstTemplate.Id}" +
                        $"&vpnId={firstTemplate.MarzbanVpnId}" +
                        $"&subscribeId={subscribeId}" +
                        $"&days={firstTemplate.Days}")));
        }

        buttons.Add(CreateList1Button(BackToHome));

        return new InlineKeyboardMarkup(buttons);
    }

    public InlineKeyboardMarkup CreateListGbAndPriceButton(List<MarzbanVpnTemplateDto> templates, long days,
        long subscribeId = 0)
    {
        templates = templates.Where(x => x.Days == days).OrderBy(x => x.Gb).ToList();

        IList<List<InlineKeyboardButton>> buttons = new List<List<InlineKeyboardButton>>();

        foreach (var template in templates)
        {
            buttons.Add(CreateList1Button(InlineKeyboardButton.WithCallbackData(
                $"{template.Gb} گیگ {template.Price:N0} تومان",
                "factor_subscribe?id=" + template.Id + "&vpnId=" + template.MarzbanVpnId + "&subscribeId=" +
                subscribeId)));
        }

        buttons.Add(CreateList1Button(BackToHome));

        return new InlineKeyboardMarkup(buttons);
    }


    public static IReplyMarkup? MainDeleteServiceButton(long marzbanUserId)
    {
        IList<List<InlineKeyboardButton>> buttons = new List<List<InlineKeyboardButton>>();
        buttons.Add(CreateList2Button(
            InlineKeyboardButton.WithCallbackData("عدم تایید حذف سرویس 🔴", $"not_deleted_service?id={marzbanUserId}"),
            InlineKeyboardButton.WithCallbackData("حذف سرویس 🟢", $"deleted_service?id={marzbanUserId}")));

        return new InlineKeyboardMarkup(buttons);
    }

    public InlineKeyboardMarkup CreateFactorButton(long id, long vpnId, long subscribeId)
    {
        IList<List<InlineKeyboardButton>> buttons = new List<List<InlineKeyboardButton>>();

        buttons.Add(CreateList1Button(InlineKeyboardButton.WithCallbackData("پرداخت و دریافت سرویس 💰",
            $"buy_subscribe" +
            $"?templateId={id}" +
            $"&vpnId={vpnId}" +
            $"&subscribeId={subscribeId}")));
        buttons.Add(CreateList1Button(BackToHome));

        return new InlineKeyboardMarkup(buttons);
    }

    public InlineKeyboardMarkup CreateRenewalButtons(long subscribeId, long vpnId)
    {
        IList<List<InlineKeyboardButton>> buttons = new List<List<InlineKeyboardButton>>();

        buttons.Add(CreateList2Button(
            InlineKeyboardButton.WithCallbackData("بازگشت به لیست سرویس‌ها 🏠", "my_services"),
            InlineKeyboardButton.WithCallbackData("بازگشت به سرویس 🏠",
                $"subscribe_info?id={subscribeId}&vpnId={vpnId}")));

        return new InlineKeyboardMarkup(buttons);
    }

    public static InlineKeyboardMarkup CreateRenewalWireguardButtons(long peerId, long vpnId)
    {
        IList<List<InlineKeyboardButton>> buttons = new List<List<InlineKeyboardButton>>();

        buttons.Add(CreateList2Button(
            InlineKeyboardButton.WithCallbackData("بازگشت به لیست سرویس‌ها 🏠", "my_wireguard_services"),
            InlineKeyboardButton.WithCallbackData("بازگشت به سرویس 🏠",
                $"peer_info?id={peerId}&vpnId={vpnId}")));

        return new InlineKeyboardMarkup(buttons);
    }

    public static InlineKeyboardMarkup CreateListAppleIdServices(FilterAppleId filter, int page)
    {
        IList<List<InlineKeyboardButton>> buttons = new List<List<InlineKeyboardButton>>();

        foreach (var entity in filter.Entities)
        {
            buttons.Add(CreateList1Button(InlineKeyboardButton.WithCallbackData(entity.Email ?? entity.Phone,
                $"appleId_info?id={entity.Id}")));
        }

        if (page != 1)
            buttons.Add(CreateList1Button(InlineKeyboardButton.WithCallbackData("قبلی",
                $"list_my_appleId?page={page - 1}")));

        if (page * filter.TakeEntity < filter.AllEntitiesCount)
            buttons.Add(CreateList1Button(InlineKeyboardButton.WithCallbackData("بعدی",
                $"list_my_appleId?page={page + 1}")));

        buttons.Add(CreateList1Button(
            InlineKeyboardButton.WithCallbackData("جستو جو اپل آیدی \ud83d\udd0d", "search_list_appleId_service")));


        buttons.Add(CreateList1Button(BackToHome));

        return new InlineKeyboardMarkup(buttons);
    }

    public static InlineKeyboardMarkup CreateListServices(FilterPeer filter, int page)
    {
        IList<List<InlineKeyboardButton>> buttons = new List<List<InlineKeyboardButton>>();

        foreach (var entity in filter.Entities)
        {
            buttons.Add(CreateList1Button(InlineKeyboardButton.WithCallbackData(entity.Name ?? "NONAME",
                $"peer_info?id={entity.Id}")));
        }

        if (page != 1)
            buttons.Add(CreateList1Button(InlineKeyboardButton.WithCallbackData("قبلی",
                $"my_wireguard_services?page={page - 1}")));

        if (page * filter.TakeEntity < filter.AllEntitiesCount)
            buttons.Add(CreateList1Button(InlineKeyboardButton.WithCallbackData("بعدی",
                $"my_wireguard_services?page={page + 1}")));

        buttons.Add(CreateList1Button(
            InlineKeyboardButton.WithCallbackData("جستو جو سرویس \ud83d\udd0d", "search_list_wg_service")));

        buttons.Add(CreateList1Button(BackToHome));

        return new InlineKeyboardMarkup(buttons);
    }

    public static InlineKeyboardMarkup CreateListServices(FilterMarzbanUser filter, int page)
    {
        IList<List<InlineKeyboardButton>> buttons = new List<List<InlineKeyboardButton>>();

        foreach (var entity in filter.Entities)
        {
            buttons.Add(CreateList1Button(InlineKeyboardButton.WithCallbackData(entity.Username ?? "NONAME",
                $"subscribe_info?id={entity.Id}&vpnId={entity.MarzbanVpnId}")));
        }

        if (page != 1)
            buttons.Add(CreateList1Button(InlineKeyboardButton.WithCallbackData("قبلی",
                $"my_services?page={page - 1}")));
        if (page * filter.TakeEntity < filter.AllEntitiesCount)
            buttons.Add(CreateList1Button(InlineKeyboardButton.WithCallbackData("بعدی",
                $"my_services?page={page + 1}")));

        buttons.Add(
            CreateList1Button(
                InlineKeyboardButton.WithCallbackData("جستو جو سرویس \ud83d\udd0d", "search_list_service")));

        buttons.Add(CreateList1Button(BackToHome));

        return new InlineKeyboardMarkup(buttons);
    }

    public static InlineKeyboardMarkup SendWireguardServiceInformationButton(long id, long vpnId, string status)
    {
        IList<List<InlineKeyboardButton>> buttons = new List<List<InlineKeyboardButton>>();

        buttons.Add(CreateList2Button(InlineKeyboardButton.WithCallbackData("فایل 📁", $"peer_file?id={id}"),
            InlineKeyboardButton.WithCallbackData("qr(کانفیگ) 🔗", $"peer_link?id={id}")));

        buttons.Add(
            CreateList1Button(InlineKeyboardButton.WithCallbackData("حذف سرویس ❌", $"delete_wg_service?id={id}")));

        buttons.Add(CreateList1Button(InlineKeyboardButton.WithCallbackData("تمدید سرویس 💊",
            $"list_wireguard_template" +
            $"?id={vpnId}&" +
            $"peerId={id}")));

        if (status == "disabled")
            buttons.Add(
                CreateList1Button(InlineKeyboardButton.WithCallbackData("فعال کردن 🤞", $"active_wg_service?id={id}")));
        else
            buttons.Add(
                CreateList1Button(
                    InlineKeyboardButton.WithCallbackData(" غیر فعال کردن ❌", $"disabled_wg_service?id={id}")));

        buttons.Add(CreateList1Button(
            InlineKeyboardButton.WithCallbackData("بازگشت به لیست سرویس‌ها 🏠", "my_wireguard_services")));

        return new InlineKeyboardMarkup(buttons);
    }

    public static InlineKeyboardMarkup SendServiceInformationButton(long id, long vpnId, string status)
    {
        IList<List<InlineKeyboardButton>> buttons = new List<List<InlineKeyboardButton>>();

        buttons.Add(CreateList1Button(InlineKeyboardButton.WithCallbackData("تغییر لینک ⚙️", $"revoke_subscription")));
        buttons.Add(
            CreateList1Button(InlineKeyboardButton.WithCallbackData("لینک اشتراک 🔗", $"subscription_link?id={id}")));
        buttons.Add(CreateList1Button(InlineKeyboardButton.WithCallbackData("حذف سرویس ❌", $"delete_service?id={id}")));
        buttons.Add(CreateList1Button(InlineKeyboardButton.WithCallbackData("تمدید سرویس 💊", $"list_vpn_template" +
            $"?id={vpnId}&" +
            $"subscribeId={id}")));
        if (status == "disabled")
            buttons.Add(
                CreateList1Button(InlineKeyboardButton.WithCallbackData("فعال کردن 🤞", $"active_service?id={id}")));
        else
            buttons.Add(
                CreateList1Button(
                    InlineKeyboardButton.WithCallbackData(" غیر فعال کردن ❌", $"disabled_service?id={id}")));

        buttons.Add(
            CreateList1Button(InlineKeyboardButton.WithCallbackData("بازگشت به لیست سرویس‌ها 🏠", "my_services")));

        return new InlineKeyboardMarkup(buttons);
    }

    public static InlineKeyboardMarkup SupportingMenuButton()
    {
        IList<List<InlineKeyboardButton>> buttons = new List<List<InlineKeyboardButton>>();

        buttons.Add(CreateList2Button(
            InlineKeyboardButton.WithCallbackData("ارسال پیام به پشتیبانی ✉️", "send_text_supporting"),
            InlineKeyboardButton.WithCallbackData("سوالات متداول ❓", "default_question")));

        buttons.Add(CreateList1Button(BackToHome));

        return new InlineKeyboardMarkup(buttons);
    }

    public static InlineKeyboardMarkup? ButtonForSendToWarranty(long id)
    {
        IList<List<InlineKeyboardButton>> buttons = new List<List<InlineKeyboardButton>>();

        buttons.Add(CreateList1Button(
            InlineKeyboardButton.WithCallbackData("با شرایط مواقفم | تایید ✅", $"accept_send_wa?id={id}")));

        buttons.Add(
            CreateList1Button(InlineKeyboardButton.WithCallbackData("بازگشت به سرویس", $"appleId_info?id={id}")));

        buttons.Add(CreateList1Button(BackToHome));

        return new InlineKeyboardMarkup(buttons);
    }

    public static InlineKeyboardMarkup Back(string callbackQuery)
    {
        IList<List<InlineKeyboardButton>> buttons = new List<List<InlineKeyboardButton>>();

        buttons.Add(CreateList1Button(InlineKeyboardButton.WithCallbackData("بازگشت 🌍", callbackQuery)));

        return new InlineKeyboardMarkup(buttons);
    }

    public static InlineKeyboardMarkup IncreaseBalance()
    {
        IList<List<InlineKeyboardButton>> buttons = new List<List<InlineKeyboardButton>>();

        buttons.Add(CreateList1Button(InlineKeyboardButton.WithCallbackData("افزایش موجودی 💵", "inventory_increase")));

        return new InlineKeyboardMarkup(buttons);
    }

    public static InlineKeyboardMarkup UserInformationButtons()
    {
        IList<List<InlineKeyboardButton>> buttons = new List<List<InlineKeyboardButton>>();

        buttons.Add(CreateList2Button(
            InlineKeyboardButton.WithCallbackData("افزایش موجودی 💵", "inventory_increase"), BackToHome));

        return new InlineKeyboardMarkup(buttons);
    }

    public static InlineKeyboardMarkup NoBalanceForAgentRequestButton()
    {
        IList<List<InlineKeyboardButton>> buttons = new List<List<InlineKeyboardButton>>();

        buttons.Add(CreateList2Button(
            InlineKeyboardButton.WithCallbackData("افزایش موجودی 💵", "inventory_increase"), Supports));

        buttons.Add(CreateList1Button(BackToHome));

        return new InlineKeyboardMarkup(buttons);
    }

    public static InlineKeyboardMarkup SendTransactionImageButton()
    {
        IList<List<InlineKeyboardButton>> buttons = new List<List<InlineKeyboardButton>>();
        buttons.Add(CreateList1Button(
            InlineKeyboardButton.WithCallbackData("✅ پرداخت کردم  | ارسال رسید", "send_transaction_image")));
        buttons.Add(CreateList1Button(BackToHome));

        return new InlineKeyboardMarkup(buttons);
    }


    public static InlineKeyboardMarkup ListAgents(List<AgentDto> enitities)
    {
        IList<List<InlineKeyboardButton>> buttons = new List<List<InlineKeyboardButton>>();

        buttons.Add(CreateList3Button(
            InlineKeyboardButton.WithCallbackData("نام نماینده"),
            InlineKeyboardButton.WithCallbackData("نام نمایندگی"),
            InlineKeyboardButton.WithCallbackData("آیدی عددی کاربر"))
        );

        foreach (var agent in enitities)
        {
            string? name = (!string.IsNullOrEmpty(agent?.PersianBrandName)
                ? agent.PersianBrandName
                : (!string.IsNullOrEmpty(agent?.BrandName) ? agent?.BrandName : "نام ثبت نشده"));

            buttons.Add(CreateList3Button(
                InlineKeyboardButton.WithCallbackData(agent?.User?.UserFullName() ?? "**",
                    $"user_management?id={agent?.User?.Id}"),
                InlineKeyboardButton.WithCallbackData(name, $"user_management?id={agent?.User!.Id}"),
                InlineKeyboardButton.WithCallbackData(agent?.User?.ChatId.ToString() ?? "NO CHAT ID",
                    $"user_management?id={agent?.User?.Id}"))
            );
        }

        return new InlineKeyboardMarkup(buttons);
    }

    public static InlineKeyboardMarkup? ManagementUserButtons(User? currentUser, bool accessToAmountNegative = false)
    {
        IList<List<InlineKeyboardButton>> buttons = new List<List<InlineKeyboardButton>>();

        if (accessToAmountNegative)
            buttons.Add(CreateList1Button(InlineKeyboardButton.WithCallbackData(
                "💲تغییر سقف خرید منفی نماینده ➖",
                $"change_amount_negative?id={currentUser.Id}")));

        buttons.Add(CreateList2Button(
            InlineKeyboardButton.WithCallbackData("افزایش موجودی ➕", $"increase_by_agent?id={currentUser.Id}"),
            InlineKeyboardButton.WithCallbackData("کاهش موجودی ➖", $"decrease_by_agent?id={currentUser.Id}")));

        if (currentUser.IsBlocked)
            buttons.Add(CreateList1Button(InlineKeyboardButton.WithCallbackData("رفع مسدودی کاربر ✅",
                $"on_blocked_user?id={currentUser.Id}")));
        else
            buttons.Add(CreateList1Button(InlineKeyboardButton.WithCallbackData("مسدود کردن کاربر ❌",
                $"blocked_user?id={currentUser.Id}")));

        buttons.Add(CreateList2Button(
            InlineKeyboardButton.WithCallbackData("ارسال پیام 📝", $"send_message_user?id={currentUser.Id}"),
            InlineKeyboardButton.WithCallbackData("لیست تراکنش ها 💸", $"user_transactions?id={currentUser.Id}")));

        if (currentUser.CardToCardPayment)
            buttons.Add(CreateList1Button(InlineKeyboardButton.WithCallbackData("غیر فعال کردن شماره کارت 🔴",
                $"action_card?id={currentUser.Id}&action={false}")));
        else
            buttons.Add(CreateList1Button(InlineKeyboardButton.WithCallbackData("فعال کردن شماره کارت 🟢",
                $"action_card?id={currentUser.Id}&action={true}")));

        if (currentUser.IsAgent)
        {
            buttons.Add(CreateList1Button(InlineKeyboardButton.WithCallbackData("تغییر در صد نماینده  📉",
                $"change_agent_percent?id={currentUser!.Id}")));
        }
        else
        {
            buttons.Add(CreateList1Button(InlineKeyboardButton.WithCallbackData("نماینده کردن 💎",
                $"added_agent?id={currentUser.Id}")));
        }

        buttons.Add(CreateList1Button(BackToHome));

        return new InlineKeyboardMarkup(buttons);
    }

    private static List<InlineKeyboardButton> CreateList1Button(InlineKeyboardButton button)
        => new List<InlineKeyboardButton>()
        {
            button
        };

    private static List<InlineKeyboardButton> CreateList2Button(InlineKeyboardButton button_1,
        InlineKeyboardButton button_2)
        => new List<InlineKeyboardButton>()
        {
            button_1,
            button_2,
        };

    private static List<InlineKeyboardButton> CreateList3Button(InlineKeyboardButton button_1,
        InlineKeyboardButton button_2, InlineKeyboardButton button_3)
        => new List<InlineKeyboardButton>()
        {
            button_1,
            button_2,
            button_3
        };

    #endregion

    #endregion

    #region message

    #region default message

    /// <summary>
    /// when send default message async
    /// </summary>
    /// <returns></returns>
    private static string Default_Message(string? username, string? chaneladdress) => $"""
         سلام خوش اومدی 👋🏻

         🕖ساعت پاسخ گویی پشتیبانی☎️
         🟢 9 تا 12 شب

         آیا میدونستی؟😁

         ✅باورت میشه با گرفتن نمایندگی قیمت هر گیگ کانفیگ تانل شده 800 تومان و مستقیم 300 تومان براتون محاسبه میشه!!!

         ✅خرید تعداد بالا با یک کلیک برات فعال میشه!

         همین الان از تو ربات با یه کلیک بگیرش که از دست ندی😉
         (از درخواست نمایندگی استفاده کن)

         👨🏻‍💻Sup: @{username ?? "NO_USERNAME"}
         """;

    #endregion

    public static string? WelcomeMessage(string? message, string? username = null, string? chaneladdress = null) =>
        message ?? Default_Message(username, null);

    public static string BackToHomeMessage => "به منو اصلی برگشتید 🏠";

    public static string ListServicesMessage => """
                                                اشتراک های خریداری شده توسط شما 🛍
                                                برای مشاهده اطلاعات و مدیریت روی نام کاربری کلیک کنید⚠️
                                                """;

    public static string DeleteServiceText => """
                                              ❌❌ لطفا درخواست خود را
                                              برای حذف سرویس ارسال کنید ❌❌
                                              """;

    public static string SuccessMessage => """
                                               درخواست شما با موفقیت ثبت شد
                                               منتظر برسی کار پشتیبان باشید ✅
                                           """;

    public static string SupportingMenuText => """
                                               ☎️  در دکمه زیر ( سوالات متداول ) سوالات پرتکرار شما آمده است
                                                روی دکمه زیر کلیک کنید در صورت نیافتن سوال خود روی دکمه پشتیبانی کلیک کنید
                                               """;

    public static string DefaultQuestionText => """
                                                💡 سوالات متداول ⁉️
                                                
                                                           1️⃣ فیلترشکن شما آیپی ثابته؟ میتونم برای صرافی های ارز دیجیتال استفاده کنم؟
                                                
                                                           ✅ به دلیل وضعیت نت و محدودیت های کشور سرویس ما مناسب ترید نیست و فقط لوکیشن‌ ثابته.
                                                
                                                           2️⃣ اگه قبل از منقضی شدن اکانت، تمدیدش کنم روزهای باقی مانده می سوزد؟
                                                
                                                           ✅ خیر، روزهای باقیمونده اکانت موقع تمدید حساب میشن و اگه مثلا 5 روز قبل از منقضی شدن اکانت 1 ماهه خودتون اون رو تمدید کنید 5 روز باقیمونده + 30 روز تمدید میشه.
                                                
                                                           3️⃣ اگه به یک اکانت بیشتر از حد مجاز متصل شیم چه اتفاقی میافته؟
                                                
                                                           ✅ در این صورت حجم سرویس شما زود تمام خواهد شد.
                                                
                                                           4️⃣ فیلترشکن شما از چه نوعیه؟
                                                
                                                           ✅ فیلترشکن های ما v2ray است و پروتکل‌های مختلفی رو ساپورت میکنیم تا حتی تو دورانی که اینترنت اختلال داره بدون مشکل و افت سرعت بتونید از سرویستون استفاده کنید.
                                                
                                                           5️⃣ فیلترشکن از کدوم کشور است؟
                                                
                                                           ✅ سرور فیلترشکن ما از کشور  آلمان است
                                                
                                                           6️⃣ چطور باید از این فیلترشکن استفاده کنم؟
                                                
                                                           ✅ برای آموزش استفاده از برنامه، روی دکمه «📚 آموزش» بزنید.
                                                
                                                           7️⃣ فیلترشکن وصل نمیشه، چیکار کنم؟
                                                
                                                           ✅ به همراه یک عکس از پیغام خطایی که میگیرید به پشتیبانی مراجعه کنید.
                                                
                                                           8️⃣ فیلترشکن شما تضمینی هست که همیشه مواقع متصل بشه؟
                                                
                                                           ✅ به دلیل قابل پیش‌بینی نبودن وضعیت نت کشور، امکان دادن تضمین نیست فقط می‌تونیم تضمین کنیم که تمام تلاشمون رو برای ارائه سرویس هر چه بهتر انجام بدیم.
                                                
                                                           9️⃣ امکان بازگشت وجه دارید؟
                                                
                                                           ✅ امکان بازگشت وجه در صورت حل نشدن مشکل از سمت ما وجود دارد.
                                                
                                                           💡 در صورتی که جواب سوالتون رو نگرفتید میتونید به «پشتیبانی» مراجعه کنید.
                                                """;

    public static string SendTextGiveEngilishBrandName => """
                                                          ⚠️ خطا در نام نمایندگی!

                                                          ❌ نامی که وارد کرده‌اید معتبر نیست. لطفاً دوباره تلاش کنید و شرایط زیر را رعایت کنید:

                                                          نام نمایندگی باید فقط حروف و اعداد انگلیسی باشد.
                                                          بدون کاراکترهای اضافی مانند @، فاصله یا خط تیره باشد.
                                                          حداکثر ۹ حرف باشد.
                                                          ✅ مثال‌های صحیح: john45 | sara | team1_xyz
                                                          ❌ مثال‌های نادرست: reza | user@ | farhad | علی

                                                          لطفاً نام جدید را دوباره وارد کنید.
                                                          """;

    public static string SuccessTransactionText(long price) => $"""
                                                                 رسید پرداخت شما ارسال شد
                                                                 پس از تایید توسط پشتیبانی
                                                                 مبلغ{price:N0} به کیف پول شما واریز خواهد شد 🚀
                                                                 از صبر و شکیبایی شما سپاس گذاریم
                                                                """;

    public static string SendRevokeSubscribetion(string link) => $"""
                                                                  ✅ کانفیگ شما با موفقیت بروزرسانی گردید
                                                                  اشتراک شما :
                                                                  `\{link}`
                                                                  """;

    public static string SendUserInformation(User? user) => $"""
                                                             🗂 اطلاعات حساب کاربری شما :

                                                             👤 نام: {user.TelegramUsername ?? "NOT_USERNAME"}
                                                             📱 شماره تماس : {user.Mobile ?? "ثبت نشده "}
                                                             ⌚️زمان ثبت نام : {PersianDateTimeHelper.GetPersianDateTime(user.CreateDate)}
                                                             💡 شناسه کاربری: {user.ChatId}
                                                             💰 موجودی: {user.Balance:N0} تومان
                                                             📆 {PersianDateTimeHelper.GetPersianDateTime(DateTime.Now)}
                                                             """;

    public static string TextAgentPaymentOption(TransactionDetailDto? transactionDetail) =>
        "💰 سقف پرداخت: " + transactionDetail?.MaximumAmountForAgent.ToString("N0") + " تومان\n" +
        "💵 کف پرداخت: " + transactionDetail?.MinimalAmountForAgent.ToString("N0") + " تومان\n" +
        "📤 لطفاً سقف پرداخت نماینده را ارسال کنید";

    public static string TextUserPaymentOption(TransactionDetailDto? transactionDetail) =>
        "💰 سقف پرداخت: " + transactionDetail?.MaximumAmountForUser.ToString("N0") + " تومان\n" +
        "💵 کف پرداخت: " + transactionDetail?.MinimalAmountForUser.ToString("N0") + " تومان\n" +
        "📤 لطفاً سقف پرداخت کاربر را ارسال کنید";


    public static string TransactionDeatilText(TransactionDetailDto transactionDetail) =>
        $"💳 شماره کارت: {transactionDetail.CardNumber ?? "ثبت نشده"} \n" +
        $"👤 نام صاحب کارت: {transactionDetail.CardHolderName ?? "ثبت نشده"}\n" +
        $"📈 درصد سود پیش‌ فرض از کاربر عادی: {transactionDetail.UserPercent}\n" +
        $"📊 درصد سود پیش‌ فرض از نماینده: {transactionDetail.AgentPercent}\n" +
        $"💰 سقف پرداخت نماینده: {transactionDetail.MaximumAmountForAgent:N0}\n" +
        $"💵 کف پرداخت نماینده: {transactionDetail.MinimalAmountForAgent:N0}\n" +
        $"💰 سقف پرداخت کاربر: {transactionDetail.MaximumAmountForUser:N0}\n" +
        $"💵 کف پرداخت کاربر: {transactionDetail.MinimalAmountForUser:N0}\n";

    public static string SendPriceTransactionText(User user, TransactionDetailDto transactionDetail)
    {
        if (user.IsAgent)
        {
            long max = user.Balance < 0
                ? transactionDetail.MaximumAmountForAgent + (-user.Balance)
                : transactionDetail.MaximumAmountForAgent;
            long min = user.Balance < 0
                ? transactionDetail.MinimalAmountForAgent + (-user.Balance)
                : transactionDetail.MinimalAmountForAgent;

            return $"""
                    💸 مبلغ را به تومان وارد کنید:
                    حداقل مبلغ {min:N0} حداکثر مبلغ {max:N0} تومان می باشد ✅
                    """;
        }

        return $"""
                💸 مبلغ را به تومان وارد کنید:
                حداقل مبلغ {transactionDetail.MinimalAmountForUser:N0} حداکثر مبلغ {transactionDetail.MaximumAmountForUser:N0} تومان می باشد ✅
                """;
    }


    public static string SendTextCardNumber(TransactionDetailDto transactionDetail, long price) => $"""
           برای افزایش موجودی مبلغ {price:N0}  تومان  را به شماره‌ی حساب زیر واریز کنید 👇🏻
                 
                 ====================
                 {transactionDetail.CardNumber}
                 {transactionDetail.CardHolderName}
                 ====================

         ‼️مبلغ باید همان مبلغی که در بالا ذکر شده واریز نمایید.
         ‼️امکان برداشت وجه از کیف پول نیست.
         ‼️مسئولیت واریز اشتباهی با شماست.
         🔝بعد از پرداخت  دکمه پرداخت کردم را زده سپس تصویر رسید را ارسال نمایید
         💵بعد از تایید پرداختتون توسط ادمین کیف پول شما شارژ خواهد شد و در صورتی که سفارشی داشته باشین انجام خواهد شد
         """;

    public static string InviteText(TelegramLinkDto link, string username) => $"""
                                                                               با استفاده از لینک میتونید از دعوت دوستان خودتون به ربات کسب درآمد کنید

                                                                               👇👇👇👇👇👇👇👇👇👇
                                                                               👇👇👇👇👇👇👇👇👇👇
                                                                               👇👇👇👇👇👇👇👇👇👇

                                                                               {link.GenerateLink(username)}
                                                                               """;

    public static string SiteInformationText(long chatId, string password) => $"""
                                                                               👤 نام کاربری شما :{chatId}
                                                                               🔐 کلمه عبور جدید: {password}
                                                                               """;

    public static string ActiveBotText = """
                                           🎉 ربات اختصاصی شما با موفقیت ساخته شد! از این به بعد می‌توانید از امکانات ویژه ربات اختصاصی خود استفاده کنید.
                                             
                                         1. پیام‌های خرید و تمدید سفارش‌ها مستقیماً از طریق ربات اختصاصی شما ارسال خواهند شد.
                                         2. شما می‌توانید به راحتی با مشتریان خود در ارتباط باشید و تمامی اطلاع‌رسانی‌ها را از طریق ربات خود انجام دهید.

                                         ✨ حالا ربات شما آماده استفاده است و می‌توانید از تمامی امکانات آن بهره ببرید. اگر سوالی دارید یا به مشکلی برخوردید، تیم پشتیبانی ما همیشه در کنار شماست! 😊
                                         """;

    public static string ChangeCardToCardText(bool action) => action switch
    {
        true => "شماره کارت برای این کاربر قابل رویت شد ✅",
        _ => "شماره کارت برای این کاربر پنهان شد ❌"
    };

//     public static string BrandingInformationText(AgentInformationDto? agentInformation) =>
//         $"""
//                 🔘 نام فعلی فارسی نمایندگی : {agentInformation.PersianBrandName ?? "ثبت نشده است"}
//                  🔘 نام فعلی انگیلیسی نمایندگی :{agentInformation.BrandName ?? "ثبت نشده است"}
//                  🔘 لطفا نام فارسی نمایندگی را ارسال کنید!
//          """;

    public static string BrandingInformationText(AgentInformationDto? agentInformation) =>
        $"""
         🔘 نام فعلی نمایندگی (انگلیسی): {agentInformation.BrandName}


         ⚠️ لطفاً نام نمایندگی خود را به زبان انگلیسی وارد کنید.
         ⚠️ توجه: نام نمایندگی باید شرایط زیر را داشته باشد:

         حداکثر ۹ حرف باشد.
         بدون کاراکترهای اضافی مانند @، فاصله یا خط تیره باشد.
         فقط به زبان انگلیسی باشد.
         ✅ مثال‌های صحیح: john45 | sara | team1_xyz
         ❌ مثال‌های نادرست: reza | user@ | farhad | علی

         🔘 لطفاً نام جدید نمایندگی خود را وارد کنید!
         """;

    #endregion

    #region telegram user state

    /// <summary>
    /// send message for state
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="telegramService"></param>
    /// <param name="message"></param>
    /// <param name="telegramUser"></param>
    /// <param name="user"></param>
    /// <param name="cancellationToken"></param>
    public static async Task MessageBasedOnStatus(
        ITelegramBotClient? botClient,
        ITelegramService telegramService,
        Message message, TelegramUser telegramUser,
        User? user = null, CancellationToken cancellationToken = default)
    {
        CallbackQuery callbackQuery;

        switch (telegramUser.State)
        {
            #region awaiting send service name

            case TelegramMarzbanVpnSessionState.AwaitingSendAppleIdServiceEmail:

                callbackQuery = new CallbackQuery()
                {
                    Message = message,
                    From = await botClient!.GetMeAsync(cancellationToken: cancellationToken),
                    Data = $"list_my_appleId?email={message.Text}",
                };

                await telegramService.SendListAppleIdServiceAsync(botClient, callbackQuery, cancellationToken);

                telegramUser.State = TelegramMarzbanVpnSessionState.None;
                break;

            case TelegramMarzbanVpnSessionState.AwaitingSendAmountNegative:

                callbackQuery = new CallbackQuery()
                {
                    Message = message,
                    From = await botClient!.GetMeAsync(cancellationToken: cancellationToken),
                    Data = $"change_amount_negative?id={telegramUser.Id}",
                };

                await telegramService.ChangeAgentAmountNegative(botClient, callbackQuery, cancellationToken,
                    telegramUser);

                break;

            case TelegramMarzbanVpnSessionState.AwaitingSendTelegramBotToken:

                callbackQuery = new CallbackQuery()
                {
                    Message = message,
                    From = await botClient!.GetMeAsync(cancellationToken: cancellationToken),
                    Data = $"active_telegram_bot",
                };

                await telegramService.ActiveTelegramBotAsync(botClient!, callbackQuery,
                    cancellationToken, telegramUser);
                break;

            case TelegramMarzbanVpnSessionState.AwaitingSendListButtons:
                callbackQuery = new CallbackQuery()
                {
                    Message = message,
                    From = await botClient!.GetMeAsync(cancellationToken: cancellationToken),
                    Data = $"list_buttons_send",
                };

                await telegramService.SendListButtonsForSendMessage(botClient!, callbackQuery,
                    cancellationToken, telegramUser);

                break;
            case TelegramMarzbanVpnSessionState.AwaitingForwardMessage:
                callbackQuery = new CallbackQuery()
                {
                    Message = message,
                    From = await botClient!.GetMeAsync(cancellationToken: cancellationToken),
                    Data = $"forward_message",
                };

                await telegramService.ForwardMessageForUserAsync(botClient!, callbackQuery,
                    cancellationToken, telegramUser);

                break;

            case TelegramMarzbanVpnSessionState.AwaitingSearchUserByChatId:

                Int64.TryParse(message.Text, out var chatId);
                if (chatId == 0 || chatId <= 0)
                {
                    await botClient!.SendTextMessageAsync(
                        chatId: message!.Chat.Id,
                        text: """
                              لطفا فرمت درست را ارسال کنید.
                              """,
                        cancellationToken: cancellationToken);
                    break;
                }

                User? currentUser = await telegramService.GetUserByChatIdAsync(chatId);

                callbackQuery = new CallbackQuery()
                {
                    Message = message,
                    From = await botClient!.GetMeAsync(cancellationToken: cancellationToken),
                    Data = $"user_management?id={currentUser?.Id ?? 0}",
                };

                await telegramService.ManagementUserAsync(botClient!, callbackQuery,
                    cancellationToken, telegramUser);

                break;

            case TelegramMarzbanVpnSessionState.AwaitingSendMinimalAmountForUser:
                callbackQuery = new CallbackQuery()
                {
                    Message = message,
                    From = await botClient!.GetMeAsync(cancellationToken: cancellationToken),
                    Data = "set_payment_user",
                };
                await telegramService.SetPaymentOptionForUserAsync(botClient!, callbackQuery, cancellationToken,
                    telegramUser);
                break;

            case TelegramMarzbanVpnSessionState.AwaitingSendMinimalAmountForAgent:
                callbackQuery = new CallbackQuery()
                {
                    Message = message,
                    From = await botClient!.GetMeAsync(cancellationToken: cancellationToken),
                    Data = "set_payment_agent",
                };
                await telegramService.SetPaymentOptionForAgentAsync(botClient!, callbackQuery, cancellationToken,
                    telegramUser);
                break;

            case TelegramMarzbanVpnSessionState.AwaitingSendMaximumAmountForUser:
                callbackQuery = new CallbackQuery()
                {
                    Message = message,
                    From = await botClient!.GetMeAsync(cancellationToken: cancellationToken),
                    Data = "give_min_payment_user",
                };
                await telegramService.GiveMaximumPaymentForUser(botClient!, callbackQuery, cancellationToken,
                    telegramUser);
                break;

            case TelegramMarzbanVpnSessionState.AwaitingSendMaximumAmountForAgent:
                callbackQuery = new CallbackQuery()
                {
                    Message = message,
                    From = await botClient!.GetMeAsync(cancellationToken: cancellationToken),
                    Data = "give_min_payment_agent",
                };
                await telegramService.GiveMaximumPaymentForAgent(botClient!, callbackQuery, cancellationToken,
                    telegramUser);
                break;

            case TelegramMarzbanVpnSessionState.AwaitingSendAgentPercent:
                callbackQuery = new CallbackQuery()
                {
                    Message = message,
                    From = await botClient!.GetMeAsync(cancellationToken: cancellationToken),
                    Data = "change_agent_percent",
                };

                await telegramService.UpdateAgentPercentAsync(botClient!, callbackQuery, cancellationToken,
                    telegramUser);
                break;

            case TelegramMarzbanVpnSessionState.AwaitingSendUserPercent:
                callbackQuery = new CallbackQuery()
                {
                    Message = message,
                    From = await botClient!.GetMeAsync(cancellationToken: cancellationToken),
                    Data = "change_agent_percent",
                };

                await telegramService.UpdateUserPercentAsync(botClient!, callbackQuery, cancellationToken,
                    telegramUser);
                break;

            case TelegramMarzbanVpnSessionState.AwaitingSendServiceName:

                callbackQuery = new CallbackQuery()
                {
                    Message = message,
                    From = await botClient!.GetMeAsync(cancellationToken: cancellationToken),
                    Data = "my_services",
                };

                await telegramService.SendListServicesAsync(botClient!, callbackQuery, cancellationToken,
                    message.Text);

                telegramUser.State = TelegramMarzbanVpnSessionState.None;
                break;

            case TelegramMarzbanVpnSessionState.AwaitingSendWireguardServiceName:
                callbackQuery = new CallbackQuery()
                {
                    Message = message,
                    From = await botClient!.GetMeAsync(cancellationToken: cancellationToken),
                    Data = "my_services",
                };

                await telegramService.SendListWireguardServicesAsync(botClient, callbackQuery, cancellationToken,
                    message.Text);

                telegramUser.State = TelegramMarzbanVpnSessionState.None;
                break;

            case TelegramMarzbanVpnSessionState.AwaitingSendDescriptionForDeleteMarzbanUser:

                callbackQuery = new CallbackQuery()
                {
                    Message = message,
                    From = await botClient!.GetMeAsync(cancellationToken: cancellationToken),
                    Data = "delete_service",
                };

                await telegramService.DeleteMarzbanUserAsync(botClient, callbackQuery, cancellationToken, telegramUser);
                break;

            case TelegramMarzbanVpnSessionState.AwaitingSendDescriptionForDeleteWireguardAccount:
                callbackQuery = new CallbackQuery()
                {
                    Message = message,
                    From = await botClient!.GetMeAsync(cancellationToken: cancellationToken),
                    Data = "delete_wg_service",
                };

                await telegramService.DeleteWireguardAccountAsync(botClient, callbackQuery, cancellationToken,
                    telegramUser);
                break;

            case TelegramMarzbanVpnSessionState.AwaitingSendTicketMessage:

                callbackQuery = new CallbackQuery()
                {
                    Message = message,
                    From = await botClient!.GetMeAsync(cancellationToken: cancellationToken),
                    Data = "send_message",
                };

                await telegramService.SendMessageForSupporting(botClient, callbackQuery, cancellationToken,
                    telegramUser);
                break;

            case TelegramMarzbanVpnSessionState.AwaitingSendPrice:

                callbackQuery = new CallbackQuery()
                {
                    Message = message,
                    From = await botClient!.GetMeAsync(cancellationToken: cancellationToken),
                    Data = "send_card_detail",
                };

                await telegramService.SendCardNumberAndDetailAsync(botClient, callbackQuery, cancellationToken,
                    telegramUser);
                break;

            case TelegramMarzbanVpnSessionState.AwaitingSendTransactionImage:
                callbackQuery = new CallbackQuery()
                {
                    Message = message,
                    From = await botClient!.GetMeAsync(cancellationToken: cancellationToken),
                    Data = "add_transaction",
                };

                await telegramService.AddTransactionAsync(botClient, callbackQuery, cancellationToken, telegramUser);
                break;

            case TelegramMarzbanVpnSessionState.AwaitingSendPhone:
                callbackQuery = new CallbackQuery()
                {
                    Message = message,
                    From = await botClient!.GetMeAsync(cancellationToken: cancellationToken),
                    Data = "add_transaction",
                };

                await telegramService.SendDescriptionTextForAddedAgent(botClient, callbackQuery, cancellationToken,
                    telegramUser);
                break;

            case TelegramMarzbanVpnSessionState.AwaitingSendDescriptionForAddAgentRequest:
                callbackQuery = new CallbackQuery()
                {
                    Message = message,
                    From = await botClient!.GetMeAsync(cancellationToken: cancellationToken),
                    Data = "add_request_agent",
                };
                await telegramService.RequestForAgentAsync(botClient, callbackQuery, cancellationToken, telegramUser);
                break;

            case TelegramMarzbanVpnSessionState.AwaitingSendPriceForIncrease:
                callbackQuery = new CallbackQuery()
                {
                    Message = message,
                    From = await botClient!.GetMeAsync(cancellationToken: cancellationToken),
                    Data = "increase_user_balance",
                };
                await telegramService.GiveDescriptionForIncreaseTransactionAsync(botClient, callbackQuery,
                    cancellationToken, telegramUser);

                break;

            case TelegramMarzbanVpnSessionState.AwaitingSendDescriptionForIncrease:
                callbackQuery = new CallbackQuery()
                {
                    Message = message,
                    From = await botClient!.GetMeAsync(cancellationToken: cancellationToken),
                    Data = "increase_user_balance",
                };

                await telegramService.IncreaseUserBalanceAsync(botClient, callbackQuery,
                    cancellationToken, telegramUser!);
                break;

            case TelegramMarzbanVpnSessionState.AwaitingSendPriceForDecrease:
                callbackQuery = new CallbackQuery()
                {
                    Message = message,
                    From = await botClient!.GetMeAsync(cancellationToken: cancellationToken),
                    Data = "decrease_user_balance",
                };
                await telegramService.GiveDescriptionForDecreaseTransactionAsync(botClient, callbackQuery,
                    cancellationToken, telegramUser);
                break;

            case TelegramMarzbanVpnSessionState.AwaitingSendDescriptionForDecrease:
                callbackQuery = new CallbackQuery()
                {
                    Message = message,
                    From = await botClient!.GetMeAsync(cancellationToken: cancellationToken),
                    Data = "decrease_user_balance",
                };

                await telegramService.DecreaseUserBalanceAsync(botClient, callbackQuery,
                    cancellationToken, telegramUser!);
                break;

            case TelegramMarzbanVpnSessionState.AwaitingSendMessageForUser:
                callbackQuery = new CallbackQuery()
                {
                    Message = message,
                    From = await botClient!.GetMeAsync(cancellationToken: cancellationToken),
                    Data = "send_message_byagent",
                };
                await telegramService.SendMessageForUserByAgentAsync(botClient, callbackQuery, cancellationToken,
                    telegramUser);
                break;

            case TelegramMarzbanVpnSessionState.AwaitingSendSpecialPercent:
                callbackQuery = new CallbackQuery()
                {
                    Message = message,
                    From = await botClient!.GetMeAsync(cancellationToken: cancellationToken),
                    Data = "change_agent_percent",
                };
                await telegramService.UpdateAgentSpecialPercentAsync(botClient, callbackQuery,
                    cancellationToken, telegramUser);

                break;

            case TelegramMarzbanVpnSessionState.AwaitingSendPersianBrandName:
                callbackQuery = new CallbackQuery()
                {
                    Message = message,
                    From = await botClient!.GetMeAsync(cancellationToken: cancellationToken),
                    Data = "set_branding_engilish"
                };

                await telegramService.SendTextEngilishBrandNameAsync(botClient, callbackQuery,
                    cancellationToken, telegramUser);

                break;

            case TelegramMarzbanVpnSessionState.AwaitingSendEnglishBrandName:
                callbackQuery = new CallbackQuery()
                {
                    Message = message,
                    From = await botClient!.GetMeAsync(cancellationToken: cancellationToken),
                    Data = "set_branding"
                };

                await telegramService.SetBrandingNameAsync(botClient, callbackQuery,
                    cancellationToken, telegramUser);
                break;

            case TelegramMarzbanVpnSessionState.AwaitingSendCardNumber:

                callbackQuery = new CallbackQuery()
                {
                    Message = message,
                    From = await botClient!.GetMeAsync(cancellationToken: cancellationToken),
                    Data = "set_card_number"
                };

                await telegramService.SetCardNumberAsync(botClient, callbackQuery,
                    cancellationToken, telegramUser);

                break;

            case TelegramMarzbanVpnSessionState.AwaitingSendCardHolderName:

                callbackQuery = new CallbackQuery()
                {
                    Message = message,
                    From = await botClient!.GetMeAsync(cancellationToken: cancellationToken),
                    Data = "set_card_number"
                };

                await telegramService.UpdateAgentCardDetailAsync(botClient, callbackQuery,
                    cancellationToken, telegramUser);

                break;

            #endregion
        }
    }

    #endregion

    #region utilitils

    public static long CheckPrice(string? priceText)
    {
        long price = 0;
        Int64.TryParse(priceText, out price);

        if (price == 0 || price <= 0)
            throw new AppException("""
                                   لطفا فرمت درست ارسال کنید ❌
                                   فرمت درست : 1000000
                                   """);

        return price;
    }

    public static long CheckPrice(User user, TransactionDetailDto transactionDetail, string? message)
    {
        long price = 0;

        long max = user.Balance < 0
            ? transactionDetail.MaximumAmountForAgent + (-user.Balance)
            : transactionDetail.MaximumAmountForAgent;

        long min = user.Balance < 0
            ? transactionDetail.MinimalAmountForAgent + (-user.Balance)
            : transactionDetail.MinimalAmountForAgent;

        Int64.TryParse(message, out price);

        if (price == 0 || price <= 0)
            throw new AppException("""
                                   لطفا فرمت درست ارسال کنید ❌
                                   فرمت درست : 1000000
                                   """);

        if (user.IsAgent)
        {
            if (max < price | min > price)
            {
                string exText = $"""
                                 ❌ خطا
                                 💬 مبلغ باید حداقل {min:N0} تومان و حداکثر {max:N0} تومان باشد
                                 """;

                throw new AppException(exText);
            }
        }
        else
        {
            if (transactionDetail!.MaximumAmountForUser < price |
                transactionDetail.MinimalAmountForUser > price)
            {
                string exText =
                    $"""
                     ❌ خطا
                     💬 مبلغ باید حداقل {transactionDetail.MaximumAmountForUser:N0} تومان و حداکثر {transactionDetail!.MinimalAmountForUser:N0} تومان باشد
                     """;

                throw new AppException(exText);
            }
        }

        return price;
    }

    public static string? CheckPhoneNumber(string? messageText)
    {
        string? phone = messageText;

        if (phone!.Length != 11)
        {
            throw new AppException("""
                                   لطفا شماره تماس درست را ارسال کنید ❌
                                   فرمت درست باید شماره تماس 11 رقمی باشد
                                   فرمت درست : 09129121212 ✅
                                   """);
        }

        return phone;
    }

    public static int CheckPercent(string? messageText)
    {
        int specialPercent = -1;

        int.TryParse(messageText, out specialPercent);

        if (specialPercent < 0) throw new AppException("❌ لطفا فرمت درست ارسال کنید ❌");

        return specialPercent;
    }

    public static string CheckBrandName(string? messageText)
    {
        string? persionBrand = messageText;

        if (persionBrand.Length < 2 || string.IsNullOrEmpty(persionBrand))
            throw new AppException("""
                                   ❌ لطفا فرمت درست ارسال کنید ❌
                                   """);

        if (persionBrand.Length > 9)
            throw new AppException("❌ نمیتواند نام نمایندگی بیشتر از 9 کارکتر باشد ❌");

        return persionBrand.Trim();
    }

    public static string CheckCardNumber(string? messageText)
    {
        long cardNumber = 0;
        Int64.TryParse(messageText, out cardNumber);

        if (cardNumber == 0 | messageText.Length != 16)
            throw new AppException("""
                                   فرمت ارسالی کارت اشتباه است! ❌
                                   : فرمت درست ✅
                                   6037696975758585
                                   """);

        return messageText;
    }

    public static string CheckHolderName(string? messageText)
    {
        if (messageText.Trim().Length <= 4 | string.IsNullOrEmpty(messageText))
            throw new AppException("""
                                   ❌ فرمت ارسالی اشتباه است
                                   حداقل باید شامل 4 کاراکتر باشد ❌
                                   """);

        return messageText;
    }

    #endregion

    #region utilitils

    public static (string?, string?, long) GetTelegramInformation(string input)
    {
        string tokenPattern = @"\d+:[A-Za-z0-9_-]{35}";

        Match tokenMatch = Regex.Match(input, tokenPattern);

        string? token = null;
        string? botLink = null;
        long botId = 0;

        if (tokenMatch.Success)
        {
            token = tokenMatch.Value;
        }

        string botLinkPattern = @"t\.me/\w+";
        Match botLinkMatch = Regex.Match(input, botLinkPattern);
        if (botLinkMatch.Success)
        {
            botLink = botLinkMatch.Value;
        }

        if (token != null)
        {
            Int64.TryParse(token.Split(":")[0], out botId);
        }

        if (token == null || botLink == null || botId == 0)
        {
            throw new ApplicationException(
                "❗ خطا: لطفاً متنی که بات فادر برای شما ارسال کرده است را ارسال کنید. متن باید شبیه به مثال زیر باشد:\n\n" +
                "✅ Done! Congratulations on your new bot. You will find it at t.me/yourbotusername. ...\n\n" +
                "Use this token to access the HTTP API:\n" +
                "123456789:ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmno\n" +
                "Keep your token secure and store it safely, it can be used by anyone to control your bot.\n\n" +
                "For a description of the Bot API, see this page: https://core.telegram.org/bots/api");
        }

        return (token, botLink, botId);
    }

    #endregion
}
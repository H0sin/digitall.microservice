using System.Security.Cryptography.Xml;
using Application.Helper;
using Application.Services.Interface.Account;
using Application.Services.Interface.Agent;
using Application.Services.Interface.Notification;
using Application.Static;
using Application.Utilities;
using Application.Exceptions;
using Application.Extensions;
using Application.Senders.Sms;
using Data.DefaultData;
using Domain.Common;
using Domain.DTOs.Account;
using Domain.DTOs.Agent;
using Domain.DTOs.Email;
using Domain.DTOs.Sms;
using Domain.DTOs.Telegram;
using Domain.Entities.Account;
using Domain.Enums.Account;
using Domain.Enums.Notification;
using Domain.IRepositories.Account;
using IPE.SmsIrClient.Models.Requests;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Application.Services.Implementation.Account;

public class UserService(
    IUserRepository userRepository,
    IAgentService agentService) : IUserService
{
    public async Task<LoginUserResult> LoginAsync(LoginUserDto login)
    {
        User user = (await userRepository
            .GetQuery()
            .SingleOrDefaultAsync(u => u.Mobile == login.Mobile))!;

        if (user is null)
            return LoginUserResult.NotFound;

        if (user.IsBlocked)
            return LoginUserResult.Blocked;

        if (user.Password == PasswordHelper.EncodePasswordMd5(login.Password))
            return LoginUserResult.Success;

        return LoginUserResult.NotFound;
    }


    public async Task<LoginUserResult> LoginByEmailAsync(string email, string password)
    {
        User? user = (await userRepository
            .GetQuery()
            .SingleOrDefaultAsync(u => u.Email == email));

        if (user is null)
            return LoginUserResult.NotFound;

        if (user.IsBlocked)
            return LoginUserResult.Blocked;

        if (user.Password == PasswordHelper.EncodePasswordMd5(password))
            return LoginUserResult.Success;

        return LoginUserResult.NotFound;
    }

    public async Task<LoginUserResult> LoginByChatIdAsync(long chatId, string password)
    {
        User? user = (await userRepository
            .GetQuery()
            .SingleOrDefaultAsync(u => u.ChatId == chatId));

        if (user is null)
            return LoginUserResult.NotFound;

        if (user.IsBlocked)
            return LoginUserResult.Blocked;

        if (user.Password == PasswordHelper.EncodePasswordMd5(password))
            return LoginUserResult.Success;

        return LoginUserResult.NotFound;
    }

    public async Task<List<UserDto>> GetUserByAgentAsync(long userId)
    {
        AgentDto? agent = await agentService.GetAgentByAdminId(userId);

        List<User> users = await userRepository.GetQuery()
            .Where(x => x.AgentId == agent.Id)
            .ToListAsync();

        return users.Select(x => new UserDto
        {
            Id = x.Id,
            Mobile = x.Mobile,
            FirstName = x.FirstName,
            LastName = x.LastName,
            Avatar = PathExtension.UserAvatarThumbServer + x.Avatar,
        }).ToList();
    }

    public async Task<UserDto> GetUserByMobileAsync(string mobile)
    {
        User? user = (await userRepository
            .GetQuery()
            .SingleOrDefaultAsync(x => x.Mobile == mobile))!;

        return user switch
        {
            null => null,
            _ => new UserDto
            {
                Id = user.Id,
                Mobile = user.Mobile,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Address = user.Address,
                Avatar = PathExtension.UserAvatarThumbServer + user.Avatar,
                AgentId = user.AgentId,
                Email = user.Email
            }
        };
    }

    public async Task<UserDto?> GetUserByIdAsync(long id)
    {
        User? user = await userRepository.GetQuery().SingleOrDefaultAsync(x => x.Id == id);

        if (user is null) throw new NotFoundException("چنین کاربری وجود ندارد");

        return new UserDto()
        {
            Id = user.Id,
            Mobile = user.Mobile,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Address = user.Address,
            Avatar = user.Avatar,
            AgentId = user.AgentId,
            Email = user.Email,
            IsMobileActive = user.IsMobileActive,
            MobileActiveCode = user.MobileActiveCode,
            Balance = user.Balance,
            ModifiedDate = user.ModifiedDate
        };
    }

    public async Task<UserDto?> GetUserByEmailAsync(string email)
    {
        User? user = await userRepository.GetQuery().SingleOrDefaultAsync(x => x.Email == email.Trim());

        if (user is null) throw new NotFoundException("چنین کاربری وجود ندارد");

        return new UserDto()
        {
            Id = user.Id,
            Mobile = user.Mobile,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Address = user.Address,
            Avatar = user.Avatar,
            AgentId = user.AgentId,
            Email = user.Email,
            IsMobileActive = user.IsMobileActive,
            MobileActiveCode = user.MobileActiveCode,
            Balance = user.Balance,
            ModifiedDate = user.ModifiedDate
        };
    }

    // public async Task<UserDto?> GetUserByChatIdAsync(long chatId)
    // {
    //     User? user = await userRepository.GetQuery().SingleOrDefaultAsync(x => x.ChatId == chatId);
    //
    //     if (user is null) throw new NotFoundException("چنین کاربری وجود ندارد");
    //
    //     return new UserDto()
    //     {
    //         Id = user.Id,
    //         Mobile = user.Mobile,
    //         FirstName = user.FirstName,
    //         LastName = user.LastName,
    //         Address = user.Address,
    //         Avatar = user.Avatar,
    //         AgentId = user.AgentId,
    //         Email = user.Email,
    //         IsMobileActive = user.IsMobileActive,
    //         MobileActiveCode = user.MobileActiveCode,
    //         Balance = user.Balance,
    //         ModifiedDate = user.ModifiedDate
    //     };
    // }

    public async Task<RegisterUserResult> RegisterAsync(RegisterUserDto registerUser)
    {
        using IDbContextTransaction transaction = await userRepository.context.Database.BeginTransactionAsync();
        try
        {
            if (await userRepository.GetQuery().SingleOrDefaultAsync(x => x.Email == registerUser.Email) is not null)
                return RegisterUserResult.IsExists;

            AgentDto? agent = await agentService.GetAgentByCode(registerUser.AgentCode ?? 0);

            if (agent == null)
                return RegisterUserResult.AgentNotFound;

            User user = new()
            {
                Email = registerUser.Email,
                EmailActiveCode = Guid.NewGuid().ToString(),
                IsEmailActive = false,
                FirstName = registerUser.FirstName,
                LastName = registerUser.LastName,
                Password = PasswordHelper.EncodePasswordMd5(registerUser.Password),
                IsDelete = false,
                MobileActiveCode = new Random().Next(10000, 999999).ToString(),
                AgentId = agent.Id,
                Description = registerUser.Description
            };

            await userRepository.AddEntity(user);
            await userRepository.SaveChanges(user.Id);

            // email 
            EmailDto email = new()
            {
                Message = "تست",
                Receiver = registerUser.Email,
                Status = 0,
                Subject = "te4st"
            };

            await transaction.CommitAsync();
            return RegisterUserResult.Success;
        }
        catch (Exception e)
        {
            await transaction.RollbackAsync();
            throw new ApplicationException();
        }
    }

    public async Task RegisterUserFromTelegram(StartTelegramBotDto user)
    {
        AgentDto? agent = await agentService.GetAgentByCode(user.AgentCode ?? 0);

        if (agent == null)
            agent = await agentService.GetAgentByIdAsync(AgentItems.Agents.First().Id);

        await userRepository.AddEntity(new User()
        {
            Balance = 0,
            AgentId = agent.Id,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Password = PasswordHelper.EncodePasswordMd5(user.ChatId.ToString()),
        });
    }

    public async Task<ForgetPasswordResult> ForgetPasswordAsync(ForgetUserPasswordDto forget)
    {
        User? user = await userRepository.GetQuery().SingleOrDefaultAsync(u => u.Mobile == forget.Mobile);

        if (user is null)
            return ForgetPasswordResult.NotExists;

        TimeSpan span = DateTime.Now.Subtract(user.ModifiedDate);
        if (span.Minutes > 3)
        {
            //generate password
            string password = CreatePassword.CreateUserPassword(7);

            //encode password
            user.Password = PasswordHelper.EncodePasswordMd5(password);

            #region send passowrd by sms

            SmsDto sms = new()
            {
                Message = "",
                Parameters = new VerifySendParameter[]
                {
                    new("NAME", user.FirstName + ' ' + user.LastName),
                    new("PASS", password),
                },
                Receiver = forget.Mobile,
                Status = 0,
                TypeSendSms = TypeSendSms.SendPassword,
            };
            ISendNotificationService<SmsDto> smsService = new SendSmsService<SmsDto>();
            await smsService.SendNotificationAsync(sms);

            #endregion

            await userRepository.UpdateEntity(user);
            await userRepository.SaveChanges(user.Id);
            return ForgetPasswordResult.Success;
        }

        return ForgetPasswordResult.Posted;
    }

    public async Task<FilterUsersDto> GetUsersByFilterAsync(FilterUsersDto filter)
    {
        IQueryable<User> query = userRepository.GetQuery();

        #region filter

        if (!string.IsNullOrEmpty(filter.FirstName))
            query = query.Where(s => EF.Functions.Like(s.FirstName, $"%{filter.FirstName}%"));

        if (!string.IsNullOrEmpty(filter.LastName))
            query = query.Where(s => EF.Functions.Like(s.LastName, $"%{filter.LastName}%"));


        if (!string.IsNullOrEmpty(filter.Mobile))
            query = query.Where(s => s.Mobile == filter.Mobile);

        #endregion

        IQueryable<UserDto> users = query.Select(u => new UserDto
        {
            Id = u.Id,
            Mobile = u.Mobile,
            FirstName = u.FirstName,
            LastName = u.LastName,
            Address = u.Address,
            Avatar = u.Avatar,
            AgentId = u.AgentId,
            Email = u.Email,
            IsMobileActive = u.IsMobileActive,
            Balance = u.Balance
        });

        await filter.Paging(users);

        return filter;
    }

    public async Task<FilterUsersDto> GetAgentUsersByFilterAsync(FilterUsersDto filter)
    {
        IQueryable<User> query = userRepository.GetQuery()
            .Where(x => x.AgentId == filter.AgentId);

        #region filter

        if (!string.IsNullOrEmpty(filter.FirstName))
            query = query.Where(s => EF.Functions.Like(s.FirstName, $"%{filter.FirstName}%"));

        if (!string.IsNullOrEmpty(filter.LastName))
            query = query.Where(s => EF.Functions.Like(s.LastName, $"%{filter.LastName}%"));


        if (!string.IsNullOrEmpty(filter.Mobile))
            query = query.Where(s => s.Mobile == filter.Mobile);

        #endregion

        IQueryable<UserDto> users = query.Select(u => new UserDto
        {
            Id = u.Id,
            Mobile = u.Mobile,
            FirstName = u.FirstName,
            LastName = u.LastName,
            Address = u.Address,
            Avatar = PathExtension.UserAvatarThumbServer + u.Avatar,
            AgentId = u.AgentId,
            Email = u.Email,
            IsMobileActive = u.IsMobileActive,
            Balance = u.Balance
        });

        await filter.Paging(users);

        return filter;
    }

    public async Task<UpdateUserProfileResult> UpdateUserProfileAsync(UpdateUserProfileDto profile, long userId)
    {
        User? user = await userRepository.GetEntityById(userId);

        if (user is null) return UpdateUserProfileResult.NotExists;

        user.Email = profile.Email;
        user.FirstName = profile.FirstName;
        user.LastName = profile.LastName;
        user.Address = profile.Address;

        if (user.Mobile != user.Mobile && user.MobileActiveCode == profile.MobileActiveCode)
        {
            user.MobileActiveCode = new Random().Next(10000, 999999).ToString();
            user.Mobile = profile.Mobile;
            await SendMobileActiveCode(user.Mobile, userId);
        }

        if (profile.Avatar != null && profile.Avatar.IsImage())
        {
            var imageName = Guid.NewGuid().ToString("N") + Path.GetExtension(profile.Avatar.FileName);
            profile.Avatar.AddImageToServer(imageName, PathExtension.UserAvatarOriginServer, 100, 100,
                PathExtension.UserAvatarThumbServer, user.Avatar);
            user.Avatar = imageName;
        }

        await userRepository.UpdateEntity(user);
        await userRepository.SaveChanges(userId);

        return UpdateUserProfileResult.Success;
    }

    public async Task UpdateUserBalance(long balance, long userId, long updateBy)
    {
        User user = await userRepository.GetEntityById(userId);
        user.Balance += balance;

        await userRepository.UpdateEntity(user);
        await userRepository.SaveChanges(updateBy);
    }

    public async Task SendMobileActiveCode(string phone, long userId)
    {
        UserDto? user = await GetUserByIdAsync(userId);
        TimeSpan span = DateTime.Now.Subtract(user.ModifiedDate);
        if (span.Minutes > 3)
        {
            SmsDto sms = new()
            {
                Message = "",
                Parameters = new VerifySendParameter[]
                {
                    new("NAME", user.FirstName + ' ' + user.LastName),
                    new("Code", user.MobileActiveCode),
                },
                Receiver = user.Mobile,
                Status = 0,
                TypeSendSms = TypeSendSms.SendChangeMobile,
            };
            ISendNotificationService<SmsDto> smsService = new SendSmsService<SmsDto>();
            await smsService.SendNotificationAsync(sms);
            // User? newUser = await userRepository.GetEntityById(userId);
            // newUser.MobileActiveCode = new Random().Next(10000, 999999).ToString();
            // await userRepository.UpdateEntity(newUser);
            await userRepository.SaveChanges(userId);
        }
        else
        {
            throw new LogicException("لطفا 3 دقیقه صبر کنید");
        }
    }

    public async Task<UserDto?> GetUserByChatIdAsync(long chatId)
    {
        User? user = await userRepository
            .GetQuery()
            .SingleOrDefaultAsync(x => x.ChatId == chatId);

        if (user is null) return null;

        return new()
        {
            Balance = user.Balance,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Id = user.Id
        };
    }

    public async Task<AddUserResult> AddUserAsync(AddUserDto user, long userId)
    {
        if (await userRepository.GetQuery().AnyAsync(x => x.Mobile == user.Mobile))
            return AddUserResult.IsExists;

        if (await userRepository.GetQuery().AnyAsync(x => x.Email == user.Email))
            return AddUserResult.IsExists;

        AgentDto? agent = await agentService.GetAgentByAdminId(userId);

        string password = CreatePassword.CreateUserPassword(7);

        User newUser = new()
        {
            Mobile = user.Mobile,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Address = user.Address,
            Email = user.Email,
            Password = PasswordHelper.EncodePasswordMd5(password),
            MobileActiveCode = new Random().Next(10000, 999999).ToString(),
            AgentId = agent.Id,
            IsMobileActive = user.IsMobileActive,
            Balance = 0
        };

        if (user.Avatar != null && user.Avatar.IsImage())
        {
            var imageName = Guid.NewGuid().ToString("N") + Path.GetExtension(user.Avatar.FileName);
            user.Avatar.AddImageToServer(imageName, PathExtension.UserAvatarOriginServer, 100, 100,
                PathExtension.UserAvatarThumbServer);
            newUser.Avatar = imageName;
        }

        await userRepository.AddEntity(newUser);
        await userRepository.SaveChanges(userId);

        return AddUserResult.Success;
    }
}
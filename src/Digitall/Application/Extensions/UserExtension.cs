using Domain.DTOs.Account;
using Domain.Entities.Account;

namespace Application.Extensions;

public static class UserExtension
{
    public static string UserFullName(this User user) => user.FirstName + " " + user.LastName;
    public static string UserFullName(this UserDto user) => user.FirstName + " " + user.LastName;

}
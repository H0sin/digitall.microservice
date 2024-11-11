using System.ComponentModel.DataAnnotations;
using Domain.Entities.Apple;

namespace Domain.DTOs.Apple;

public class AddAppleIdDto
{
    [Required]
    public long AppleIdTypeId { get; set; }
    
    [Required]
    [EmailAddress(ErrorMessage = "please enter email")]
    public string Email { get; set; }
    
    [Required]
    public string? Phone { get; set; }
    
    [Required]
    public string? Password { get; set; }
    
    [Required]
    [Compare(nameof(Password),ErrorMessage = "different password ")]
    public string? ComparePassword { get; set; }
    
    [Required]
    public DateTime? BirthDay { get; set; }
    
    [Required]
    public string? Question1 { get; set; }
    
    [Required]
    public string? Answer1 { get; set; }
    
    [Required]
    public string? Question2 { get; set; }
    
    [Required]
    public string? Answer2 { get; set; }
    
    [Required]
    public string? Question3 { get; set; }
    
    [Required]
    public string? Answer3 { get; set; }
    
    public AppleId GenerateAppleId()
    {
        return new()
        {
            AppleIdTypeId = AppleIdTypeId,
            Email = Email,
            Phone = Phone,
            Password = Password,
            BirthDay = BirthDay,
            Question1 = Question1,
            Answer1 = Answer1,
            Question2 = Question2,
            Answer2 = Answer2,
            Question3 = Question3,
            Answer3 = Answer3,
        };
    }
}
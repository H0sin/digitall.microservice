using System.ComponentModel.DataAnnotations;

namespace Domain.DTOs.Country;

public class AddCountryDto
{
    [Display(Name = "نام کشور")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(20, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string Name { get; set; }

    public Entities.Country.Country SetCountry()
    {
        return new Entities.Country.Country
        {
            Name = Name
        };
    }
}
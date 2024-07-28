using System.ComponentModel.DataAnnotations;

namespace Domain.DTOs.Country;

public class CountryDto
{
    public CountryDto(Entities.Country.Country country)
    {
        Name = country.Name;
        Id = country.Id;
    }

    [Display(Name = "نام کشور")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(20, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string Name { get; set; }

    public long Id { get; set; }
}
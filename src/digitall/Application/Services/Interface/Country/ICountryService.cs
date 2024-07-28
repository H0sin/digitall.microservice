using Domain.DTOs.Country;

namespace Application.Services.Interface.Country;

public interface ICountryService
{
    Task AddCountryAsync(AddCountryDto country, long userId);
    Task<List<CountryDto>> GetCountriesAsync();

    Task<CountryDto> GetCountryByIdAsync(long id);
}
using Application.Services.Interface.Country;
using Azure.Core;
using Application.Exceptions;
using Domain.DTOs.Country;
using Domain.IRepositories.Country;
using Microsoft.EntityFrameworkCore;

namespace Application.Services.Implementation.Country;

public class CountryService(ICountryRepository countryRepository) : ICountryService
{
    public async Task AddCountryAsync(AddCountryDto country, long userId)
    {
        if (await countryRepository.GetQuery().AnyAsync(x => x.Name == country.Name.Trim()))
            throw new ApplicationException("کشوری با این نام وجود دارد");
        await countryRepository.AddEntity(country.SetCountry());
        await countryRepository.SaveChanges(userId);
    }

    public async Task<List<CountryDto>> GetCountriesAsync()
    {
        var countries = await countryRepository.GetQuery().ToListAsync();
        return countries.Select(x => new CountryDto(x)).ToList();
    }

    public async Task<CountryDto> GetCountryByIdAsync(long id)
    {
        Domain.Entities.Country.Country? country = await countryRepository.GetQuery()
            .SingleOrDefaultAsync(x => x.Id == id);

        if (country is null) throw new NotFoundException("کشوری با این مشخصات یافت نشد");

        return new CountryDto(country);
    }
}
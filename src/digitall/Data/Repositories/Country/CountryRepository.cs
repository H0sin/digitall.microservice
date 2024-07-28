using Data.Context;
using Data.Repositories.Base;
using Domain.IRepositories.Country;

namespace Data.Repositories.Country;

public class CountryRepository(DigitallDbContext context) : BaseRepository<Domain.Entities.Country.Country>(context), ICountryRepository;
using CRUD.Core.Domain.RepositoryContracts;
using CRUD.Core.DTO.Countries;
using CRUD.Core.ServiceContracts.CountryContracts;

namespace CRUD.Core.Services.CountryServices
{
    public class CountriesAdderService : ICountriesAdderService
    {
        private readonly ICountriesRepository _countriesRepository;

        public CountriesAdderService(ICountriesRepository countriesRepository)
        {
            _countriesRepository = countriesRepository;
        }

        public Task<CountryResponse> AddCountry(CountryAddRequest? countryAddRequest)
        {
            if (countryAddRequest == null) throw new ArgumentNullException(nameof(countryAddRequest));
            if (countryAddRequest.CountryName == null) throw new ArgumentException(nameof(countryAddRequest.CountryName));

        }
    }
}

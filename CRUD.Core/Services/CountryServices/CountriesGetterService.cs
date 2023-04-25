using CRUD.Core.Domain.Entities;
using CRUD.Core.Domain.RepositoryContracts;
using CRUD.Core.DTO.Countries;
using CRUD.Core.ServiceContracts.CountryContracts;

namespace CRUD.Core.Services.CountryServices
{
    public class CountriesGetterService : ICountriesGetterService
    {
        private readonly ICountriesRepository _countriesRepository;

        public CountriesGetterService(ICountriesRepository countriesRepository)
        {
            _countriesRepository = countriesRepository;
        }

        public async Task<List<CountryResponse>> GetAllCountries()
        {
            List<Country> countries = await _countriesRepository.GetAllCountries();
            return countries.Select(country => country.ToCountryResponse()).ToList();   
        }

        public async Task<CountryResponse?> GetCountryByCountryID(Guid? countryID)
        {
            if (countryID == null) return null;

            Country? country_resp = await _countriesRepository.GetCountryByCountryID(countryID.Value);

            if (country_resp == null) return null;
            return country_resp.ToCountryResponse();
        }
    }
}

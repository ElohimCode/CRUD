﻿using CRUD.Core.DTO.Countries;

namespace CRUD.Core.ServiceContracts.CountryContracts
{
    public interface ICountriesAdderService
    {
        /// <summary>
        /// Adds a country object to the list of countries
        /// </summary>
        /// <param name="countryAddRequest">Country object to add</param>
        /// <returns>Returns the country object after adding it (including newly generated country id)</returns>
        Task<CountryResponse> AddCountry(CountryAddRequest? countryAddRequest);

    }
}

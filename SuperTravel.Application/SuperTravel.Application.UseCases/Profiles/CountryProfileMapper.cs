using SuperTravel.Core.DTOs;
using SuperTravel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTravel.Application.UseCases.Profiles
{
    public class CountryProfileMapper
    {
        public static Country GetCountryByCountryOutput(CountryOutput countryOutput)
        {
            Country country = new Country()
            {
                Id = countryOutput.Id,
                CommonName = countryOutput.commonName,
                OfficialName = countryOutput.OfficialName,
                Capital = countryOutput.Capital,
                Region = countryOutput.Region,
                Currency = new Currency()
                { 
                    Code = countryOutput.Currency.Code,
                    Name = countryOutput.Currency.Name,
                    Symbol = countryOutput.Currency.Symbol,
                }
            };
            return country;
        }

        public static List<Country> GetCountriesByCountriesOutputs(IEnumerable<CountryOutput> CountriesOutputs)
        {
            List<Country> countries = new List<Country>();
            foreach (CountryOutput countryOutput in CountriesOutputs)
            {
                countries.Add(GetCountryByCountryOutput(countryOutput));    
            }
            return countries;   
        }

        public static CountryOutput GetCountryOutputsByCountry(Country country)
        {
            CurrencyOutput currencyOutput = new(country.Currency.Code, country.Currency.Name, country.Currency.Symbol);
            CountryOutput countryOutput = new(country.Id, country.OfficialName, country.CommonName, country.Capital, currencyOutput, country.Region);
            return countryOutput;   
        }

        public static List<CountryOutput> GetCountriesOutputsByCountries(IEnumerable<Country> Countries)
        {
            List<CountryOutput> countriesOutputs = new();
            foreach (Country country in Countries)
            {
                countriesOutputs.Add(GetCountryOutputsByCountry(country));
            }
            return countriesOutputs;
        }
    }
}

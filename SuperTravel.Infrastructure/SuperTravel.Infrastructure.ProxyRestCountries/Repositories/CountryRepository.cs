using SuperTravel.Core.Entities;
using SuperTravel.Core.IRepositories;
using System.Collections.Generic;
using System.Text;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Diagnostics.CodeAnalysis;
using SuperTravel.Core.DTOs;

namespace SuperTravel.Infrastructure.ProxyRestCountries.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        private readonly IHttpClientFactory httpClientFactory;
        private readonly HttpClient httpClient;

        public CountryRepository(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
            this.httpClient = httpClientFactory.CreateClient("RestCountries");
        }
        public IEnumerable<Country>? GetAllAcountries()
        {
            List<Country>? countries = null;

            JsonArray? jsonCountries = null;
            if ((jsonCountries = GetJsonArray(this.httpClient))!=null)
            {
                countries = new List<Country>();
                for (int i = 0; i < jsonCountries.Count; i++)
                {
                    Country country = new()
                    {
                        Id = GetId(jsonCountries[i]!),
                        CommonName = GetCommonName(jsonCountries[i]!),
                        OfficialName = GetOfficialName(jsonCountries[i]!),
                        Capital = GetCapital(jsonCountries[i]!),
                        Region = GetRegion(jsonCountries[i]!)
                    };
                    country.Currency.Code = GetCurrecyCode(jsonCountries[i]!);
                    country.Currency.Name = GetCurrecyName(jsonCountries[i]!);
                    country.Currency.Symbol = GetCurrecySymbol(jsonCountries[i]!);
                    countries.Add(country);
                }
            }
            else
            {
                return countries;
            }

            return countries;
        }

        public ResultContainer<Country>? GetAll()
        {
            throw new NotImplementedException();
        }

        private static JsonArray? GetJsonArray(HttpClient httpClient)
        {
            JsonArray? jsonCountries = null;
            try
            {
                if ((jsonCountries = JsonNode.Parse(httpClient.GetAsync("/v3.1/all").Result.Content.ReadAsStringAsync().Result)!.AsArray()) != null)
                {
                    return jsonCountries;
                }
                else
                {
                    return jsonCountries;
                }
            }
            catch
            {
                return jsonCountries;
            }

            
        }

        private static string GetCapital(JsonNode countryNode)
        {
            string capital;
            try
            {
                capital = countryNode["capital"]!.AsArray()[0]!.GetValue<string>();
            }
            catch
            {
                capital = $"Not available";
            }
            return capital;
        }

        private static string GetCommonName(JsonNode countryNode)
        {
            string name;
            try
            {
                name = countryNode["name"]!["common"]!.GetValue<string>();
            }
            catch
            {
                name = $"Not available";
            }
            return name;
        }

        private static string GetOfficialName(JsonNode countryNode)
        {
            string name;
            try
            {
                name = countryNode["name"]!["common"]!.GetValue<string>();
            }
            catch
            {
                name = $"Not available";
            }
            return name;
        }

        private static string GetCurrecyCode(JsonNode countryNode)
        {
            string nameCode;
            try
            {
                var jsonCurrency = countryNode["currencies"]!.AsObject().ToList();
                nameCode = jsonCurrency[0].Key.ToString();
            }
            catch
            {
                nameCode = $"Not available";
            }
            return nameCode;
        }

        private static string GetCurrecySymbol(JsonNode countryNode)
        {
            string? nameSymbol;
            try
            {
                var jsonCurrency = countryNode["currencies"]!.AsObject().ToList();
                nameSymbol = jsonCurrency[0]!.Value!["symbol"]!.GetValue<string>();
            }
            catch
            {
                nameSymbol = $"Not available";
            }
            return nameSymbol;
        }

        private static string GetCurrecyName(JsonNode countryNode)
        {
            string? nameSymbol;
            try
            {
                var jsonCurrency = countryNode["currencies"]!.AsObject().ToList();
                nameSymbol = jsonCurrency[0]!.Value!["name"]!.GetValue<string>();
            }
            catch
            {
                nameSymbol = $"Not available";
            }
            return nameSymbol;
        }

        private static string GetRegion(JsonNode countryNode)
        {
            string name;
            try
            {
                name = countryNode["region"]!.GetValue<string>();
            }
            catch
            {
                name = $"Not available";
            }
            return name;
        }

        private static string GetId(JsonNode countryNode)
        {
            string? id;
            try
            {
                id = countryNode["tld"]!.AsArray()[0]!.GetValue<string>().Replace(".","");
            }
            catch
            {
                id = $"Not available";
            }
            return id;
        }
    }
}


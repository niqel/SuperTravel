using SuperTravel.Core.Entities;
using SuperTravel.Core.DTOs;
using SuperTravel.Core.IRepositories;
using SuperTravel.Core.IUseCases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SuperTravel.Application.UseCases.Profiles;

namespace SuperTravel.Application.UseCases.Cases
{
    public class CountryFinder : UseCasePattern, IFindAllCountries
    {
        public CountryFinder(IUnityOfWork unityOfWork) : base(unityOfWork)
        {
        }

        public IEnumerable<CountryOutput>? FindAllCountries()
        {
            IEnumerable<CountryOutput>? countryOutputs = null;
            IEnumerable<Country>? countries;
            if ((countries = this.unityOfWork.CountryRepository.GetAllAcountries()) != null)
            {
                countryOutputs = CountryProfileMapper.GetCountriesOutputsByCountries(countries);
            }
            
            return countryOutputs;
        }
    }
}

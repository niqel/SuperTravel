using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperTravel.Core.DTOs;
using SuperTravel.Core.IUseCases;
using System.ComponentModel.DataAnnotations;

namespace SuperTravel.InterfaceAdapter.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly IFindAllCountries countryFinder;

        public CountryController(IFindAllCountries countryFinder)
        {
            this.countryFinder = countryFinder;
        }

        [HttpGet]
        public ActionResult<CountryOutput> FindAllCountries()
        {
            IEnumerable<CountryOutput>? countriesOutput = this.countryFinder.FindAllCountries();
            if (countriesOutput != null)
            {
                if (countriesOutput.Count() > 0)
                {
                    return Ok(countriesOutput);
                }
            }
            return NotFound();
        }
    }
}

using SuperTravel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperTravel.Core.DTOs;

namespace SuperTravel.Core.IUseCases
{
    public interface IFindAllCountries
    {
        IEnumerable<CountryOutput>? FindAllCountries();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace SuperTravel.Core.DTOs
{
    public record CountryOutput(string Id, string OfficialName, string commonName, string Capital, CurrencyOutput Currency, string Region);
}

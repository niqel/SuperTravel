using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace SuperTravel.Core.Entities
{
    public class Country
    {
        private string id;
        private string officialName;
        private string commonName;
        private string capital;
        private string region;
        private Currency currency;
        

        public string Id { get => id; set => id = value; }
        public string OfficialName { get => officialName; set => officialName = value; }
        public string CommonName { get => commonName; set => commonName = value; }
        public string Capital { get => capital; set => capital = value; }
        public string Region { get => region; set => region = value; }
        public Currency Currency { get => currency; set => currency = value; }
        

        public Country()
        {
            this.id = string.Empty;
            this.officialName = string.Empty;
            this.commonName = string.Empty;
            this.capital = string.Empty;
            this.region = string.Empty;
            this.currency = new Currency();
            
        }

        public Country(string id, string commonName, string officialName, string capital, Currency currency, string region)
        {
            this.id = id;
            this.commonName = commonName;
            this.officialName = officialName;
            this.capital = capital;
            this.region = region;
            this.currency = currency;
        }
    }
}

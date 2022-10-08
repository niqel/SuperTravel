using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTravel.Core.Entities
{
    public class Currency
    {
        private string code;
        private string name;
        private string symbol;

        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public string Symbol { get => symbol; set => symbol = value; }

        public Currency()
        {
            this.code = string.Empty;
            this.name = string.Empty;
            this.symbol = string.Empty;
        }

        public Currency(string code, string name, string symbol)
        {
            this.code = code;
            this.name = name;
            this.symbol = symbol;
        }
    }
}

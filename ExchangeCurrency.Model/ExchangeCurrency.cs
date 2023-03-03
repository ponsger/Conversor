using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeCurrency.Model
{
    public class ExchangeCurrency
    {
        public string Base { get; set; }
        public string To { get; set; }
        public double Amount { get; set; }
        public double Converted { get; set; }
        public double Rate { get; set; }
        public string LastUpdate { get; set; }
    }
}

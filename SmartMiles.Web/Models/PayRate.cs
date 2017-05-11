using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartMiles.Web.Models
{
    public enum PayRateType
    {
        Hourly = 1,
        PerMile = 2
    }
    public class PayRate
    {        
        public decimal Rate { get; set; }
        public PayRateType Type { get; set; }       

    }
}

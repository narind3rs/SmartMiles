using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmartMiles.Web.Models
{
    public class Company
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string TaxIdentifier { get; set; }        
        public Address Address { get; set; }

        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }
    }
}

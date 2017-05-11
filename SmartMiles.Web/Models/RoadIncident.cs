using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartMiles.Web.Models
{
    public class RoadIncident
    {
        public int Id { get; set; }
        public Trip Trip { get; set; }
        public string Description { get; set; }
        public string Severity { get; set; }
    }
}

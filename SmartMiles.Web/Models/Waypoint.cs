using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartMiles.Web.Models
{
    public class Waypoint
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Notes { get; set; }        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartMiles.Web.Models
{
    public class Trip
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? StartDate { get; set; } = DateTime.Now;
        public DateTime? EndDate { get; set; }
        public List<Waypoint> Stops { get; set; }
        public Truck Truck { get; set; }
        public List<Driver> Driver { get; set; }
        public int Mileage { get; set; }//Need to consider mileage type
        public string Notes { get; set; }

    }
}

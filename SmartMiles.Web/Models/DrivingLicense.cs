using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartMiles.Web.Models
{
    public class DrivingLicense
    {
        public string Number { get; set; }
        public string Class { get; set; }
        public string IssueState { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmartMiles.Web.Models
{
    /// <summary>
    /// This class will hold contact info attributes
    /// </summary>
    public class ContactInfo
    {
        [DataType(DataType.PhoneNumber)]
        public string HomePhone { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string CellPhone { get; set; }
        
        public Address Address { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}

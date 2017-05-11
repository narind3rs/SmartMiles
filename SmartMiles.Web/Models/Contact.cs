using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmartMiles.Web.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string FullName { get; set; }       
        public string Relationship { get; set; }
        public ContactInfo Info { get; set; }
    }
}

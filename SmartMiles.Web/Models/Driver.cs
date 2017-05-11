using System;

namespace SmartMiles.Web.Models
{
    public class Driver
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public ContactInfo ContactInfo { get; set; }
        public Company Company { get; set; }
        //public string CVOR { get; set; }
        public DrivingLicense DrivingLicense { get; set; }
        public Address MailingAddress { get; set; }
        public Contact DrivingReference { get; set; }
        public Contact EmergencyContact { get; set; }
        public Contact EmergencyContact2 { get; set; }
        public Truck AssignedTruck { get; set; }
        public PayRate Rate { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? TerminationDate { get; set; }
        public string Notes { get; set; }
    }
}

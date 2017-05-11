using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SmartMiles.Web.Models
{
    public class Truck
    {
        public int Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }//Business Identifier - Could be a name or number that is used by a business

        public string Make
        {
            get;
            set;
        }

        public string Model
        {
            get;
            set;
        }

        public string ModelYear
        {
            get;
            set;
        }

        public string Color
        {
            get;
            set;
        }

        public string VIN
        {
            get;
            set;
        }

        public DateTime? PurchaseDate
        {
            get;
            set;
        }

        public PurchaseTypes PurchaseType
        {
            get;
            set;
        }//It will be used to track whether the vehicle was new or used when purchased

        public LicensePlate Plate
        {
            get;
            set;
        }

        public DateTime InServiceDate
        {
            get;
            set;
        }

        public Odometer InServiceOdometer
        {
            get;
            set;
        }

        public List<Odometer> OdometerReading
        {
            get;
            set;
        }

        public DateTime? VehicleSafetyExpirationDate
        {
            get;
            set;
        }

        public DateTime? VehicleEmissionsExpirationDate
        {
            get;
            set;
        }

        public DateTime? RetiredDate
        {
            get;
            set;
        }

        public List<Warranty> Warranties
        {
            get;
            set;
        }
        [DataType(DataType.MultilineText)]
        public string Notes
        {
            get;
            set;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsurance.View_Models
{
    public class Quote
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int CarYear { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public bool DUI { get; set; }
        public int SpeedingTickets { get; set; }
        public bool CoverageType { get; set; }
        public decimal quoteAge { get; set; }
        public decimal quoteCar { get; set; }
        public decimal quoteTickets { get; set; }
        public decimal quoteDUI { get; set; }
        public decimal quoteCoverage { get; set; }
    }
}
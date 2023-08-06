using OfficeOpenXml.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperProject
{
    public class Facility
    {
        public int FacilityId { get; set; }
        public string FacilityName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string PhoneNumber { get; set; }
        [EpplusIgnore]
        public string EmailAddress { get; set; }
        [EpplusIgnore]
        public bool Live { get; set; }
        [EpplusIgnore]
        public DateTime ActiveDate { get; set; }
        [EpplusIgnore]
        public DateTime LastUpdated { get; set; }
        [EpplusIgnore]
        public string LastUpdatedBy { get; set; }
      
    }
}

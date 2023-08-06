using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperProject
{
    public class FacilityRepository
    {
        public List<Facility> GetFacilities()
        {
            var context = new FacilityDbContext();
            return context.Facilities.ToList();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperProject
{
    public class FacilityDbContext : DbContext
    {
        private readonly string _connectionString = "Data Source=.;Initial Catalog=NursingHomes;Integrated Security=true;TrustServerCertificate=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        public DbSet<Facility> Facilities { get; set; }
    }
}

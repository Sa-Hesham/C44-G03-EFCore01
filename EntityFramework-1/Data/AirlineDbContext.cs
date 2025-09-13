using EntityFramework_1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_1.Data
{
    internal class AirlineDbContext :DbContext
    {

        public AirlineDbContext() : base()
        {
            
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =.; Database =AireLine02 ; Trusted_Connection = True ;TrustServerCertificate=True;");
        }

        public DbSet<AireCraft>AireCrafts { get; set; }
        public DbSet<AireLine> AireLines { get; set; }
        public DbSet<AireLinePhones> AireLine_Phones { get; set; }
        public DbSet<Transactions> transactions { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<EmployeeCualifications> Emp_Cualifications { get; set; }

        public DbSet<Route> routes {  get; set; }


        public DbSet<AircraftRoute> aircraft_routes { get; set; }






    }
}

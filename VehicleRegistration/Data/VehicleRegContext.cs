using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRegistration.Data
{
     public class VehicleRegContext : DbContext 
    {
        public VehicleRegContext(DbContextOptions<VehicleRegContext> options) : base(options){}

        public DbSet<Vehicle> Vehicles{get; set;}
    }
}

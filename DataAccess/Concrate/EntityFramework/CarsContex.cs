using Entities.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrate.EntityFramework
{
    public class CarsContex:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Cars;Trusted_Connection=true");
            

        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarBrand> CarBrand { get; set; }
        public DbSet<CarColor> CarColor { get; set; }
        public DbSet<CarList> CarList { get; set; }

    }
}

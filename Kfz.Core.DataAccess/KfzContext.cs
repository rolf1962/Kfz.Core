using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Kfz.Core.Model;

namespace Kfz.Core.DataAccess
{
    public class KfzContext : DbContext
    {
        public KfzContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<CostType> CostType { get; set; }
        public DbSet<VehicleType> VehicleType { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<Cost> Cost { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseMySQL("server=192.168.178.22;database=kfz_code_first;user=kfz;password=Syquest1!");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cost>()
                .HasKey(cost => cost.CostId);
            modelBuilder.Entity<CostType>()
                .HasKey(costType => costType.costTypeId);
            modelBuilder.Entity<Vehicle>()
                .HasKey(vehicle => vehicle.vehicleId);
            modelBuilder.Entity<VehicleType>()
                .HasKey(vehicleType => vehicleType.vehicleTypeId);
        }
    }
}

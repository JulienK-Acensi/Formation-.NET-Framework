using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tours_OpenData.Parkings_Indigo.Domain;
using Tours_OpenData.Parkings_Indigo.Infrastructures.Entities;

namespace Tours_OpenData.Parkings_Indigo.Infrastructures.Contexts
{
    public class ParkingContext : DbContext
    {
        public ParkingContext([NotNullAttribute] DbContextOptions options): base(options) { }
        public ParkingContext() : base() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ParkingEntityTypeConfiguration());
        }

        public DbSet<Parking> Parkings { get; set; }
    }
}

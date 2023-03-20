using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tours_OpenData.Parkings_Indigo.Domain;

namespace Tours_OpenData.Parkings_Indigo.Infrastructures.Entities
{
    class ParkingEntityTypeConfiguration : IEntityTypeConfiguration<Parking>
    {
        public void Configure(EntityTypeBuilder<Parking> builder)
        {
            builder.ToTable("Parkings_Indigo");
            builder.HasKey(item => item.key);
        }
    }
}

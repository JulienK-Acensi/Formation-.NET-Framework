using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_Project.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Project.Core.Infrastructure.Data.TypeConfigurations
{
    class PokemonEntityTypeConfiguration : IEntityTypeConfiguration<Pokemon>
    {


        public void Configure(EntityTypeBuilder<Pokemon> builder)
        {
            builder.ToTable("Pokemon");
            builder.HasKey(x => x.Id);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using MVC_Project.Core.Domain;
using MVC_Project.Core.Infrastructure.Data.TypeConfigurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Project.Core.Infrastructure.Data
{
    public class PokemonsContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new PokemonEntityTypeConfiguration());
        }

        public DbSet<Pokemon> Pokemons { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Termo.Generales.Core;

namespace Termo.Generales.Data
{
    public class GeneralesContext : DbContext
    {
        public GeneralesContext(DbContextOptions<GeneralesContext> options)
            : base(options)
        {
        }

        public DbSet<Linea> Lineas { get; set; }
        public DbSet<Producto> Productos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Generales");
        }


    }
}

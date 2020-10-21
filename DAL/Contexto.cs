using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using PrestamosDetalle.Modelos;
using System.Threading.Tasks;

namespace PrestamosDetalle.DAL
{
    public class Contexto : DbContext
    {
         public DbSet<Personas> Personas {get; set;}
         public DbSet<Prestamos> Prestamos {get; set;}
          public DbSet<Moras> Moras{get; set;}
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
            optionsBuilder.UseSqlite(@"Data source= Data/PrestamoDetalle.db");
        }

         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personas>()
                .HasOne(a => a.Prestamos)
                .WithOne(b => b.Personas)
                .HasForeignKey<Prestamos>(b => b.PersonaId);
        }
    }
}
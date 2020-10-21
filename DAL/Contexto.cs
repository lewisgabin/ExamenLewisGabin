using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using PrestamosDetalle.Modeloss;
using System.Threading.Tasks;

namespace PrestamosDetalle.DAL
{
    public class Contexto : DbContext
    {
         public DbSet<Personas> Personas {get; set;}
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
            optionsBuilder.UseSqlite(@"Data source= Data/PrestamoDetalle.db");
        }
    }
}
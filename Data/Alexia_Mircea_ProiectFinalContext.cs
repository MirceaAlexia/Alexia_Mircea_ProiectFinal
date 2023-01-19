using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Alexia_Mircea_ProiectFinal.Models;

namespace Alexia_Mircea_ProiectFinal.Data
{
    public class Alexia_Mircea_ProiectFinalContext : DbContext
    {
        public Alexia_Mircea_ProiectFinalContext (DbContextOptions<Alexia_Mircea_ProiectFinalContext> options)
            : base(options)
        {
        }

        public DbSet<Alexia_Mircea_ProiectFinal.Models.Clothing> Clothing { get; set; } = default!;

        public DbSet<Alexia_Mircea_ProiectFinal.Models.Category> Category { get; set; }

        public DbSet<Alexia_Mircea_ProiectFinal.Models.Order> Order { get; set; }

    }
}

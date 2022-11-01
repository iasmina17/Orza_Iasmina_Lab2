using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Orza_Iasmina_Lab2.Models;

namespace Orza_Iasmina_Lab2.Data
{
    public class Orza_Iasmina_Lab2Context : DbContext
    {
        public Orza_Iasmina_Lab2Context (DbContextOptions<Orza_Iasmina_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Orza_Iasmina_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Orza_Iasmina_Lab2.Models.Publisher> Publisher { get; set; }
    }
}

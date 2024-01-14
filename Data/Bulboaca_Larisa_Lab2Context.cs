using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bulboaca_Larisa_Lab2.Models;

namespace Bulboaca_Larisa_Lab2.Data
{
    public class Bulboaca_Larisa_Lab2Context : DbContext
    {
        public Bulboaca_Larisa_Lab2Context (DbContextOptions<Bulboaca_Larisa_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Bulboaca_Larisa_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Bulboaca_Larisa_Lab2.Models.Publisher> Publisher { get; set; } = default!;

        public DbSet<Bulboaca_Larisa_Lab2.Models.Author> Author { get; set; } = default!;
    }
}

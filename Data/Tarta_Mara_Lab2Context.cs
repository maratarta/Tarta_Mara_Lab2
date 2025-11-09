using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tarta_Mara_Lab2.Models;

namespace Tarta_Mara_Lab2.Data
{
    public class Tarta_Mara_Lab2Context : DbContext
    {
        public Tarta_Mara_Lab2Context (DbContextOptions<Tarta_Mara_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Tarta_Mara_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Tarta_Mara_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Tarta_Mara_Lab2.Models.Author> Author { get; set; } = default!;
        public DbSet<Tarta_Mara_Lab2.Models.Category> Category { get; set; } = default!;
        public DbSet<Tarta_Mara_Lab2.Models.Member> Member { get; set; } = default!;
        public DbSet<Tarta_Mara_Lab2.Models.Borrowing> Borrowing { get; set; } = default!;
    }
}

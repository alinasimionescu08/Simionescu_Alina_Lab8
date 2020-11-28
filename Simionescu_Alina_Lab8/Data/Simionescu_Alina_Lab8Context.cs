using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Simionescu_Alina_Lab8.Models;

namespace Simionescu_Alina_Lab8.Data
{
    public class Simionescu_Alina_Lab8Context : DbContext
    {
        public Simionescu_Alina_Lab8Context (DbContextOptions<Simionescu_Alina_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Simionescu_Alina_Lab8.Models.Book> Book { get; set; }

        public DbSet<Simionescu_Alina_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Simionescu_Alina_Lab8.Models.Category> Category { get; set; }
    }
}

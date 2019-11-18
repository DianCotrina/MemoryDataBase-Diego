using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataBaseMemory.Models;
using Microsoft.EntityFrameworkCore;

namespace DataBaseMemory.DataContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
    }
}

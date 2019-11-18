using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataBaseMemory.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DataBaseMemory.DataContext.Data
{
    public static class DbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var _context = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
                if (_context.Artists.Any())
                {
                    return;
                }

                _context.Artists.AddRange(
                    new Artist { Name = "Luis Miguel" },
                                new Artist { Name = "Ricardo Arjona" },
                                new Artist { Name = "Kalimba" }
                        );

                _context.SaveChanges();

                if (_context.Albums.Any())
                {
                    return;
                }

                _context.Albums.AddRange(
                    new Album
                    {
                        ArtistId = _context.Artists.FirstOrDefault(a => a.Name.Equals("Kalimba")).ArtistId,
                        Tittle = $"Mi otro yo",
                        Price = 200
                    },
                    new Album
                    {
                        ArtistId = _context.Artists.FirstOrDefault(a => a.Name.Equals("Kalimba")).ArtistId,
                        Tittle = $"Aerosoul",
                        Price = 200
                    },
                    new Album
                    {
                        ArtistId = _context.Artists.FirstOrDefault(a => a.Name.Equals("Ricardo Arjona")).ArtistId,
                        Tittle = $"Circo Soledad",
                        Price = 200
                    },
                    new Album
                    {
                        ArtistId = _context.Artists.FirstOrDefault(a => a.Name.Equals("Luis Miguel")).ArtistId,
                        Tittle = $"Romance",
                        Price = 200
                    }

                );

                _context.SaveChanges();
            }
        }
    }
}

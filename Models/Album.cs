using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataBaseMemory.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }
        public string Tittle { get; set; }
        public double Price { get; set; }

    }
}

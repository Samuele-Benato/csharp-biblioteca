using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static csharp_biblioteca.Document;

namespace csharp_biblioteca
{
    internal class Dvd : Document
    {
        public int Duration { get; set; }

        public Dvd(string id, string title, int year, Sector sector, char shelf, byte position, string author, int duration) : base(id, title, year, sector, shelf, position, author)
        {
            Duration = duration;
        }
    }
}

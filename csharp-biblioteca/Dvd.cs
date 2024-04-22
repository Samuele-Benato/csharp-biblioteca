using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static csharp_biblioteca.Document;

namespace csharp_biblioteca
{
    public class Dvd : Document
    {
        public int Duration { get; set; }

        public Dvd(string id, string title, int year, Sector sector, char shelf, byte position, string author, int duration, bool avaiable = true) : base(id, title, year, sector, shelf, position, author, avaiable)
        {
            Duration = duration;
        }
    }
}

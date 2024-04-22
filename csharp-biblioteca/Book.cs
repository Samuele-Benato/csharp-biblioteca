using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Book : Document
    {
        public int Pages { get; set; }

        public Book(string id, string title, int year, Sector sector, char shelf, byte position, string author, int pages) : base(id, title, year, sector, shelf, position, author)
        {
            Pages = pages;
        }
    }
}

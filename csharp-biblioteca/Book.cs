using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Book : Document
    {
        public int Pages { get; set; }

        public Book(string id, string title, int year, Sector sector, char shelf, byte position, string author,  int pages, bool avaiable = true) : base(id, title, year, sector, shelf, position, author, avaiable)
        {
            Pages = pages;
        }
    }
}

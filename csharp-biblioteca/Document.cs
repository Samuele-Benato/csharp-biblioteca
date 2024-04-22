using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Document
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public int Year {  get; set; }
        public enum Sector {History, Mathematics, Economics, Comedy, Horror }
        public Sector DocumentSector { get; set; }
        public char Shelf { get; set; }
        public byte Position { get; set; }
        public string Author { get; set; }

        public Document(string id, string title, int year, Sector sector, char shelf, byte position, string author)
        {
            Id = id;
            Title = title;
            Year = year;
            DocumentSector = sector;
            Shelf = shelf;
            Position = position;
            Author = author;

        }
    }
}

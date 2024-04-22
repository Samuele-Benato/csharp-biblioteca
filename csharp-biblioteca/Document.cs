using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Document
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public int Year {  get; set; }
        public enum Sector {History, Mathematics, Economics, Comedy, Horror }
        public Sector DocumentSector { get; set; }
        public char Shelf { get; set; }
        public byte Position { get; set; }
        public string Author { get; set; }
        public bool Avaiable { get; set; }

        public Document(string id, string title, int year, Sector sector, char shelf, byte position, string author, bool avaiable = true)
        {
            Id = id;
            Title = title;
            Year = year;
            DocumentSector = sector;
            Shelf = shelf;
            Position = position;
            Author = author;
            Avaiable = avaiable;

        }

        public bool GetDocument(string searchedDocument)
        {
            if(searchedDocument == Id || searchedDocument == Title)
            {
                return true;
            }
            else
            {
                return false;
            }
                
        }

        public void SetBusy(bool input)
        {
            if(input == true)
            {
                Avaiable = false;
                Console.WriteLine("Prenotazione avvenuta con successo");
            }else 
            {
                Console.WriteLine("Prenotazione annullata");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Library
    {
        public List<Book> Books { get; private set; }
        public List<Dvd> DVDs { get; private set; }

        public Library()
        {
            Books = new List<Book>()
            {
                new Book("B001", "The History of Rome", 2005, Document.Sector.History, 'A', 1, "John Smith", 300),
                new Book("B002", "Mathematics for Beginners", 2010, Document.Sector.Mathematics, 'B', 3, "Alice Johnson", 200),
                new Book("B003", "Economics: Principles and Applications", 2018, Document.Sector.Economics, 'C', 2, "David Brown", 400),
                new Book("B004", "Comedy for Dummies", 2020, Document.Sector.Comedy, 'D', 4, "Emily White", 250),
                new Book("B005", "Horror Stories", 2015, Document.Sector.Horror, 'E', 5, "Michael Black", 350)
            };

            DVDs = new List<Dvd>()
            {
                new Dvd("D001", "The History of Rome", 2005, Document.Sector.History, 'A', 1, "John Smith", 120),
                new Dvd("D002", "Mathematics for Beginners", 2010, Document.Sector.Mathematics, 'B', 3, "Alice Johnson", 90),
                new Dvd("D003", "Economics: Principles and Applications", 2018, Document.Sector.Economics, 'C', 2, "David Brown", 150),
                new Dvd("D004", "Comedy for Dummies", 2020, Document.Sector.Comedy, 'D', 4, "Emily White", 100),
                new Dvd("D005", "Horror Stories", 2015, Document.Sector.Horror, 'E', 5, "Michael Black", 110)
            };
        }

        public void SearchDocument(string searchedDocument)
        {
            foreach (var book in Books)
            {
                if (book.GetDocument(searchedDocument))
                {
                    Console.WriteLine($"Vuoi prenotare {book.Title} ? ");
                    string inputString = Console.ReadLine();

                    bool input;
                    if (bool.TryParse(inputString, out input))
                    {
                        book.SetBusy(input);
                    }
                    else
                    {
                        Console.WriteLine("Input non valido. Devi inserire true o false.");
                    }

                    break;
                };
   
            }

            foreach (var dvd in DVDs)
            {
                if(dvd.GetDocument(searchedDocument))
                {
                    Console.WriteLine($"Vuoi prenotare {dvd.Title} ? ");
                    string inputString = Console.ReadLine();

                    bool input;
                    if (bool.TryParse(inputString, out input))
                    {
                        dvd.SetBusy(input);
                    }
                    else
                    {
                        Console.WriteLine("Input non valido. Devi inserire true o false.");
                    }

                    break;
                };
            }

        }
    }
}

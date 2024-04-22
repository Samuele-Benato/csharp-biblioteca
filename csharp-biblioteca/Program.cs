namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            Console.WriteLine("Inserisci il titolo o l'ID del documento:");
            string searchedDocument = Console.ReadLine();

            library.SearchDocument(searchedDocument);
        }
    }
}

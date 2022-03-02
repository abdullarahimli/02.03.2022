using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            library.AddBook("Philosophy", "Anonymous", 650);
            library.AddBook("Sociology", "Anonymous", 854);
            library.AddBook("Science", "Anonymous", 327);
            library.AddBook("Match", "Anonymous", 450);
            library.AddBook("Algorhitms", "Anonymous", 1020);
            library.AddBook("C# ile Nesne Tabanlı Programlama", "Fahrettin Erdinç", 420);

            ShowBook(library.SearchBooks("Algorhitms"));
        }
        static void ShowBook(List<Book> books)
        {
            foreach (var item in books)
            {
                Console.WriteLine(item);

            }
        }
    }
}

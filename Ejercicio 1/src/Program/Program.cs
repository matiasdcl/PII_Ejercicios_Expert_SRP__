using System;
using System.Collections.Generic;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            //book1.ShelveBook("A","7");
            //book2.ShelveBook("B","3");
            List<Book> bookList = new List<Book>();
            Sector sector1 = new Sector("sector1", bookList);
            sector1.AddBookToSector(book1);
            sector1.AddBookToSector(book2);
            sector1.WhichBooksAreInSector();

            List<Sector> sectorList = new List<Sector>();
            Shelve shelve1 = new Shelve("shelve1", sectorList);
            shelve1.AddSectorToShelve(sector1);
            shelve1.WhichSectorsAreInShelve();

        }
    }
}
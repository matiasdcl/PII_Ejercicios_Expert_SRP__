using System;
using System.Collections.Generic;
using SRP;

public class Sector
    {
        public string sectorName;
        public List<Book> bookList = new List<Book>();

        public Sector(string sectorName, List<Book> bookList)
        {
            this.sectorName = sectorName;
            this.bookList = bookList;
        }

        public void AddBookToSector(Book book)
        {
            bookList.Add(book);
        }

        public void WhichBooksAreInSector()
        {
            int forvar = 1;
            foreach (var books in bookList)
            {
                Console.WriteLine($"book[{forvar}]\ntitle: {books.Title}. author: {books.Author}. code: {books.Code}\n");
                forvar++;
            }
        }
    }
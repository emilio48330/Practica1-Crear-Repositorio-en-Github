using ConsoleApp2;
using System;
using System.Collections.Generic;

public class Library
{
    private static Library instance;
    private List<Book> books;

    private Library()
    {
        books = new List<Book>();
    }

    public static Library Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Library();
            }
            return instance;
        }
    }

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void DisplayBooks()
    {
        Console.WriteLine("Books in the library:");
        foreach (var book in books)
        {
            Console.WriteLine(book);
        }
    }
}



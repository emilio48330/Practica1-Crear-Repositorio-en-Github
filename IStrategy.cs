using ConsoleApp2;
using System;


public interface IStrategy
{
    void Execute();
}

public class PrintBookStrategy : IStrategy
{
    private Book book;

    public PrintBookStrategy(Book book)
    {
        this.book = book;
    }

    public void Execute()
    {
        Console.WriteLine($"Printing book: {book.Title}");
    }
}

public class EmailBookStrategy : IStrategy
{
    private Book book;
    private string emailAddress;

    public EmailBookStrategy(Book book, string emailAddress)
    {
        this.book = book;
        this.emailAddress = emailAddress;
    }

    public void Execute()
    {
        Console.WriteLine($"Emailing book: {book.Title} to {emailAddress}");
    }
}

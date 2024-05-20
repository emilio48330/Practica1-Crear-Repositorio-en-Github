using ConsoleApp2;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Crear libros
        Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald");
        Book book2 = new Book("To Kill a Mockingbird", "Harper Lee");

        // Agregar libros a la biblioteca
        Library.Instance.AddBook(book1);
        Library.Instance.AddBook(book2);

        // Mostrar libros en la biblioteca
        Library.Instance.DisplayBooks();

        // Ejecutar una estrategia
        IStrategy printStrategy = new PrintBookStrategy(book1);
        printStrategy.Execute();

        // Ejecutar otra estrategia
        IStrategy emailStrategy = new EmailBookStrategy(book2, "20230616@itla.edu.do");
        emailStrategy.Execute();
    }
}

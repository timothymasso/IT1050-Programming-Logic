using System;
using System.Collections.Generic;

public class Author : Person
{
    private List<Book> Books = new List<Book>();

    public Author() : base() { }
    public Author(string ssn, string name, string gender, DateTime dob) : base(ssn, name, gender, dob) { }

    public void DisplayInfo()
    {
        Console.WriteLine($"Author: {Name}");
    }

    public void DisplayBooks()
    {
        foreach (var book in Books)
        {
            book.Display();
        }
    }

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public void RemoveBook(string isbn)
    {
        Book bookToRemove = Books.Find(b => b.ISBN == isbn);
        if (bookToRemove != null)
        {
            Books.Remove(bookToRemove);
        }
    }
}

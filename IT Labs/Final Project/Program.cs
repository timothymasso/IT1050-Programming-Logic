using System;

class Program
{
    static void Main() {
        Author author1 = new Author("111223333", "Joanne Rowling", "F", Convert.ToDateTime("07/31/1965"));
        Author author2 = new Author("222332222", "Stephen King", "M", Convert.ToDateTime("09/21/1947"));

        author1.DisplayInfo();
        author2.DisplayInfo();

        Book book1 = new Book("9780439708180", "Harry Potter Book 1", author1);
        Book book2 = new Book("9780450411434", "Carrie", author2);
        Book book3 = new Book("9780439064873", "Harry Potter Book 2", author1);
        Book book4 = new Book("9781501142970", "It", author2, Convert.ToDateTime("09/15/1986"), "Viking");
        Book book5 = new Book("9780439136365", "Harry Potter Book 3", author1, Convert.ToDateTime("07/08/1999"), "Scholastic");
        Book book6 = new Book("9780670813025", "The Shining", author2, Convert.ToDateTime("01/28/1977"), "Doubleday");

        author1.AddBook(book1);
        author1.AddBook(book3);
        author1.AddBook(book5);
        Console.WriteLine("\nBooks by Author 1:");
        author1.DisplayBooks();

        author2.AddBook(book2);
        author2.AddBook(book4);
        author2.AddBook(book6);
        Console.WriteLine("\nBooks by Author 2:");
        author2.DisplayBooks();

        author1.RemoveBook("9780439708180");
        Console.WriteLine("\nBooks by Author 1 after removing book 1:");
        author1.DisplayBooks();
    }
}
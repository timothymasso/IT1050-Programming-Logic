using System;

public class Book
{
    public string ISBN { get; set; }
    public string Title { get; set; }
    public Author AuthorInfo { get; set; }
    public DateTime PublishedOn { get; set; }
    public string PublishedBy { get; set; }

    public Book(string isbn, string title, Author authorInfo)
    {
        ISBN = isbn;
        Title = title;
        AuthorInfo = authorInfo;
        PublishedOn = DateTime.Now;
        PublishedBy = "Unknown";
    }

    public Book(string isbn, string title, Author authorInfo, DateTime publishedOn, string publishedBy)
    {
        ISBN = isbn;
        Title = title;
        AuthorInfo = authorInfo;
        PublishedOn = publishedOn;
        PublishedBy = publishedBy;
    }

    public void Display()
    {
        Console.WriteLine($"Book '{Title}' was written by {AuthorInfo.Name} and published on {PublishedOn.ToShortDateString()}");
    }
}

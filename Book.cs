namespace NetDev;

public class Book
{
    public string title { get; set; }
    public string author { get; set; }
    public int year { get; set; }
    public bool isBorrowed { get; set; }

    public Book(string title, string author, int year)
    {
        this.title = title;
        this.author = author;
        this.year = year;
        this.isBorrowed = false;
    }

    public override string ToString()
    {
        return $"{title} by {author} ({year}) - {(isBorrowed ? "Borrowed" : "Available")}";
    }
}
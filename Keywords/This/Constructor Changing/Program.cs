public class Book
{
    private string title;
    private string author;

    public Book(string title) : this(title, "Unknown")
    {

    }

    public Book(string title, string author)
    {
        this.title = title;
        this.author = author;
    }

    public void Show()
    {
        Console.WriteLine($"Title: {title}, Author: {author}");
    }

    public static void Main()
    {
        Book b = new Book("C# Basic");
        b.Show();
    }
}
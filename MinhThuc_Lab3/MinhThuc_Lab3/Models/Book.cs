namespace MinhThuc_Lab3.Models;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    public DateTime PublishedDate { get; set; }
    public string Genre { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }

    public string FormattedPublishedDate => PublishedDate.ToString("dd/MM/yyyy");

    public Book(int id, string title, string author, string publisher, DateTime publishedDate, string genre, string description, string imageUrl)
    {
        Id = id;
        Title = title;
        Author = author;
        Publisher = publisher;
        PublishedDate = publishedDate;
        Genre = genre;
        Description = description;
        ImageUrl = imageUrl;
    }


}
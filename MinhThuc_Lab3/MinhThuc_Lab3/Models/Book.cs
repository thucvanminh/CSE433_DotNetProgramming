using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MinhThuc_Lab3.Models;

public class Book
{
    [Key]
    public int BookId { get; set; }

    [Required]
    [StringLength(200)]
    public string Title { get; set; }

    public string Description { get; set; }

    public string BookCode { get; set; }

    public string Publisher { get; set; }

    public DateTime PublishedYear { get; set; }

    [ForeignKey("Category")]
    public int CategoryId { get; set; }

    [ForeignKey("Author")]
    public int AuthorId { get; set; }

    public int TotalCopies { get; set; }

    public int AvailableCopies { get; set; }

    public DateTime CreatedDate { get; set; }

    public string Avatar { get; set; }

    public string Pdf { get; set; }

    public virtual Category Category { get; set; }
    public virtual Author Author { get; set; }
    public virtual ICollection<Loan> Loans { get; set; }
}
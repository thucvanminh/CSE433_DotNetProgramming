namespace VanMinhThuc_2031200067_Lab2.Models;

public class BorrowTransaction : Transaction
{
    public Book BookBorrowed { get; set; }
    
    public override void Execute()
    {
        if(BookBorrowed.CopiesAvailable >0)
        {
            BookBorrowed.CopiesAvailable--;
            Console.WriteLine($"Book '{BookBorrowed.Title}' borrowed successfully.");
        }
        else
        {
            Console.WriteLine($"Cannot borrow {BookBorrowed.Title}");
        }
    }
}
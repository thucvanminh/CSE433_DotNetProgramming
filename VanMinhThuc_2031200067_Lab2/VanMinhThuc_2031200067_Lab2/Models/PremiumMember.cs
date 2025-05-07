namespace VanMinhThuc_2031200067_Lab2.Models;

public class PremiumMember : Member
{
    private DateTime _membershipDate;
    private int _maxBooksAllowed;

    public DateTime MembershipDate
    {
        get { return _membershipDate; }
        set { _membershipDate = value; }
    }
    public int MaxBooksAllowed
    {
        get { return _maxBooksAllowed; }
        set { _maxBooksAllowed = value; }
    }

    // public PremiumMember(string memberid, string name, string email, DateTime membershipDate, int maxBooksAllowed) :
    //     base(memberid, name, email)
    // {
    //     _membershipDate = membershipDate;
    //     _maxBooksAllowed = maxBooksAllowed;
    // }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Membership Date: {_membershipDate.ToShortDateString()} \n " +
                          $"Max Books Allowed: {_maxBooksAllowed}");
    }
    public override void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine($"Membership Expire: {MembershipDate.ToShortDateString()}, Max Books Allowed: {MaxBooksAllowed}");
    }
    public override void BorrowBook(Book book)
    {
        if(book.CopiesAvailable > 0 && MaxBooksAllowed > 0)
        {
            MaxBooksAllowed--;
            book.CopiesAvailable--;
            Console.WriteLine($"Book '{book.Title}' borrowed successfully.");
        }
        else
        {
            Console.WriteLine($"Cannot borrow {book.Title}");
        }
    }
    
   
}
using System.Runtime.InteropServices.JavaScript;
using VanMinhThuc_2031200067_Lab2.Interfaces;

namespace VanMinhThuc_2031200067_Lab2.Models;

public class Member : IPrintable ,IMemberAction
{
   

    // public Member(string memberId, string name, string email)
    // {
    //   MemberId = memberId;
    //     Name = name;
    //     Email = email;
    // }
    public Member() { }



    public string MemberId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Member ID: {MemberId} \n Name: {Name} \n Email: {Email}");
    }

    public virtual void PrintDetails()
    {
        Console.WriteLine($"Member ID: {MemberId} \n Name: {Name} \n Email: {Email}");
    }

    public virtual void BorrowBook(Book book)
    {

        if (book.CopiesAvailable > 0)
        {
            book.CopiesAvailable--;
            Console.WriteLine($"Book '{book.Title}' borrowed successfully.");
        }
        else
        {
            Console.WriteLine($"No copies of '{book.Title}' available for borrowing.");
        }
    }

    public virtual void ReturnBook(Book book)
    {
        book.CopiesAvailable++;
        Console.WriteLine($"Book '{book.Title}' returned successfully.");
    }
}
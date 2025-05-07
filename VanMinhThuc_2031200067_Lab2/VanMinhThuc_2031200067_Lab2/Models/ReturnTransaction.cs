namespace VanMinhThuc_2031200067_Lab2.Models;

public class ReturnTransaction : Transaction 
{ 
    public Book BookReturned { get; set; } 
 
    public override void Execute() 
    { 
        BookReturned.CopiesAvailable++; 
        Console.WriteLine($"{Member.Name} has returned '{BookReturned.Title}'."); 
    } 
} 
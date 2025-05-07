namespace VanMinhThuc_2031200067_Lab2.Models;

public class NotificationServiceHandler 
{ 
    public void SendBorrowNotification(Book book, Member member) 
    { 
        Console.WriteLine($"Notification: {member.Name} has borrowed '{book.Title}'."); 
    } 
 
    public void LogBorrowActivity(Book book, Member member) 
    { 
        Console.WriteLine($"Log: {member.Name} borrowed '{book.Title}' on {DateTime.Now}."); 
    } 
} 
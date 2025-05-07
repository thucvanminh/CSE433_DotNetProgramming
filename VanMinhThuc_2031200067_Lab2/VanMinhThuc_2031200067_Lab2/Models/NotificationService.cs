namespace VanMinhThuc_2031200067_Lab2.Models;

public class NotificationService 
{ 
    public virtual void SendNotification(string message) 
    { 
        Console.WriteLine($"Notification: {message}"); 
    } 
 
    public void SendNotification(string message, string recipient) 
    { 
        Console.WriteLine($"Notification to {recipient}: {message}"); 
    } 
 
    public void SendNotification(string message, List<string> recipients) 
    { 
        foreach (var recipient in recipients) 
        { 
            Console.WriteLine($"Notification to {recipient}: {message}"); 
        } 
    } 
}
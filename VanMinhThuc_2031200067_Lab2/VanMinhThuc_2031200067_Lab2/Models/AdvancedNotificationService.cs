namespace VanMinhThuc_2031200067_Lab2.Models;

public class AdvancedNotificationService : NotificationService 
{ 
    public override void SendNotification(string message) 
    { 
        Console.WriteLine($"[{DateTime.Now}] Advanced Notification: {message}"); 
    } 
}
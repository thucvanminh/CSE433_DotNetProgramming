using VanMinhThuc_2031200067_Lab2.Models;
public class Program 
{ 
    public static void Main(string[] args) 
    { 
        // Initialize Library 
        Library library = new Library("Central Library"); 
 
        // Add Books 
        library.AddBook(new Book { ISBN = "ISBN001", Title = "C# Programming", Author = "Author A", Year = 
2020, CopiesAvailable = 5 }); 
        library.AddBook(new Book { ISBN = "ISBN002", Title = "OOP Concepts", Author = "Author B", Year = 
2018, CopiesAvailable = 2 }); 
 
        // Add Members 
        Member member1 = new Member { MemberId = "M001", Name = "Alice", Email = "alice@example.com" }; 
        PremiumMember member2 = new PremiumMember { MemberId = "M002", Name = "Bob", Email = 
"bob@example.com", MembershipDate = DateTime.Now.AddYears(1), MaxBooksAllowed = 10 }; 
        library.AddMember(member1); 
        library.AddMember(member2); 
 
        // Create LibraryCard 
        LibraryCard card1 = new LibraryCard("C001", member1); 
        LibraryCard card2 = new LibraryCard("C002", member2); 
 
        card1.PrintCardDetails(); 
        card2.PrintCardDetails(); 
 
        // Renew Library Card 
        card1.RenewCard(); 
 
        // Create and Handle Transactions 
        TransactionHandler transactionHandler = new TransactionHandler(); 
        transactionHandler.HandleTransactions(); 
 
        // Setup Notification Service 
        NotificationServiceHandler notificationHandler = new NotificationServiceHandler(); 
        library.OnBookBorrowed += notificationHandler.SendBorrowNotification; 
        library.OnBookBorrowed += notificationHandler.LogBorrowActivity; 
 
        // Borrow a Book 
        library.BorrowBook("ISBN001", "M001"); 
 
        // Demonstrate Overloading and Overriding 
        NotificationService basicService = new NotificationService(); 
        AdvancedNotificationService advancedService = new AdvancedNotificationService(); 
 
        // Call overloaded methods 
        basicService.SendNotification("Welcome to the library!"); 
        basicService.SendNotification("Your book is due tomorrow.", "Alice"); 
        basicService.SendNotification("Library meeting at 5 PM.", new List<string> { "Bob", "Charlie" }); 
 
        // Call overridden method 
        advancedService.SendNotification("System maintenance tonight."); 
 
        // Compare Class and Record 
        BookClass bookClass1 = new BookClass("ISBN123", "C# Basics", "Author A"); 
        BookClass bookClass2 = new BookClass("ISBN123", "C# Basics", "Author A"); 
 
        BookRecord bookRecord1 = new BookRecord("ISBN123", "C# Basics", "Author A"); 
        BookRecord bookRecord2 = new BookRecord("ISBN123", "C# Basics", "Author A"); 
 
        // Compare using == 
        Console.WriteLine(bookClass1 == bookClass2); // False 
        Console.WriteLine(bookRecord1 == bookRecord2); // True 
 
        // Use with to create a copy 
        var bookRecord3 = bookRecord1 with { Title = "Advanced C#" }; 
        Console.WriteLine(bookRecord3); // BookRecord { ISBN = ISBN123, Title = Advanced C#, Author = Author A } 
    } 
} 

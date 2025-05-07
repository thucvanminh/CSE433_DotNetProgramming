namespace VanMinhThuc_2031200067_Lab2.Models;

public class TransactionHandler 
{ 
    public void HandleTransactions() 
    { 
        List<Transaction> transactions = new List<Transaction>(); 
 
        // Create members 
        Member member1 = new Member { MemberId = "M001", Name = "Alice", Email = "alice@example.com" }; 
        PremiumMember member2 = new PremiumMember { MemberId = "M002", Name = "Bob", Email = 
            "bob@example.com", MembershipDate = DateTime.Now.AddYears(1), MaxBooksAllowed = 10 }; 
 
        // Create books 
        Book book1 = new Book { ISBN = "ISBN001", Title = "C# Programming", Author = "Author A", Year = 
            2020, CopiesAvailable = 5 }; 
        Book book2 = new Book { ISBN = "ISBN002", Title = "OOP Concepts", Author = "Author B", Year = 2018, 
            CopiesAvailable = 2 }; 
 
        // Create borrow and return transactions 
        BorrowTransaction borrow1 = new BorrowTransaction 
        { 
            TransactionId = "T001", 
            TransactionDate = DateTime.Now, 
            Member = member1, 
            BookBorrowed = book1 
        }; 
 
        ReturnTransaction return1 = new ReturnTransaction 
        { 
            TransactionId = "T002", 
            TransactionDate = DateTime.Now, 
            Member = member1, 
            BookReturned = book1 
        }; 
 
        transactions.Add(borrow1); 
        transactions.Add(return1); 
 
        // Execute transactions 
        foreach (var transaction in transactions) 
        { 
            transaction.Execute(); 
        } 
    } 
} 

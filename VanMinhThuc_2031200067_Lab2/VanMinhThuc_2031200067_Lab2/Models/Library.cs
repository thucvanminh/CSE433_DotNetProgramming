namespace VanMinhThuc_2031200067_Lab2.Models;

public class Library 
{ 
    public string LibraryName { get; set; } 
    public List<Book> Books { get; set; } 
    public List<Member> Members { get; set; } 
 
    // Event when a book is borrowed 
    public event Action<Book, Member> OnBookBorrowed; 
 
    public Library(string libraryName) 
    { 
        LibraryName = libraryName; 
        Books = new List<Book>(); 
        Members = new List<Member>(); 
    } 
 
    public void AddBook(Book book) 
    { 
        Books.Add(book); 
    } 
 
    public void AddMember(Member member) 
    { 
        Members.Add(member); 
    } 
 
    public void BorrowBook(string isbn, string memberId) 
    { 
        var book = Books.FirstOrDefault(b => b.ISBN == isbn); 
        var member = Members.FirstOrDefault(m => m.MemberId == memberId); 
 
        if (book != null && member != null && book.CopiesAvailable > 0) 
        { 
            member.BorrowBook(book); 
            OnBookBorrowed?.Invoke(book, member); 
        } 
        else 
        { 
            Console.WriteLine("Cannot borrow the book."); 
        } 
    } 
 
    public void ReturnBook(string isbn, string memberId) 
    { 
        var book = Books.FirstOrDefault(b => b.ISBN == isbn); 
        var member = Members.FirstOrDefault(m => m.MemberId == memberId); 
 
        if (book != null && member != null) 
        { 
            member.ReturnBook(book); 
        } 
        else 
        { 
            Console.WriteLine("Cannot return the book."); 
        } 
    } 
} 

namespace VanMinhThuc_2031200067_Lab2.Interfaces;
using Models;

public interface IMemberAction
{
    void BorrowBook(Book book);
    void ReturnBook(Book book);
}
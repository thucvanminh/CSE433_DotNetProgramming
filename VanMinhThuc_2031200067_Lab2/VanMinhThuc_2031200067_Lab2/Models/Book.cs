namespace VanMinhThuc_2031200067_Lab2.Models;

public class Book
{
    private string _isbn;
    private string _title;
    private string _author;
    private int _year;
    private int _copiesAvailable;


    public Book(string isbn, string title, string author, int year, int copiesAvailable)
    {
        _isbn = isbn;
        _title = title;
        _author = author;
        _year = year;
        _copiesAvailable = copiesAvailable;
    }

    public string ISBN
    {
        get { return _isbn; }
        set { _isbn = value; }
    }

    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }

    public string Author
    {
        get { return _author; }
        set { _author = value; }
    }

    public int Year
    {
        get { return _year; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Year cannot be nagative");
            }
            else
            {
                _year = value;
            }
        }
    }

    public int CopiesAvailable
    {
        get { return _copiesAvailable; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Copies Available cannot be nagative");
            }
            else
            {
                _copiesAvailable = value;
            }
        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine(
            $"ISBN: {_isbn} \n Title: {_title} \n Author: {_author} \n Year: {_year} \n Copies Available: {_copiesAvailable}");
    }
}
using System.Runtime.InteropServices.JavaScript;

namespace VanMinhThuc_2031200067_Lab2.Models;

public class Member
{
    private string _memberId;
    private string _name;
    private string _email;

    public Member(string memberId, string name, string email)
    {
        _memberId = memberId;
        _name = name;
        _email = email;
    }


    public string MemberId
    {
        get { return _memberId; }
        set { _memberId = value; }
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Email
    {
        get { return _email; }
        set { _email = value; }
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Member ID: {_memberId} \n Name: {_name} \n Email: {_email}");
    }
}
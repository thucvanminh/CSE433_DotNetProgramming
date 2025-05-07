namespace VanMinhThuc_2031200067_Lab2.Models;

public abstract class Transaction
{
    public string TransactionId { get; set; }
    public DateTime TransactionDate { get; set; }
    public Member Member { get; set; }

    public abstract void Execute();

}
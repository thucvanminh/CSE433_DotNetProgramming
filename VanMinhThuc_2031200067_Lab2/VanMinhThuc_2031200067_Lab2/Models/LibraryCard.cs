﻿namespace VanMinhThuc_2031200067_Lab2.Models;

public class LibraryCard 
{ 
    public string CardNumber { get; private set; } 
    public Member Owner { get; set; } 
    public DateTime IssueDate { get; private set; } 
 
    public LibraryCard(string cardNumber, Member owner) 
    { 
        CardNumber = cardNumber; 
        Owner = owner; 
        IssueDate = DateTime.Now; 
    } 
 
    public void RenewCard() 
    { 
        IssueDate = DateTime.Now; 
        Console.WriteLine($"Library card {CardNumber} has been renewed on {IssueDate.ToShortDateString()}."); 
    } 
 
    public void PrintCardDetails() 
    { 
        Console.WriteLine($"Card Number: {CardNumber}, Owner: {Owner.Name}, Issue Date: {IssueDate.ToShortDateString()}");
    } 
} 
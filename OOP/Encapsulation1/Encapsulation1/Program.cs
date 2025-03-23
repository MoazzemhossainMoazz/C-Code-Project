using System;

//Top level Statement
var ba = new BankAccount();
ba.DisplayBalance();


public class BankAccount
{
    private double balance;

    public double Balance
    {
        get { return balance; }
        private set { balance = value; }
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && Balance >= amount)
        {
            Balance -= amount;
        }
    }

    public void DisplayBalance()
    {
        
        
        Console.WriteLine("Balance: " + Balance);
    }
}
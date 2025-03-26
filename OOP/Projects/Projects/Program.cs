using System;
using System.Collections.Generic;

namespace BankSystem
{
    abstract class BankAccount
    {
        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        protected decimal Balance { get; set; }

        public BankAccount(string accNumber, string accHolder, decimal balance)
        {
            AccountNumber = accNumber;
            AccountHolder = accHolder;
            Balance = balance;
        }

        public abstract void Deposit(decimal amount);
        public abstract bool Withdraw(decimal amount);
        public void DisplayBalance()
        {
            Console.WriteLine($"Account number:{AccountNumber}, Balance:{Balance:C}");
        }
    }
}

namespace BankSystem
{
    class SavingsAccount: BankAccount
    {
        private decimal interestRate = 0.05m;

        public SavingsAccount(string accNumber, string accHolder, decimal balance) : base(accNumber, accHolder, balance) { }

        public override void Deposit(decimal amount)
        {
            Balance += amount + (amount * interestRate);
            Console.WriteLine($"Deposited {amount:C} with interest. New Balance: {Balance:C}");
        }

        public override bool Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn {amount:C}. Remaining Balance: {Balance:C}");
                return true;
            }
            Console.WriteLine("Insufficient balance!");
            return false;
        }
    }

    class CurrentAccount : BankAccount
    {
        private decimal overdraftLimit = 500m;

        public CurrentAccount(string accNumber, string accHolder, decimal balance) : base(accNumber, accHolder, balance) { }
        public override void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount:C}. New Balance: {Balance:C}");
        }

        public override bool Withdraw(decimal amount)
        {
            if(Balance + overdraftLimit >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn {amount:C}. Remaining Balance: {Balance:C}");
                return true;
            }
            Console.WriteLine("Overdraft limit exceeded!");
            return false;
        }
    }
}

namespace BankSystem
{
    class Bank
    {
        private List<BankAccount> accounts = new List<BankAccount>();

        public void AddAccount(BankAccount account)
        {
            accounts.Add(account);
            Console.WriteLine("Account Create Successfully");
        }

        public BankAccount GetAccount(string accNumber)
        {
            return accounts.Find(acc => acc.AccountNumber == accNumber);
        }

        public void DisplayAccount()
        {
            Console.WriteLine("\nBank Accounts:");
            foreach(var acc in accounts)
            {
                Console.WriteLine($"Account number: {acc.AccountNumber}, Holder: {acc.AccountHolder}");
            }
        }
    }
}

namespace BankSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            while (true)
            {
                Console.WriteLine("\n-- Bank Mangement System --");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Check Balance");
                Console.WriteLine("5. Show All Accounts");
                Console.WriteLine("6. Exit");
                Console.WriteLine("Enter your choice; ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Account Number: ");
                        string accNum = Console.ReadLine();
                        Console.Write("Enter Account Holder Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Initial Balance: ");
                        decimal balance = Convert.ToDecimal(Console.ReadLine());
                        Console.Write("Account type (Savings/Current): ");
                        string accType = Console.ReadLine().ToLower();

                        if (accType == "savings")
                            bank.AddAccount(new SavingsAccount(accNum, name, balance));
                        else if (accType == "current")
                            bank.AddAccount(new CurrentAccount(accNum, name, balance));
                        else
                            Console.WriteLine("Invalid Account Type!");
                        break;

                    case 2:
                        Console.Write("Enter Account Number: ");
                        accNum = Console.ReadLine();
                        var account = bank.GetAccount(accNum);
                        if (account != null)
                        {
                            Console.WriteLine("Enter Deposit Amount: ");
                            decimal amount = Convert.ToDecimal(Console.ReadLine());
                            account.Deposit(amount);
                        }
                        else
                            Console.WriteLine("Account not founf!");
                        break;

                    case 3:
                        Console.Write("Enter Account Number: ");
                        accNum = Console.ReadLine();
                        account = bank.GetAccount(accNum);
                        if (account != null)
                        {
                            Console.Write("Enter Withdraw Amount: ");
                            decimal amount = Convert.ToDecimal(Console.ReadLine());
                            account.Withdraw(amount);
                        }
                        else
                            Console.WriteLine("Account not foud!");
                        break;

                    case 4:
                        Console.Write("Enter Account Number: ");
                        accNum = Console.ReadLine();
                        account = bank.GetAccount(accNum);
                            if (account != null)
                            account.DisplayBalance();
                        else
                            Console.WriteLine("Account not found");
                        break;

                    case 5:
                        bank.DisplayAccount();
                        break;

                    case 6:
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid Choice! Try again");
                        break;
                }
            }
        }
    }
}

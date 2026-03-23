using System;

class Account
{
    protected int accountNumber;
    protected string accountHolder;
    protected double balance;

    public Account(int accNo, string holder, double bal)
    {
        accountNumber = accNo;
        accountHolder = holder;
        balance = bal;
    }

    public void Deposit(double amount)
    {
        balance += amount;
    }

    public virtual void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient balance");
        }
    }

    public void Display()
    {
        Console.WriteLine($"Account No: {accountNumber}, Name: {accountHolder}, Balance: {balance}");
    }
}

class SavingsAccount : Account
{
    private double interestRate;

    public SavingsAccount(int accNo, string holder, double bal, double rate)
        : base(accNo, holder, bal)
    {
        interestRate = rate;
    }

    public void AddInterest()
    {
        balance += balance * interestRate / 100;
    }

    public override void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
        }
        else
        {
            Console.WriteLine("Savings: Insufficient balance");
        }
    }
}

class CurrentAccount : Account
{
    private double overdraftLimit;

    public CurrentAccount(int accNo, string holder, double bal, double limit)
        : base(accNo, holder, bal)
    {
        overdraftLimit = limit;
    }

    public override void Withdraw(double amount)
    {
        if (amount <= balance + overdraftLimit)
        {
            balance -= amount;
        }
        else
        {
            Console.WriteLine("Current: Overdraft limit exceeded");
        }
    }
}

class Program
{
    static void Main()
    {
        SavingsAccount sa = new SavingsAccount(101, "Abhinash", 5000, 5);
        sa.Deposit(1000);
        sa.Withdraw(2000);
        sa.AddInterest();
        sa.Display();

        CurrentAccount ca = new CurrentAccount(102, "Gautam", 3000, 2000);
        ca.Deposit(500);
        ca.Withdraw(4500);
        ca.Display();
    }
}
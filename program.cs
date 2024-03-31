using System;

public class BankAccount
{
    // Properties
    public string AccountNumber { get; }
    public double Balance { get; private set; }
    public string Type { get; }

    // Constructors
    public BankAccount(string accountNumber, double initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
        Type = "Checking"; // Default type
    }

    public BankAccount(string accountNumber, double initialBalance, string type)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
        Type = type;
    }

    public BankAccount(string accountNumber) : this(accountNumber, 0)
    {
    }

    public BankAccount(string accountNumber, string type) : this(accountNumber, 0, type)
    {
    }

    public void Deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine($"{amount:C} is deposited into account {AccountNumber},  Your New balance: {Balance:C}");
    }

    public void Withdraw(double amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            Console.WriteLine($"{amount:C} Withdrawn from account {AccountNumber}, Your New balance: {Balance:C}");
        }
        else
        {
            Console.WriteLine("Insufficient funds. Cannot Withdraw");
        }
    }

    // Method Overloading
    public void Deposit(int amount)
    {
        Deposit((double)amount);
    }

    public void Withdraw(int amount)
    {
        Withdraw((double)amount);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating different types of accounts using different constructors
        BankAccount checkingAccount = new BankAccount("9013247", 1500.0);
        BankAccount savingAccount = new BankAccount("445690", 600.0, "Savings");

        // Depositing and withdrawing from accounts
        checkingAccount.Deposit(600);
        checkingAccount.Withdraw(400);

        savingAccount.Deposit(100);
        savingAccount.Withdraw(50);
        Console.ReadLine();
    }
}
namespace OOPPrinciplesPolymorphismAbstractionInterfaces;

public abstract class BankAccount 
{
    public string AccountNumber { get; set; }
    public double Balance { get; protected set; }

    public BankAccount(string accountNumber, double initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposit amount: {amount}. New Balance: {Balance}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    public abstract void Withdraw(double amount);
}
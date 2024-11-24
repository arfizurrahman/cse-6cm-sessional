namespace OOPPrinciplesApp2;

public class BankAccount 
{
    public string AccountNumber { get; set; }
    public double Balance { get; protected set; }

    public BankAccount(string accountNumber, double initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }

    public virtual void Deposit(double amount)
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

    public double GetBalance() => Balance;
    
    public virtual void Withdraw(double amount){
        if(amount <= Balance){
            Balance -= amount;
            Console.WriteLine($"Withdaw amount: {amount}. Remaining Balance: {Balance}");
        }else{
            Console.WriteLine("Insufficient funds");
        }
    }
}
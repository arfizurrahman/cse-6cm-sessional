namespace OOPPrinciplesApp;

public class BankAccount
{
    private double balance;
    private string accountNumber;

    public string AccountHolder { get; set; }

    public BankAccount(string accountHolder, string accountNumber, double initialBalance){
        AccountHolder = accountHolder;
        this.accountNumber = accountHolder;
        balance = initialBalance > 0 ? initialBalance : 0;
    }

    public double GetBalance(){
        return balance;
    }

    public void Deposit(double amount)
    {
        if(amount > 0){
            balance += amount;
            Console.WriteLine($"Deposited amount {amount}, New balance: {balance}");
        }else{
            Console.WriteLine("Deposited amount must be positive.");
        }
    }

    public void Withdraw(double amount)
    {
        if(amount > 0 && amount <= balance){
            balance -= amount;
            Console.WriteLine($"Withdrew amount: {amount}, New balance: {balance}");
        }else{
            Console.WriteLine("Invalid withdrawl amount.");
        }
    }
}

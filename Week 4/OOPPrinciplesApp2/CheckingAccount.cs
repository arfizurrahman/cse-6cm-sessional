namespace OOPPrinciplesApp2;

public class CheckingAccount : BankAccount
{
    public double OverdrafLimit { get; set; }

    public CheckingAccount(string accountNumber, double initialBalance, double overdraftLimit)
    : base(accountNumber,initialBalance)
    {
        OverdrafLimit = overdraftLimit;
    }

    public override void Withdraw(double amount)
    {
        if(amount <= Balance + OverdrafLimit)
        {
            Balance += amount;
            Console.WriteLine($"Withdraw amount: {amount}, Remaining Balance: {Balance}");
        }else{
            Console.WriteLine("Overdraft limit exceeded");
        }
    }

}
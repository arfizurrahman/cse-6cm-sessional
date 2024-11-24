namespace OOPPrinciplesApp;

public class CheckingAccount : BankAccount
{
    public double OverdraftLimit {get; private set;}

    public CheckingAccount(string accountHolder, string accountNumber, double initialBalance, double overdraftLimit)
    : base(accountHolder,accountNumber,initialBalance)
    {
        OverdraftLimit = overdraftLimit;
    }

    public new void Withdraw(double amount)
    {
        if(amount > 0 && amount <= GetBalance() + OverdraftLimit){
            base.Withdraw(amount);
        }else{
            Console.WriteLine("Exceeds overdraft limit");
        }
    }
}
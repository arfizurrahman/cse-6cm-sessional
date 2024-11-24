namespace OOPPrinciplesApp;

public class SavingsAccount : BankAccount 
{
    public double InterestRate { get; private set; }

    public SavingsAccount(string accountHolder, string accountNumber, double initialBalance, double interestRate)
    : base(accountHolder,accountNumber,initialBalance)
    {
        InterestRate = interestRate;
    }

    public void ApplyInterest(){
        double interest = GetBalance() * InterestRate;
        Deposit(interest);
        Console.WriteLine($"Interest of {interest} applied");
    }
}


namespace OOPPrinciplesApp2;
public class SavingsAccount : BankAccount
{
    public double InterestRate { get; set; }
    

    public SavingsAccount(string accountNumber, double initialBalance, double interestRate)
    :base(accountNumber,initialBalance)
    {
        InterestRate = interestRate;
    }

    public void ApplyInterest()
    {
        Balance += Balance * InterestRate;
        Console.WriteLine($"Interest Applied. New Balance: {Balance}");
    }

    public override void Withdraw(double amount)
    {
        if(amount <= Balance * 0.8)
        {
            base.Withdraw(amount);
        }
        else{
            Console.WriteLine("Cannot withdraw more than 80% of the balance in Savings Account");
        }
    }
}

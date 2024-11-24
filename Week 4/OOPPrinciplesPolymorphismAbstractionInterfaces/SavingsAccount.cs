

namespace OOPPrinciplesPolymorphismAbstractionInterfaces;
public class SavingsAccount : BankAccount, ITransaction
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
            Balance -= amount;
            Console.WriteLine($"Windrawal amount: {amount}. Remaining Balance: {Balance}");
        }
        else{
            Console.WriteLine("Cannot withdraw more than 80% of the balance in Savings Account");
        }
    }

    public void TransferFunds(BankAccount targetAccount, double amount)
    {
        if(Balance >= amount){
            Withdraw(amount);
            targetAccount.Deposit(amount);
            Console.WriteLine($"Transfered amount: {amount} to {targetAccount.AccountNumber}");
        }else{
            Console.WriteLine("Insufficient funds");
        }
    }
}

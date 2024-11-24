using OOPPrinciplesApp2;
class Program
{
    static void Main(string[] args)
    {
        BankAccount savings = new SavingsAccount("S1001",1000,0.1);
        BankAccount checking = new CheckingAccount("C1001",500, 200);

        savings.Withdraw(600);
        checking.Withdraw(700);

        SavingsAccount savingsAccount = (SavingsAccount)savings;

        Console.WriteLine($"Savings Balance is: {savings.Balance}");
        savingsAccount.ApplyInterest();
        Console.WriteLine($"After Interest Savings Balance is: {savings.Balance}");
    }

    static int Add(int a, int b){
        return a + b;
    }

    static int Add(int a, int b, int c){
        return a + b;
    }
}

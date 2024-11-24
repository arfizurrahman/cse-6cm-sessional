namespace OOPPrinciplesPolymorphismAbstractionInterfaces;

public interface ITransaction
{
    void TransferFunds(BankAccount targetAccount, double amount);
}

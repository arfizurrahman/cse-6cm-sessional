
using OOPPrinciplesPolymorphismAbstractionInterfaces;

SavingsAccount savingsAccount1 = new SavingsAccount("1001",1000,0.1);
SavingsAccount savingsAccount2 = new SavingsAccount("1002",1000,0.1);

savingsAccount1.TransferFunds(savingsAccount2,200);

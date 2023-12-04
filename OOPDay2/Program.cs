using OOPDay2;

Console.WriteLine("Welcome to banking system");

Customer c1 = new Customer()
{ Name = "Mg Mg", NRC = "12/DAKANA(N)3453454", PhoneNo = "093423432", Address = "Yangon" };

BankAccount bankAccount1 = new BankAccount()
{
    AccountName = "U Mg Mg",
    AccountNumber = "001122334455",
    OpeningBalance = 300000
};
c1.BankAccount = bankAccount1;
bankAccount1.CheckBalance();
c1.ShowInfo();

Customer c2 = new Customer()
{
    Name = "Su Su",
    NRC = "12/DAKANA(N)3453454",
    PhoneNo = "093423432",
    Address = "Yangon",
    BankAccount = new BankAccount()
    {
        AccountName = "Daw Su Su",
        AccountNumber = "0010203044",
        OpeningBalance = 300000
    }
};

c2.BankAccount.CheckBalance();
c2.BankAccount.Deposit(c2.BankAccount, 100000);
c2.BankAccount.CheckBalance();

bankAccount1.Transfer(bankAccount1, c2.BankAccount, 200000);
bankAccount1.CheckBalance();
c2.BankAccount.CheckBalance();
c2.BankAccount.Topup("09232947", 20000);
c2.BankAccount.CheckBalance();
ILoanOperation loanOperation = new LoanOperationService(c2.BankAccount);
loanOperation.HomeLoan(10000, DateTime.Now);
loanOperation.LoanInstallment(10000, "homeloan");
c2.BankAccount.CheckBalance();



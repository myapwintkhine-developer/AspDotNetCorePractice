using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDay2
{
    public abstract class BankOperations
    {
        public abstract void Deposit(BankAccount bankAccount,decimal amount);
        public abstract void Withdraw(BankAccount bankAccount,decimal amount);
        public abstract void Transfer(BankAccount fromBankAccount, BankAccount toBankAccount,decimal amount);
        public abstract void CheckBalance();
    }
}

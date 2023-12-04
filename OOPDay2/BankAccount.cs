using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPDay2
{
    public class BankAccount:BankOperations,IATMOperation
    {
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public decimal OpeningBalance { get; set; }

 

        public void ShowInfo()
        {
            Console.WriteLine($"AccountNumber: {AccountNumber}; AccountName: {AccountName}; OpeningBalance: {OpeningBalance}");
        }

        public override void Deposit(BankAccount bankAccount, decimal amount)
        {
            CheckValidAmount( amount );
            if(bankAccount.AccountName.Equals( this.AccountName)) {
                this.OpeningBalance += amount;
                Console.WriteLine("Deposit success");
            }
        }

        public override void Transfer(BankAccount fromBankAccount, BankAccount toBankAccount, decimal amount)
        {
            CheckValidAmount(amount);
            if (amount > fromBankAccount.OpeningBalance)
            {
                Console.WriteLine("You don't have enough money to transfer. Current amount is " + fromBankAccount.OpeningBalance);
            }
            else
            {
                toBankAccount.OpeningBalance += amount;
                fromBankAccount.OpeningBalance -= amount;
                Console.WriteLine("Transfer success");
            }
            
        }

        public override void Withdraw(BankAccount bankAccount, decimal amount)
        {
            CheckValidAmount(amount);
            if (amount>bankAccount.OpeningBalance)
            {
                Console.WriteLine("You don't have enough money. Current amount is " + bankAccount.OpeningBalance);
            }
            else
            {
                bankAccount.OpeningBalance -= amount;
                Console.WriteLine("Withdraw successful! Current amount is "+bankAccount.OpeningBalance);
            }
        }

        private void CheckValidAmount(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Invalid amount");
        }

        public override void CheckBalance()
        {
            Console.WriteLine("Current Balance is "+this.OpeningBalance);
        }

        public void Topup(string phoneNumber, decimal amount)
        {
            if (amount > this.OpeningBalance)
                Console.WriteLine("You don't have enough money");
            else if (!string.IsNullOrEmpty(phoneNumber))
            {
                Console.WriteLine($"{phoneNumber} is topuped successfully with {amount} kyats");
                this.OpeningBalance -= amount;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDay2
{
    public class LoanOperationService : ILoanOperation
    {
        private readonly BankAccount _bankAccount;
        public LoanOperationService(BankAccount bankAccount)
        {
            this._bankAccount = bankAccount;
        }
        public void HomeLoan(decimal loanAmount, DateTime loanDate)
        {
            Console.WriteLine("Home loan success");
            Console.WriteLine("You loan at " + loanDate);
        }

        public void LoanInstallment(decimal installAmount, string loanType)
        {
            if (loanType.Equals("homeloan"))
            {
                Console.WriteLine("Home lone installment is paid with amount" + installAmount);
                _bankAccount.OpeningBalance -= installAmount;
            }
            else if(loanType.Equals("smeloan"))
            {
                Console.WriteLine("SME lone installment is paid with amount" + installAmount);
                _bankAccount.OpeningBalance -= installAmount;
            }
            else if (loanType.Equals("vehicleloan"))
            {
                Console.WriteLine("Vehicle lone installment is paid with amount" + installAmount);
                _bankAccount.OpeningBalance -= installAmount;
            }

        }

        public void SMELoan(string companyLicenseNo, DateTime loanDate)
        {
            if(!string.IsNullOrEmpty(companyLicenseNo))
            {
                Console.WriteLine("loan success for "+companyLicenseNo);
                Console.WriteLine("You loan at " + loanDate);
            }
        }

        public void VehicleLoan(decimal loanAmount, DateTime loanDate)
        {
            Console.WriteLine("Vehicle loan success");
            Console.WriteLine("You loan at " + loanDate);
        }
    }
}

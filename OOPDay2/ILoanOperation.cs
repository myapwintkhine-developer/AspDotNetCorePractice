using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDay2
{
    public interface ILoanOperation
    {
        void HomeLoan(decimal loanAmount, DateTime loanDate);
        void SMELoan(string companyLicenseNo, DateTime loanDate);
        void VehicleLoan(decimal loanAmount,DateTime loanDate);
        void LoanInstallment(decimal installAmount, string loanType);
    }
}

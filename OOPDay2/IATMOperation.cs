﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDay2
{
    public interface IATMOperation
    {
        void Withdraw(BankAccount bankAccount, decimal amount);
        void CheckBalance();
        void Topup(string phoneNumber,decimal amount);
    }
}

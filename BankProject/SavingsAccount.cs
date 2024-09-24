using System;
using System.Collections.Generic;
using System.Text;

namespace BankProject
{
    class SavingsAccount : Account
    {
        private double montlyInterestRate;

        public SavingsAccount(string name, string address, double ir) : base(name,address)
        {
            montlyInterestRate = ir;
        }


       public override void MU()
        {
            double b = getBalance();
            double nb = montlyInterestRate * b + b;
            setBalance(nb);

           
        }
    }
}

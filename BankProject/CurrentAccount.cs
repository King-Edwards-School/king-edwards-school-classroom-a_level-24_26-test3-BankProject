using System;
using System.Collections.Generic;
using System.Text;

namespace BankProject
{
    class CurrentAccount : Account
    {
        private double montlyCharge;

        public CurrentAccount(string name, string address, double mc) : base(name,address)
        {
            montlyCharge = mc;
        }


        public override void MU()
        {
            // add interest
            double nb = getBalance() - montlyCharge;
           setBalance(nb);

        }
    }
}

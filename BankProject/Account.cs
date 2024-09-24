using System;
using System.Collections.Generic;
using System.Text;

namespace BankProject
{
    abstract class Account
    {
        private static int accountsCreated = 0;
        private int AccNo;
        private double b;
        private string name;
        private string address;

        public Account(string n, string a)
        {
            name = n;
            address = a;
            b = 0;
            AccNo = accountsCreated;
            accountsCreated++;
        }

        public static int getAccountsCreated()
        {
            return accountsCreated;
        }
        public bool withdraw(double amount)
        {
            bool success = false;
            if (b >= amount)
            {
                b = b - amount;
                success = true;
            }

            return success;
        }

           
        public double getBalance()
        {
            return b;
        }

        public void setBalance(double bb)
        {
            b = bb;
        }

        public void deposit(double amount)
        {
            b = b + amount;
        }

        public string printBalance()
        {
            return "Balance = "+ b;
        }

        public abstract void MU();
    }
}

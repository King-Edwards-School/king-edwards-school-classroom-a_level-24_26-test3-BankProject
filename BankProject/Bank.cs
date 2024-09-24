using System;
using System.Collections.Generic;
using System.Text;

namespace BankProject
{
    class Bank
    {
        private string name;
        private const int MAX_ACCOUNT = 100;
        private Account[] accounts;
      

        public Bank(string n)
        {
            name = n;
            accounts = new Account[MAX_ACCOUNT];

        }

        public int createAccount(string name, string address, string type)
        {
            int accNo=-1;

            if (Account.getAccountsCreated() < MAX_ACCOUNT)
            {
                if (type == "SA")
                {

                    accNo = Account.getAccountsCreated();
                    accounts[Account.getAccountsCreated()] = new SavingsAccount(name, address, 0.045d);

                }
                else
                {
                    accNo = = Account.getAccountsCreated();
                    accounts[Account.getAccountsCreated()] = new CurrentAccount(name, address, 10.0d);
                }
            }
            return accNo;
        }
           
            


        public bool withdraw(int a, double amount)
        {
            
            return accounts[a].withdraw(amount);

        }

        public void deposit(int a, double amount)
        {
            if (a < Account.getAccountsCreated())
            {


                accounts[a].deposit(amount);
            }
        }

        public string printBalance(int accNo)
        {
            return accounts[accNo].printBalance();

        }





    }
}

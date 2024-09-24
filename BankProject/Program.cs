using System;

namespace BankProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank b1 = new Bank("Eltham College Bank");

            int accNo = b1.addAccount("Mr Collins", "SA");
            b1.deposit(accNo, 20.00d);
            b1.update();
            b1.printBalance(accNo);
        }
    }
}

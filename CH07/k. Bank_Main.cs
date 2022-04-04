using System;
using Bank;

namespace Bank_Main
{
    class Bank_Main
    {
        static void Main(string[] args)
        {
            BankAccount a1 = new BankAccount();

            a1.SetName("kim");
            Console.WriteLine("{0}, {1}", a1.GetName(), a1.GetBalance());

            a1.Deposit(10000);
            Console.WriteLine("{0}, {1}", a1.GetName(), a1.GetBalance());

            a1.Withdraw(5000);
            Console.WriteLine("{0}, {1}", a1.GetName(), a1.GetBalance());

            a1.Withdraw(50000);
            Console.WriteLine("{0}, {1}", a1.GetName(), a1.GetBalance());
        }
    }
}

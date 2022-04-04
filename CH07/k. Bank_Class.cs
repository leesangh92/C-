using System;

namespace Bank
{
    class BankAccount
    {
        private decimal balance;
        private string name;

        public BankAccount()
        {
            name = "noName";
            balance = 0;
        }

        //메서드 추가
        public void SetName(string _name)
        {
            name = _name;
        }

        public string GetName()
        {
            return name;
        }

        public decimal GetBalance()
        {
            return balance;
        }

        public void Deposit(int money)
        {
            balance += money;
        }

        public void Withdraw(int money)
        {
            if(money > balance)
            {
                Console.WriteLine("잔액 부족 !!!, 현재 잔액 : {0}", balance);
                return;
            }
            balance -= money;
        }
    }
}

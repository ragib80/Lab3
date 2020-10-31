using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class Account
    {
        string accName;
        string accId;
        int balance;



        public Account(string AccName, string AccId, int Balance)
        {
            this.accName = AccName;
            this.accId = AccId;
            this.balance = Balance;
        }

        public void showInfo()
        {
            Console.WriteLine("Acoount name is " + accName);
            Console.WriteLine("Acoount id is " + accId);
            Console.WriteLine("Acoount balance is " + balance);


        }
        public void Deposit(int amount)
        {
            balance = balance + amount;
            Console.WriteLine("after depotist : " + amount + " your balance is : " + balance);
        }

        public void Withdraw(int amount)
        {
            balance = balance - amount;

            Console.WriteLine("after withdraw : "+amount+" your balace is : "+balance);
            if (balance < 0)
            {
               Console.WriteLine("sorry you have no amount in your account");
            }

           
        }

    }
}

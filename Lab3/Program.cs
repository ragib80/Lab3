﻿using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("ragib","18-38278-2","cse",3.9f);
            s1.ShowInfo();

            Console.WriteLine("");

            Course c1 = new Course("oriented programming 2 ", "CSC2201", 3);
            c1.ShowInfo();

            Console.WriteLine("");

            Account a1 = new Account("Mr. shahriar ", "5506", 50000);
            a1.showInfo();
            a1.Deposit(5000);
            a1.Withdraw(7000);

        }
    }
}

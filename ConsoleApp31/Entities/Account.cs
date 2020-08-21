using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp31.Entities.Exceptions;

namespace ConsoleApp31.Entities
{
    class Account
    {
        //throw 
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public Account()
        {
        }

        public void deposit(double balancee)
        {
            Balance = Balance - balancee;
            if (Balance < balancee)
            {
                throw new DomainExceptions("Not enough Balance");
            }
            Console.WriteLine("New Balance : " + Balance);
        }

        public void WithDraw(double withDraw)
        {
            if (WithDrawLimit < withDraw)
            {
                throw new DomainExceptions("The amount exceeds withdraw Limit");
            }


        }
    }
}

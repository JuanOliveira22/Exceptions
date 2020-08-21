using ConsoleApp31.Entities;
using ConsoleApp31.Entities.Exceptions;
using System;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data :");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = (Console.ReadLine());
                Console.Write("Initial Balance : ");
                double balancee = double.Parse(Console.ReadLine());
                Console.Write("Withdraw Limit : ");
                double Limit = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter amount for withdraw  :");
                double withdraw = double.Parse(Console.ReadLine());

                Account account = new Account(number, holder, balancee, Limit);
                account.WithDraw(withdraw);

                account.deposit(withdraw);






            }
            catch (DomainExceptions e)
            {
                Console.WriteLine("WithDraw Error : " + e.Message);
            }
                 

        }
    }
}

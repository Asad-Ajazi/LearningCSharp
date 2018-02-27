using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingConsole //will be used to test small sections of code.
{

    class Account
    {
        private decimal balance = 0;
        public static decimal interestCharged = 20;

        //static members can be used by static methods, non static members cannot.
        private static decimal minIncome = 10000;
        private static int minAge = 18;

        //pubilc method inside the class. allows access to private fields in main method.
        public bool WithdrawFunds(decimal amount)
        {
            if (balance < amount)
            {
                return false;
            }
            balance = balance - amount;
            return true;
        }
        //pays in funds method
        public void PayInFunds(decimal amount)
        {
            balance += amount;
        }
        //get balance method
        public decimal GetBalance()
        {
            return balance;
        }
        //a static balance for testing purposes.
        public static decimal StaticBalance()
        {
            decimal balance = 444;
            return balance;
        }
        //page 100 account allowed, static method.
        public static bool AccountAllowed(decimal income, int age)
        {
            if ((income >= minIncome) && (age >= minAge))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            //using a static method.
            if (Account.AccountAllowed(25000, 21))
            {
                Console.WriteLine("account allowed");
            }


            Account John = new Account();

            if (John.WithdrawFunds(5))
            {
                Console.WriteLine("Cash withdrawn");
            }
            else Console.WriteLine("Funds not available");
            John.PayInFunds(500);
            if (John.GetBalance() != 500)
            {
                Console.WriteLine("test failed, balance was not paid in");
            }
            else Console.WriteLine("test successful, balance was paid");
            John.PayInFunds(500);


            Console.WriteLine("Current Balance is: {0}", John.GetBalance());
            Console.WriteLine("Static method balance is {0}", Account.StaticBalance());

            Console.WriteLine("current interest charged {0}", Account.interestCharged);
            Account.interestCharged += 15;
            Console.WriteLine("new interest charged {0}", Account.interestCharged);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsStatesAndStructures
{
    //Enumeration and states 4.2.1. 
    //Enums hold a certain value that we predefine
    //use enums to gold things that have limited values.

    enum AccountState
    {
        New, Active, UnderAudit, Frozen, Closed
    }

    //struct essential acts as a database table and links fields together.
    struct Account
    {
        public AccountState State;
        public string Name;
        public string Address;
        public int AccountNumber;
        public int Balance;
        public int Overdraft;

    }

    class Program
    {
        //method that uses strut array value in call.
        public static void PrintAccount(Account a)
        {
            Console.WriteLine("name: {0}.", a.Name);
            Console.WriteLine("Address: {0}.", a.Address);
            Console.WriteLine("Balance: {0}.", a.Balance);
        }


        static void Main(string[] args)
        {
            //single account created from struct.
            Account BobsAccount;
            BobsAccount.Name = "Bob";
            BobsAccount.State = AccountState.Active;
            BobsAccount.Balance = 1000;

            //using an array of structs
            const int MAX_CUST = 100;
            Account[] Bank = new Account[MAX_CUST];
            Bank[0].Name = "Bob";
            Bank[0].Address = "bobs house";
            Bank[0].State = AccountState.Active;
            Bank[0].Balance = 100;
            PrintAccount(Bank[0]);
            Bank[1].Name = "Tom";
            Bank[1].Address = "Toms Farm";
            Bank[1].State = AccountState.Frozen;
            Bank[1].Balance = 0;
            PrintAccount(Bank[1]);


            Console.WriteLine("all done");


        }
    }
}

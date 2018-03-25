using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class Account : IAccount
    {

        private string name;
        public string _name;
        private string address;
        private decimal balance =0;
        public virtual string RudeLetterString()
        {
            return "rudelettersstringmethod.";
        }


        public Account(string inName, string inAddress, decimal inBalance)
        {
            name = inName;
            address = inAddress;
            balance = inBalance;
        }
        //overloading the account constructor using this.
        public Account(string inName, string inAddress) :
            this(inName, inAddress, 0)
        {
        }
        public Account(string inName) :
            this(inName, "not supplied", 0)
        {
        }

        public string GetName()
        {            
            return name;
        }

        



        public virtual bool WithdrawFunds(decimal amount)
        {
            if (balance<amount)
            {
                return false;
            }
            balance -= amount;
            return true;
        } //end WithdrawFunds.

        public void PayInFunds(decimal amount)
        {
            balance += amount;
        }

        public decimal GetBalance()
        {
            return balance;
        }

    }
}

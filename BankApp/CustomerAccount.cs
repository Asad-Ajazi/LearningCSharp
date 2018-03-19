using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class CustomerAccount : Account, IAccount
    {
        //protected decimal balance = 0;//protected allows subclass to use value.
        //using base in the subclass to limit useage outside of the customeraccount class.
        //can change back to private field.
        private decimal balance;


        public CustomerAccount (string inName,string inAddress, decimal inBalance) :
                                                base (inName, inAddress,inBalance)
        {

        }

        public override string RudeLetterString()
        {
            return "You are overdrawn";
        }

        public override bool WithdrawFunds(decimal amount) //virtual/override pair.
            //removed virtual keyword and put new in the subclass.
        {
            if (balance < amount)
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

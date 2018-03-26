using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class BabyAccount : Account
    {
        public BabyAccount(string inName, string inAddress, decimal inBalance) : base(inName, inAddress, inBalance)
        {
        }

        public override bool WithdrawFunds(decimal amount) //using new keyword instead of override
        {
            if (amount > 10)
            {
                Console.WriteLine("amount over 10");
                return false;
            }            
            return base.WithdrawFunds(amount); //base refers to partent method
        } //end WithdrawFunds.





    }
}

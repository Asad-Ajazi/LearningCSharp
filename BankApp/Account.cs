using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Account
    {

        private string name;
        private string address;
        private decimal balance;

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

    }
}

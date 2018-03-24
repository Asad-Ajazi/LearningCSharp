using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class ArrayBank :IBank
    {
        private IAccount[] accounts;

        public ArrayBank(int bankSize)
        {
            accounts = new IAccount[bankSize];
        }

        public IAccount FindAccount(string _name)
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    continue;
                }
                if (accounts[i].GetName() == _name )
                {
                    Console.WriteLine("was true");
                    return accounts[i];
                }
            }
            Console.WriteLine("was false");
            return null;
        }

        public bool StoreAccount(IAccount account)
        {
            //loop through array, check if empty and fill first empty locations.
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    accounts[i] = account;
                    return true;
                }
            }
            return false;
        }
    }
}

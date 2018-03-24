using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class HashBank : IBank
    {
        Hashtable bankHashtable = new Hashtable();

        public IAccount FindAccount(string name)
        {
            return bankHashtable[name] as IAccount;
        }

        public bool StoreAccount(IAccount account)
        {
            bankHashtable.Add(account.GetName(), account);
            return true;
        }
    }
}

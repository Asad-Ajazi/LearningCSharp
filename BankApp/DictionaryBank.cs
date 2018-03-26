using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class DictionaryBank
    {
        Dictionary<string, Account> accoutnDictionary = new Dictionary<string, Account>();
        public IAccount FindAccount(string name)
        {
            if (accoutnDictionary.ContainsKey(name))
            {
                return accoutnDictionary[name];
            }
            else
            {
                return null;
            }
        }

        public bool StoreAcount(Account account)
        {
            if (accoutnDictionary.ContainsKey(account.GetName()))
               return false;
            
            
                accoutnDictionary.Add(account.GetName(),account);
                return true;
            
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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

        public void Save(TextWriter textOut)
        {
            textOut.WriteLine(bankHashtable.Count);
            foreach (CustomerAccount account in bankHashtable.Values)
            {
                account.Save(textOut);
            }
        }

        public static HashBank Load(TextReader textIn)
        {
            HashBank results = new HashBank();
            string countString = textIn.ReadLine();
            int count = int.Parse(countString);

            for (int i = 0; i < count; i++)
            {
                CustomerAccount account = CustomerAccount.Load(textIn);
                results.bankHashtable.Add(account.GetName(), account);
            }
            return results;
        }
    }
}

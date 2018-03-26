using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Program
    {
        //edit notes
        static void Main(string[] args)
        {

            

            ArrayBank ourbank = new ArrayBank(100);
            IAccount newAccount = new CustomerAccount("Rob","add",10000);
            IAccount anewAccount = new CustomerAccount("Tom", "add", 10000);

            if (ourbank.StoreAccount(anewAccount) == true)
            {
                Console.WriteLine("account added");
            }

            if (ourbank.StoreAccount(newAccount)==true)
            {
                Console.WriteLine("account added");
            }

            IAccount storedAccount = ourbank.FindAccount("Rob");
            if (storedAccount!=null)
            {
                Console.WriteLine("Account found in bank");
            }

            //testing hashtables.
            HashBank hbank = new HashBank();

            IAccount jimAcc = new CustomerAccount("Jim", "add", 10000);
            IAccount joeAcc = new CustomerAccount("Joe", "housing place", 400);

            hbank.StoreAccount(jimAcc);
            hbank.StoreAccount(joeAcc);

            IAccount hashAccount = hbank.FindAccount("Jim");
            if (hashAccount != null)
            {
                Console.WriteLine("hash Account found in bank");
            }

            Console.WriteLine("newwwwwwwwwwwwwww \\n");

            //Using arraylists
            ArrayList store = new ArrayList();

            
            Account robsaccout = new Account("robsacc");
            store.Add(robsaccout); //add robsacc to arraylist
            Account a = (Account) store[0]; //store robsacc in a
            Console.WriteLine(a.GetBalance());

            a.PayInFunds(500);          
            Console.WriteLine(a.GetBalance());

            if (store.Contains(robsaccout))
            {
                Console.WriteLine("rob is in the bank");
            }

            store.Remove(a);

            if (store.Count == 0)
            {
                Console.WriteLine("arraylist empty");
            }

            //Using List
            //similar to arraylist but typesafe.
            List<Account> accountList = new List<Account>();
            accountList.Add(robsaccout);
            accountList[0].PayInFunds(99);
            
            Console.WriteLine("List balance :{0}",accountList[0].GetBalance());

            //using dictionary
            //similar to hashtable.
            Dictionary<string, Account> accountDictionary = new Dictionary<string, Account>();
            accountDictionary.Add("robsacc", robsaccout);

            if (accountDictionary.ContainsKey("robsacc")) 
            {
                accountDictionary["robsacc"].PayInFunds(288);

                Console.WriteLine("rob is here his balance is: " +accountDictionary["robsacc"].GetBalance());
            }

            
        }
    }
}

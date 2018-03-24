using System;
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

            IAccount storedAccount = ourbank.FindAccount("Tam");
            if (storedAccount!=null)
            {
                Console.WriteLine("Account found in bank");
            }
        }
    }
}

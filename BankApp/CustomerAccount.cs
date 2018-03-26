using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankApp
{
    class CustomerAccount : IAccount
    {
        //protected decimal balance = 0;//protected allows subclass to use value.
        //using base in the subclass to limit useage outside of the customeraccount class.
        //can change back to private field.
        private decimal balance = 0;
        private string name;

        public CustomerAccount (string newName, decimal initialBalance)
        {
            name = newName;
            balance = initialBalance;
        }

        


        public virtual bool WithdrawFunds(decimal amount) //virtual/override pair.
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

        public string GetName()
        {
            return name;
        }

        //adding a save method. (text file in this case. databases would be much better.)
        //for single account
        public bool Save (string filename)
        {
            textOut = null;
            try
            {
                textOut = new StreamWriter(filename);
                Save(textOut);
            }
            catch
            {
                return false;
            }
            finally
            {
                if (textOut != null)
                {
                    textOut.Close();
                }
            }
            return true;
        }

        //loading the text file.
        //for single account

            
        //changing the load method to read from the textreader.
        /*public static CustomerAccount Load(string filename)
        {
            CustomerAccount result = null;
            TextReader textIn = null;

            try
            {
                textIn = new StreamReader(filename);
                string nameText = textIn.ReadLine();
                string balanceText = textIn.ReadLine();
                decimal balance = decimal.Parse(balanceText);
                result = new CustomerAccount(nameText, balance);
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                if (textIn !=null)
                {
                    textIn.Close();
                }                
            }
            return result;
        }*/

            //new load method. using text streams.
            public static CustomerAccount Load(TextReader textIn)
        {
            CustomerAccount result = null;
            try
            {
                string name = textIn.ReadLine();
                string balanceText = textIn.ReadLine();
                decimal balance = decimal.Parse(balanceText);
                result = new CustomerAccount(name, balance);
            }
            catch (Exception)
            {
                return null;
            }
            return result;
        }

        //using a stream to save multiple accounts. is passed into older save method with same name.(overloading.)
        TextWriter textOut = new StreamWriter("test.txt");

        public void Save(TextWriter textOut)
        {
            textOut.WriteLine(name);
            textOut.WriteLine(balance);
        }

        //p153 saving/loading accounts. -- put into HashBank class.
        //public void Save(TextWriter textOut)
        //{
        //    textOut.WriteLine(bankHashtable.Count);
        //    foreach (CustomerAccount account in bankHashtable.Values)
        //    {
        //        account.Save(textOut);
        //    }
        //}



    }
}

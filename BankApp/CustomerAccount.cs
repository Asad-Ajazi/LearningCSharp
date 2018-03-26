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
        public bool Save (string filename)
        {
            try
            {
                TextWriter outText = new StreamWriter(filename);
                outText.WriteLine(name);
                outText.WriteLine(balance);
                outText.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        //loading the text file.
        public static CustomerAccount Load(string filename)
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


        }




    }
}

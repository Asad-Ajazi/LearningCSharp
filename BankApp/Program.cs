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

            const int MAX_CUST = 100;
            IAccount[] accs = new IAccount[MAX_CUST];
            //accs[0] = new Account("rob");
            //accs[1] = new Account("foo", "house");

            //accs[2] = new Account("chief","lands",500);

            accs[0] = new CustomerAccount("bob","homehome",400);
            accs[0].PayInFunds(40);
            Console.WriteLine("customer account balance:"+accs[0].GetBalance());

            accs[1] = new BabyAccount("bosdfb", "homehomsfsdfe", 4030);
            accs[1].PayInFunds(90);
            accs[1].WithdrawFunds(50);
            accs[1].WithdrawFunds(8);
            
            Console.WriteLine("baby balance:"+ accs[1].GetBalance());

            BabyAccount b = new BabyAccount("baaaaob", "hdddomehome", 900);
            Console.WriteLine("b bal before:"+b.GetBalance());
            b.PayInFunds(100);
            Console.WriteLine("mid bal:"+b.GetBalance());
            b.WithdrawFunds(5);
            Console.WriteLine("b bal after:" + b.GetBalance());


        }
    }
}
